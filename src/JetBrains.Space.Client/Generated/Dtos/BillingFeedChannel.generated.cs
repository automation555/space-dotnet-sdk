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
    public sealed class BillingFeedChannel
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "BillingFeedChannel";
        
        public BillingFeedChannel() { }
        
        public BillingFeedChannel(ChannelSpecificDefaults? notificationDefaults = null)
        {
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<ChannelSpecificDefaults?> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults?>(nameof(BillingFeedChannel), nameof(NotificationDefaults));
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults? NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
