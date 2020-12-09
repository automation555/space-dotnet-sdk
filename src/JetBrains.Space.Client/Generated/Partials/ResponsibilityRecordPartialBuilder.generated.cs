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

namespace JetBrains.Space.Client.ResponsibilityRecordPartialBuilder
{
    public static class ResponsibilityRecordPartialExtensions
    {
        public static Partial<ResponsibilityRecord> WithResponsibilityId(this Partial<ResponsibilityRecord> it)
            => it.AddFieldName("responsibilityId");
        
        public static Partial<ResponsibilityRecord> WithSummary(this Partial<ResponsibilityRecord> it)
            => it.AddFieldName("summary");
        
        public static Partial<ResponsibilityRecord> WithNotes(this Partial<ResponsibilityRecord> it)
            => it.AddFieldName("notes");
        
        public static Partial<ResponsibilityRecord> WithAssignedPeople(this Partial<ResponsibilityRecord> it)
            => it.AddFieldName("assignedPeople");
        
        public static Partial<ResponsibilityRecord> WithAssignedPeople(this Partial<ResponsibilityRecord> it, Func<Partial<AssignedPerson>, Partial<AssignedPerson>> partialBuilder)
            => it.AddFieldName("assignedPeople", partialBuilder(new Partial<AssignedPerson>(it)));
        
    }
    
}
