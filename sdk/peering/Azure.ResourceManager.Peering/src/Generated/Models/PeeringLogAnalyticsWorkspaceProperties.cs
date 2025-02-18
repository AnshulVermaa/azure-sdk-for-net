// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define a Log Analytics Workspace. </summary>
    public partial class PeeringLogAnalyticsWorkspaceProperties
    {
        /// <summary> Initializes a new instance of PeeringLogAnalyticsWorkspaceProperties. </summary>
        public PeeringLogAnalyticsWorkspaceProperties()
        {
            ConnectedAgents = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PeeringLogAnalyticsWorkspaceProperties. </summary>
        /// <param name="workspaceId"> The Workspace ID. </param>
        /// <param name="key"> The Workspace Key. </param>
        /// <param name="connectedAgents"> The list of connected agents. </param>
        internal PeeringLogAnalyticsWorkspaceProperties(string workspaceId, string key, IReadOnlyList<string> connectedAgents)
        {
            WorkspaceId = workspaceId;
            Key = key;
            ConnectedAgents = connectedAgents;
        }

        /// <summary> The Workspace ID. </summary>
        public string WorkspaceId { get; }
        /// <summary> The Workspace Key. </summary>
        public string Key { get; }
        /// <summary> The list of connected agents. </summary>
        public IReadOnlyList<string> ConnectedAgents { get; }
    }
}
