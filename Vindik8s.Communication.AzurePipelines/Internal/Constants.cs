namespace Vindik8s.Communication.AzurePipelines.Internal
{
    internal static class Constants
    {
        internal static class RunsApi
        {
            internal const string ApiVersion = "6.0-preview.1";
        }

        internal static class Approvals
        {
            internal const string ApiVersion = "7.0";

            internal static class ApprovalStatuses
            {
                // https://learn.microsoft.com/en-us/rest/api/azure/devops/release/approvals/update?view=azure-devops-rest-7.0&tabs=HTTP#approvalstatus
                internal const string Approved = "approved";
                internal const string Rejected = "rejected";
            }
        }
    }
}
