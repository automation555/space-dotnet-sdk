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
    public class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest() { }
        
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest(string text, bool pending = false, DiffContext? diffContext = null, string? filename = null, int? line = null, int? oldLine = null)
        {
            Text = text;
            DiffContext = diffContext;
            Filename = filename;
            Line = line;
            OldLine = oldLine;
            IsPending = pending;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<DiffContext?> _diffContext = new PropertyValue<DiffContext?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(DiffContext));
        
        [JsonPropertyName("diffContext")]
        public DiffContext? DiffContext
        {
            get => _diffContext.GetValue();
            set => _diffContext.SetValue(value);
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get => _filename.GetValue();
            set => _filename.SetValue(value);
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get => _line.GetValue();
            set => _line.SetValue(value);
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get => _oldLine.GetValue();
            set => _oldLine.SetValue(value);
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(IsPending));
        
        [JsonPropertyName("pending")]
        public bool IsPending
        {
            get => _pending.GetValue();
            set => _pending.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _diffContext.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _line.SetAccessPath(path, validateHasBeenSet);
            _oldLine.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
