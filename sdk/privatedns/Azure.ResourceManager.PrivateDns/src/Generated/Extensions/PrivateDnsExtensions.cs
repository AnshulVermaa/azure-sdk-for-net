// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PrivateDns. </summary>
    public static partial class PrivateDnsExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists the Private DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of Private DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateDnsZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PrivateDnsZoneResource> GetPrivateDnsZonesAsync(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPrivateDnsZonesAsync(top, cancellationToken);
        }

        /// <summary>
        /// Lists the Private DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/privateDnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="top"> The maximum number of Private DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateDnsZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PrivateDnsZoneResource> GetPrivateDnsZones(this SubscriptionResource subscriptionResource, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPrivateDnsZones(top, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of PrivateDnsZoneResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PrivateDnsZoneResources and their operations over a PrivateDnsZoneResource. </returns>
        public static PrivateDnsZoneCollection GetPrivateDnsZones(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetPrivateDnsZones();
        }

        /// <summary>
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PrivateDnsZoneResource>> GetPrivateDnsZoneAsync(this ResourceGroupResource resourceGroupResource, string privateZoneName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetPrivateDnsZones().GetAsync(privateZoneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Private DNS zone. Retrieves the zone properties, but not the virtual networks links or the record sets within the zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="privateZoneName"> The name of the Private DNS zone (without a terminating dot). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateZoneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateZoneName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PrivateDnsZoneResource> GetPrivateDnsZone(this ResourceGroupResource resourceGroupResource, string privateZoneName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetPrivateDnsZones().Get(privateZoneName, cancellationToken);
        }

        #region PrivateDnsZoneResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsZoneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsZoneResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsZoneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsZoneResource" /> object. </returns>
        public static PrivateDnsZoneResource GetPrivateDnsZoneResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsZoneResource>(() =>
            {
                PrivateDnsZoneResource.ValidateResourceId(id);
                return new PrivateDnsZoneResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualNetworkLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="VirtualNetworkLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualNetworkLinkResource.CreateResourceIdentifier" /> to create a <see cref="VirtualNetworkLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetworkLinkResource" /> object. </returns>
        public static VirtualNetworkLinkResource GetVirtualNetworkLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualNetworkLinkResource.ValidateResourceId(id);
                return new VirtualNetworkLinkResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsARecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsARecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsARecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsARecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsARecordResource" /> object. </returns>
        public static PrivateDnsARecordResource GetPrivateDnsARecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsARecordResource>(() =>
            {
                PrivateDnsARecordResource.ValidateResourceId(id);
                return new PrivateDnsARecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsAaaaRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsAaaaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsAaaaRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsAaaaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsAaaaRecordResource" /> object. </returns>
        public static PrivateDnsAaaaRecordResource GetPrivateDnsAaaaRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsAaaaRecordResource>(() =>
            {
                PrivateDnsAaaaRecordResource.ValidateResourceId(id);
                return new PrivateDnsAaaaRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsCnameRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsCnameRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsCnameRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsCnameRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsCnameRecordResource" /> object. </returns>
        public static PrivateDnsCnameRecordResource GetPrivateDnsCnameRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsCnameRecordResource>(() =>
            {
                PrivateDnsCnameRecordResource.ValidateResourceId(id);
                return new PrivateDnsCnameRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsMXRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsMXRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsMXRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsMXRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsMXRecordResource" /> object. </returns>
        public static PrivateDnsMXRecordResource GetPrivateDnsMXRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsMXRecordResource>(() =>
            {
                PrivateDnsMXRecordResource.ValidateResourceId(id);
                return new PrivateDnsMXRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsPtrRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsPtrRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsPtrRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsPtrRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsPtrRecordResource" /> object. </returns>
        public static PrivateDnsPtrRecordResource GetPrivateDnsPtrRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsPtrRecordResource>(() =>
            {
                PrivateDnsPtrRecordResource.ValidateResourceId(id);
                return new PrivateDnsPtrRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsSoaRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsSoaRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsSoaRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsSoaRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsSoaRecordResource" /> object. </returns>
        public static PrivateDnsSoaRecordResource GetPrivateDnsSoaRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsSoaRecordResource>(() =>
            {
                PrivateDnsSoaRecordResource.ValidateResourceId(id);
                return new PrivateDnsSoaRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsSrvRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsSrvRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsSrvRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsSrvRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsSrvRecordResource" /> object. </returns>
        public static PrivateDnsSrvRecordResource GetPrivateDnsSrvRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsSrvRecordResource>(() =>
            {
                PrivateDnsSrvRecordResource.ValidateResourceId(id);
                return new PrivateDnsSrvRecordResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateDnsTxtRecordResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateDnsTxtRecordResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateDnsTxtRecordResource.CreateResourceIdentifier" /> to create a <see cref="PrivateDnsTxtRecordResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateDnsTxtRecordResource" /> object. </returns>
        public static PrivateDnsTxtRecordResource GetPrivateDnsTxtRecordResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient<PrivateDnsTxtRecordResource>(() =>
            {
                PrivateDnsTxtRecordResource.ValidateResourceId(id);
                return new PrivateDnsTxtRecordResource(client, id);
            }
            );
        }
        #endregion
    }
}
