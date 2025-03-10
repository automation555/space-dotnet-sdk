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

public sealed class ApplicationWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ApplicationWebhookEvent";
    
    public ApplicationWebhookEvent() { }
    
    public ApplicationWebhookEvent(KMetaMod meta, ESApp application, bool clientIdChanged, bool clientSecretChanged, bool verificationTokenChanged, bool signingKeyChanged, Modification<string>? name = null, Modification<TDMemberProfile>? owner = null, Modification<bool>? archived = null, Modification<string>? endpointURI = null)
    {
        Meta = meta;
        Application = application;
        Name = name;
        Owner = owner;
        Archived = archived;
        EndpointURI = endpointURI;
        IsClientIdChanged = clientIdChanged;
        IsClientSecretChanged = clientSecretChanged;
        IsVerificationTokenChanged = verificationTokenChanged;
        IsSigningKeyChanged = signingKeyChanged;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ApplicationWebhookEvent), nameof(Meta));
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue();
        set => _meta.SetValue(value);
    }

    private PropertyValue<ESApp> _application = new PropertyValue<ESApp>(nameof(ApplicationWebhookEvent), nameof(Application));
    
    [Required]
    [JsonPropertyName("application")]
    public ESApp Application
    {
        get => _application.GetValue();
        set => _application.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _name = new PropertyValue<Modification<string>?>(nameof(ApplicationWebhookEvent), nameof(Name));
    
    [JsonPropertyName("name")]
    public Modification<string>? Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<Modification<TDMemberProfile>?> _owner = new PropertyValue<Modification<TDMemberProfile>?>(nameof(ApplicationWebhookEvent), nameof(Owner));
    
    [JsonPropertyName("owner")]
    public Modification<TDMemberProfile>? Owner
    {
        get => _owner.GetValue();
        set => _owner.SetValue(value);
    }

    private PropertyValue<Modification<bool>?> _archived = new PropertyValue<Modification<bool>?>(nameof(ApplicationWebhookEvent), nameof(Archived));
    
    [JsonPropertyName("archived")]
    public Modification<bool>? Archived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _endpointURI = new PropertyValue<Modification<string>?>(nameof(ApplicationWebhookEvent), nameof(EndpointURI));
    
    [JsonPropertyName("endpointURI")]
    public Modification<string>? EndpointURI
    {
        get => _endpointURI.GetValue();
        set => _endpointURI.SetValue(value);
    }

    private PropertyValue<bool> _clientIdChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsClientIdChanged));
    
    [Required]
    [JsonPropertyName("clientIdChanged")]
    public bool IsClientIdChanged
    {
        get => _clientIdChanged.GetValue();
        set => _clientIdChanged.SetValue(value);
    }

    private PropertyValue<bool> _clientSecretChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsClientSecretChanged));
    
    [Required]
    [JsonPropertyName("clientSecretChanged")]
    public bool IsClientSecretChanged
    {
        get => _clientSecretChanged.GetValue();
        set => _clientSecretChanged.SetValue(value);
    }

    private PropertyValue<bool> _verificationTokenChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsVerificationTokenChanged));
    
    [Required]
    [JsonPropertyName("verificationTokenChanged")]
    public bool IsVerificationTokenChanged
    {
        get => _verificationTokenChanged.GetValue();
        set => _verificationTokenChanged.SetValue(value);
    }

    private PropertyValue<bool> _signingKeyChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsSigningKeyChanged));
    
    [Required]
    [JsonPropertyName("signingKeyChanged")]
    public bool IsSigningKeyChanged
    {
        get => _signingKeyChanged.GetValue();
        set => _signingKeyChanged.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(path, validateHasBeenSet);
        _application.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _owner.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
        _endpointURI.SetAccessPath(path, validateHasBeenSet);
        _clientIdChanged.SetAccessPath(path, validateHasBeenSet);
        _clientSecretChanged.SetAccessPath(path, validateHasBeenSet);
        _verificationTokenChanged.SetAccessPath(path, validateHasBeenSet);
        _signingKeyChanged.SetAccessPath(path, validateHasBeenSet);
    }

}

