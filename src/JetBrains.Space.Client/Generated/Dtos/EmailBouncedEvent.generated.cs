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

public sealed class EmailBouncedEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "EmailBouncedEvent";
    
    public EmailBouncedEvent() { }
    
    public EmailBouncedEvent(string email, string reason)
    {
        Email = email;
        Reason = reason;
    }
    
    private PropertyValue<string> _email = new PropertyValue<string>(nameof(EmailBouncedEvent), nameof(Email));
    
    [Required]
    [JsonPropertyName("email")]
    public string Email
    {
        get => _email.GetValue();
        set => _email.SetValue(value);
    }

    private PropertyValue<string> _reason = new PropertyValue<string>(nameof(EmailBouncedEvent), nameof(Reason));
    
    [Required]
    [JsonPropertyName("reason")]
    public string Reason
    {
        get => _reason.GetValue();
        set => _reason.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _email.SetAccessPath(path, validateHasBeenSet);
        _reason.SetAccessPath(path, validateHasBeenSet);
    }

}

