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
    public class FingerprintDto
    {
        [Required]
        [JsonPropertyName("md5")]
        public string Md5 { get; set; }        
        
        [Required]
        [JsonPropertyName("sha1")]
        public string Sha1 { get; set; }        
        
        [Required]
        [JsonPropertyName("sha256")]
        public string Sha256 { get; set; }        
        
        [Required]
        [JsonPropertyName("sha384")]
        public string Sha384 { get; set; }        
        
        [Required]
        [JsonPropertyName("sha512")]
        public string Sha512 { get; set; }        
        
    }
    
}
