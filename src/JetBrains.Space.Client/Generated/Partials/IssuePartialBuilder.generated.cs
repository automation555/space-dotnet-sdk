// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.IssuePartialBuilder
{
    public static class IssuePartialExtensions
    {
        public static Partial<Issue> WithId(this Partial<Issue> it)
            => it.AddFieldName("id");
        
        public static Partial<Issue> WithIsArchived(this Partial<Issue> it)
            => it.AddFieldName("archived");
        
        public static Partial<Issue> WithProjectId(this Partial<Issue> it)
            => it.AddFieldName("projectId");
        
        public static Partial<Issue> WithProjectRef(this Partial<Issue> it)
            => it.AddFieldName("projectRef");
        
        public static Partial<Issue> WithProjectRef(this Partial<Issue> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("projectRef", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<Issue> WithTrackerRef(this Partial<Issue> it)
            => it.AddFieldName("trackerRef");
        
        public static Partial<Issue> WithTrackerRef(this Partial<Issue> it, Func<Partial<IssueTracker>, Partial<IssueTracker>> partialBuilder)
            => it.AddFieldName("trackerRef", partialBuilder(new Partial<IssueTracker>(it)));
        
        public static Partial<Issue> WithNumber(this Partial<Issue> it)
            => it.AddFieldName("number");
        
        public static Partial<Issue> WithCreatedBy(this Partial<Issue> it)
            => it.AddFieldName("createdBy");
        
        public static Partial<Issue> WithCreatedBy(this Partial<Issue> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<Issue> WithCreationTime(this Partial<Issue> it)
            => it.AddFieldName("creationTime");
        
        public static Partial<Issue> WithAssignee(this Partial<Issue> it)
            => it.AddFieldName("assignee");
        
        public static Partial<Issue> WithAssignee(this Partial<Issue> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("assignee", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<Issue> WithStatus(this Partial<Issue> it)
            => it.AddFieldName("status");
        
        public static Partial<Issue> WithStatus(this Partial<Issue> it, Func<Partial<IssueStatus>, Partial<IssueStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<IssueStatus>(it)));
        
        public static Partial<Issue> WithDueDate(this Partial<Issue> it)
            => it.AddFieldName("dueDate");
        
        public static Partial<Issue> WithImportInfo(this Partial<Issue> it)
            => it.AddFieldName("importInfo");
        
        public static Partial<Issue> WithImportInfo(this Partial<Issue> it, Func<Partial<ImportedEntityInfo>, Partial<ImportedEntityInfo>> partialBuilder)
            => it.AddFieldName("importInfo", partialBuilder(new Partial<ImportedEntityInfo>(it)));
        
        public static Partial<Issue> WithExternalEntityInfo(this Partial<Issue> it)
            => it.AddFieldName("externalEntityInfo");
        
        public static Partial<Issue> WithExternalEntityInfo(this Partial<Issue> it, Func<Partial<ExternalEntityInfoRecord>, Partial<ExternalEntityInfoRecord>> partialBuilder)
            => it.AddFieldName("externalEntityInfo", partialBuilder(new Partial<ExternalEntityInfoRecord>(it)));
        
        public static Partial<Issue> WithTags(this Partial<Issue> it)
            => it.AddFieldName("tags");
        
        public static Partial<Issue> WithTags(this Partial<Issue> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("tags", partialBuilder(new Partial<PlanningTag>(it)));
        
        public static Partial<Issue> WithTitle(this Partial<Issue> it)
            => it.AddFieldName("title");
        
        public static Partial<Issue> WithAttachmentsCount(this Partial<Issue> it)
            => it.AddFieldName("attachmentsCount");
        
        public static Partial<Issue> WithAttachments(this Partial<Issue> it)
            => it.AddFieldName("attachments");
        
        public static Partial<Issue> WithAttachments(this Partial<Issue> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfo>(it)));
        
        public static Partial<Issue> WithChannel(this Partial<Issue> it)
            => it.AddFieldName("channel");
        
        public static Partial<Issue> WithChannel(this Partial<Issue> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<Issue> WithChecklists(this Partial<Issue> it)
            => it.AddFieldName("checklists");
        
        public static Partial<Issue> WithChecklists(this Partial<Issue> it, Func<Partial<Checklist>, Partial<Checklist>> partialBuilder)
            => it.AddFieldName("checklists", partialBuilder(new Partial<Checklist>(it)));
        
        public static Partial<Issue> WithDescription(this Partial<Issue> it)
            => it.AddFieldName("description");
        
        public static Partial<Issue> WithSprints(this Partial<Issue> it)
            => it.AddFieldName("sprints");
        
        public static Partial<Issue> WithSprints(this Partial<Issue> it, Func<Partial<SprintRecord>, Partial<SprintRecord>> partialBuilder)
            => it.AddFieldName("sprints", partialBuilder(new Partial<SprintRecord>(it)));
        
    }
    
}
