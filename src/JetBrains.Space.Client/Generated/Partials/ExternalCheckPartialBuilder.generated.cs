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

namespace JetBrains.Space.Client.ExternalCheckPartialBuilder
{
    public static class ExternalCheckPartialExtensions
    {
        public static Partial<ExternalCheck> WithRepository(this Partial<ExternalCheck> it)
            => it.AddFieldName("repository");
        
        public static Partial<ExternalCheck> WithRevision(this Partial<ExternalCheck> it)
            => it.AddFieldName("revision");
        
        public static Partial<ExternalCheck> WithExecutionStatus(this Partial<ExternalCheck> it)
            => it.AddFieldName("executionStatus");
        
        public static Partial<ExternalCheck> WithExecutionStatus(this Partial<ExternalCheck> it, Func<Partial<CommitExecutionStatus>, Partial<CommitExecutionStatus>> partialBuilder)
            => it.AddFieldName("executionStatus", partialBuilder(new Partial<CommitExecutionStatus>(it)));
        
        public static Partial<ExternalCheck> WithUrl(this Partial<ExternalCheck> it)
            => it.AddFieldName("url");
        
        public static Partial<ExternalCheck> WithExternalServiceName(this Partial<ExternalCheck> it)
            => it.AddFieldName("externalServiceName");
        
        public static Partial<ExternalCheck> WithTaskName(this Partial<ExternalCheck> it)
            => it.AddFieldName("taskName");
        
        public static Partial<ExternalCheck> WithTaskId(this Partial<ExternalCheck> it)
            => it.AddFieldName("taskId");
        
        public static Partial<ExternalCheck> WithTimestamp(this Partial<ExternalCheck> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<ExternalCheck> WithDescription(this Partial<ExternalCheck> it)
            => it.AddFieldName("description");
        
    }
    
}
