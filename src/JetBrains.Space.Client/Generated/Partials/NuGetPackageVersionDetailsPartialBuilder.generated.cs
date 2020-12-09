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

namespace JetBrains.Space.Client.NuGetPackageVersionDetailsPartialBuilder
{
    public static class NuGetPackageVersionDetailsPartialExtensions
    {
        public static Partial<NuGetPackageVersionDetails> WithType(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("type");
        
        public static Partial<NuGetPackageVersionDetails> WithType(this Partial<NuGetPackageVersionDetails> it, Func<Partial<PackageType>, Partial<PackageType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageType>(it)));
        
        public static Partial<NuGetPackageVersionDetails> WithRepository(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("repository");
        
        public static Partial<NuGetPackageVersionDetails> WithName(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("name");
        
        public static Partial<NuGetPackageVersionDetails> WithVersion(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("version");
        
        public static Partial<NuGetPackageVersionDetails> WithTags(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("tags");
        
        public static Partial<NuGetPackageVersionDetails> WithCreated(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("created");
        
        public static Partial<NuGetPackageVersionDetails> WithAccessed(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("accessed");
        
        public static Partial<NuGetPackageVersionDetails> WithDownloads(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("downloads");
        
        public static Partial<NuGetPackageVersionDetails> WithIsPinned(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("pinned");
        
        public static Partial<NuGetPackageVersionDetails> WithComment(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("comment");
        
        public static Partial<NuGetPackageVersionDetails> WithDiskSize(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("diskSize");
        
        public static Partial<NuGetPackageVersionDetails> WithAuthor(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("author");
        
        public static Partial<NuGetPackageVersionDetails> WithAuthor(this Partial<NuGetPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<NuGetPackageVersionDetails> WithAuthors(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("authors");
        
        public static Partial<NuGetPackageVersionDetails> WithAuthors(this Partial<NuGetPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<NuGetPackageVersionDetails> WithOrigin(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("origin");
        
        public static Partial<NuGetPackageVersionDetails> WithOrigin(this Partial<NuGetPackageVersionDetails> it, Func<Partial<PackageOrigin>, Partial<PackageOrigin>> partialBuilder)
            => it.AddFieldName("origin", partialBuilder(new Partial<PackageOrigin>(it)));
        
        public static Partial<NuGetPackageVersionDetails> WithMetadata(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("metadata");
        
        public static Partial<NuGetPackageVersionDetails> WithMetadata(this Partial<NuGetPackageVersionDetails> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<string>(it)));
        
        public static Partial<NuGetPackageVersionDetails> WithDescription(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("description");
        
        public static Partial<NuGetPackageVersionDetails> WithProjectUrl(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("projectUrl");
        
        public static Partial<NuGetPackageVersionDetails> WithLicense(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("license");
        
        public static Partial<NuGetPackageVersionDetails> WithLicenseUrl(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("licenseUrl");
        
        public static Partial<NuGetPackageVersionDetails> WithIcon(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("icon");
        
        public static Partial<NuGetPackageVersionDetails> WithTitle(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("title");
        
        public static Partial<NuGetPackageVersionDetails> WithDependencies(this Partial<NuGetPackageVersionDetails> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<NuGetPackageVersionDetails> WithDependencies(this Partial<NuGetPackageVersionDetails> it, Func<Partial<NuGetDependencyGroup>, Partial<NuGetDependencyGroup>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<NuGetDependencyGroup>(it)));
        
    }
    
}
