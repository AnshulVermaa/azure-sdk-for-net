// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Virtual Network rule. </summary>
    public partial class StorageAccountVirtualNetworkRule
    {
        /// <summary> Initializes a new instance of StorageAccountVirtualNetworkRule. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkResourceId"/> is null. </exception>
        public StorageAccountVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId)
        {
            Argument.AssertNotNull(virtualNetworkResourceId, nameof(virtualNetworkResourceId));

            VirtualNetworkResourceId = virtualNetworkResourceId;
        }

        /// <summary> Initializes a new instance of StorageAccountVirtualNetworkRule. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <param name="action"> The action of virtual network rule. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        internal StorageAccountVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId, StorageAccountNetworkRuleAction? action, StorageAccountNetworkRuleState? state)
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            Action = action;
            State = state;
        }

        /// <summary> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </summary>
        public ResourceIdentifier VirtualNetworkResourceId { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public StorageAccountNetworkRuleAction? Action { get; set; }
        /// <summary> Gets the state of virtual network rule. </summary>
        public StorageAccountNetworkRuleState? State { get; set; }
    }
}
