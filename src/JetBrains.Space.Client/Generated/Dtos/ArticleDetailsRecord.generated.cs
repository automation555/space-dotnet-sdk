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

namespace JetBrains.Space.Client
{
    public sealed class ArticleDetailsRecord
         : IPropagatePropertyAccessPath
    {
        public ArticleDetailsRecord() { }
        
        public ArticleDetailsRecord(string id, bool archived, MeetingRecord? @event = null, TDTeam? team = null, TDLocation? location = null, List<TDTeam>? teams = null, List<TDLocation>? locations = null, ExternalEntityInfoRecord? externalEntityInfo = null)
        {
            Id = id;
            IsArchived = archived;
            Event = @event;
            Team = team;
            Location = location;
            Teams = teams;
            Locations = locations;
            ExternalEntityInfo = externalEntityInfo;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleDetailsRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleDetailsRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<MeetingRecord?> _event = new PropertyValue<MeetingRecord?>(nameof(ArticleDetailsRecord), nameof(Event));
        
        [JsonPropertyName("event")]
        public MeetingRecord? Event
        {
            get => _event.GetValue();
            set => _event.SetValue(value);
        }
    
        private PropertyValue<TDTeam?> _team = new PropertyValue<TDTeam?>(nameof(ArticleDetailsRecord), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeam? Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<TDLocation?> _location = new PropertyValue<TDLocation?>(nameof(ArticleDetailsRecord), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocation? Location
        {
            get => _location.GetValue();
            set => _location.SetValue(value);
        }
    
        private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(ArticleDetailsRecord), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeam>? Teams
        {
            get => _teams.GetValue();
            set => _teams.SetValue(value);
        }
    
        private PropertyValue<List<TDLocation>?> _locations = new PropertyValue<List<TDLocation>?>(nameof(ArticleDetailsRecord), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<TDLocation>? Locations
        {
            get => _locations.GetValue();
            set => _locations.SetValue(value);
        }
    
        private PropertyValue<ExternalEntityInfoRecord?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecord?>(nameof(ArticleDetailsRecord), nameof(ExternalEntityInfo));
        
        [JsonPropertyName("externalEntityInfo")]
        public ExternalEntityInfoRecord? ExternalEntityInfo
        {
            get => _externalEntityInfo.GetValue();
            set => _externalEntityInfo.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _event.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _externalEntityInfo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
