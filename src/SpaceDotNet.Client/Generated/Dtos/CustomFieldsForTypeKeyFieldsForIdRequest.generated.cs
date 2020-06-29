// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class CustomFieldsForTypeKeyFieldsForIdRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsForTypeKeyFieldsForIdRequest() { }
        
        public CustomFieldsForTypeKeyFieldsForIdRequest(string? name = null, string? description = null, string? key = null, CFConstraintDto? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFValueDto? defaultValue = null, List<EnumValueDataDto>? enumValues = null)
        {
            Name = name;
            Description = description;
            Key = key;
            Constraint = constraint;
            Required = required;
            Private = @private;
            Access = access;
            DefaultValue = defaultValue;
            EnumValues = enumValues;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _key = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Key));
        
        [JsonPropertyName("key")]
        public string? Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<CFConstraintDto?> _constraint = new PropertyValue<CFConstraintDto?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Constraint));
        
        [JsonPropertyName("constraint")]
        public CFConstraintDto? Constraint
        {
            get { return _constraint.GetValue(); }
            set { _constraint.SetValue(value); }
        }
    
        private PropertyValue<bool?> _required = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Required));
        
        [JsonPropertyName("required")]
        public bool? Required
        {
            get { return _required.GetValue(); }
            set { _required.SetValue(value); }
        }
    
        private PropertyValue<bool?> _private = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Private));
        
        [JsonPropertyName("private")]
        public bool? Private
        {
            get { return _private.GetValue(); }
            set { _private.SetValue(value); }
        }
    
        private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessType? Access
        {
            get { return _access.GetValue(); }
            set { _access.SetValue(value); }
        }
    
        private PropertyValue<CFValueDto?> _defaultValue = new PropertyValue<CFValueDto?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(DefaultValue));
        
        [JsonPropertyName("defaultValue")]
        public CFValueDto? DefaultValue
        {
            get { return _defaultValue.GetValue(); }
            set { _defaultValue.SetValue(value); }
        }
    
        private PropertyValue<List<EnumValueDataDto>?> _enumValues = new PropertyValue<List<EnumValueDataDto>?>(nameof(CustomFieldsForTypeKeyFieldsForIdRequest), nameof(EnumValues));
        
        [JsonPropertyName("enumValues")]
        public List<EnumValueDataDto>? EnumValues
        {
            get { return _enumValues.GetValue(); }
            set { _enumValues.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _constraint.SetAccessPath(path, validateHasBeenSet);
            _required.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
            _defaultValue.SetAccessPath(path, validateHasBeenSet);
            _enumValues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
