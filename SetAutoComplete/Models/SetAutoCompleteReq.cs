namespace SetAutoComplete
{
    public class SetAutoCompleteReq
    {
        public AutocompleteSetBy AutoCompleteSetBy { get; set; } = new AutocompleteSetBy();
        public CompletionOptions CompletionOptions { get; set; } = new CompletionOptions();
        public string SourceRefName { get; set; }
        public string TargetRefName { get; set; }
    }

    public class AutocompleteSetBy
    {
        public string Id { get; set; }
    }

    public class CompletionOptions
    {
        public string DeleteSourceBranch { get; set; } = "false";
        public string MergeCommitMessage { get; set; }
        public string SquashMerge { get; set; } = "false";
    }
}
