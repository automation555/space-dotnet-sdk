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

namespace SpaceDotNet.Client.BranchInfoExtensions
{
    public static class BranchInfoDtoPartialExtensions
    {
        public static Partial<BranchInfoDto> WithHead(this Partial<BranchInfoDto> it)
            => it.AddFieldName("head");
        
        public static Partial<BranchInfoDto> WithRef(this Partial<BranchInfoDto> it)
            => it.AddFieldName("ref");
        
    }
    
}
