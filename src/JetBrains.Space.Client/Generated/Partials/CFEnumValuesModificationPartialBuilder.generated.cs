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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.CFEnumValuesModificationPartialBuilder
{
    public static class CFEnumValuesModificationPartialExtensions
    {
        public static Partial<CFEnumValuesModification> WithValuesToAdd(this Partial<CFEnumValuesModification> it)
            => it.AddFieldName("valuesToAdd");
        
        public static Partial<CFEnumValuesModification> WithValuesToAdd(this Partial<CFEnumValuesModification> it, Func<Partial<EnumValueData>, Partial<EnumValueData>> partialBuilder)
            => it.AddFieldName("valuesToAdd", partialBuilder(new Partial<EnumValueData>(it)));
        
        public static Partial<CFEnumValuesModification> WithValuesToUpdate(this Partial<CFEnumValuesModification> it)
            => it.AddFieldName("valuesToUpdate");
        
        public static Partial<CFEnumValuesModification> WithValuesToUpdate(this Partial<CFEnumValuesModification> it, Func<Partial<EnumValueData>, Partial<EnumValueData>> partialBuilder)
            => it.AddFieldName("valuesToUpdate", partialBuilder(new Partial<EnumValueData>(it)));
        
        public static Partial<CFEnumValuesModification> WithValuesToDelete(this Partial<CFEnumValuesModification> it)
            => it.AddFieldName("valuesToDelete");
        
    }
    
}
