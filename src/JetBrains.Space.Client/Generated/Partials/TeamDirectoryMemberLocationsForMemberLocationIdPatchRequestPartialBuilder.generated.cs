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

namespace JetBrains.Space.Client.TeamDirectoryMemberLocationsForMemberLocationIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryMemberLocationsForMemberLocationIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithLocation(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("location");
        
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithSince(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("since");
        
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithTill(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("till");
        
    }
    
}
