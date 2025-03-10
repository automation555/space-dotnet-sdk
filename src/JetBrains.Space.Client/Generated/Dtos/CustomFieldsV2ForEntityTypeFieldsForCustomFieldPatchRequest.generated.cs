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

public class CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest() { }
    
    public CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest(string? name = null, CFUpdateParameters? parameters = null, bool? required = null, CFInputValue? defaultValue = null, CFConstraint? constraint = null, string? description = null)
    {
        Name = name;
        Parameters = parameters;
        IsRequired = required;
        DefaultValue = defaultValue;
        Constraint = constraint;
        Description = description;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(Name));
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<CFUpdateParameters?> _parameters = new PropertyValue<CFUpdateParameters?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(Parameters));
    
    [JsonPropertyName("parameters")]
    public CFUpdateParameters? Parameters
    {
        get => _parameters.GetValue();
        set => _parameters.SetValue(value);
    }

    private PropertyValue<bool?> _required = new PropertyValue<bool?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(IsRequired));
    
    [JsonPropertyName("required")]
    public bool? IsRequired
    {
        get => _required.GetValue();
        set => _required.SetValue(value);
    }

    private PropertyValue<CFInputValue?> _defaultValue = new PropertyValue<CFInputValue?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(DefaultValue));
    
    [JsonPropertyName("defaultValue")]
    public CFInputValue? DefaultValue
    {
        get => _defaultValue.GetValue();
        set => _defaultValue.SetValue(value);
    }

    private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(Constraint));
    
    [JsonPropertyName("constraint")]
    public CFConstraint? Constraint
    {
        get => _constraint.GetValue();
        set => _constraint.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _parameters.SetAccessPath(path, validateHasBeenSet);
        _required.SetAccessPath(path, validateHasBeenSet);
        _defaultValue.SetAccessPath(path, validateHasBeenSet);
        _constraint.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
    }

}

