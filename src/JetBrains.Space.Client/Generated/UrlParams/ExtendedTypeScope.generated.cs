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

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ExtendedTypeScope : IUrlParameter
    {
        public static ExtendedTypeScope Org
            => new ExtendedTypeScopeOrg();
        
        public static ExtendedTypeScope Container(string containerId)
            => new ExtendedTypeScopeContainer(containerId);
        
        private class ExtendedTypeScopeOrg : ExtendedTypeScope
        {
            public override string ToString()
                => "org";
        }
        
        private class ExtendedTypeScopeContainer : ExtendedTypeScope
        {
            private readonly string _containerId;
            
            public ExtendedTypeScopeContainer(string containerId)
                => _containerId = containerId;
            
            public override string ToString()
                => $"containerId:{_containerId}";
        }
        
    }
    
}
