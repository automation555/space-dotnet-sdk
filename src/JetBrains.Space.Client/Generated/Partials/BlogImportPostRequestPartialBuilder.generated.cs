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

namespace JetBrains.Space.Client.BlogImportPostRequestPartialBuilder
{
    public static class BlogImportPostRequestPartialExtensions
    {
        public static Partial<BlogImportPostRequest> WithMetadata(this Partial<BlogImportPostRequest> it)
            => it.AddFieldName("metadata");
        
        public static Partial<BlogImportPostRequest> WithMetadata(this Partial<BlogImportPostRequest> it, Func<Partial<ImportMetadata>, Partial<ImportMetadata>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<ImportMetadata>(it)));
        
        public static Partial<BlogImportPostRequest> WithArticles(this Partial<BlogImportPostRequest> it)
            => it.AddFieldName("articles");
        
        public static Partial<BlogImportPostRequest> WithArticles(this Partial<BlogImportPostRequest> it, Func<Partial<ExternalArticle>, Partial<ExternalArticle>> partialBuilder)
            => it.AddFieldName("articles", partialBuilder(new Partial<ExternalArticle>(it)));
        
    }
    
}
