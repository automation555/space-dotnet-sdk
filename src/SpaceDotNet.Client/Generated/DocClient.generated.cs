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

namespace SpaceDotNet.Client
{
    public partial class DocClient
    {
        private readonly Connection _connection;
        
        public DocClient(Connection connection)
        {
            _connection = connection;
        }
        
        public DraftClient Drafts => new DraftClient(_connection);
        
        public partial class DraftClient
        {
            private readonly Connection _connection;
            
            public DraftClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<DRDraftDto> CreateDraft(CreateDraftRequestDto data, Func<Partial<DRDraftDto>, Partial<DRDraftDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateDraftRequestDto, DRDraftDto>("POST", $"api/http/docs/drafts?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DRDraftDto>()) : new EagerPartial<DRDraftDto>()), data);            
            
            public async Task<DRDraftDto> GetDraft(string id, Func<Partial<DRDraftDto>, Partial<DRDraftDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<DRDraftDto>("GET", $"api/http/docs/drafts/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DRDraftDto>()) : new EagerPartial<DRDraftDto>()));            
            
            public async Task<DRDraftDto> UpdateDraft(string id, UpdateDraftRequestDto data, Func<Partial<DRDraftDto>, Partial<DRDraftDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<UpdateDraftRequestDto, DRDraftDto>("PATCH", $"api/http/docs/drafts/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DRDraftDto>()) : new EagerPartial<DRDraftDto>()), data);            
            
            public async Task DeleteDraft(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}");            
            
            public EditorClient Editors => new EditorClient(_connection);
            
            public partial class EditorClient
            {
                private readonly Connection _connection;
                
                public EditorClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public ProfileClient Profiles => new ProfileClient(_connection);
                
                public partial class ProfileClient
                {
                    private readonly Connection _connection;
                    
                    public ProfileClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task CreateProfile(string id, CreateProfileRequestDto data)
                        => await _connection.RequestResourceAsync<CreateProfileRequestDto>("POST", $"api/http/docs/drafts/{id}/editors/profiles", data);                    
                    
                    public async Task<List<TDMemberProfileDto>> GetAllProfiles(string id, Func<Partial<List<TDMemberProfileDto>>, Partial<List<TDMemberProfileDto>>> partialBuilder = null)
                        => await _connection.RequestResourceAsync<List<TDMemberProfileDto>>("GET", $"api/http/docs/drafts/{id}/editors/profiles?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<TDMemberProfileDto>>()) : new EagerPartial<List<TDMemberProfileDto>>()));                    
                    
                    public async Task DeleteProfile(string id, string editorId)
                        => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}/editors/profiles/{editorId}");                    
                    
                }
                
                public TeamClient Teams => new TeamClient(_connection);
                
                public partial class TeamClient
                {
                    private readonly Connection _connection;
                    
                    public TeamClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task CreateTeam(string id, CreateTeamRequestDto data)
                        => await _connection.RequestResourceAsync<CreateTeamRequestDto>("POST", $"api/http/docs/drafts/{id}/editors/teams", data);                    
                    
                    public async Task<List<TDTeamDto>> GetAllTeams(string id, Func<Partial<List<TDTeamDto>>, Partial<List<TDTeamDto>>> partialBuilder = null)
                        => await _connection.RequestResourceAsync<List<TDTeamDto>>("GET", $"api/http/docs/drafts/{id}/editors/teams?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<TDTeamDto>>()) : new EagerPartial<List<TDTeamDto>>()));                    
                    
                    public async Task DeleteTeam(string id, string teamId)
                        => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}/editors/teams/{teamId}");                    
                    
                }
                
            }
            
        }
        
    }
    
}
