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

namespace SpaceDotNet.Client.UpdatePointRequestExtensions
{
    public static class UpdatePointRequestDtoPartialExtensions
    {
        public static Partial<UpdatePointRequestDto> WithX(this Partial<UpdatePointRequestDto> it)
            => it.AddFieldName("x");
        
        public static Partial<UpdatePointRequestDto> WithY(this Partial<UpdatePointRequestDto> it)
            => it.AddFieldName("y");
        
        public static Partial<UpdatePointRequestDto> WithMapId(this Partial<UpdatePointRequestDto> it)
            => it.AddFieldName("mapId");
        
    }
    
}
