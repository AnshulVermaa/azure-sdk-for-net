// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies additional settings to be applied when patch mode
    /// AutomaticByPlatform is selected in Linux patch settings.
    /// </summary>
    public partial class LinuxVMGuestPatchAutomaticByPlatformSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LinuxVMGuestPatchAutomaticByPlatformSettings class.
        /// </summary>
        public LinuxVMGuestPatchAutomaticByPlatformSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LinuxVMGuestPatchAutomaticByPlatformSettings class.
        /// </summary>
        /// <param name="rebootSetting">Specifies the reboot setting for all
        /// AutomaticByPlatform patch installation operations. Possible values
        /// include: 'Unknown', 'IfRequired', 'Never', 'Always'</param>
        public LinuxVMGuestPatchAutomaticByPlatformSettings(string rebootSetting = default(string))
        {
            RebootSetting = rebootSetting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the reboot setting for all
        /// AutomaticByPlatform patch installation operations. Possible values
        /// include: 'Unknown', 'IfRequired', 'Never', 'Always'
        /// </summary>
        [JsonProperty(PropertyName = "rebootSetting")]
        public string RebootSetting { get; set; }

    }
}
