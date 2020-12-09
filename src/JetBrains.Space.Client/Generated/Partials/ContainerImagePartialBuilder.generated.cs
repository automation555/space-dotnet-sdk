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

namespace JetBrains.Space.Client.ContainerImagePartialBuilder
{
    public static class ContainerImagePartialExtensions
    {
        public static Partial<ContainerImage> WithName(this Partial<ContainerImage> it)
            => it.AddFieldName("name");
        
        public static Partial<ContainerImage> WithDescription(this Partial<ContainerImage> it)
            => it.AddFieldName("description");
        
        public static Partial<ContainerImage> WithTags(this Partial<ContainerImage> it)
            => it.AddFieldName("tags");
        
        public static Partial<ContainerImage> WithProjectUrl(this Partial<ContainerImage> it)
            => it.AddFieldName("projectUrl");
        
        public static Partial<ContainerImage> WithSourceUrl(this Partial<ContainerImage> it)
            => it.AddFieldName("sourceUrl");
        
        public static Partial<ContainerImage> WithVersion(this Partial<ContainerImage> it)
            => it.AddFieldName("version");
        
        public static Partial<ContainerImage> WithPlatform(this Partial<ContainerImage> it)
            => it.AddFieldName("platform");
        
        public static Partial<ContainerImage> WithPlatform(this Partial<ContainerImage> it, Func<Partial<ContainerImagePlatform>, Partial<ContainerImagePlatform>> partialBuilder)
            => it.AddFieldName("platform", partialBuilder(new Partial<ContainerImagePlatform>(it)));
        
        public static Partial<ContainerImage> WithHistory(this Partial<ContainerImage> it)
            => it.AddFieldName("history");
        
        public static Partial<ContainerImage> WithHistory(this Partial<ContainerImage> it, Func<Partial<ContainerImageLayer>, Partial<ContainerImageLayer>> partialBuilder)
            => it.AddFieldName("history", partialBuilder(new Partial<ContainerImageLayer>(it)));
        
        public static Partial<ContainerImage> WithChildren(this Partial<ContainerImage> it)
            => it.AddFieldName("children");
        
        public static Partial<ContainerImage> WithChildren(this Partial<ContainerImage> it, Func<Partial<ContainerManifest>, Partial<ContainerManifest>> partialBuilder)
            => it.AddFieldName("children", partialBuilder(new Partial<ContainerManifest>(it)));
        
        public static Partial<ContainerImage> WithConfig(this Partial<ContainerImage> it)
            => it.AddFieldName("config");
        
        public static Partial<ContainerImage> WithConfig(this Partial<ContainerImage> it, Func<Partial<ContainerImageConfig>, Partial<ContainerImageConfig>> partialBuilder)
            => it.AddFieldName("config", partialBuilder(new Partial<ContainerImageConfig>(it)));
        
        public static Partial<ContainerImage> WithAnnotation(this Partial<ContainerImage> it)
            => it.AddFieldName("annotation");
        
        public static Partial<ContainerImage> WithAnnotation(this Partial<ContainerImage> it, Func<Partial<ContainerImageAnnotation>, Partial<ContainerImageAnnotation>> partialBuilder)
            => it.AddFieldName("annotation", partialBuilder(new Partial<ContainerImageAnnotation>(it)));
        
    }
    
}
