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

namespace JetBrains.Space.Client.WebhookRequestPayloadPartialBuilder;

public static class WebhookRequestPayloadPartialExtensions
{
    public static Partial<WebhookRequestPayload> WithVerificationToken(this Partial<WebhookRequestPayload> it)
        => it.AddFieldName("verificationToken");
    
    public static Partial<WebhookRequestPayload> WithClientId(this Partial<WebhookRequestPayload> it)
        => it.AddFieldName("clientId");
    
    public static Partial<WebhookRequestPayload> WithWebhookId(this Partial<WebhookRequestPayload> it)
        => it.AddFieldName("webhookId");
    
    public static Partial<WebhookRequestPayload> WithPayload(this Partial<WebhookRequestPayload> it)
        => it.AddFieldName("payload");
    
    public static Partial<WebhookRequestPayload> WithPayload(this Partial<WebhookRequestPayload> it, Func<Partial<WebhookEvent>, Partial<WebhookEvent>> partialBuilder)
        => it.AddFieldName("payload", partialBuilder(new Partial<WebhookEvent>(it)));
    
}

