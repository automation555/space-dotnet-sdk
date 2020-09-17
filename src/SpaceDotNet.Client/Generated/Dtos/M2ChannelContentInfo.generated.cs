// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public interface M2ChannelContentInfo
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static BillingFeedChannel BillingFeedChannel(ChannelSpecificDefaults? notificationDefaults = null)
            => new BillingFeedChannel(notificationDefaults: null);
        
        public static M2ChannelAutomationJobFeedInfo M2ChannelAutomationJobFeedInfo(JobSubscription jobSubscription, string jobName, ChannelSpecificDefaults notificationDefaults, string? repoName = null)
            => new M2ChannelAutomationJobFeedInfo(jobSubscription: jobSubscription, jobName: jobName, notificationDefaults: notificationDefaults, repoName: null);
        
        public static M2ChannelContactObsolete M2ChannelContactObsolete(M2ObsoleteCause? cause = null)
            => new M2ChannelContactObsolete(cause: null);
        
        public static M2ChannelContentApplication M2ChannelContentApplication(ESService service, ChannelSpecificDefaults notificationDefaults)
            => new M2ChannelContentApplication(service: service, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentArticle M2ChannelContentArticle(ArticleRecord article, ArticleContentRecord articleContent, ArticleDetailsRecord? details = null)
            => new M2ChannelContentArticle(article: article, articleContent: articleContent, details: null);
        
        public static M2ChannelContentCodeDiscussion M2ChannelContentCodeDiscussion(string codeDiscussionId, ChannelSpecificDefaults notificationDefaults, CodeDiscussionRecord? codeDiscussion = null)
            => new M2ChannelContentCodeDiscussion(codeDiscussionId: codeDiscussionId, notificationDefaults: notificationDefaults, codeDiscussion: null);
        
        public static M2ChannelContentCodeReviewDiscussion M2ChannelContentCodeReviewDiscussion(string codeReviewDiscussion, ChannelSpecificDefaults notificationDefaults)
            => new M2ChannelContentCodeReviewDiscussion(codeReviewDiscussion: codeReviewDiscussion, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentCodeReviewFeed M2ChannelContentCodeReviewFeed(string codeReviewId, ChannelSpecificDefaults notificationDefaults, CodeReviewRecord? codeReview = null, CodeReviewParticipants? participants = null, CodeReviewPendingMessageCounter? pendingMessageCounter = null, PRProject? project = null)
            => new M2ChannelContentCodeReviewFeed(codeReviewId: codeReviewId, notificationDefaults: notificationDefaults, codeReview: null, participants: null, pendingMessageCounter: null, project: null);
        
        public static M2ChannelContentLocation M2ChannelContentLocation(TDLocation location, ChannelSpecificDefaults notificationDefaults)
            => new M2ChannelContentLocation(location: location, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentMember M2ChannelContentMember(TDMemberProfile member, ChannelSpecificDefaults notificationDefaults, ProfileAbsencesRecord? memberAbsences = null, ProfileMembershipRecord? memberTeams = null)
            => new M2ChannelContentMember(member: member, notificationDefaults: notificationDefaults, memberAbsences: null, memberTeams: null);
        
        public static M2ChannelContentMembership M2ChannelContentMembership()
            => new M2ChannelContentMembership();
        
        public static M2ChannelContentMention M2ChannelContentMention(ChannelItemRecord record, M2ChannelRecord parent)
            => new M2ChannelContentMention(record: record, parent: parent);
        
        public static M2ChannelContentNamedPrivateChannel M2ChannelContentNamedPrivateChannel(string name, ChannelSpecificDefaults? notificationDefaults = null)
            => new M2ChannelContentNamedPrivateChannel(name: name, notificationDefaults: null);
        
        public static M2ChannelContentTeam M2ChannelContentTeam(TDTeam team, ChannelSpecificDefaults notificationDefaults)
            => new M2ChannelContentTeam(team: team, notificationDefaults: notificationDefaults);
        
        public static M2ChannelContentThread M2ChannelContentThread(ChannelItemRecord record, M2ChannelRecord parent)
            => new M2ChannelContentThread(record: record, parent: parent);
        
        public static M2ChannelIssueInfo M2ChannelIssueInfo(Issue issue, ChannelSpecificDefaults notificationDefaults, ProjectKey? projectKey = null)
            => new M2ChannelIssueInfo(issue: issue, notificationDefaults: notificationDefaults, projectKey: null);
        
        public static M2PrivateConversationChannelContent M2PrivateConversationChannelContent(string channelId, List<TDMemberProfile> members, string? subject = null, ChannelSpecificDefaults? notificationDefaults = null)
            => new M2PrivateConversationChannelContent(channelId: channelId, members: members, subject: null, notificationDefaults: null);
        
        public static M2SharedChannelContent M2SharedChannelContent(string name, string group, M2Access access, string description, ChannelSpecificDefaults notificationDefaults, string? iconId = null, List<TDTeam>? teams = null, bool? canEdit = null)
            => new M2SharedChannelContent(name: name, group: group, access: access, description: description, notificationDefaults: notificationDefaults, iconId: null, teams: null, canEdit: null);
        
        public static SpaceNewsFeedChannel SpaceNewsFeedChannel(ChannelSpecificDefaults? notificationDefaults = null)
            => new SpaceNewsFeedChannel(notificationDefaults: null);
        
    }
    
}
