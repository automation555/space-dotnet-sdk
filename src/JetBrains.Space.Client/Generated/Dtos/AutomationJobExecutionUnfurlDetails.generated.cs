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
    public sealed class AutomationJobExecutionUnfurlDetails
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "AutomationJobExecutionUnfurlDetails";
        
        public AutomationJobExecutionUnfurlDetails() { }
        
        public AutomationJobExecutionUnfurlDetails(string jobExecutionId, PRProject projectRef, string repoName)
        {
            JobExecutionId = jobExecutionId;
            ProjectRef = projectRef;
            RepoName = repoName;
        }
        
        private PropertyValue<string> _jobExecutionId = new PropertyValue<string>(nameof(AutomationJobExecutionUnfurlDetails), nameof(JobExecutionId));
        
        [Required]
        [JsonPropertyName("jobExecutionId")]
        public string JobExecutionId
        {
            get => _jobExecutionId.GetValue();
            set => _jobExecutionId.SetValue(value);
        }
    
        private PropertyValue<PRProject> _projectRef = new PropertyValue<PRProject>(nameof(AutomationJobExecutionUnfurlDetails), nameof(ProjectRef));
        
        [Required]
        [JsonPropertyName("projectRef")]
        public PRProject ProjectRef
        {
            get => _projectRef.GetValue();
            set => _projectRef.SetValue(value);
        }
    
        private PropertyValue<string> _repoName = new PropertyValue<string>(nameof(AutomationJobExecutionUnfurlDetails), nameof(RepoName));
        
        [Required]
        [JsonPropertyName("repoName")]
        public string RepoName
        {
            get => _repoName.GetValue();
            set => _repoName.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _jobExecutionId.SetAccessPath(path, validateHasBeenSet);
            _projectRef.SetAccessPath(path, validateHasBeenSet);
            _repoName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
