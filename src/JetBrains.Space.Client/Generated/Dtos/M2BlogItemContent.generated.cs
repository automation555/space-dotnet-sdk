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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class M2BlogItemContent
     : M2BlogItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2BlogItemContent";
    
    public M2BlogItemContent() { }
    
    public M2BlogItemContent(ArticleRecord article, ArticleContentRecord articleContent, ArticleDetailsRecord articleDetails, ArticleChannelRecord articleChannel)
    {
        Article = article;
        ArticleContent = articleContent;
        ArticleDetails = articleDetails;
        ArticleChannel = articleChannel;
    }
    
    private PropertyValue<ArticleRecord> _article = new PropertyValue<ArticleRecord>(nameof(M2BlogItemContent), nameof(Article));
    
    [Required]
    [JsonPropertyName("article")]
    public ArticleRecord Article
    {
        get => _article.GetValue();
        set => _article.SetValue(value);
    }

    private PropertyValue<ArticleContentRecord> _articleContent = new PropertyValue<ArticleContentRecord>(nameof(M2BlogItemContent), nameof(ArticleContent));
    
    [Required]
    [JsonPropertyName("articleContent")]
    public ArticleContentRecord ArticleContent
    {
        get => _articleContent.GetValue();
        set => _articleContent.SetValue(value);
    }

    private PropertyValue<ArticleDetailsRecord> _articleDetails = new PropertyValue<ArticleDetailsRecord>(nameof(M2BlogItemContent), nameof(ArticleDetails));
    
    [Required]
    [JsonPropertyName("articleDetails")]
    public ArticleDetailsRecord ArticleDetails
    {
        get => _articleDetails.GetValue();
        set => _articleDetails.SetValue(value);
    }

    private PropertyValue<ArticleChannelRecord> _articleChannel = new PropertyValue<ArticleChannelRecord>(nameof(M2BlogItemContent), nameof(ArticleChannel));
    
    [Required]
    [JsonPropertyName("articleChannel")]
    public ArticleChannelRecord ArticleChannel
    {
        get => _articleChannel.GetValue();
        set => _articleChannel.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _article.SetAccessPath(path, validateHasBeenSet);
        _articleContent.SetAccessPath(path, validateHasBeenSet);
        _articleDetails.SetAccessPath(path, validateHasBeenSet);
        _articleChannel.SetAccessPath(path, validateHasBeenSet);
    }

}

