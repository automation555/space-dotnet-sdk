using System;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.Extensions;

public static class ApiFieldTypeExtensions
{
    public static ApiFieldType GetArrayElementTypeOrType(this ApiFieldType subject)
    {
        if (subject is ApiFieldType.Array arrayFieldType)
        {
            return arrayFieldType.ElementType;
        }

        return subject;
    }
        
    public static ApiFieldType GetMapValueTypeOrType(this ApiFieldType subject)
    {
        if (subject is ApiFieldType.Map mapFieldType)
        {
            return mapFieldType.ValueType;
        }

        return subject;
    }
        
    public static ApiFieldType GetBatchElementTypeOrType(this ApiFieldType subject)
    {
        if (subject is ApiFieldType.Object objectFieldType)
        {
            return GetBatchDataType(objectFieldType)?.ElementType ?? objectFieldType;
        }

        return subject.GetArrayElementTypeOrType();
    }
        
    public static ApiFieldType.Array? GetBatchDataType(this ApiFieldType.Object subject)
    {
        if (subject.Kind != ApiFieldType.Object.ObjectKind.BATCH) return null;
            
        var dataFieldType = subject.Fields.First(it => string.Equals(it.Name, "data", StringComparison.OrdinalIgnoreCase));
        var dataFieldArrayType = (ApiFieldType.Array)dataFieldType.Type;
        return dataFieldArrayType;
    }
}