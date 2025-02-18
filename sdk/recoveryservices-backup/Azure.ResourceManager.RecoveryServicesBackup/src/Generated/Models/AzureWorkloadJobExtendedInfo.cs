// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM workload-specific additional information for job. </summary>
    public partial class AzureWorkloadJobExtendedInfo
    {
        /// <summary> Initializes a new instance of AzureWorkloadJobExtendedInfo. </summary>
        public AzureWorkloadJobExtendedInfo()
        {
            TasksList = new ChangeTrackingList<AzureWorkloadJobTaskDetails>();
            PropertyBag = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of AzureWorkloadJobExtendedInfo. </summary>
        /// <param name="tasksList"> List of tasks for this job. </param>
        /// <param name="propertyBag"> Job properties. </param>
        /// <param name="dynamicErrorMessage"> Non localized error message on job execution. </param>
        internal AzureWorkloadJobExtendedInfo(IList<AzureWorkloadJobTaskDetails> tasksList, IDictionary<string, string> propertyBag, string dynamicErrorMessage)
        {
            TasksList = tasksList;
            PropertyBag = propertyBag;
            DynamicErrorMessage = dynamicErrorMessage;
        }

        /// <summary> List of tasks for this job. </summary>
        public IList<AzureWorkloadJobTaskDetails> TasksList { get; }
        /// <summary> Job properties. </summary>
        public IDictionary<string, string> PropertyBag { get; }
        /// <summary> Non localized error message on job execution. </summary>
        public string DynamicErrorMessage { get; set; }
    }
}
