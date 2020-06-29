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

namespace SpaceDotNet.Client.CustomFieldDtoPartialBuilder
{
    public static class CustomFieldDtoPartialExtensions
    {
        public static Partial<CustomFieldDto> WithExtendedType(this Partial<CustomFieldDto> it)
            => it.AddFieldName("extendedType");
        
        public static Partial<CustomFieldDto> WithExtendedType(this Partial<CustomFieldDto> it, Func<Partial<ExtendedTypeDto>, Partial<ExtendedTypeDto>> partialBuilder)
            => it.AddFieldName("extendedType", partialBuilder(new Partial<ExtendedTypeDto>(it)));
        
        public static Partial<CustomFieldDto> WithId(this Partial<CustomFieldDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CustomFieldDto> WithName(this Partial<CustomFieldDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CustomFieldDto> WithDescription(this Partial<CustomFieldDto> it)
            => it.AddFieldName("description");
        
        public static Partial<CustomFieldDto> WithKey(this Partial<CustomFieldDto> it)
            => it.AddFieldName("key");
        
        public static Partial<CustomFieldDto> WithType(this Partial<CustomFieldDto> it)
            => it.AddFieldName("type");
        
        public static Partial<CustomFieldDto> WithType(this Partial<CustomFieldDto> it, Func<Partial<CFTypeDto>, Partial<CFTypeDto>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<CFTypeDto>(it)));
        
        public static Partial<CustomFieldDto> WithConstraint(this Partial<CustomFieldDto> it)
            => it.AddFieldName("constraint");
        
        public static Partial<CustomFieldDto> WithConstraint(this Partial<CustomFieldDto> it, Func<Partial<CFConstraintDto>, Partial<CFConstraintDto>> partialBuilder)
            => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraintDto>(it)));
        
        public static Partial<CustomFieldDto> WithRequired(this Partial<CustomFieldDto> it)
            => it.AddFieldName("required");
        
        public static Partial<CustomFieldDto> WithPrivate(this Partial<CustomFieldDto> it)
            => it.AddFieldName("private");
        
        public static Partial<CustomFieldDto> WithAccess(this Partial<CustomFieldDto> it)
            => it.AddFieldName("access");
        
        public static Partial<CustomFieldDto> WithAccess(this Partial<CustomFieldDto> it, Func<Partial<AccessType>, Partial<AccessType>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<AccessType>(it)));
        
        public static Partial<CustomFieldDto> WithDefaultValue(this Partial<CustomFieldDto> it)
            => it.AddFieldName("defaultValue");
        
        public static Partial<CustomFieldDto> WithDefaultValue(this Partial<CustomFieldDto> it, Func<Partial<CFValueDto>, Partial<CFValueDto>> partialBuilder)
            => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFValueDto>(it)));
        
        public static Partial<CustomFieldDto> WithOrder(this Partial<CustomFieldDto> it)
            => it.AddFieldName("order");
        
        public static Partial<CustomFieldDto> WithArchived(this Partial<CustomFieldDto> it)
            => it.AddFieldName("archived");
        
    }
    
}
