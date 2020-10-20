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
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CFConstraint
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CFConstraint";
        
        public static DateCFConstraint Date(DateTime? min = null, DateTime? max = null, string? message = null)
            => new DateCFConstraint(min: null, max: null, message: null);
        
        public static IntCFConstraint Int(int? min = null, int? max = null, string? message = null)
            => new IntCFConstraint(min: null, max: null, message: null);
        
        public static PercentCFConstraint Percent()
            => new PercentCFConstraint();
        
        public static StringCFConstraint String(int? min = null, int? max = null, string? pattern = null, string? message = null)
            => new StringCFConstraint(min: null, max: null, pattern: null, message: null);
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
