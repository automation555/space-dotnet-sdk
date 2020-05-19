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

namespace SpaceDotNet.Client.PermissionComparisonEntryDTOExtensions
{
    public static class PermissionComparisonEntryDTODtoPartialExtensions
    {
        public static Partial<PermissionComparisonEntryDTODto> WithPrincipalIndex(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("principalIndex");
        
        public static Partial<PermissionComparisonEntryDTODto> WithRightIndex(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("rightIndex");
        
        public static Partial<PermissionComparisonEntryDTODto> WithAllTargets1(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("allTargets1");
        
        public static Partial<PermissionComparisonEntryDTODto> WithTargetIndices1(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("targetIndices1");
        
        public static Partial<PermissionComparisonEntryDTODto> WithTargetIndices1(this Partial<PermissionComparisonEntryDTODto> it, Func<Partial<int>, Partial<int>> partialBuilder)
            => it.AddFieldName("targetIndices1", partialBuilder(new Partial<int>()));
        
        public static Partial<PermissionComparisonEntryDTODto> WithAllTargets2(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("allTargets2");
        
        public static Partial<PermissionComparisonEntryDTODto> WithTargetIndices2(this Partial<PermissionComparisonEntryDTODto> it)
            => it.AddFieldName("targetIndices2");
        
        public static Partial<PermissionComparisonEntryDTODto> WithTargetIndices2(this Partial<PermissionComparisonEntryDTODto> it, Func<Partial<int>, Partial<int>> partialBuilder)
            => it.AddFieldName("targetIndices2", partialBuilder(new Partial<int>()));
        
    }
    
}
