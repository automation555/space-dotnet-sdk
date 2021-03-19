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
    public sealed class TDMemberWithTeam
         : IPropagatePropertyAccessPath
    {
        public TDMemberWithTeam() { }
        
        public TDMemberWithTeam(TDMemberProfile profile, List<TDTeam> teams)
        {
            Profile = profile;
            Teams = teams;
        }
        
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(TDMemberWithTeam), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<List<TDTeam>> _teams = new PropertyValue<List<TDTeam>>(nameof(TDMemberWithTeam), nameof(Teams), new List<TDTeam>());
        
        [Required]
        [JsonPropertyName("teams")]
        public List<TDTeam> Teams
        {
            get => _teams.GetValue();
            set => _teams.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
