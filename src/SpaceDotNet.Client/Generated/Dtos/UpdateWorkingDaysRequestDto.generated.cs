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
    public class UpdateWorkingDaysRequestDto
    {
        [JsonPropertyName("profile")]
        public string? Profile { get; set; }        
        
        [JsonPropertyName("dateStart")]
        public SpaceDate? DateStart { get; set; }        
        
        [JsonPropertyName("dateEnd")]
        public SpaceDate? DateEnd { get; set; }        
        
        [Required]
        [JsonPropertyName("workingDaysSpec")]
        public WorkingDaysSpecDto WorkingDaysSpec { get; set; }        
        
    }
    
}
