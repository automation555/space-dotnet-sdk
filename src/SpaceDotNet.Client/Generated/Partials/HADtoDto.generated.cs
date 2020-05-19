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

namespace SpaceDotNet.Client.HADtoExtensions
{
    public static class HADtoDtoPartialExtensions
    {
        public static Partial<HADtoDto> WithId(this Partial<HADtoDto> it)
            => it.AddFieldName("id");
        
        public static Partial<HADtoDto> WithName(this Partial<HADtoDto> it)
            => it.AddFieldName("name");
        
        public static Partial<HADtoDto> WithFields(this Partial<HADtoDto> it)
            => it.AddFieldName("fields");
        
        public static Partial<HADtoDto> WithFields(this Partial<HADtoDto> it, Func<Partial<HADtoFieldDto>, Partial<HADtoFieldDto>> partialBuilder)
            => it.AddFieldName("fields", partialBuilder(new Partial<HADtoFieldDto>()));
        
        public static Partial<HADtoDto> WithHierarchyRole(this Partial<HADtoDto> it)
            => it.AddFieldName("hierarchyRole");
        
        public static Partial<HADtoDto> WithExtends(this Partial<HADtoDto> it)
            => it.AddFieldName("extends");
        
        public static Partial<HADtoDto> WithExtends(this Partial<HADtoDto> it, Func<Partial<HADtoDto>, Partial<HADtoDto>> partialBuilder)
            => it.AddFieldName("extends", partialBuilder(new Partial<HADtoDto>()));
        
        public static Partial<HADtoDto> WithImplements(this Partial<HADtoDto> it)
            => it.AddFieldName("implements");
        
        public static Partial<HADtoDto> WithImplements(this Partial<HADtoDto> it, Func<Partial<HADtoDto>, Partial<HADtoDto>> partialBuilder)
            => it.AddFieldName("implements", partialBuilder(new Partial<HADtoDto>()));
        
        public static Partial<HADtoDto> WithInheritors(this Partial<HADtoDto> it)
            => it.AddFieldName("inheritors");
        
        public static Partial<HADtoDto> WithInheritors(this Partial<HADtoDto> it, Func<Partial<HADtoDto>, Partial<HADtoDto>> partialBuilder)
            => it.AddFieldName("inheritors", partialBuilder(new Partial<HADtoDto>()));
        
        public static Partial<HADtoDto> WithDeprecation(this Partial<HADtoDto> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HADtoDto> WithDeprecation(this Partial<HADtoDto> it, Func<Partial<HADeprecationDto>, Partial<HADeprecationDto>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecationDto>()));
        
        public static Partial<HADtoDto> WithRecord(this Partial<HADtoDto> it)
            => it.AddFieldName("record");
        
    }
    
}
