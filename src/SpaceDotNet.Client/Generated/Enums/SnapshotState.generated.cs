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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class SnapshotState : Enumeration
    {
        private SnapshotState(string value) : base(value) { }
        
        public static readonly SnapshotState UNKNOWN = new SnapshotState("UNKNOWN");
        public static readonly SnapshotState PENDING = new SnapshotState("PENDING");
        public static readonly SnapshotState COMPLETED = new SnapshotState("COMPLETED");
        public static readonly SnapshotState ERROR = new SnapshotState("ERROR");
    }
    
}
