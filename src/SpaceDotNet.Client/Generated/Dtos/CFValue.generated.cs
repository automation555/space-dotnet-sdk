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
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CFValue
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CFValue";
        
        public static BooleanCFValue Boolean(bool? value = null)
            => new BooleanCFValue(value: null);
        
        public static DateCFValue Date(DateTime? value = null)
            => new DateCFValue(value: null);
        
        public static EnumCFValue Enum(EnumValueData? value = null)
            => new EnumCFValue(value: null);
        
        public static EnumListCFValue EnumList(List<EnumValueData> values)
            => new EnumListCFValue(values: values);
        
        public static FractionCFValue Fraction(Fraction? value = null)
            => new FractionCFValue(value: null);
        
        public static IntCFValue Int(int? value = null)
            => new IntCFValue(value: null);
        
        public static IntListCFValue IntList(List<int> values)
            => new IntListCFValue(values: values);
        
        public static PercentCFValue Percent(int? value = null)
            => new PercentCFValue(value: null);
        
        public static ProfileCFValue Profile(TDMemberProfile? profile = null)
            => new ProfileCFValue(profile: null);
        
        public static ProfileListCFValue ProfileList(List<TDMemberProfile> profiles)
            => new ProfileListCFValue(profiles: profiles);
        
        public static StringCFValue String(string? value = null)
            => new StringCFValue(value: null);
        
        public static StringListCFValue StringList(List<string> values)
            => new StringListCFValue(values: values);
        
        public static UrlCFValue Url(string? href = null)
            => new UrlCFValue(href: null);
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
