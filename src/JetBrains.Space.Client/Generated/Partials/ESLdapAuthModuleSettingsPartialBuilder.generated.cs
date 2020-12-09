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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ESLdapAuthModuleSettingsPartialBuilder
{
    public static class ESLdapAuthModuleSettingsPartialExtensions
    {
        public static Partial<ESLdapAuthModuleSettings> WithType(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("type");
        
        public static Partial<ESLdapAuthModuleSettings> WithType(this Partial<ESLdapAuthModuleSettings> it, Func<Partial<LdapModuleType>, Partial<LdapModuleType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<LdapModuleType>(it)));
        
        public static Partial<ESLdapAuthModuleSettings> WithIsRegisterNewUsers(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESLdapAuthModuleSettings> WithServerUrl(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("serverUrl");
        
        public static Partial<ESLdapAuthModuleSettings> WithConnectionTimeout(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("connectionTimeout");
        
        public static Partial<ESLdapAuthModuleSettings> WithReadTimeout(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("readTimeout");
        
        public static Partial<ESLdapAuthModuleSettings> WithSslKeystore(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("sslKeystore");
        
        public static Partial<ESLdapAuthModuleSettings> WithSslKeystore(this Partial<ESLdapAuthModuleSettings> it, Func<Partial<SSLKeystore>, Partial<SSLKeystore>> partialBuilder)
            => it.AddFieldName("sslKeystore", partialBuilder(new Partial<SSLKeystore>(it)));
        
        public static Partial<ESLdapAuthModuleSettings> WithTeamMappings(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("teamMappings");
        
        public static Partial<ESLdapAuthModuleSettings> WithTeamMappings(this Partial<ESLdapAuthModuleSettings> it, Func<Partial<ESTeamMapping>, Partial<ESTeamMapping>> partialBuilder)
            => it.AddFieldName("teamMappings", partialBuilder(new Partial<ESTeamMapping>(it)));
        
        public static Partial<ESLdapAuthModuleSettings> WithIsReferralIgnored(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("referralIgnored");
        
        public static Partial<ESLdapAuthModuleSettings> WithFilter(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("filter");
        
        public static Partial<ESLdapAuthModuleSettings> WithBindUserDN(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("bindUserDN");
        
        public static Partial<ESLdapAuthModuleSettings> WithBindUserPassword(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("bindUserPassword");
        
        public static Partial<ESLdapAuthModuleSettings> WithAttributeNames(this Partial<ESLdapAuthModuleSettings> it)
            => it.AddFieldName("attributeNames");
        
        public static Partial<ESLdapAuthModuleSettings> WithAttributeNames(this Partial<ESLdapAuthModuleSettings> it, Func<Partial<ESLdapAttributeNames>, Partial<ESLdapAttributeNames>> partialBuilder)
            => it.AddFieldName("attributeNames", partialBuilder(new Partial<ESLdapAttributeNames>(it)));
        
    }
    
}
