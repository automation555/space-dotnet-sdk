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

public sealed class ProjectEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ProjectEvent";
    
    public ProjectEvent() { }
    
    public ProjectEvent(KMetaMod meta, PRProject project)
    {
        Meta = meta;
        Project = project;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ProjectEvent), nameof(Meta));
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue();
        set => _meta.SetValue(value);
    }

    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(ProjectEvent), nameof(Project));
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(path, validateHasBeenSet);
        _project.SetAccessPath(path, validateHasBeenSet);
    }

}

