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

namespace SpaceDotNet.Client.MCButtonExtensions
{
    public static class MCButtonDtoPartialExtensions
    {
        public static Partial<MCButtonDto> WithText(this Partial<MCButtonDto> it)
            => it.AddFieldName("text");
        
        public static Partial<MCButtonDto> WithStyle(this Partial<MCButtonDto> it)
            => it.AddFieldName("style");
        
        public static Partial<MCButtonDto> WithAction(this Partial<MCButtonDto> it)
            => it.AddFieldName("action");
        
        public static Partial<MCButtonDto> WithAction(this Partial<MCButtonDto> it, Func<Partial<MCActionDto>, Partial<MCActionDto>> partialBuilder)
            => it.AddFieldName("action", partialBuilder(new Partial<MCActionDto>()));
        
    }
    
}
