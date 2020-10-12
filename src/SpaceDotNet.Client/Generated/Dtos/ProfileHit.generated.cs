// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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
    public sealed class ProfileHit
         : EntityHit, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ProfileHit";
        
        public ProfileHit() { }
        
        public ProfileHit(string id, double score, string firstName, string lastName, string userName, List<string> phones, List<string> emails, List<string> links, List<string> messengers, List<string> internationalNames, bool notAMember, TDMemberProfile @ref, ProfileAbsencesRecord absencesRef, ProfileMembershipRecord membershipRef, ProfileLocationsRecord locationsRef, List<CustomFieldHit> customFields)
        {
            Id = id;
            Score = score;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Phones = phones;
            Emails = emails;
            Links = links;
            Messengers = messengers;
            InternationalNames = internationalNames;
            IsNotAMember = notAMember;
            Ref = @ref;
            AbsencesRef = absencesRef;
            MembershipRef = membershipRef;
            LocationsRef = locationsRef;
            CustomFields = customFields;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProfileHit), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(ProfileHit), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<string> _firstName = new PropertyValue<string>(nameof(ProfileHit), nameof(FirstName));
        
        [Required]
        [JsonPropertyName("firstName")]
        public string FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string> _lastName = new PropertyValue<string>(nameof(ProfileHit), nameof(LastName));
        
        [Required]
        [JsonPropertyName("lastName")]
        public string LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        private PropertyValue<string> _userName = new PropertyValue<string>(nameof(ProfileHit), nameof(UserName));
        
        [Required]
        [JsonPropertyName("userName")]
        public string UserName
        {
            get { return _userName.GetValue(); }
            set { _userName.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _phones = new PropertyValue<List<string>>(nameof(ProfileHit), nameof(Phones));
        
        [Required]
        [JsonPropertyName("phones")]
        public List<string> Phones
        {
            get { return _phones.GetValue(); }
            set { _phones.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _emails = new PropertyValue<List<string>>(nameof(ProfileHit), nameof(Emails));
        
        [Required]
        [JsonPropertyName("emails")]
        public List<string> Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _links = new PropertyValue<List<string>>(nameof(ProfileHit), nameof(Links));
        
        [Required]
        [JsonPropertyName("links")]
        public List<string> Links
        {
            get { return _links.GetValue(); }
            set { _links.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _messengers = new PropertyValue<List<string>>(nameof(ProfileHit), nameof(Messengers));
        
        [Required]
        [JsonPropertyName("messengers")]
        public List<string> Messengers
        {
            get { return _messengers.GetValue(); }
            set { _messengers.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _internationalNames = new PropertyValue<List<string>>(nameof(ProfileHit), nameof(InternationalNames));
        
        [Required]
        [JsonPropertyName("internationalNames")]
        public List<string> InternationalNames
        {
            get { return _internationalNames.GetValue(); }
            set { _internationalNames.SetValue(value); }
        }
    
        private PropertyValue<bool> _notAMember = new PropertyValue<bool>(nameof(ProfileHit), nameof(IsNotAMember));
        
        [Required]
        [JsonPropertyName("notAMember")]
        public bool IsNotAMember
        {
            get { return _notAMember.GetValue(); }
            set { _notAMember.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _ref = new PropertyValue<TDMemberProfile>(nameof(ProfileHit), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public TDMemberProfile Ref
        {
            get { return _ref.GetValue(); }
            set { _ref.SetValue(value); }
        }
    
        private PropertyValue<ProfileAbsencesRecord> _absencesRef = new PropertyValue<ProfileAbsencesRecord>(nameof(ProfileHit), nameof(AbsencesRef));
        
        [Required]
        [JsonPropertyName("absencesRef")]
        public ProfileAbsencesRecord AbsencesRef
        {
            get { return _absencesRef.GetValue(); }
            set { _absencesRef.SetValue(value); }
        }
    
        private PropertyValue<ProfileMembershipRecord> _membershipRef = new PropertyValue<ProfileMembershipRecord>(nameof(ProfileHit), nameof(MembershipRef));
        
        [Required]
        [JsonPropertyName("membershipRef")]
        public ProfileMembershipRecord MembershipRef
        {
            get { return _membershipRef.GetValue(); }
            set { _membershipRef.SetValue(value); }
        }
    
        private PropertyValue<ProfileLocationsRecord> _locationsRef = new PropertyValue<ProfileLocationsRecord>(nameof(ProfileHit), nameof(LocationsRef));
        
        [Required]
        [JsonPropertyName("locationsRef")]
        public ProfileLocationsRecord LocationsRef
        {
            get { return _locationsRef.GetValue(); }
            set { _locationsRef.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldHit>> _customFields = new PropertyValue<List<CustomFieldHit>>(nameof(ProfileHit), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public List<CustomFieldHit> CustomFields
        {
            get { return _customFields.GetValue(); }
            set { _customFields.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _firstName.SetAccessPath(path, validateHasBeenSet);
            _lastName.SetAccessPath(path, validateHasBeenSet);
            _userName.SetAccessPath(path, validateHasBeenSet);
            _phones.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _links.SetAccessPath(path, validateHasBeenSet);
            _messengers.SetAccessPath(path, validateHasBeenSet);
            _internationalNames.SetAccessPath(path, validateHasBeenSet);
            _notAMember.SetAccessPath(path, validateHasBeenSet);
            _ref.SetAccessPath(path, validateHasBeenSet);
            _absencesRef.SetAccessPath(path, validateHasBeenSet);
            _membershipRef.SetAccessPath(path, validateHasBeenSet);
            _locationsRef.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
