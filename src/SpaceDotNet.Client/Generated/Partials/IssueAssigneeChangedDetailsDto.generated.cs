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

namespace SpaceDotNet.Client.IssueAssigneeChangedDetailsExtensions
{
    public static class IssueAssigneeChangedDetailsDtoPartialExtensions
    {
        public static Partial<IssueAssigneeChangedDetailsDto> WithOldAssignee(this Partial<IssueAssigneeChangedDetailsDto> it)
            => it.AddFieldName("oldAssignee");
        
        public static Partial<IssueAssigneeChangedDetailsDto> WithOldAssignee(this Partial<IssueAssigneeChangedDetailsDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("oldAssignee", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<IssueAssigneeChangedDetailsDto> WithNewAssignee(this Partial<IssueAssigneeChangedDetailsDto> it)
            => it.AddFieldName("newAssignee");
        
        public static Partial<IssueAssigneeChangedDetailsDto> WithNewAssignee(this Partial<IssueAssigneeChangedDetailsDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("newAssignee", partialBuilder(new Partial<TDMemberProfileDto>()));
        
    }
    
}
