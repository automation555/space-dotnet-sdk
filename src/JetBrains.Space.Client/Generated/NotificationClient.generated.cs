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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class NotificationClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public NotificationClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// List all subscription subjects
        /// </summary>
        public async Task<List<EventSubjectInfo>> GetAllNotificationsAsync(Func<Partial<EventSubjectInfo>, Partial<EventSubjectInfo>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<EventSubjectInfo>()) : Partial<EventSubjectInfo>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<EventSubjectInfo>>("GET", $"api/http/notifications{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public ChannelSubscriptionClient ChannelSubscriptions => new ChannelSubscriptionClient(_connection);
        
        public partial class ChannelSubscriptionClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ChannelSubscriptionClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Add subscription for a channel
            /// </summary>
            public async Task<Subscription> CreateChannelSubscriptionAsync(ChatChannel channel, string name, CustomGenericSubscriptionIn subscription, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsChannelSubscriptionsPostRequest, Subscription>("POST", $"api/http/notifications/channel-subscriptions{queryParameters.ToQueryString()}", 
                    new NotificationsChannelSubscriptionsPostRequest
                    { 
                        Channel = channel,
                        Name = name,
                        Subscription = subscription,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// List subscriptions for a channel
            /// </summary>
            public async Task<List<Subscription>> GetAllChannelSubscriptionsAsync(ChatChannel channel, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("channel", channel.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<Subscription>>("GET", $"api/http/notifications/channel-subscriptions{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Update subscription for a channel
            /// </summary>
            public async Task<Subscription> UpdateChannelSubscriptionAsync(string id, string? name = null, bool? enabled = null, CustomGenericSubscriptionIn? subscription = null, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsChannelSubscriptionsForIdPatchRequest, Subscription>("PATCH", $"api/http/notifications/channel-subscriptions/{id}{queryParameters.ToQueryString()}", 
                    new NotificationsChannelSubscriptionsForIdPatchRequest
                    { 
                        Name = name,
                        IsEnabled = enabled,
                        Subscription = subscription,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Delete channel subscription
            /// </summary>
            public async Task DeleteChannelSubscriptionAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/notifications/channel-subscriptions/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public PersonalCustomSubscriptionClient PersonalCustomSubscriptions => new PersonalCustomSubscriptionClient(_connection);
        
        public partial class PersonalCustomSubscriptionClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public PersonalCustomSubscriptionClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create personal custom subscription
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Subscription> CreatePersonalCustomSubscriptionAsync(ProfileIdentifier profile, string name, string feed, CustomGenericSubscriptionIn subscription, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsPersonalCustomSubscriptionsPostRequest, Subscription>("POST", $"api/http/notifications/personal-custom-subscriptions{queryParameters.ToQueryString()}", 
                    new NotificationsPersonalCustomSubscriptionsPostRequest
                    { 
                        Profile = profile,
                        Name = name,
                        Feed = feed,
                        Subscription = subscription,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// List personal custom subscriptions
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<Subscription>> GetAllPersonalCustomSubscriptionsAsync(ProfileIdentifier profile, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("profile", profile.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<Subscription>>("GET", $"api/http/notifications/personal-custom-subscriptions{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Create personal custom subscription
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Subscription> UpdatePersonalCustomSubscriptionAsync(string id, string? name = null, bool? enabled = null, string? feed = null, CustomGenericSubscriptionIn? subscription = null, Func<Partial<Subscription>, Partial<Subscription>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Subscription>()) : Partial<Subscription>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsPersonalCustomSubscriptionsForIdPatchRequest, Subscription>("PATCH", $"api/http/notifications/personal-custom-subscriptions/{id}{queryParameters.ToQueryString()}", 
                    new NotificationsPersonalCustomSubscriptionsForIdPatchRequest
                    { 
                        Name = name,
                        IsEnabled = enabled,
                        Feed = feed,
                        Subscription = subscription,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Delete personal custom subscription
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task DeletePersonalCustomSubscriptionAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/notifications/personal-custom-subscriptions/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public PersonalSubscriptionClient PersonalSubscriptions => new PersonalSubscriptionClient(_connection);
        
        public partial class PersonalSubscriptionClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public PersonalSubscriptionClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Update personal subscription settings for a member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task UpdatePersonalSubscriptionSubjectAsync(ProfileIdentifier profile, string subjectCode, string feed, bool enabled, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/notifications/personal-subscriptions/update-personal-subscription-subject{queryParameters.ToQueryString()}", 
                    new NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionSubjectPostRequest
                    { 
                        Profile = profile,
                        SubjectCode = subjectCode,
                        Feed = feed,
                        IsEnabled = enabled,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Update personal subscription settings for a member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task UpdatePersonalSubscriptionTargetAsync(ProfileIdentifier profile, string targetCode, string feed, List<string> eventCodes, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/notifications/personal-subscriptions/update-personal-subscription-target{queryParameters.ToQueryString()}", 
                    new NotificationsPersonalSubscriptionsUpdatePersonalSubscriptionTargetPostRequest
                    { 
                        Profile = profile,
                        TargetCode = targetCode,
                        Feed = feed,
                        EventCodes = eventCodes,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// List all personal subscription targets
            /// </summary>
            public async Task<List<PersonalSubscriptionTarget>> AllPersonalSubscriptionTargetsAsync(Func<Partial<PersonalSubscriptionTarget>, Partial<PersonalSubscriptionTarget>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<PersonalSubscriptionTarget>()) : Partial<PersonalSubscriptionTarget>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<PersonalSubscriptionTarget>>("GET", $"api/http/notifications/personal-subscriptions/all-personal-subscription-targets{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Get personal subscription settings for a member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<PersonalSubscriptionSettings> GetPersonalSubscriptionSettingsAsync(ProfileIdentifier profile, string feed, Func<Partial<PersonalSubscriptionSettings>, Partial<PersonalSubscriptionSettings>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("profile", profile.ToString());
                queryParameters.Append("feed", feed);
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<PersonalSubscriptionSettings>()) : Partial<PersonalSubscriptionSettings>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<PersonalSubscriptionSettings>("GET", $"api/http/notifications/personal-subscriptions/personal-subscription-settings{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public PrivateFeedClient PrivateFeeds => new PrivateFeedClient(_connection);
        
        public partial class PrivateFeedClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public PrivateFeedClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create personal feed for member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<PrivateFeed> CreatePrivateFeedAsync(ProfileIdentifier profile, string name, string icon, PrivateFeedColor color, Func<Partial<PrivateFeed>, Partial<PrivateFeed>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<PrivateFeed>()) : Partial<PrivateFeed>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsPrivateFeedsPostRequest, PrivateFeed>("POST", $"api/http/notifications/private-feeds{queryParameters.ToQueryString()}", 
                    new NotificationsPrivateFeedsPostRequest
                    { 
                        Profile = profile,
                        Name = name,
                        Icon = icon,
                        Color = color,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// List personal feeds for a member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<PrivateFeed>> GetAllPrivateFeedsAsync(ProfileIdentifier profile, Func<Partial<PrivateFeed>, Partial<PrivateFeed>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("profile", profile.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<PrivateFeed>()) : Partial<PrivateFeed>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<PrivateFeed>>("GET", $"api/http/notifications/private-feeds{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Update personal feed for a member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<PrivateFeed> UpdatePrivateFeedAsync(string id, string? name = null, string? icon = null, PrivateFeedColor? color = null, Func<Partial<PrivateFeed>, Partial<PrivateFeed>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<PrivateFeed>()) : Partial<PrivateFeed>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<NotificationsPrivateFeedsForIdPatchRequest, PrivateFeed>("PATCH", $"api/http/notifications/private-feeds/{id}{queryParameters.ToQueryString()}", 
                    new NotificationsPrivateFeedsForIdPatchRequest
                    { 
                        Name = name,
                        Icon = icon,
                        Color = color,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Delete personal feed for member
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit notification settings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task DeletePrivateFeedAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/notifications/private-feeds/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
    }
    
}
