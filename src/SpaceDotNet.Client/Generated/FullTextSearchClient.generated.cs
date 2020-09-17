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
    public partial class FullTextSearchClient
    {
        private readonly Connection _connection;
        
        public FullTextSearchClient(Connection connection)
        {
            _connection = connection;
        }
        
        public BlogClient Blogs => new BlogClient(_connection);
        
        public partial class BlogClient
        {
            private readonly Connection _connection;
            
            public BlogClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all blogs.
            /// </summary>
            public async Task<Batch<FTSBlog>> GetAllBlogsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSBlog>>, Partial<Batch<FTSBlog>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<FTSBlog>>("GET", $"api/http/full-text-search/blogs?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSBlog>>()) : Partial<Batch<FTSBlog>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all blogs.
            /// </summary>
            public IAsyncEnumerable<FTSBlog> GetAllBlogsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSBlog>, Partial<FTSBlog>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllBlogsAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<FTSBlog>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSBlog>.Default())), skip, cancellationToken);
        
        }
    
        public DraftClient Drafts => new DraftClient(_connection);
        
        public partial class DraftClient
        {
            private readonly Connection _connection;
            
            public DraftClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all drafts.
            /// </summary>
            public async Task<Batch<FTSDraft>> GetAllDraftsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSDraft>>, Partial<Batch<FTSDraft>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<FTSDraft>>("GET", $"api/http/full-text-search/drafts?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSDraft>>()) : Partial<Batch<FTSDraft>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all drafts.
            /// </summary>
            public IAsyncEnumerable<FTSDraft> GetAllDraftsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSDraft>, Partial<FTSDraft>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllDraftsAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<FTSDraft>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSDraft>.Default())), skip, cancellationToken);
        
        }
    
        public MessagesSearchClient MessagesSearch => new MessagesSearchClient(_connection);
        
        public partial class MessagesSearchClient
        {
            private readonly Connection _connection;
            
            public MessagesSearchClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search for messages in chat.
            /// </summary>
            public async Task<Batch<MessageHit>> GetAllMessagesSearchAsync(string chatId, string query, string? skip = null, int? top = 100, Func<Partial<Batch<MessageHit>>, Partial<Batch<MessageHit>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<MessageHit>>("GET", $"api/http/full-text-search/messages-search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&chatId={chatId.ToString()}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<MessageHit>>()) : Partial<Batch<MessageHit>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search for messages in chat.
            /// </summary>
            public IAsyncEnumerable<MessageHit> GetAllMessagesSearchAsyncEnumerable(string chatId, string query, string? skip = null, int? top = 100, Func<Partial<MessageHit>, Partial<MessageHit>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllMessagesSearchAsync(chatId: chatId, query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<MessageHit>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<MessageHit>.Default())), skip, cancellationToken);
        
        }
    
        public ProfileClient Profiles => new ProfileClient(_connection);
        
        public partial class ProfileClient
        {
            private readonly Connection _connection;
            
            public ProfileClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public async Task<Batch<FTSProfile>> GetAllProfilesAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSProfile>>, Partial<Batch<FTSProfile>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<FTSProfile>>("GET", $"api/http/full-text-search/profiles?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSProfile>>()) : Partial<Batch<FTSProfile>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public IAsyncEnumerable<FTSProfile> GetAllProfilesAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSProfile>, Partial<FTSProfile>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllProfilesAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<FTSProfile>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSProfile>.Default())), skip, cancellationToken);
        
        }
    
        public ProfilesSearchClient ProfilesSearch => new ProfilesSearchClient(_connection);
        
        public partial class ProfilesSearchClient
        {
            private readonly Connection _connection;
            
            public ProfilesSearchClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public async Task<Batch<ProfileHit>> GetAllProfilesSearchAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<ProfileHit>>, Partial<Batch<ProfileHit>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<ProfileHit>>("GET", $"api/http/full-text-search/profiles-search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<ProfileHit>>()) : Partial<Batch<ProfileHit>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public IAsyncEnumerable<ProfileHit> GetAllProfilesSearchAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<ProfileHit>, Partial<ProfileHit>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllProfilesSearchAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<ProfileHit>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<ProfileHit>.Default())), skip, cancellationToken);
        
        }
    
        public SearchClient Search => new SearchClient(_connection);
        
        public partial class SearchClient
        {
            private readonly Connection _connection;
            
            public SearchClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all supported entities.
            /// </summary>
            public async Task<Batch<EntityHit>> GetAllSearchAsync(string query, bool quick = false, string? skip = null, int? top = 100, Func<Partial<Batch<EntityHit>>, Partial<Batch<EntityHit>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<EntityHit>>("GET", $"api/http/full-text-search/search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&quick={quick.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<Batch<EntityHit>>()) : Partial<Batch<EntityHit>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all supported entities.
            /// </summary>
            public IAsyncEnumerable<EntityHit> GetAllSearchAsyncEnumerable(string query, bool quick = false, string? skip = null, int? top = 100, Func<Partial<EntityHit>, Partial<EntityHit>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllSearchAsync(query: query, quick: quick, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<EntityHit>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EntityHit>.Default())), skip, cancellationToken);
        
        }
    
        public TeamClient Teams => new TeamClient(_connection);
        
        public partial class TeamClient
        {
            private readonly Connection _connection;
            
            public TeamClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Perform full-text search in all teams.
            /// </summary>
            public async Task<Batch<FTSTeam>> GetAllTeamsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSTeam>>, Partial<Batch<FTSTeam>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<FTSTeam>>("GET", $"api/http/full-text-search/teams?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSTeam>>()) : Partial<Batch<FTSTeam>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Perform full-text search in all teams.
            /// </summary>
            public IAsyncEnumerable<FTSTeam> GetAllTeamsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSTeam>, Partial<FTSTeam>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllTeamsAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<FTSTeam>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSTeam>.Default())), skip, cancellationToken);
        
        }
    
    }
    
}
