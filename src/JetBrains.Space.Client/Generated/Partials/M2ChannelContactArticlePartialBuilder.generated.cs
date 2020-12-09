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

namespace JetBrains.Space.Client.M2ChannelContactArticlePartialBuilder
{
    public static class M2ChannelContactArticlePartialExtensions
    {
        public static Partial<M2ChannelContactArticle> WithArticle(this Partial<M2ChannelContactArticle> it)
            => it.AddFieldName("article");
        
        public static Partial<M2ChannelContactArticle> WithArticle(this Partial<M2ChannelContactArticle> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
        public static Partial<M2ChannelContactArticle> WithNotificationDefaults(this Partial<M2ChannelContactArticle> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContactArticle> WithNotificationDefaults(this Partial<M2ChannelContactArticle> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
    }
    
}
