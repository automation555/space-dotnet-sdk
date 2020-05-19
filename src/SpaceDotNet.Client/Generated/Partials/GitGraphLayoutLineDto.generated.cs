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

namespace SpaceDotNet.Client.GitGraphLayoutLineExtensions
{
    public static class GitGraphLayoutLineDtoPartialExtensions
    {
        public static Partial<GitGraphLayoutLineDto> WithNodes(this Partial<GitGraphLayoutLineDto> it)
            => it.AddFieldName("nodes");
        
        public static Partial<GitGraphLayoutLineDto> WithNodes(this Partial<GitGraphLayoutLineDto> it, Func<Partial<GitGraphLayoutNodeDto>, Partial<GitGraphLayoutNodeDto>> partialBuilder)
            => it.AddFieldName("nodes", partialBuilder(new Partial<GitGraphLayoutNodeDto>()));
        
        public static Partial<GitGraphLayoutLineDto> WithEdges(this Partial<GitGraphLayoutLineDto> it)
            => it.AddFieldName("edges");
        
        public static Partial<GitGraphLayoutLineDto> WithEdges(this Partial<GitGraphLayoutLineDto> it, Func<Partial<GitGraphLayoutEdgeDto>, Partial<GitGraphLayoutEdgeDto>> partialBuilder)
            => it.AddFieldName("edges", partialBuilder(new Partial<GitGraphLayoutEdgeDto>()));
        
    }
    
}
