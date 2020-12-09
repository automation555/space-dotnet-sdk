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
    public class DocsDraftsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public DocsDraftsForIdPatchRequest() { }
        
        public DocsDraftsForIdPatchRequest(string? title = null, string? text = null, long? textVersion = null, DraftDocumentType? type = null, string? folder = null, PublicationDetails? publicationDetails2 = null)
        {
            Title = title;
            Text = text;
            TextVersion = textVersion;
            Type = type;
            Folder = folder;
            PublicationDetails2 = publicationDetails2;
        }
        
        private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(DocsDraftsForIdPatchRequest), nameof(Title));
        
        [JsonPropertyName("title")]
        public string? Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<string?> _text = new PropertyValue<string?>(nameof(DocsDraftsForIdPatchRequest), nameof(Text));
        
        [JsonPropertyName("text")]
        public string? Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<long?> _textVersion = new PropertyValue<long?>(nameof(DocsDraftsForIdPatchRequest), nameof(TextVersion));
        
        [JsonPropertyName("textVersion")]
        public long? TextVersion
        {
            get => _textVersion.GetValue();
            set => _textVersion.SetValue(value);
        }
    
        private PropertyValue<DraftDocumentType?> _type = new PropertyValue<DraftDocumentType?>(nameof(DocsDraftsForIdPatchRequest), nameof(Type));
        
        [JsonPropertyName("type")]
        public DraftDocumentType? Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string?> _folder = new PropertyValue<string?>(nameof(DocsDraftsForIdPatchRequest), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public string? Folder
        {
            get => _folder.GetValue();
            set => _folder.SetValue(value);
        }
    
        private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DocsDraftsForIdPatchRequest), nameof(PublicationDetails2));
        
        [JsonPropertyName("publicationDetails2")]
        public PublicationDetails? PublicationDetails2
        {
            get => _publicationDetails2.GetValue();
            set => _publicationDetails2.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _textVersion.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _publicationDetails2.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
