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
    public sealed class MessageRecipientMember
         : MessageRecipient, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MessageRecipient.Member";
        
        public MessageRecipientMember() { }
        
        public MessageRecipientMember(ProfileIdentifier member)
        {
            Member = member;
        }
        
        private PropertyValue<ProfileIdentifier> _member = new PropertyValue<ProfileIdentifier>(nameof(MessageRecipientMember), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public ProfileIdentifier Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
