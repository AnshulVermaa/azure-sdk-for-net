// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> Model representing SKU for Azure Dev Spaces Controller. </summary>
    public partial class DevSpacesSku
    {
        /// <summary> Initializes a new instance of DevSpacesSku. </summary>
        /// <param name="name"> The name of the SKU for Azure Dev Spaces Controller. </param>
        public DevSpacesSku(DevSpacesSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of DevSpacesSku. </summary>
        /// <param name="name"> The name of the SKU for Azure Dev Spaces Controller. </param>
        /// <param name="tier"> The tier of the SKU for Azure Dev Spaces Controller. </param>
        internal DevSpacesSku(DevSpacesSkuName name, DevSpacesSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The name of the SKU for Azure Dev Spaces Controller. </summary>
        public DevSpacesSkuName Name { get; set; }
        /// <summary> The tier of the SKU for Azure Dev Spaces Controller. </summary>
        public DevSpacesSkuTier? Tier { get; set; }
    }
}
