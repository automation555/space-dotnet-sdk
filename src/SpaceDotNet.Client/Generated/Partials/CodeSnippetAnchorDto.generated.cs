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

namespace SpaceDotNet.Client.CodeSnippetAnchorExtensions
{
    public static class CodeSnippetAnchorDtoPartialExtensions
    {
        public static Partial<CodeSnippetAnchorDto> WithProjectKey(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<CodeSnippetAnchorDto> WithProjectKey(this Partial<CodeSnippetAnchorDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<CodeSnippetAnchorDto> WithRepository(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<CodeSnippetAnchorDto> WithRevision(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("revision");
        
        public static Partial<CodeSnippetAnchorDto> WithFilename(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("filename");
        
        public static Partial<CodeSnippetAnchorDto> WithLineIndex(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("lineIndex");
        
        public static Partial<CodeSnippetAnchorDto> WithLineStart(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("lineStart");
        
        public static Partial<CodeSnippetAnchorDto> WithLineEnd(this Partial<CodeSnippetAnchorDto> it)
            => it.AddFieldName("lineEnd");
        
    }
    
}
