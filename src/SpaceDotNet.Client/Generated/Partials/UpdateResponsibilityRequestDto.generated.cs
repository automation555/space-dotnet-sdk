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

namespace SpaceDotNet.Client.UpdateResponsibilityRequestExtensions
{
    public static class UpdateResponsibilityRequestDtoPartialExtensions
    {
        public static Partial<UpdateResponsibilityRequestDto> WithSummary(this Partial<UpdateResponsibilityRequestDto> it)
            => it.AddFieldName("summary");
        
        public static Partial<UpdateResponsibilityRequestDto> WithNotes(this Partial<UpdateResponsibilityRequestDto> it)
            => it.AddFieldName("notes");
        
    }
    
}
