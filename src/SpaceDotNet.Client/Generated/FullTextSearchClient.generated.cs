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
            public async Task<Batch<FTSBlogDto>> GetAllBlogsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSBlogDto>>, Partial<Batch<FTSBlogDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<FTSBlogDto>>("GET", $"api/http/full-text-search/blogs?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSBlogDto>>()) : Partial<Batch<FTSBlogDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all blogs.
            /// </summary>
            public IAsyncEnumerable<FTSBlogDto> GetAllBlogsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSBlogDto>, Partial<FTSBlogDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllBlogsAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<FTSBlogDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSBlogDto>.Default())), skip);
        
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
            public async Task<Batch<FTSDraftDto>> GetAllDraftsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSDraftDto>>, Partial<Batch<FTSDraftDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<FTSDraftDto>>("GET", $"api/http/full-text-search/drafts?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSDraftDto>>()) : Partial<Batch<FTSDraftDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all drafts.
            /// </summary>
            public IAsyncEnumerable<FTSDraftDto> GetAllDraftsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSDraftDto>, Partial<FTSDraftDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllDraftsAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<FTSDraftDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSDraftDto>.Default())), skip);
        
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
            public async Task<Batch<FTSProfileDto>> GetAllProfilesAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSProfileDto>>, Partial<Batch<FTSProfileDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<FTSProfileDto>>("GET", $"api/http/full-text-search/profiles?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSProfileDto>>()) : Partial<Batch<FTSProfileDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public IAsyncEnumerable<FTSProfileDto> GetAllProfilesAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSProfileDto>, Partial<FTSProfileDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllProfilesAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<FTSProfileDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSProfileDto>.Default())), skip);
        
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
            public async Task<Batch<ProfileHitDto>> GetAllProfilesSearchAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<ProfileHitDto>>, Partial<Batch<ProfileHitDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<ProfileHitDto>>("GET", $"api/http/full-text-search/profiles-search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<ProfileHitDto>>()) : Partial<Batch<ProfileHitDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all user profiles.
            /// </summary>
            public IAsyncEnumerable<ProfileHitDto> GetAllProfilesSearchAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<ProfileHitDto>, Partial<ProfileHitDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllProfilesSearchAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<ProfileHitDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<ProfileHitDto>.Default())), skip);
        
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
            public async Task<Batch<EntityHitDto>> GetAllSearchAsync(string query, bool quick = false, string? skip = null, int? top = 100, Func<Partial<Batch<EntityHitDto>>, Partial<Batch<EntityHitDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<EntityHitDto>>("GET", $"api/http/full-text-search/search?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&quick={quick.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<Batch<EntityHitDto>>()) : Partial<Batch<EntityHitDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all supported entities.
            /// </summary>
            public IAsyncEnumerable<EntityHitDto> GetAllSearchAsyncEnumerable(string query, bool quick = false, string? skip = null, int? top = 100, Func<Partial<EntityHitDto>, Partial<EntityHitDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllSearchAsync(query: query, quick: quick, top: top, skip: batchSkip, partial: builder => Partial<Batch<EntityHitDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EntityHitDto>.Default())), skip);
        
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
            public async Task<Batch<FTSTeamDto>> GetAllTeamsAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<FTSTeamDto>>, Partial<Batch<FTSTeamDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<FTSTeamDto>>("GET", $"api/http/full-text-search/teams?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&query={query.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<FTSTeamDto>>()) : Partial<Batch<FTSTeamDto>>.Default())}");
            
            /// <summary>
            /// Perform full-text search in all teams.
            /// </summary>
            public IAsyncEnumerable<FTSTeamDto> GetAllTeamsAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<FTSTeamDto>, Partial<FTSTeamDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllTeamsAsync(query: query, top: top, skip: batchSkip, partial: builder => Partial<Batch<FTSTeamDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<FTSTeamDto>.Default())), skip);
        
        }
    
    }
    
}
