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

namespace SpaceDotNet.Client.UnfurlDetailsCodeSnippetExtensions
{
    public static class UnfurlDetailsCodeSnippetDtoPartialExtensions
    {
        public static Partial<UnfurlDetailsCodeSnippetDto> WithAnchor(this Partial<UnfurlDetailsCodeSnippetDto> it)
            => it.AddFieldName("anchor");
        
        public static Partial<UnfurlDetailsCodeSnippetDto> WithAnchor(this Partial<UnfurlDetailsCodeSnippetDto> it, Func<Partial<CodeSnippetAnchorDto>, Partial<CodeSnippetAnchorDto>> partialBuilder)
            => it.AddFieldName("anchor", partialBuilder(new Partial<CodeSnippetAnchorDto>()));
        
        public static Partial<UnfurlDetailsCodeSnippetDto> WithLines(this Partial<UnfurlDetailsCodeSnippetDto> it)
            => it.AddFieldName("lines");
        
        public static Partial<UnfurlDetailsCodeSnippetDto> WithLines(this Partial<UnfurlDetailsCodeSnippetDto> it, Func<Partial<CodeLineDto>, Partial<CodeLineDto>> partialBuilder)
            => it.AddFieldName("lines", partialBuilder(new Partial<CodeLineDto>()));
        
    }
    
}
