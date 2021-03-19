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
    public sealed class TwoFactorAuthenticationSecret
         : IPropagatePropertyAccessPath
    {
        public TwoFactorAuthenticationSecret() { }
        
        public TwoFactorAuthenticationSecret(string secretKey, QRCode qrCode, List<int> scratchCodes)
        {
            SecretKey = secretKey;
            QrCode = qrCode;
            ScratchCodes = scratchCodes;
        }
        
        private PropertyValue<string> _secretKey = new PropertyValue<string>(nameof(TwoFactorAuthenticationSecret), nameof(SecretKey));
        
        [Required]
        [JsonPropertyName("secretKey")]
        public string SecretKey
        {
            get => _secretKey.GetValue();
            set => _secretKey.SetValue(value);
        }
    
        private PropertyValue<QRCode> _qrCode = new PropertyValue<QRCode>(nameof(TwoFactorAuthenticationSecret), nameof(QrCode));
        
        [Required]
        [JsonPropertyName("qrCode")]
        public QRCode QrCode
        {
            get => _qrCode.GetValue();
            set => _qrCode.SetValue(value);
        }
    
        private PropertyValue<List<int>> _scratchCodes = new PropertyValue<List<int>>(nameof(TwoFactorAuthenticationSecret), nameof(ScratchCodes), new List<int>());
        
        [Required]
        [JsonPropertyName("scratchCodes")]
        public List<int> ScratchCodes
        {
            get => _scratchCodes.GetValue();
            set => _scratchCodes.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _secretKey.SetAccessPath(path, validateHasBeenSet);
            _qrCode.SetAccessPath(path, validateHasBeenSet);
            _scratchCodes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
