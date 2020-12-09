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

namespace JetBrains.Space.Client.ArticleDetailsRecordPartialBuilder
{
    public static class ArticleDetailsRecordPartialExtensions
    {
        public static Partial<ArticleDetailsRecord> WithId(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ArticleDetailsRecord> WithIsArchived(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<ArticleDetailsRecord> WithEvent(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("event");
        
        public static Partial<ArticleDetailsRecord> WithEvent(this Partial<ArticleDetailsRecord> it, Func<Partial<MeetingRecord>, Partial<MeetingRecord>> partialBuilder)
            => it.AddFieldName("event", partialBuilder(new Partial<MeetingRecord>(it)));
        
        public static Partial<ArticleDetailsRecord> WithTeam(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("team");
        
        public static Partial<ArticleDetailsRecord> WithTeam(this Partial<ArticleDetailsRecord> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<ArticleDetailsRecord> WithLocation(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("location");
        
        public static Partial<ArticleDetailsRecord> WithLocation(this Partial<ArticleDetailsRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<ArticleDetailsRecord> WithTeams(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("teams");
        
        public static Partial<ArticleDetailsRecord> WithTeams(this Partial<ArticleDetailsRecord> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<ArticleDetailsRecord> WithLocations(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("locations");
        
        public static Partial<ArticleDetailsRecord> WithLocations(this Partial<ArticleDetailsRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<ArticleDetailsRecord> WithExternalEntityInfo(this Partial<ArticleDetailsRecord> it)
            => it.AddFieldName("externalEntityInfo");
        
        public static Partial<ArticleDetailsRecord> WithExternalEntityInfo(this Partial<ArticleDetailsRecord> it, Func<Partial<ExternalEntityInfoRecord>, Partial<ExternalEntityInfoRecord>> partialBuilder)
            => it.AddFieldName("externalEntityInfo", partialBuilder(new Partial<ExternalEntityInfoRecord>(it)));
        
    }
    
}
