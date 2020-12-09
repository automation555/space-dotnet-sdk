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
    public class AuthModulesForIdLoginsForIdentifierChangePostRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesForIdLoginsForIdentifierChangePostRequest() { }
        
        public AuthModulesForIdLoginsForIdentifierChangePostRequest(string oldPassword, string newPassword)
        {
            OldPassword = oldPassword;
            NewPassword = newPassword;
        }
        
        private PropertyValue<string> _oldPassword = new PropertyValue<string>(nameof(AuthModulesForIdLoginsForIdentifierChangePostRequest), nameof(OldPassword));
        
        [Required]
        [JsonPropertyName("oldPassword")]
        public string OldPassword
        {
            get => _oldPassword.GetValue();
            set => _oldPassword.SetValue(value);
        }
    
        private PropertyValue<string> _newPassword = new PropertyValue<string>(nameof(AuthModulesForIdLoginsForIdentifierChangePostRequest), nameof(NewPassword));
        
        [Required]
        [JsonPropertyName("newPassword")]
        public string NewPassword
        {
            get => _newPassword.GetValue();
            set => _newPassword.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _oldPassword.SetAccessPath(path, validateHasBeenSet);
            _newPassword.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
