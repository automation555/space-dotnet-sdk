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

namespace SpaceDotNet.Client.TDMemberLocationExtensions
{
    public static class TDMemberLocationDtoPartialExtensions
    {
        public static Partial<TDMemberLocationDto> WithId(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDMemberLocationDto> WithLocation(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("location");
        
        public static Partial<TDMemberLocationDto> WithLocation(this Partial<TDMemberLocationDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocationDto>()));
        
        public static Partial<TDMemberLocationDto> WithLocationMapPoints(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("locationMapPoints");
        
        public static Partial<TDMemberLocationDto> WithLocationMapPoints(this Partial<TDMemberLocationDto> it, Func<Partial<TDLocationMapPointDto>, Partial<TDLocationMapPointDto>> partialBuilder)
            => it.AddFieldName("locationMapPoints", partialBuilder(new Partial<TDLocationMapPointDto>()));
        
        public static Partial<TDMemberLocationDto> WithSince(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("since");
        
        public static Partial<TDMemberLocationDto> WithTill(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("till");
        
        public static Partial<TDMemberLocationDto> WithMember(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("member");
        
        public static Partial<TDMemberLocationDto> WithMember(this Partial<TDMemberLocationDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<TDMemberLocationDto> WithArchived(this Partial<TDMemberLocationDto> it)
            => it.AddFieldName("archived");
        
    }
    
}
