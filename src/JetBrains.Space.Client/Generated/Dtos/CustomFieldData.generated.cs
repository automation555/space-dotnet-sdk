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

public sealed class CustomFieldData
     : IPropagatePropertyAccessPath
{
    public CustomFieldData() { }
    
    public CustomFieldData(string id, string name, CustomFieldType type, bool multivalued, bool required, CFValue defaultValue, int order, bool archived, CFParameters? parameters = null, CFConstraint? constraint = null, string? description = null)
    {
        Id = id;
        Name = name;
        Type = type;
        IsMultivalued = multivalued;
        Parameters = parameters;
        IsRequired = required;
        DefaultValue = defaultValue;
        Constraint = constraint;
        Description = description;
        Order = order;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CustomFieldData), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomFieldData), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<CustomFieldType> _type = new PropertyValue<CustomFieldType>(nameof(CustomFieldData), nameof(Type));
    
    [Required]
    [JsonPropertyName("type")]
    public CustomFieldType Type
    {
        get => _type.GetValue();
        set => _type.SetValue(value);
    }

    private PropertyValue<bool> _multivalued = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsMultivalued));
    
    [Required]
    [JsonPropertyName("multivalued")]
    public bool IsMultivalued
    {
        get => _multivalued.GetValue();
        set => _multivalued.SetValue(value);
    }

    private PropertyValue<CFParameters?> _parameters = new PropertyValue<CFParameters?>(nameof(CustomFieldData), nameof(Parameters));
    
    [JsonPropertyName("parameters")]
    public CFParameters? Parameters
    {
        get => _parameters.GetValue();
        set => _parameters.SetValue(value);
    }

    private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsRequired));
    
    [Required]
    [JsonPropertyName("required")]
    public bool IsRequired
    {
        get => _required.GetValue();
        set => _required.SetValue(value);
    }

    private PropertyValue<CFValue> _defaultValue = new PropertyValue<CFValue>(nameof(CustomFieldData), nameof(DefaultValue));
    
    [Required]
    [JsonPropertyName("defaultValue")]
    public CFValue DefaultValue
    {
        get => _defaultValue.GetValue();
        set => _defaultValue.SetValue(value);
    }

    private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldData), nameof(Constraint));
    
    [JsonPropertyName("constraint")]
    public CFConstraint? Constraint
    {
        get => _constraint.GetValue();
        set => _constraint.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldData), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<int> _order = new PropertyValue<int>(nameof(CustomFieldData), nameof(Order));
    
    [Required]
    [JsonPropertyName("order")]
    public int Order
    {
        get => _order.GetValue();
        set => _order.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _type.SetAccessPath(path, validateHasBeenSet);
        _multivalued.SetAccessPath(path, validateHasBeenSet);
        _parameters.SetAccessPath(path, validateHasBeenSet);
        _required.SetAccessPath(path, validateHasBeenSet);
        _defaultValue.SetAccessPath(path, validateHasBeenSet);
        _constraint.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _order.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
    }

}

