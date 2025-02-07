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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class GitFileContent
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "GitFileContent";
    
    public static GitFileContentBase64 Base64(string value, bool? executable = null)
        => new GitFileContentBase64(value: value, executable: executable);
    
    public static GitFileContentDeleted Deleted()
        => new GitFileContentDeleted();
    
    public static GitFileContentText Text(string value, bool? executable = null)
        => new GitFileContentText(value: value, executable: executable);
    
    public GitFileContent() { }
    
    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
    }

}

