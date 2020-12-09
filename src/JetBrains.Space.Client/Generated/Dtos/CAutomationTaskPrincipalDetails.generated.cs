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
    public sealed class CAutomationTaskPrincipalDetails
         : CPrincipalDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CAutomationTaskPrincipalDetails";
        
        public CAutomationTaskPrincipalDetails() { }
        
        public CAutomationTaskPrincipalDetails(PRProject project, string name, string id)
        {
            Project = project;
            Name = name;
            Id = id;
        }
        
        private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(CAutomationTaskPrincipalDetails), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public PRProject Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CAutomationTaskPrincipalDetails), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CAutomationTaskPrincipalDetails), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
