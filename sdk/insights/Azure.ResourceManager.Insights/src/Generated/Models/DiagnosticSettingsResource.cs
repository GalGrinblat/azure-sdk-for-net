// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The diagnostic setting resource. </summary>
    public partial class DiagnosticSettingsResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of DiagnosticSettingsResource. </summary>
        public DiagnosticSettingsResource()
        {
            Metrics = new ChangeTrackingList<MetricSettings>();
            Logs = new ChangeTrackingList<LogSettings>();
        }

        /// <summary> Initializes a new instance of DiagnosticSettingsResource. </summary>
        /// <param name="id"> Azure resource Id. </param>
        /// <param name="name"> Azure resource name. </param>
        /// <param name="type"> Azure resource type. </param>
        /// <param name="storageAccountId"> The resource ID of the storage account to which you would like to send Diagnostic Logs. </param>
        /// <param name="serviceBusRuleId"> The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility. </param>
        /// <param name="eventHubAuthorizationRuleId"> The resource Id for the event hub authorization rule. </param>
        /// <param name="eventHubName"> The name of the event hub. If none is specified, the default event hub will be selected. </param>
        /// <param name="metrics"> The list of metric settings. </param>
        /// <param name="logs"> The list of logs settings. </param>
        /// <param name="workspaceId"> The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2. </param>
        /// <param name="logAnalyticsDestinationType"> A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: &lt;normalized service identity&gt;_&lt;normalized category name&gt;. Possible values are: Dedicated and null (null is default.). </param>
        internal DiagnosticSettingsResource(string id, string name, string type, string storageAccountId, string serviceBusRuleId, string eventHubAuthorizationRuleId, string eventHubName, IList<MetricSettings> metrics, IList<LogSettings> logs, string workspaceId, string logAnalyticsDestinationType) : base(id, name, type)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            EventHubAuthorizationRuleId = eventHubAuthorizationRuleId;
            EventHubName = eventHubName;
            Metrics = metrics;
            Logs = logs;
            WorkspaceId = workspaceId;
            LogAnalyticsDestinationType = logAnalyticsDestinationType;
        }

        /// <summary> The resource ID of the storage account to which you would like to send Diagnostic Logs. </summary>
        public string StorageAccountId { get; set; }
        /// <summary> The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility. </summary>
        public string ServiceBusRuleId { get; set; }
        /// <summary> The resource Id for the event hub authorization rule. </summary>
        public string EventHubAuthorizationRuleId { get; set; }
        /// <summary> The name of the event hub. If none is specified, the default event hub will be selected. </summary>
        public string EventHubName { get; set; }
        /// <summary> The list of metric settings. </summary>
        public IList<MetricSettings> Metrics { get; }
        /// <summary> The list of logs settings. </summary>
        public IList<LogSettings> Logs { get; }
        /// <summary> The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> A string indicating whether the export to Log Analytics should use the default destination type, i.e. AzureDiagnostics, or use a destination type constructed as follows: &lt;normalized service identity&gt;_&lt;normalized category name&gt;. Possible values are: Dedicated and null (null is default.). </summary>
        public string LogAnalyticsDestinationType { get; set; }
    }
}