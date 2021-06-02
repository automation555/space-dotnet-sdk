using System.Text;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp
{
    public class CSharpDocument
    {
        private readonly string? _namespaceSuffix;
        private readonly StringBuilder _builder = new StringBuilder();

        public CSharpDocument(string? namespaceSuffix = null)
        {
            _namespaceSuffix = namespaceSuffix;
        }

        public void AppendLine(string content) => _builder.AppendLine(content);

        public override string ToString()
        {
            var indent = new Indent();
            
            var builder = new StringBuilder();
            builder.AppendLine($"{indent}// ------------------------------------------------------------------------------");
            builder.AppendLine($"{indent}// <auto-generated>");
            builder.AppendLine($"{indent}//     This code was generated by a tool.");
            builder.AppendLine($"{indent}// ");
            builder.AppendLine($"{indent}//     Changes to this file may cause incorrect behavior and will be lost if");
            builder.AppendLine($"{indent}//     the code is regenerated.");
            builder.AppendLine($"{indent}// </auto-generated>");
            builder.AppendLine($"{indent}// ------------------------------------------------------------------------------");
            builder.AppendLine($"{indent}");
            builder.AppendLine($"{indent}#nullable enable");
            builder.AppendLine($"{indent}#pragma warning disable CS1591"); // Missing XML comment for publicly visible type or member 'Type_or_Member'
            builder.AppendLine($"{indent}#pragma warning disable CS0108"); // 'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended
            builder.AppendLine($"{indent}#pragma warning disable 618");    // 'member' is obsolete.
            builder.AppendLine($"{indent}");
            builder.AppendLine($"{indent}using System;");
            builder.AppendLine($"{indent}using System.Collections.Generic;");
            builder.AppendLine($"{indent}using System.Collections.Specialized;");
            builder.AppendLine($"{indent}using System.ComponentModel.DataAnnotations;");
            builder.AppendLine($"{indent}using System.Linq;");
            builder.AppendLine($"{indent}using System.Runtime.Serialization;");
            builder.AppendLine($"{indent}using System.Text.Json.Serialization;");
            builder.AppendLine($"{indent}using System.Threading;");
            builder.AppendLine($"{indent}using System.Threading.Tasks;");
            builder.AppendLine($"{indent}using JetBrains.Space.Common;");
            builder.AppendLine($"{indent}using JetBrains.Space.Common.Json.Serialization;");
            builder.AppendLine($"{indent}using JetBrains.Space.Common.Json.Serialization.Polymorphism;");
            builder.AppendLine($"{indent}using JetBrains.Space.Common.Types;");
            builder.AppendLine($"{indent}");
            builder.AppendLine($"{indent}namespace JetBrains.Space.Client{(!string.IsNullOrEmpty(_namespaceSuffix) ? "." + _namespaceSuffix : "")}");
            builder.AppendLine($"{indent}{{");
            
            indent.Increment();

            builder.Append(indent.Wrap(_builder.ToString()));
            
            indent.Decrement();
            
            builder.AppendLine($"{indent}}}");

            return builder.ToString();
        }
    }
}