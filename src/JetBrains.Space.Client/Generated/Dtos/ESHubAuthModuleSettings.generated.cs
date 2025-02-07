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

public sealed class ESHubAuthModuleSettings
     : ESOAuth2AuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ES_HubAuthModuleSettings";
    
    public ESHubAuthModuleSettings() { }
    
    public ESHubAuthModuleSettings(string hubUrl, string clientId, string clientSecret, bool? registerNewUsers = null, string? orgAuthProviderName = null, List<string>? groups = null)
    {
        HubUrl = hubUrl;
        ClientId = clientId;
        ClientSecret = clientSecret;
        IsRegisterNewUsers = registerNewUsers;
        OrgAuthProviderName = orgAuthProviderName;
        Groups = groups;
    }
    
    private PropertyValue<string> _hubUrl = new PropertyValue<string>(nameof(ESHubAuthModuleSettings), nameof(HubUrl));
    
    [Required]
    [JsonPropertyName("hubUrl")]
    public string HubUrl
    {
        get => _hubUrl.GetValue();
        set => _hubUrl.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESHubAuthModuleSettings), nameof(ClientId));
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue();
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string> _clientSecret = new PropertyValue<string>(nameof(ESHubAuthModuleSettings), nameof(ClientSecret));
    
    [Required]
    [JsonPropertyName("clientSecret")]
    public string ClientSecret
    {
        get => _clientSecret.GetValue();
        set => _clientSecret.SetValue(value);
    }

    private PropertyValue<bool?> _registerNewUsers = new PropertyValue<bool?>(nameof(ESHubAuthModuleSettings), nameof(IsRegisterNewUsers));
    
    [JsonPropertyName("registerNewUsers")]
    public bool? IsRegisterNewUsers
    {
        get => _registerNewUsers.GetValue();
        set => _registerNewUsers.SetValue(value);
    }

    private PropertyValue<string?> _orgAuthProviderName = new PropertyValue<string?>(nameof(ESHubAuthModuleSettings), nameof(OrgAuthProviderName));
    
    [JsonPropertyName("orgAuthProviderName")]
    public string? OrgAuthProviderName
    {
        get => _orgAuthProviderName.GetValue();
        set => _orgAuthProviderName.SetValue(value);
    }

    private PropertyValue<List<string>?> _groups = new PropertyValue<List<string>?>(nameof(ESHubAuthModuleSettings), nameof(Groups));
    
    [JsonPropertyName("groups")]
    public List<string>? Groups
    {
        get => _groups.GetValue();
        set => _groups.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _hubUrl.SetAccessPath(path, validateHasBeenSet);
        _clientId.SetAccessPath(path, validateHasBeenSet);
        _clientSecret.SetAccessPath(path, validateHasBeenSet);
        _registerNewUsers.SetAccessPath(path, validateHasBeenSet);
        _orgAuthProviderName.SetAccessPath(path, validateHasBeenSet);
        _groups.SetAccessPath(path, validateHasBeenSet);
    }

}

