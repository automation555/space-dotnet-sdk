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

[JsonConverter(typeof(EnumStringConverter))]
public enum SyntaxMarkupType
{
    [EnumMember(Value = "KEYWORD")]
    KEYWORD,
    
    [EnumMember(Value = "COMMENT")]
    COMMENT,
    
    [EnumMember(Value = "NUM_LITERAL")]
    NUMLITERAL,
    
    [EnumMember(Value = "STRING_LITERAL")]
    STRINGLITERAL,
    
    [EnumMember(Value = "DECLARATION")]
    DECLARATION,
    
    [EnumMember(Value = "PARAMETER_ASSIGNMENT")]
    PARAMETERASSIGNMENT,
    
    [EnumMember(Value = "IDENTIFIER")]
    IDENTIFIER,
    
    [EnumMember(Value = "IDENTIFIER_TYPE")]
    IDENTIFIERTYPE,
    
    [EnumMember(Value = "IDENTIFIER_DECLARATION")]
    IDENTIFIERDECLARATION,
    
    [EnumMember(Value = "KEY")]
    KEY,
    
    [EnumMember(Value = "TAG")]
    TAG,
    
    [EnumMember(Value = "ANNOTATION")]
    ANNOTATION,
    
    [EnumMember(Value = "PREPROCESSOR_ANNOTATION")]
    PREPROCESSORANNOTATION,
    
    [EnumMember(Value = "PREPROCESSOR_MESSAGE")]
    PREPROCESSORMESSAGE,
    
    [EnumMember(Value = "HIGHLIGHT")]
    HIGHLIGHT,
    
    [EnumMember(Value = "SKIP")]
    SKIP,
    
}

