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
    public sealed class MessageButton
         : MessageControlElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageButton";
        
        public MessageButton() { }
        
        public MessageButton(string text, MessageButtonStyle style, MessageAction action, bool? disabled = null)
        {
            Text = text;
            Style = style;
            Action = action;
            IsDisabled = disabled;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageButton), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<MessageButtonStyle> _style = new PropertyValue<MessageButtonStyle>(nameof(MessageButton), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public MessageButtonStyle Style
        {
            get => _style.GetValue();
            set => _style.SetValue(value);
        }
    
        private PropertyValue<MessageAction> _action = new PropertyValue<MessageAction>(nameof(MessageButton), nameof(Action));
        
        [Required]
        [JsonPropertyName("action")]
        public MessageAction Action
        {
            get => _action.GetValue();
            set => _action.SetValue(value);
        }
    
        private PropertyValue<bool?> _disabled = new PropertyValue<bool?>(nameof(MessageButton), nameof(IsDisabled));
        
        [JsonPropertyName("disabled")]
        public bool? IsDisabled
        {
            get => _disabled.GetValue();
            set => _disabled.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _style.SetAccessPath(path, validateHasBeenSet);
            _action.SetAccessPath(path, validateHasBeenSet);
            _disabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
