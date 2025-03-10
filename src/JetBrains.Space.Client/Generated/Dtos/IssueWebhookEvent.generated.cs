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

namespace JetBrains.Space.Client;

public sealed class IssueWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "IssueWebhookEvent";
    
    public IssueWebhookEvent() { }
    
    public IssueWebhookEvent(KMetaMod meta, Issue issue, Modification<string>? title = null, Modification<string>? description = null, Modification<TDMemberProfile>? assignee = null, Modification<IssueStatus>? status = null, Modification<DateTime>? dueDate = null, Modification<List<PlanningTag>>? tagDelta = null, Modification<List<Topic>>? topicDelta = null, Modification<List<Checklist>>? checklistDelta = null, Modification<List<SprintRecord>>? sprintDelta = null, IssueWebhookCustomFieldUpdate? customFieldUpdate = null, Modification<bool>? deleted = null)
    {
        Meta = meta;
        Issue = issue;
        Title = title;
        Description = description;
        Assignee = assignee;
        Status = status;
        DueDate = dueDate;
        TagDelta = tagDelta;
        TopicDelta = topicDelta;
        ChecklistDelta = checklistDelta;
        SprintDelta = sprintDelta;
        CustomFieldUpdate = customFieldUpdate;
        Deleted = deleted;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(IssueWebhookEvent), nameof(Meta));
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue();
        set => _meta.SetValue(value);
    }

    private PropertyValue<Issue> _issue = new PropertyValue<Issue>(nameof(IssueWebhookEvent), nameof(Issue));
    
    [Required]
    [JsonPropertyName("issue")]
    public Issue Issue
    {
        get => _issue.GetValue();
        set => _issue.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _title = new PropertyValue<Modification<string>?>(nameof(IssueWebhookEvent), nameof(Title));
    
    [JsonPropertyName("title")]
    public Modification<string>? Title
    {
        get => _title.GetValue();
        set => _title.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _description = new PropertyValue<Modification<string>?>(nameof(IssueWebhookEvent), nameof(Description));
    
    [JsonPropertyName("description")]
    public Modification<string>? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<Modification<TDMemberProfile>?> _assignee = new PropertyValue<Modification<TDMemberProfile>?>(nameof(IssueWebhookEvent), nameof(Assignee));
    
    [JsonPropertyName("assignee")]
    public Modification<TDMemberProfile>? Assignee
    {
        get => _assignee.GetValue();
        set => _assignee.SetValue(value);
    }

    private PropertyValue<Modification<IssueStatus>?> _status = new PropertyValue<Modification<IssueStatus>?>(nameof(IssueWebhookEvent), nameof(Status));
    
    [JsonPropertyName("status")]
    public Modification<IssueStatus>? Status
    {
        get => _status.GetValue();
        set => _status.SetValue(value);
    }

    private PropertyValue<Modification<DateTime>?> _dueDate = new PropertyValue<Modification<DateTime>?>(nameof(IssueWebhookEvent), nameof(DueDate));
    
    [JsonPropertyName("dueDate")]
    public Modification<DateTime>? DueDate
    {
        get => _dueDate.GetValue();
        set => _dueDate.SetValue(value);
    }

    private PropertyValue<Modification<List<PlanningTag>>?> _tagDelta = new PropertyValue<Modification<List<PlanningTag>>?>(nameof(IssueWebhookEvent), nameof(TagDelta));
    
    [JsonPropertyName("tagDelta")]
    public Modification<List<PlanningTag>>? TagDelta
    {
        get => _tagDelta.GetValue();
        set => _tagDelta.SetValue(value);
    }

    private PropertyValue<Modification<List<Topic>>?> _topicDelta = new PropertyValue<Modification<List<Topic>>?>(nameof(IssueWebhookEvent), nameof(TopicDelta));
    
    [JsonPropertyName("topicDelta")]
    public Modification<List<Topic>>? TopicDelta
    {
        get => _topicDelta.GetValue();
        set => _topicDelta.SetValue(value);
    }

    private PropertyValue<Modification<List<Checklist>>?> _checklistDelta = new PropertyValue<Modification<List<Checklist>>?>(nameof(IssueWebhookEvent), nameof(ChecklistDelta));
    
    [JsonPropertyName("checklistDelta")]
    public Modification<List<Checklist>>? ChecklistDelta
    {
        get => _checklistDelta.GetValue();
        set => _checklistDelta.SetValue(value);
    }

    private PropertyValue<Modification<List<SprintRecord>>?> _sprintDelta = new PropertyValue<Modification<List<SprintRecord>>?>(nameof(IssueWebhookEvent), nameof(SprintDelta));
    
    [JsonPropertyName("sprintDelta")]
    public Modification<List<SprintRecord>>? SprintDelta
    {
        get => _sprintDelta.GetValue();
        set => _sprintDelta.SetValue(value);
    }

    private PropertyValue<IssueWebhookCustomFieldUpdate?> _customFieldUpdate = new PropertyValue<IssueWebhookCustomFieldUpdate?>(nameof(IssueWebhookEvent), nameof(CustomFieldUpdate));
    
    [JsonPropertyName("customFieldUpdate")]
    public IssueWebhookCustomFieldUpdate? CustomFieldUpdate
    {
        get => _customFieldUpdate.GetValue();
        set => _customFieldUpdate.SetValue(value);
    }

    private PropertyValue<Modification<bool>?> _deleted = new PropertyValue<Modification<bool>?>(nameof(IssueWebhookEvent), nameof(Deleted));
    
    [JsonPropertyName("deleted")]
    public Modification<bool>? Deleted
    {
        get => _deleted.GetValue();
        set => _deleted.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(path, validateHasBeenSet);
        _issue.SetAccessPath(path, validateHasBeenSet);
        _title.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _assignee.SetAccessPath(path, validateHasBeenSet);
        _status.SetAccessPath(path, validateHasBeenSet);
        _dueDate.SetAccessPath(path, validateHasBeenSet);
        _tagDelta.SetAccessPath(path, validateHasBeenSet);
        _topicDelta.SetAccessPath(path, validateHasBeenSet);
        _checklistDelta.SetAccessPath(path, validateHasBeenSet);
        _sprintDelta.SetAccessPath(path, validateHasBeenSet);
        _customFieldUpdate.SetAccessPath(path, validateHasBeenSet);
        _deleted.SetAccessPath(path, validateHasBeenSet);
    }

}

