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
    public sealed class TodoItemRecord
         : IPropagatePropertyAccessPath
    {
        public TodoItemRecord() { }
        
        public TodoItemRecord(string id, bool archived, DateTime created, DateTime updated, TodoItemContent content, string _status, DateTime? dueDate = null)
        {
            Id = id;
            IsArchived = archived;
            Created = created;
            Updated = updated;
            Content = content;
            Status = _status;
            DueDate = dueDate;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TodoItemRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TodoItemRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(TodoItemRecord), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<DateTime> _updated = new PropertyValue<DateTime>(nameof(TodoItemRecord), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<TodoItemContent> _content = new PropertyValue<TodoItemContent>(nameof(TodoItemRecord), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public TodoItemContent Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<string> __status = new PropertyValue<string>(nameof(TodoItemRecord), nameof(Status));
        
        [Required]
        [JsonPropertyName("_status")]
        public string Status
        {
            get => __status.GetValue();
            set => __status.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _dueDate = new PropertyValue<DateTime?>(nameof(TodoItemRecord), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? DueDate
        {
            get => _dueDate.GetValue();
            set => _dueDate.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            __status.SetAccessPath(path, validateHasBeenSet);
            _dueDate.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
