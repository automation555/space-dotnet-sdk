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

namespace JetBrains.Space.Client.CustomFieldsV2ValuesForEntityForCustomFieldPostRequestPartialBuilder;

public static class CustomFieldsV2ValuesForEntityForCustomFieldPostRequestPartialExtensions
{
    public static Partial<CustomFieldsV2ValuesForEntityForCustomFieldPostRequest> WithNewValue(this Partial<CustomFieldsV2ValuesForEntityForCustomFieldPostRequest> it)
        => it.AddFieldName("newValue");
    
    public static Partial<CustomFieldsV2ValuesForEntityForCustomFieldPostRequest> WithNewValue(this Partial<CustomFieldsV2ValuesForEntityForCustomFieldPostRequest> it, Func<Partial<CFInputValue>, Partial<CFInputValue>> partialBuilder)
        => it.AddFieldName("newValue", partialBuilder(new Partial<CFInputValue>(it)));
    
}

