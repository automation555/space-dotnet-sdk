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

namespace SpaceDotNet.Client.CommitSetReviewRecordExtensions
{
    public static class CommitSetReviewRecordDtoPartialExtensions
    {
        public static Partial<CommitSetReviewRecordDto> WithId(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<CommitSetReviewRecordDto> WithProject(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("project");
        
        public static Partial<CommitSetReviewRecordDto> WithProject(this Partial<CommitSetReviewRecordDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<CommitSetReviewRecordDto> WithProjectId(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("projectId");
        
        public static Partial<CommitSetReviewRecordDto> WithNumber(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("number");
        
        public static Partial<CommitSetReviewRecordDto> WithTitle(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("title");
        
        public static Partial<CommitSetReviewRecordDto> WithState(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("state");
        
        public static Partial<CommitSetReviewRecordDto> WithCanBeReopened(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("canBeReopened");
        
        public static Partial<CommitSetReviewRecordDto> WithCreatedAt(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("createdAt");
        
        public static Partial<CommitSetReviewRecordDto> WithCreatedBy(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("createdBy");
        
        public static Partial<CommitSetReviewRecordDto> WithCreatedBy(this Partial<CommitSetReviewRecordDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("createdBy", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<CommitSetReviewRecordDto> WithTurnBased(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("turnBased");
        
        public static Partial<CommitSetReviewRecordDto> WithParticipants(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("participants");
        
        public static Partial<CommitSetReviewRecordDto> WithParticipants(this Partial<CommitSetReviewRecordDto> it, Func<Partial<CodeReviewParticipantDto>, Partial<CodeReviewParticipantDto>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipantDto>()));
        
        public static Partial<CommitSetReviewRecordDto> WithFeedChannel(this Partial<CommitSetReviewRecordDto> it)
            => it.AddFieldName("feedChannel");
        
        public static Partial<CommitSetReviewRecordDto> WithFeedChannel(this Partial<CommitSetReviewRecordDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)
            => it.AddFieldName("feedChannel", partialBuilder(new Partial<M2ChannelRecordDto>()));
        
    }
    
}
