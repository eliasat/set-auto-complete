namespace SetAutoComplete
{
    using System;

    public class PRCreatedHookBody
    {
        public string SubscriptionId { get; set; }
        public int NotificationId { get; set; }
        public string Id { get; set; }
        public string EventType { get; set; }
        public string PublisherId { get; set; }
        public Message Message { get; set; }
        public DetailedMessage DetailedMessage { get; set; }
        public Resource Resource { get; set; }
        public string ResourceVersion { get; set; }
        public ResourceContainers ResourceContainers { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class Message
    {
        public string Text { get; set; }
        public string Html { get; set; }
        public string Markdown { get; set; }
    }

    public class DetailedMessage
    {
        public string Text { get; set; }
        public string Html { get; set; }
        public string Markdown { get; set; }
    }

    public class Resource
    {
        public Repository Repository { get; set; }
        public int PullRequestId { get; set; }
        public string Status { get; set; }
        public Createdby CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SourceRefName { get; set; }
        public string TargetRefName { get; set; }
        public string MergeStatus { get; set; }
        public string MergeId { get; set; }
        public LastMergeSourceCommit LastMergeSourceCommit { get; set; }
        public LastMergeTargetCommit LastMergeTargetCommit { get; set; }
        public LastMergeCommit LastMergeCommit { get; set; }
        public Reviewer[] Reviewers { get; set; }
        public Commit[] Commits { get; set; }
        public string Url { get; set; }
        public _Links _links { get; set; }
    }

    public class Repository
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Project Project { get; set; }
        public string DefaultBranch { get; set; }
        public string RemoteUrl { get; set; }
    }

    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string State { get; set; }
        public string Visibility { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }

    public class Createdby
    {
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public string UniqueName { get; set; }
        public string ImageUrl { get; set; }
    }

    public class LastMergeSourceCommit
    {
        public string CommitId { get; set; }
        public string Url { get; set; }
    }

    public class LastMergeTargetCommit
    {
        public string CommitId { get; set; }
        public string Url { get; set; }
    }

    public class LastMergeCommit
    {
        public string CommitId { get; set; }
        public string Url { get; set; }
    }

    public class _Links
    {
        public Web Web { get; set; }
        public Statuses Statuses { get; set; }
    }

    public class Web
    {
        public string Href { get; set; }
    }

    public class Statuses
    {
        public string Href { get; set; }
    }

    public class Reviewer
    {
        public object ReviewerUrl { get; set; }
        public int Vote { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string Id { get; set; }
        public string UniqueName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsContainer { get; set; }
    }

    public class Commit
    {
        public string CommitId { get; set; }
        public string Url { get; set; }
    }

    public class ResourceContainers
    {
        public Collection Collection { get; set; }
        public Account Account { get; set; }
        public Project1 Project { get; set; }
    }

    public class Collection
    {
        public string Id { get; set; }
    }

    public class Account
    {
        public string Id { get; set; }
    }

    public class Project1
    {
        public string Id { get; set; }
    }
}
