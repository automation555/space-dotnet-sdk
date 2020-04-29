using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public class CSharpApiModelVisitor : ApiModelVisitor
    {
        protected readonly Indent Indent = new Indent();
        protected readonly StringBuilder Builder;

        protected ImmutableSortedDictionary<string, ApiEnum> IdToEnumMap = ImmutableSortedDictionary<string, ApiEnum>.Empty;
        protected ImmutableSortedDictionary<string, ApiDto> IdToDtoMap = ImmutableSortedDictionary<string, ApiDto>.Empty;
        protected readonly SortedDictionary<string, ApiDto> IdToAnonymousClassMap = new SortedDictionary<string, ApiDto>();

        public CSharpApiModelVisitor(StringBuilder builder)
        {
            Builder = builder;
        }
        
        public override void Visit(ApiModel apiModel)
        {
            // Metadata mappings
            IdToEnumMap =
                apiModel.Enums.ToImmutableSortedDictionary(
                    it => it.Id, 
                    it => it, 
                    StringComparer.OrdinalIgnoreCase);
            
            IdToDtoMap =
                apiModel.Dto.ToImmutableSortedDictionary(
                    it => it.Id, 
                    it => it, 
                    StringComparer.OrdinalIgnoreCase);
            
            // Start building
            Builder.AppendLine($"{Indent}// ------------------------------------------------------------------------------");
            Builder.AppendLine($"{Indent}// <auto-generated>");
            Builder.AppendLine($"{Indent}//     This code was generated by a tool.");
            Builder.AppendLine($"{Indent}// ");
            Builder.AppendLine($"{Indent}//     Changes to this file may cause incorrect behavior and will be lost if");
            Builder.AppendLine($"{Indent}//     the code is regenerated.");
            Builder.AppendLine($"{Indent}// ");
            Builder.AppendLine($"{Indent}//     Generated: {DateTimeOffset.UtcNow:O}");
            Builder.AppendLine($"{Indent}// </auto-generated>");
            Builder.AppendLine($"{Indent}// ------------------------------------------------------------------------------");
            Builder.AppendLine();
            Builder.AppendLine($"{Indent}#nullable enable");
            Builder.AppendLine();
            Builder.AppendLine($"{Indent}using System;");
            Builder.AppendLine($"{Indent}using System.Collections.Generic;");
            Builder.AppendLine($"{Indent}using System.ComponentModel.DataAnnotations;");
            Builder.AppendLine($"{Indent}using System.Text.Json.Serialization;");
            Builder.AppendLine($"{Indent}using System.Threading.Tasks;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Client.Internal;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common.Json.Serialization;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common.Types;");
            Builder.AppendLine();
            Builder.AppendLine($"{Indent}namespace SpaceDotNet.Client");
            Builder.AppendLine($"{Indent}{{");
            
            Indent.Increment();
            foreach (var apiEnum in apiModel.Enums)
            {
                Visit(apiEnum);
            }
            
            foreach (var apiDto in apiModel.Dto)
            {
                Visit(apiDto);
            }
            
            foreach (var apiResource in apiModel.Resources)
            {
                Visit(apiResource);
            }

            var currentIdToAnonymousClassMap = IdToAnonymousClassMap.ToImmutableSortedDictionary();
            var writtenIdToAnonymousClassMap = new SortedDictionary<string, ApiDto>();
            do
            {
                // Write output
                foreach (var (anonymousDtoKey, anonymousDto) in currentIdToAnonymousClassMap)
                {
                    Visit(anonymousDto);
                    writtenIdToAnonymousClassMap.Add(anonymousDtoKey, anonymousDto);
                }
                
                // See if new classes have been generated?
                var temp = IdToAnonymousClassMap
                    .Where(it => !writtenIdToAnonymousClassMap.ContainsKey(it.Key))
                    .ToImmutableSortedDictionary();

                currentIdToAnonymousClassMap = temp;

            } while (currentIdToAnonymousClassMap.Count > 0);

            Indent.Decrement();
            
            Builder.AppendLine($"{Indent}}}");
        }

        public override void Visit(ApiEnum apiEnum)
        {
            Builder.AppendLine($"{Indent}// Source: " + apiEnum.Id);
            Builder.AppendLine($"{Indent}[JsonConverter(typeof(EnumerationConverter))]");
            Builder.AppendLine($"{Indent}public sealed class " + apiEnum.Name.ToSafeIdentifier() + " : Enumeration");
            Builder.AppendLine($"{Indent}{{");
                
            Indent.Increment();
            Builder.AppendLine($"{Indent}private " + apiEnum.Name.ToSafeIdentifier() + "(string value) : base(value) { }");
            Builder.AppendLine();
            
            foreach (var value in apiEnum.Values)
            {
                Builder.AppendLine($"{Indent}public static readonly " + apiEnum.Name.ToSafeIdentifier() + " " + value.ToSafeIdentifier() + " = new " + apiEnum.Name.ToSafeIdentifier() + "(\"" + value + "\");");
            }
            
            Indent.Decrement();
                
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine();
        }

        public override void Visit(ApiDto apiDto)
        {
            Builder.AppendLine($"{Indent}// Source: " + apiDto.Id);
            Builder.AppendLine($"{Indent}public class " + apiDto.Name.ToSafeIdentifier() + "Dto");
            if (apiDto.Extends != null && IdToDtoMap.TryGetValue(apiDto.Extends.Id, out var apiDtoExtends))
            {
                Indent.Increment();
                Builder.AppendLine($"{Indent} : " + apiDtoExtends.Name.ToSafeIdentifier() + "Dto");
                Indent.Decrement();
            }
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();
                
            // For implements, add all referenced types' fields
            foreach (var dtoReference in apiDto.Implements)
            {
                if (IdToDtoMap.TryGetValue(dtoReference.Id, out var apiDtoImplements))
                {
                    foreach (var apiDtoField in apiDtoImplements.Fields)
                    {
                        Visit(apiDtoField);
                    }
                }
            }
            
            // Add own fields
            foreach (var apiDtoField in apiDto.Fields)
            {
                Visit(apiDtoField);
            }

            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine();
        }
        
        public override void Visit(ApiField apiField)
        {
            if (!apiField.Type.Optional && !apiField.Type.Nullable)
            {
                Builder.AppendLine($"{Indent}[Required]");
            }
            Builder.AppendLine($"{Indent}[JsonPropertyName(\"{apiField.Name}\")]");
            
            Builder.Append($"{Indent}public ");
            Visit(apiField.Type);
            if (apiField.Type.Nullable)
            {
                Builder.Append("?");
            }
            Builder.Append(" ");
            Builder.Append(apiField.Name.ToSafeIdentifier().ToUppercaseFirst());
            Builder.Append(" { get; set; }");
            Builder.AppendLine();
            Builder.AppendLine();
        }

        public override void Visit(ApiFieldType apiFieldType)
        {
            switch (apiFieldType)
            {
                case ApiFieldType.Array apiFieldTypeArray:
                    Builder.Append("List<");
                    Visit(apiFieldTypeArray.ElementType);
                    Builder.Append(">");
                    break;
                
                case ApiFieldType.Dto apiFieldTypeDto:
                    if (apiFieldTypeDto.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                    {
                        Builder.Append(apiDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    else
                    {
                        Builder.Append("object");
                    }
                    break;
                
                case ApiFieldType.Enum apiFieldTypeEnum:
                    if (apiFieldTypeEnum.EnumRef?.Id != null && IdToEnumMap.TryGetValue(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                    {
                        Builder.Append(apiEnum.Name.ToSafeIdentifier());
                    }
                    else
                    {
                        Builder.Append("string");
                    }
                    break;
                
                case ApiFieldType.Object apiFieldTypeObject:
                    if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                    {
                        // Known anonymous type
                        Builder.Append("Pair<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                    {
                        // Known anonymous type
                        Builder.Append("Triple<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[2].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MAP_ENTRY)
                    {
                        // Known anonymous type
                        Builder.Append("MapEntry<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                    {
                        // Known anonymous type
                        Builder.Append("Batch<");
                        var dataFieldType = apiFieldTypeObject.Fields.First(it => string.Equals(it.Name, "data", StringComparison.OrdinalIgnoreCase));
                        var dataFieldArrayType = (ApiFieldType.Array)dataFieldType.Type;
                        Visit(dataFieldArrayType.ElementType);
                        Builder.Append(">");
                    }  
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                    {
                        // Known anonymous type
                        Builder.Append("Modification<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Request body/anonymous type - check whether we generated it before?
                        var anonymousClassFields = apiFieldTypeObject.Fields.Select(it => new ApiDtoField { Field = it }).ToList();

                        // TODO: make this check less expensive, serializing N times is probably not the best idea
                        var anonymousClassSignature = JsonSerializer.Serialize(anonymousClassFields);
                        var anonymousClass = IdToAnonymousClassMap.Values.FirstOrDefault(it => anonymousClassSignature == JsonSerializer.Serialize(it.Fields));
                        if (anonymousClass == null)
                        {
                            var anonymousClassId = !string.IsNullOrEmpty(_clientMethodName)
                                ? _clientMethodName + "Request"
                                : "Object" + IdToAnonymousClassMap.Count;
                            anonymousClass = new ApiDto
                            {
                                Id = anonymousClassId,
                                Name = anonymousClassId,
                                Fields = anonymousClassFields
                            };

                            IdToAnonymousClassMap[anonymousClassId] = anonymousClass;
                        }

                        Builder.Append(anonymousClass.Id + "Dto");
                    }
                    else
                    {
                        // Unknown object kind
                        throw new ResourceException("Could not generate class for object kind: " + apiFieldTypeObject.Kind);
                    }

                    break;
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    Builder.Append(apiFieldTypePrimitive.Type.ToCSharpPrimitiveType());
                    break;

                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        Builder.Append(apiReferenceDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    else
                    {
                        Builder.Append("object");
                    }
                    break;
                
                default:
                    Builder.Append("object");
                    break;
            }
        }

        private string _baseEndpointPath = string.Empty;
        private string _baseMethodName = string.Empty;
        
        public override void Visit(ApiResource apiResource)
        {
            Builder.AppendLine($"{Indent}// Source: " + apiResource.Id);
            Builder.AppendLine($"{Indent}public partial class " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client");
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();

            Builder.AppendLine($"{Indent}private readonly Connection _connection;");
            Builder.AppendLine();
            Builder.AppendLine($"{Indent}public " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client(Connection connection)");
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();

            Builder.AppendLine($"{Indent}_connection = connection;");
            
            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine();
        
            foreach (var apiEndpoint in apiResource.Endpoints)
            {
                _baseEndpointPath = apiResource.Path.Segments.ToPath();
                _baseMethodName = string.Empty;
                Visit(apiResource, apiEndpoint);
                _baseMethodName = string.Empty;
                _baseEndpointPath = string.Empty;
            }
            
            // Nested resources
            foreach (var apiNestedResource in apiResource.NestedResources)
            {
                foreach (var apiEndpoint in apiNestedResource.Endpoints)
                {
                    _baseEndpointPath = apiResource.Path.Segments.Union(apiNestedResource.Path.Segments).ToPath();
                    _baseMethodName = apiNestedResource.DisplayPlural.ToSafeIdentifier() ?? apiNestedResource.DisplayPlural;
                    Visit(apiNestedResource, apiEndpoint);
                    _baseMethodName = string.Empty;
                    _baseEndpointPath = string.Empty;
                }

                // Nested nested resources
                foreach (var apiNestedResourceNestedResource in apiNestedResource.NestedResources)
                {
                    foreach (var apiEndpoint in apiNestedResourceNestedResource.Endpoints)
                    {
                        _baseEndpointPath = apiResource.Path.Segments.Union(apiNestedResource.Path.Segments).Union(apiNestedResourceNestedResource.Path.Segments).ToPath();
                        _baseMethodName = apiNestedResource.DisplayPlural.ToSafeIdentifier() + apiNestedResourceNestedResource.DisplayPlural.ToSafeIdentifier();
                        Visit(apiNestedResourceNestedResource, apiEndpoint);
                        _baseMethodName = string.Empty;
                        _baseEndpointPath = string.Empty;
                    }
                    
                    // Nested nested nested resources
                    foreach (var apiNestedResourceNestedResourceNestedResource in apiNestedResourceNestedResource.NestedResources)
                    {
                        foreach (var apiEndpoint in apiNestedResourceNestedResourceNestedResource.Endpoints)
                        {
                            _baseEndpointPath = apiResource.Path.Segments.Union(apiNestedResource.Path.Segments).Union(apiNestedResourceNestedResource.Path.Segments).Union(apiNestedResourceNestedResourceNestedResource.Path.Segments).ToPath();
                            _baseMethodName = apiNestedResource.DisplayPlural.ToSafeIdentifier() + apiNestedResourceNestedResource.DisplayPlural.ToSafeIdentifier() + apiNestedResourceNestedResourceNestedResource.DisplayPlural.ToSafeIdentifier();
                            Visit(apiNestedResourceNestedResourceNestedResource, apiEndpoint);
                            _baseMethodName = string.Empty;
                            _baseEndpointPath = string.Empty;
                        }
                    }
                }
            }

            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine();
        }
        
        private string _clientMethodName = string.Empty;
        
        public override void Visit(ApiResource apiResource, ApiEndpoint apiEndpoint)
        {
            var endpointPath = (_baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');

            var apiCallMethod = apiEndpoint.Method.ToHttpMethod();
            _clientMethodName = _baseMethodName + apiEndpoint.DisplayName.ToSafeIdentifier();

            bool AppendParameterList(ApiEndpoint apiEndpoint1)
            {
                var methodParameters = apiEndpoint1.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
                foreach (var apiEndpointParameter in methodParameters)
                {
                    Visit(apiEndpointParameter.Field.Type);
                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        Builder.Append("?");
                    }
                    Builder.Append(" ");
                    Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        Builder.Append(" = null");
                    }

                    if (apiEndpointParameter != methodParameters.Last())
                    {
                        Builder.Append(", ");
                    }
                }

                return methodParameters.Count > 0;
            }

            bool AppendRequestParameterList(ApiEndpoint apiEndpoint1)
            {
                var methodParameters = apiEndpoint1.Parameters.Where(it => !it.Path).ToList();
                if (methodParameters.Count > 0)
                {
                    Builder.Append("?");
                }
                
                foreach (var apiEndpointParameter in methodParameters)
                {
                    Builder.Append(apiEndpointParameter.Field.Name);
                    Builder.Append("=");
                    Builder.Append("{");
                    Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
                    
                    if (apiEndpointParameter.Field.Type is ApiFieldType.Array arrayType)
                    {
                        // For lists, we will need to repeat the parameter for each element
                        Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                            ? ".JoinToString("
                            : "?.JoinToString(");
                        
                        Builder.Append("\"");
                        Builder.Append(apiEndpointParameter.Field.Name);
                        Builder.Append("\", it => it");
                        
                        Builder.Append(!arrayType.ElementType.Nullable
                            ? ".ToString()"
                            : "?.ToString()");
                    
                        if (arrayType.ElementType is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                        {
                            // Boolean needs lowercase value
                            Builder.Append(!arrayType.ElementType.Nullable
                                ? ".ToLowerInvariant()"
                                : "?.ToLowerInvariant()"); }

                        Builder.Append(")");
                    }
                    else
                    {
                        // Anything else can be "ToString()"
                        Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                            ? ".ToString()"
                            : "?.ToString()");
                    
                        if (apiEndpointParameter.Field.Type is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                        {
                            // Boolean needs lowercase value
                            Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                                ? ".ToLowerInvariant()"
                                : "?.ToLowerInvariant()");
                        }
                    }

                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        // Used to be able to filter out nullable query string parameters in Connection.CleanNullableNullQueryStringParameters
                        Builder.Append(" ?? \"null\"");
                    }
                    Builder.Append("}");
                    
                    if (apiEndpointParameter != methodParameters.Last())
                    {
                        Builder.Append("&");
                    }
                }

                return methodParameters.Count > 0;
            }

            if (apiEndpoint.Deprecation != null)
            {
                Builder.Append($"{Indent}[Obsolete(\"");
                if (!string.IsNullOrEmpty(apiEndpoint.Deprecation.Message))
                {
                    Builder.Append(apiEndpoint.Deprecation.Message);
                }
                else
                {
                    Builder.Append("This API is obsolete");
                }
                if (!string.IsNullOrEmpty(apiEndpoint.Deprecation.Since))
                {
                    Builder.Append(" (since " + apiEndpoint.Deprecation.Since + ")");
                }
                Builder.Append("\")]");
                Builder.AppendLine();
            }
            
            if (apiEndpoint.RequestBody == null && apiEndpoint.ResponseBody == null)
            {
                Builder.Append($"{Indent}public async Task " + _clientMethodName + "(");
            
                AppendParameterList(apiEndpoint);

                Builder.Append(") => await _connection.RequestResourceAsync");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                AppendRequestParameterList(apiEndpoint);
                Builder.Append("\");");
                Builder.AppendLine();
            }
            else if (apiEndpoint.RequestBody == null && apiEndpoint.ResponseBody != null)
            {
                Builder.Append($"{Indent}public async Task<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append(" " + _clientMethodName + "(");
            
                AppendParameterList(apiEndpoint);
                
                Builder.Append(") => await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                Builder.Append(AppendRequestParameterList(apiEndpoint) ? "&" : "?");
                Builder.Append("$fields=\" + ObjectToFieldDescriptor.FieldsFor(typeof(");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(")));");
                Builder.AppendLine();
            }
            else if (apiEndpoint.RequestBody != null && apiEndpoint.ResponseBody == null)
            {
                Builder.Append($"{Indent}public async Task");
                Builder.Append(" " + _clientMethodName + "(");
            
                if (AppendParameterList(apiEndpoint))
                {
                    Builder.Append(", ");
                }
                
                Visit(apiEndpoint.RequestBody);
                Builder.Append(" data");
                
                Builder.Append(") => await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.RequestBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                AppendRequestParameterList(apiEndpoint);
                Builder.Append("\", data);");
                Builder.AppendLine();
            }
            else if (apiEndpoint.RequestBody != null && apiEndpoint.ResponseBody != null)
            {
                Builder.Append($"{Indent}public async Task<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append(" " + _clientMethodName + "(");

                if (AppendParameterList(apiEndpoint))
                {
                    Builder.Append(", ");
                }

                Visit(apiEndpoint.RequestBody);
                Builder.Append(" data");
                
                Builder.Append(") => await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.RequestBody);
                Builder.Append(", ");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                Builder.Append(AppendRequestParameterList(apiEndpoint) ? "&" : "?");
                Builder.Append("$fields=\" + ObjectToFieldDescriptor.FieldsFor(typeof(");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(")), data);");
                Builder.AppendLine();
            }
            else
            {
                Builder.AppendLine($"{Indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }
            
            Builder.AppendLine();

            _clientMethodName = string.Empty;
        }
    }
}