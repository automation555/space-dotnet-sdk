// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.PublishSitePartialBuilder
{
    public static class PublishSitePartialExtensions
    {
        public static Partial<PublishSite> WithSiteUrl(this Partial<PublishSite> it)
            => it.AddFieldName("siteUrl");
        
        public static Partial<PublishSite> WithFileStats(this Partial<PublishSite> it)
            => it.AddFieldName("fileStats");
        
        public static Partial<PublishSite> WithFileStats(this Partial<PublishSite> it, Func<Partial<SyncFileStats>, Partial<SyncFileStats>> partialBuilder)
            => it.AddFieldName("fileStats", partialBuilder(new Partial<SyncFileStats>(it)));
        
    }
    
}
