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

namespace SpaceDotNet.Client.TestLDAPSettingsRequestExtensions
{
    public static class TestLDAPSettingsRequestDtoPartialExtensions
    {
        public static Partial<TestLDAPSettingsRequestDto> WithSettings(this Partial<TestLDAPSettingsRequestDto> it)
            => it.AddFieldName("settings");
        
        public static Partial<TestLDAPSettingsRequestDto> WithSettings(this Partial<TestLDAPSettingsRequestDto> it, Func<Partial<ESLdapAuthModuleSettingsDto>, Partial<ESLdapAuthModuleSettingsDto>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESLdapAuthModuleSettingsDto>()));
        
        public static Partial<TestLDAPSettingsRequestDto> WithUsername(this Partial<TestLDAPSettingsRequestDto> it)
            => it.AddFieldName("username");
        
        public static Partial<TestLDAPSettingsRequestDto> WithPassword(this Partial<TestLDAPSettingsRequestDto> it)
            => it.AddFieldName("password");
        
    }
    
}
