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
    public class ESSamlAttributeNamesDto
    {
        [JsonPropertyName("loginAttributeName")]
        public string? LoginAttributeName { get; set; }        
        
        [JsonPropertyName("firstNameAttributeName")]
        public string? FirstNameAttributeName { get; set; }        
        
        [JsonPropertyName("lastNameAttributeName")]
        public string? LastNameAttributeName { get; set; }        
        
        [JsonPropertyName("fullNameAttributeName")]
        public string? FullNameAttributeName { get; set; }        
        
        [JsonPropertyName("emailAttributeName")]
        public string? EmailAttributeName { get; set; }        
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool EmailVerified { get; set; }        
        
    }
    
}
