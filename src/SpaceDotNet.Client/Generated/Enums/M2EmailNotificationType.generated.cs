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
    public sealed class M2EmailNotificationType : Enumeration
    {
        private M2EmailNotificationType(string value) : base(value) { }
        
        public static readonly M2EmailNotificationType INSTANT = new M2EmailNotificationType("INSTANT");
        public static readonly M2EmailNotificationType DELAYED = new M2EmailNotificationType("DELAYED");
        public static readonly M2EmailNotificationType NONE = new M2EmailNotificationType("NONE");
    }
    
}
