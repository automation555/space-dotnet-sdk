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

public sealed class InaccessibleDocumentBody
     : DocumentBody, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "InaccessibleDocumentBody";
    
    public InaccessibleDocumentBody() { }
    
    public InaccessibleDocumentBody(DocumentBodyType docBodyType, string docBodyId)
    {
        DocBodyType = docBodyType;
        DocBodyId = docBodyId;
    }
    
    private PropertyValue<DocumentBodyType> _docBodyType = new PropertyValue<DocumentBodyType>(nameof(InaccessibleDocumentBody), nameof(DocBodyType));
    
    [Required]
    [JsonPropertyName("docBodyType")]
    public DocumentBodyType DocBodyType
    {
        get => _docBodyType.GetValue();
        set => _docBodyType.SetValue(value);
    }

    private PropertyValue<string> _docBodyId = new PropertyValue<string>(nameof(InaccessibleDocumentBody), nameof(DocBodyId));
    
    [Required]
    [JsonPropertyName("docBodyId")]
    public string DocBodyId
    {
        get => _docBodyId.GetValue();
        set => _docBodyId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _docBodyType.SetAccessPath(path, validateHasBeenSet);
        _docBodyId.SetAccessPath(path, validateHasBeenSet);
    }

}

