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

namespace JetBrains.Space.Client.ImageAttachmentVariantPartialBuilder
{
    public static class ImageAttachmentVariantPartialExtensions
    {
        public static Partial<ImageAttachmentVariant> WithId(this Partial<ImageAttachmentVariant> it)
            => it.AddFieldName("id");
        
        public static Partial<ImageAttachmentVariant> WithName(this Partial<ImageAttachmentVariant> it)
            => it.AddFieldName("name");
        
        public static Partial<ImageAttachmentVariant> WithWidth(this Partial<ImageAttachmentVariant> it)
            => it.AddFieldName("width");
        
        public static Partial<ImageAttachmentVariant> WithHeight(this Partial<ImageAttachmentVariant> it)
            => it.AddFieldName("height");
        
    }
    
}
