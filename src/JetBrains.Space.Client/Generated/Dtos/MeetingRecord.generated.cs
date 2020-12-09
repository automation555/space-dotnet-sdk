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
    public sealed class MeetingRecord
         : IPropagatePropertyAccessPath
    {
        public MeetingRecord() { }
        
        public MeetingRecord(string id, bool archived, DateTime starts, DateTime finishes, bool allDay, List<TDLocation> rooms, List<Participant> participants, ATimeZone? timezone = null, ArticleRecord? article = null)
        {
            Id = id;
            IsArchived = archived;
            Starts = starts;
            Finishes = finishes;
            Timezone = timezone;
            IsAllDay = allDay;
            Rooms = rooms;
            Participants = participants;
            Article = article;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(MeetingRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(MeetingRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<DateTime> _starts = new PropertyValue<DateTime>(nameof(MeetingRecord), nameof(Starts));
        
        [Required]
        [JsonPropertyName("starts")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Starts
        {
            get => _starts.GetValue();
            set => _starts.SetValue(value);
        }
    
        private PropertyValue<DateTime> _finishes = new PropertyValue<DateTime>(nameof(MeetingRecord), nameof(Finishes));
        
        [Required]
        [JsonPropertyName("finishes")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Finishes
        {
            get => _finishes.GetValue();
            set => _finishes.SetValue(value);
        }
    
        private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(MeetingRecord), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZone? Timezone
        {
            get => _timezone.GetValue();
            set => _timezone.SetValue(value);
        }
    
        private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(MeetingRecord), nameof(IsAllDay));
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool IsAllDay
        {
            get => _allDay.GetValue();
            set => _allDay.SetValue(value);
        }
    
        private PropertyValue<List<TDLocation>> _rooms = new PropertyValue<List<TDLocation>>(nameof(MeetingRecord), nameof(Rooms));
        
        [Required]
        [JsonPropertyName("rooms")]
        public List<TDLocation> Rooms
        {
            get => _rooms.GetValue();
            set => _rooms.SetValue(value);
        }
    
        private PropertyValue<List<Participant>> _participants = new PropertyValue<List<Participant>>(nameof(MeetingRecord), nameof(Participants));
        
        [Required]
        [JsonPropertyName("participants")]
        public List<Participant> Participants
        {
            get => _participants.GetValue();
            set => _participants.SetValue(value);
        }
    
        private PropertyValue<ArticleRecord?> _article = new PropertyValue<ArticleRecord?>(nameof(MeetingRecord), nameof(Article));
        
        [JsonPropertyName("article")]
        public ArticleRecord? Article
        {
            get => _article.GetValue();
            set => _article.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _starts.SetAccessPath(path, validateHasBeenSet);
            _finishes.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
            _rooms.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _article.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
