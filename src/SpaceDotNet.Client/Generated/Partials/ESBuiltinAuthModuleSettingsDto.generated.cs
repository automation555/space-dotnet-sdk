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

namespace SpaceDotNet.Client.ESBuiltinAuthModuleSettingsExtensions
{
    public static class ESBuiltinAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESBuiltinAuthModuleSettingsDto> WithPasswordStrengthPolicy(this Partial<ESBuiltinAuthModuleSettingsDto> it)
            => it.AddFieldName("passwordStrengthPolicy");
        
        public static Partial<ESBuiltinAuthModuleSettingsDto> WithDomains(this Partial<ESBuiltinAuthModuleSettingsDto> it)
            => it.AddFieldName("domains");
        
        public static Partial<ESBuiltinAuthModuleSettingsDto> WithDomains(this Partial<ESBuiltinAuthModuleSettingsDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("domains", partialBuilder(new Partial<string>()));
        
    }
    
}
