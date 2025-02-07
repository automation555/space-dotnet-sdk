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

public interface PackageVersionDetails
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static ContainerPackageVersionDetails Container(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, int schemaVersion, string mediaType, string manifestType, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, ContainerImage? image = null, ContainerHelmChart? chart = null)
        => new ContainerPackageVersionDetails(type: type, repository: repository, name: name, version: version, created: created, downloads: downloads, pinned: pinned, diskSize: diskSize, schemaVersion: schemaVersion, mediaType: mediaType, manifestType: manifestType, tags: tags, accessed: accessed, comment: comment, author: author, authors: authors, origin: origin, metadata: metadata, image: image, chart: chart);
    
    public static MavenPackageVersionDetails Maven(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<string> licenses, List<MavenPackageDependency> dependencies, List<MavenPackageFile> files, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? packaging = null, string? packageName = null, string? description = null, string? url = null, string? scmUrl = null, List<KotlinPlatform>? kotlinPlatforms = null, MavenPackageParent? parent = null, string? pathPrefix = null)
        => new MavenPackageVersionDetails(type: type, repository: repository, name: name, version: version, created: created, downloads: downloads, pinned: pinned, diskSize: diskSize, licenses: licenses, dependencies: dependencies, files: files, tags: tags, accessed: accessed, comment: comment, author: author, authors: authors, origin: origin, metadata: metadata, packaging: packaging, packageName: packageName, description: description, url: url, scmUrl: scmUrl, kotlinPlatforms: kotlinPlatforms, parent: parent, pathPrefix: pathPrefix);
    
    public static NpmPackageVersionDetails Npm(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<NpmPackageDependency> dependencies, List<string> keywords, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? description = null, string? license = null, string? projectUrl = null, string? repositoryUrl = null, string? repositoryRevision = null, string? readme = null)
        => new NpmPackageVersionDetails(type: type, repository: repository, name: name, version: version, created: created, downloads: downloads, pinned: pinned, diskSize: diskSize, dependencies: dependencies, keywords: keywords, tags: tags, accessed: accessed, comment: comment, author: author, authors: authors, origin: origin, metadata: metadata, description: description, license: license, projectUrl: projectUrl, repositoryUrl: repositoryUrl, repositoryRevision: repositoryRevision, readme: readme);
    
    public static NuGetPackageVersionDetails NuGet(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, string verbatimVersion, List<NuGetDependency> dependencies, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? description = null, string? projectUrl = null, string? license = null, string? licenseUrl = null, string? icon = null, string? title = null)
        => new NuGetPackageVersionDetails(type: type, repository: repository, name: name, version: version, created: created, downloads: downloads, pinned: pinned, diskSize: diskSize, verbatimVersion: verbatimVersion, dependencies: dependencies, tags: tags, accessed: accessed, comment: comment, author: author, authors: authors, origin: origin, metadata: metadata, description: description, projectUrl: projectUrl, license: license, licenseUrl: licenseUrl, icon: icon, title: title);
    
}

