// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class TrustedCertificateDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias { get; set; }        
        
        [Required]
        [JsonPropertyName("data")]
        public string Data { get; set; }        
        
        [Required]
        [JsonPropertyName("info")]
        public CertificateInfoDto Info { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
    }
    
}
