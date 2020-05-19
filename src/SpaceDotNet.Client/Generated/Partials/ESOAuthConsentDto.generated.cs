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

namespace SpaceDotNet.Client.ESOAuthConsentExtensions
{
    public static class ESOAuthConsentDtoPartialExtensions
    {
        public static Partial<ESOAuthConsentDto> WithClientService(this Partial<ESOAuthConsentDto> it)
            => it.AddFieldName("clientService");
        
        public static Partial<ESOAuthConsentDto> WithClientService(this Partial<ESOAuthConsentDto> it, Func<Partial<ESServiceDto>, Partial<ESServiceDto>> partialBuilder)
            => it.AddFieldName("clientService", partialBuilder(new Partial<ESServiceDto>()));
        
        public static Partial<ESOAuthConsentDto> WithApprovedScopes(this Partial<ESOAuthConsentDto> it)
            => it.AddFieldName("approvedScopes");
        
        public static Partial<ESOAuthConsentDto> WithApprovedScopes(this Partial<ESOAuthConsentDto> it, Func<Partial<ESApprovedScopeDto>, Partial<ESApprovedScopeDto>> partialBuilder)
            => it.AddFieldName("approvedScopes", partialBuilder(new Partial<ESApprovedScopeDto>()));
        
        public static Partial<ESOAuthConsentDto> WithRefreshTokens(this Partial<ESOAuthConsentDto> it)
            => it.AddFieldName("refreshTokens");
        
        public static Partial<ESOAuthConsentDto> WithRefreshTokens(this Partial<ESOAuthConsentDto> it, Func<Partial<ESRefreshTokenDto>, Partial<ESRefreshTokenDto>> partialBuilder)
            => it.AddFieldName("refreshTokens", partialBuilder(new Partial<ESRefreshTokenDto>()));
        
    }
    
}
