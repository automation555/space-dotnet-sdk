using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
        
    [JsonPropertyName("deprecation")]
    public ApiDeprecation? Deprecation { get; set; } = default;
        
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;
        
    [JsonPropertyName("fields")]
    public List<ApiDtoField> Fields { get; set; } = new();
        
    [JsonPropertyName("extends")]
    public Reference<ApiDto>? Extends { get; set; }
        
    [JsonPropertyName("implements")]
    public List<Reference<ApiDto>> Implements { get; set; } = new();
        
    [JsonPropertyName("inheritors")]
    public List<Reference<ApiDto>> Inheritors { get; set; } = new();
        
    [JsonPropertyName("hierarchyRole")]
    public HierarchyRole HierarchyRole { get; set; } = default!;

    [JsonPropertyName("record")]
    public bool Record { get; set; }
}