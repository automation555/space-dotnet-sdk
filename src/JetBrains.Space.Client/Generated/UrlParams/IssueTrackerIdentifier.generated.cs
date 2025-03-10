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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class IssueTrackerIdentifier : IUrlParameter
{
    public static IssueTrackerIdentifier DefaultProjectTracker(ProjectIdentifier project)
        => new IssueTrackerIdentifierDefaultProjectTracker(project);
    
    public static IssueTrackerIdentifier Id(string id)
        => new IssueTrackerIdentifierId(id);
    
    private class IssueTrackerIdentifierDefaultProjectTracker : IssueTrackerIdentifier
    {
        private readonly ProjectIdentifier _project;
        
        public IssueTrackerIdentifierDefaultProjectTracker(ProjectIdentifier project)
        {
            _project = project;
        }
        
        public override string ToString()
            => $"project:{_project}";
    }
    
    private class IssueTrackerIdentifierId : IssueTrackerIdentifier
    {
        private readonly string _id;
        
        public IssueTrackerIdentifierId(string id)
        {
            _id = id;
        }
        
        public override string ToString()
            => $"id:{_id}";
    }
    
}

