// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public class CustomFieldsV2ForEntityTypeFieldsReorderPostRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsV2ForEntityTypeFieldsReorderPostRequest() { }
    
    public CustomFieldsV2ForEntityTypeFieldsReorderPostRequest(List<CFIdentifier> customFields)
    {
        CustomFields = customFields;
    }
    
    private PropertyValue<List<CFIdentifier>> _customFields = new PropertyValue<List<CFIdentifier>>(nameof(CustomFieldsV2ForEntityTypeFieldsReorderPostRequest), nameof(CustomFields), new List<CFIdentifier>());
    
    [Required]
    [JsonPropertyName("customFields")]
    public List<CFIdentifier> CustomFields
    {
        get => _customFields.GetValue();
        set => _customFields.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _customFields.SetAccessPath(path, validateHasBeenSet);
    }

}

