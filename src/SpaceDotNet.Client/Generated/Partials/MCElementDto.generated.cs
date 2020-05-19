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

namespace SpaceDotNet.Client.MCElementExtensions
{
    public static class MCElementDtoPartialExtensions
    {
        public static Partial<MCElementDto> WithDefaultText(this Partial<MCElementDto> it)
            => it.AddFieldName("defaultText");
        
        public static Partial<MCElementDto> WithDetails(this Partial<MCElementDto> it)
            => it.AddFieldName("details");
        
        public static Partial<MCElementDto> WithDetails(this Partial<MCElementDto> it, Func<Partial<MCElementDetailsDto>, Partial<MCElementDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<MCElementDetailsDto>()));
        
    }
    
}
