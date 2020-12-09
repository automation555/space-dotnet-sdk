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
    public sealed class KBArticle
         : IPropagatePropertyAccessPath
    {
        public KBArticle() { }
        
        public KBArticle(string id, bool archived, string title, KBBook book, KBFolder folder, PublicationItem item, DateTime created, string alias, CPrincipal? createdBy = null, DateTime? updated = null, CPrincipal? updatedBy = null)
        {
            Id = id;
            IsArchived = archived;
            Title = title;
            Book = book;
            Folder = folder;
            Item = item;
            Created = created;
            CreatedBy = createdBy;
            Updated = updated;
            UpdatedBy = updatedBy;
            Alias = alias;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBArticle), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBArticle), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(KBArticle), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KBArticle), nameof(Book));
        
        [Required]
        [JsonPropertyName("book")]
        public KBBook Book
        {
            get => _book.GetValue();
            set => _book.SetValue(value);
        }
    
        private PropertyValue<KBFolder> _folder = new PropertyValue<KBFolder>(nameof(KBArticle), nameof(Folder));
        
        [Required]
        [JsonPropertyName("folder")]
        public KBFolder Folder
        {
            get => _folder.GetValue();
            set => _folder.SetValue(value);
        }
    
        private PropertyValue<PublicationItem> _item = new PropertyValue<PublicationItem>(nameof(KBArticle), nameof(Item));
        
        [Required]
        [JsonPropertyName("item")]
        public PublicationItem Item
        {
            get => _item.GetValue();
            set => _item.SetValue(value);
        }
    
        private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(KBArticle), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(KBArticle), nameof(CreatedBy));
        
        [JsonPropertyName("createdBy")]
        public CPrincipal? CreatedBy
        {
            get => _createdBy.GetValue();
            set => _createdBy.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _updated = new PropertyValue<DateTime?>(nameof(KBArticle), nameof(Updated));
        
        [JsonPropertyName("updated")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(KBArticle), nameof(UpdatedBy));
        
        [JsonPropertyName("updatedBy")]
        public CPrincipal? UpdatedBy
        {
            get => _updatedBy.GetValue();
            set => _updatedBy.SetValue(value);
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBArticle), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get => _alias.GetValue();
            set => _alias.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _book.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _item.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _updatedBy.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
