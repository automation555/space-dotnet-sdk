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

public sealed class ApplicationSshKeyWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ApplicationSshKeyWebhookEvent";
    
    public ApplicationSshKeyWebhookEvent() { }
    
    public ApplicationSshKeyWebhookEvent(KMetaMod meta, ESApp application, Modification<string>? fingerprint = null, Modification<string>? comment = null)
    {
        Meta = meta;
        Application = application;
        Fingerprint = fingerprint;
        Comment = comment;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ApplicationSshKeyWebhookEvent), nameof(Meta));
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue();
        set => _meta.SetValue(value);
    }

    private PropertyValue<ESApp> _application = new PropertyValue<ESApp>(nameof(ApplicationSshKeyWebhookEvent), nameof(Application));
    
    [Required]
    [JsonPropertyName("application")]
    public ESApp Application
    {
        get => _application.GetValue();
        set => _application.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _fingerprint = new PropertyValue<Modification<string>?>(nameof(ApplicationSshKeyWebhookEvent), nameof(Fingerprint));
    
    [JsonPropertyName("fingerprint")]
    public Modification<string>? Fingerprint
    {
        get => _fingerprint.GetValue();
        set => _fingerprint.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _comment = new PropertyValue<Modification<string>?>(nameof(ApplicationSshKeyWebhookEvent), nameof(Comment));
    
    [JsonPropertyName("comment")]
    public Modification<string>? Comment
    {
        get => _comment.GetValue();
        set => _comment.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(path, validateHasBeenSet);
        _application.SetAccessPath(path, validateHasBeenSet);
        _fingerprint.SetAccessPath(path, validateHasBeenSet);
        _comment.SetAccessPath(path, validateHasBeenSet);
    }

}

