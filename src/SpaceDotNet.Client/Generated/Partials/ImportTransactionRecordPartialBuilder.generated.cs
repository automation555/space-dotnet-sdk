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

namespace SpaceDotNet.Client.ImportTransactionRecordPartialBuilder
{
    public static class ImportTransactionRecordPartialExtensions
    {
        public static Partial<ImportTransactionRecord> WithId(this Partial<ImportTransactionRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ImportTransactionRecord> WithIsArchived(this Partial<ImportTransactionRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<ImportTransactionRecord> WithImporter(this Partial<ImportTransactionRecord> it)
            => it.AddFieldName("importer");
        
        public static Partial<ImportTransactionRecord> WithImporter(this Partial<ImportTransactionRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("importer", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<ImportTransactionRecord> WithExternalSource(this Partial<ImportTransactionRecord> it)
            => it.AddFieldName("externalSource");
        
        public static Partial<ImportTransactionRecord> WithImported(this Partial<ImportTransactionRecord> it)
            => it.AddFieldName("imported");
        
    }
    
}
