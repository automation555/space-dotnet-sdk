using System;
using System.Text;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiFieldExtensions
{
    public static string ToCSharpVariableName(this ApiField subject)
        => CSharpIdentifier.ForVariable(subject.Name);
        
    public static string ToCSharpBackingFieldName(this ApiField subject)
        => CSharpIdentifier.ForBackingField(subject.Name);
        
    public static string ToCSharpPropertyName(this ApiField subject, string? containingType)
    {
        var propertyName = CSharpIdentifier.ForClassOrNamespace(subject.Name);

        return subject.Type switch
        {
            ApiFieldType.Primitive primitive when primitive.ToCSharpPrimitiveType() == CSharpType.Bool 
                                                  && !propertyName.StartsWith("Is") 
                                                  && !propertyName.StartsWith("Can")
                => $"Is{propertyName}",
                
            // Resolve CS0542 - Member names cannot be the same as their enclosing type by adding prefix/suffix
            ApiFieldType.Array when string.Equals(propertyName, containingType, StringComparison.OrdinalIgnoreCase)
                => $"{propertyName}Items",
                
            // Resolve CS0542 - Member names cannot be the same as their enclosing type by adding prefix/suffix
            ApiFieldType.Dto when string.Equals(propertyName, containingType, StringComparison.OrdinalIgnoreCase)
                => $"{propertyName}Item",
                
            _ => propertyName
        };
    }

    public static string ToCSharpVariableInstanceOrDefaultValue(this ApiField subject, CodeGenerationContext context)
    {
        var variableName = subject.ToCSharpVariableName();
        var defaultValue = subject.ToCSharpDefaultValueForAssignment(context);
            
        return !string.IsNullOrEmpty(defaultValue) 
            ? $"({variableName} ?? {defaultValue})" 
            : variableName;
    }
        
    public static string? ToCSharpDefaultValueForParameterList(this ApiField subject, CodeGenerationContext context)
    {
        if (subject.DefaultValue != null)
        {
            switch (subject.DefaultValue)
            {
                case ApiDefaultValue.Const.Primitive primitive:
                    return primitive.Expression;
                    
                case ApiDefaultValue.Const.EnumEntry:
                    return subject.ToCSharpDefaultValueForAssignment(context);

                case ApiDefaultValue.Collection:
                    return CSharpExpression.NullLiteral;

                case ApiDefaultValue.Map:
                    return CSharpExpression.NullLiteral;

                case ApiDefaultValue.Reference:
                    throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
            }
        } 
            
        if (subject.IsPrimitiveAndRequiresAddedNullability())
        {
            return CSharpExpression.NullLiteral;
        }
            
        return subject.Type.Nullable 
            ? CSharpExpression.NullLiteral 
            : null;
    }
        
    public static string? ToCSharpDefaultValueForAssignment(this ApiField subject, CodeGenerationContext context)
    {
        if (subject.IsPrimitiveAndRequiresAddedNullability())
        {
            return "string.Empty";
        }

        if (subject.DefaultValue == null) return null;
            
        if (subject.DefaultValue is ApiDefaultValue.Const.EnumEntry enumEntry)
        {
            var apiEnumRef = subject.Type as ApiFieldType.Enum;
            if (apiEnumRef == null || !context.TryGetEnum(apiEnumRef.EnumRef!.Id, out var apiEnum) || apiEnum == null)
            {
                throw new NotSupportedException("For " + nameof(ApiDefaultValue.Const.EnumEntry) + ", the field type should be of type" + nameof(ApiFieldType.Enum) + ".");
            }

            var typeNameForEnum = apiEnum.ToCSharpClassName();
            var identifierForValue = CSharpIdentifier.ForClassOrNamespace(enumEntry.EntryName);

            return $"{typeNameForEnum}.{identifierForValue}";
        }

        if (subject.DefaultValue is ApiDefaultValue.Collection collection)
        {
            var typeNameForArrayElement = subject.Type.GetArrayElementTypeOrType().ToCSharpType(context);

            var builder = new StringBuilder();
            builder.Append($"new List<{typeNameForArrayElement}>()");

            if (collection.Elements.Count > 0)
            {
                throw new NotSupportedException("Default values with populated collections are not supported yet.");
            }
                
            return builder.ToString();
        }

        if (subject.DefaultValue is ApiDefaultValue.Map map)
        {
            var typeNameForMapValue = subject.Type.GetMapValueTypeOrType().ToCSharpType(context);

            var builder = new StringBuilder();
            builder.Append($"new Dictionary<string, {typeNameForMapValue}>()");

            if (map.Elements.Count > 0)
            {
                throw new NotSupportedException("Default values with populated maps are not supported yet.");
            }
                
            return builder.ToString();
        }

        if (subject.DefaultValue is ApiDefaultValue.Reference)
        {
            throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
        }

        return null;
    }
        
    public static bool IsPrimitiveAndRequiresAddedNullability(this ApiField subject)
    {
        // For optional strings, add nullability if not present
        return subject.Optional && 
               !subject.Type.Nullable &&
               subject.DefaultValue == null && 
               subject.Type is ApiFieldType.Primitive primitiveType &&
               primitiveType.ToCSharpPrimitiveType() == CSharpType.String;
    }
}