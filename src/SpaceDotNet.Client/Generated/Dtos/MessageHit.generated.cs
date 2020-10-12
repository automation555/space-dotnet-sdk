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
    public sealed class MessageHit
         : EntityHit, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MessageHit";
        
        public MessageHit() { }
        
        public MessageHit(string id, string parentItemId, double score, M2ChannelRecord channel, M2ChatReader readerRef, ChannelItemRecord @ref, string message, bool threadStarter, string? thread = null)
        {
            Id = id;
            ParentItemId = parentItemId;
            Score = score;
            Channel = channel;
            ReaderRef = readerRef;
            Ref = @ref;
            Message = message;
            IsThreadStarter = threadStarter;
            Thread = thread;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(MessageHit), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _parentItemId = new PropertyValue<string>(nameof(MessageHit), nameof(ParentItemId));
        
        [Required]
        [JsonPropertyName("parentItemId")]
        public string ParentItemId
        {
            get { return _parentItemId.GetValue(); }
            set { _parentItemId.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(MessageHit), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(MessageHit), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<M2ChatReader> _readerRef = new PropertyValue<M2ChatReader>(nameof(MessageHit), nameof(ReaderRef));
        
        [Required]
        [JsonPropertyName("readerRef")]
        public M2ChatReader ReaderRef
        {
            get { return _readerRef.GetValue(); }
            set { _readerRef.SetValue(value); }
        }
    
        private PropertyValue<ChannelItemRecord> _ref = new PropertyValue<ChannelItemRecord>(nameof(MessageHit), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public ChannelItemRecord Ref
        {
            get { return _ref.GetValue(); }
            set { _ref.SetValue(value); }
        }
    
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(MessageHit), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        private PropertyValue<bool> _threadStarter = new PropertyValue<bool>(nameof(MessageHit), nameof(IsThreadStarter));
        
        [Required]
        [JsonPropertyName("threadStarter")]
        public bool IsThreadStarter
        {
            get { return _threadStarter.GetValue(); }
            set { _threadStarter.SetValue(value); }
        }
    
        private PropertyValue<string?> _thread = new PropertyValue<string?>(nameof(MessageHit), nameof(Thread));
        
        [JsonPropertyName("thread")]
        public string? Thread
        {
            get { return _thread.GetValue(); }
            set { _thread.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _parentItemId.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _readerRef.SetAccessPath(path, validateHasBeenSet);
            _ref.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
            _threadStarter.SetAccessPath(path, validateHasBeenSet);
            _thread.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
