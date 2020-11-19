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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.ProjectsForProjectPackagesRepositoriesPostRequestPartialBuilder
{
    public static class ProjectsForProjectPackagesRepositoriesPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithType(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithName(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithDescription(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithIsPublic(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("public");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithSettings(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithSettings(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it, Func<Partial<ESPackageRepositorySettings>, Partial<ESPackageRepositorySettings>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESPackageRepositorySettings>(it)));
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithMirror(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it)
            => it.AddFieldName("mirror");
        
        public static Partial<ProjectsForProjectPackagesRepositoriesPostRequest> WithMirror(this Partial<ProjectsForProjectPackagesRepositoriesPostRequest> it, Func<Partial<PackageRepositoryMirror>, Partial<PackageRepositoryMirror>> partialBuilder)
            => it.AddFieldName("mirror", partialBuilder(new Partial<PackageRepositoryMirror>(it)));
        
    }
    
}
