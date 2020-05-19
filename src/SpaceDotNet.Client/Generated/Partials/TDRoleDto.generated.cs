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

namespace SpaceDotNet.Client.TDRoleExtensions
{
    public static class TDRoleDtoPartialExtensions
    {
        public static Partial<TDRoleDto> WithId(this Partial<TDRoleDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TDRoleDto> WithName(this Partial<TDRoleDto> it)
            => it.AddFieldName("name");
        
        public static Partial<TDRoleDto> WithParent(this Partial<TDRoleDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<TDRoleDto> WithParent(this Partial<TDRoleDto> it, Func<Partial<TDRoleDto>, Partial<TDRoleDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<TDRoleDto>()));
        
        public static Partial<TDRoleDto> WithArchived(this Partial<TDRoleDto> it)
            => it.AddFieldName("archived");
        
    }
    
}
