// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.AbsenceApprovalExtensions
{
    public static class AbsenceApprovalDtoPartialExtensions
    {
        public static Partial<AbsenceApprovalDto> WithApproved(this Partial<AbsenceApprovalDto> it)
            => it.AddFieldName("approved");
        
        public static Partial<AbsenceApprovalDto> WithApprovedBy(this Partial<AbsenceApprovalDto> it)
            => it.AddFieldName("approvedBy");
        
        public static Partial<AbsenceApprovalDto> WithApprovedBy(this Partial<AbsenceApprovalDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("approvedBy", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<AbsenceApprovalDto> WithApprovedAt(this Partial<AbsenceApprovalDto> it)
            => it.AddFieldName("approvedAt");
        
    }
    
}
