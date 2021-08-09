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

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CFValue
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CFValue";
        
        public static AutonumberCFValue Autonumber(string? value = null)
            => new AutonumberCFValue(value: value);
        
        public static BooleanCFValue Boolean(bool? value = null)
            => new BooleanCFValue(value: value);
        
        public static ContactCFValue Contact(string? value = null)
            => new ContactCFValue(value: value);
        
        public static ContactListCFValue ContactList(List<string> values)
            => new ContactListCFValue(values: values);
        
        public static DateCFValue Date(DateTime? value = null)
            => new DateCFValue(value: value);
        
        public static DateTimeCFValue DateTime(DateTime? value = null)
            => new DateTimeCFValue(value: value);
        
        public static DocumentCFValue Document(Document? document = null)
            => new DocumentCFValue(document: document);
        
        public static DocumentListCFValue DocumentList(List<Document> documents)
            => new DocumentListCFValue(documents: documents);
        
        public static EnumCFValue Enum(EnumValueData? value = null)
            => new EnumCFValue(value: value);
        
        public static EnumListCFValue EnumList(List<EnumValueData> values)
            => new EnumListCFValue(values: values);
        
        public static IntCFValue Int(int? value = null)
            => new IntCFValue(value: value);
        
        public static IntListCFValue IntList(List<int> values)
            => new IntListCFValue(values: values);
        
        public static IssueCFValue Issue(Issue? issue = null)
            => new IssueCFValue(issue: issue);
        
        public static IssueListCFValue IssueList(List<Issue> issues)
            => new IssueListCFValue(issues: issues);
        
        public static LocationCFValue Location(TDLocation? location = null)
            => new LocationCFValue(location: location);
        
        public static OpenEnumCFValue OpenEnum(EnumValueData? value = null)
            => new OpenEnumCFValue(value: value);
        
        public static OpenEnumListCFValue OpenEnumList(List<EnumValueData> values)
            => new OpenEnumListCFValue(values: values);
        
        public static PercentageCFValue Percentage(int? value = null)
            => new PercentageCFValue(value: value);
        
        public static ProfileCFValue Profile(TDMemberProfile? profile = null)
            => new ProfileCFValue(profile: profile);
        
        public static ProfileListCFValue ProfileList(List<TDMemberProfile> profiles)
            => new ProfileListCFValue(profiles: profiles);
        
        public static ProjectCFValue Project(PRProject? project = null)
            => new ProjectCFValue(project: project);
        
        public static StringCFValue String(string? value = null)
            => new StringCFValue(value: value);
        
        public static StringListCFValue StringList(List<string> values)
            => new StringListCFValue(values: values);
        
        public static TeamCFValue Team(TDTeam? team = null)
            => new TeamCFValue(team: team);
        
        public static UrlCFValue Url(string? href = null)
            => new UrlCFValue(href: href);
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
