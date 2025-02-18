// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal partial class AttachedDataNetworkListResult
    {
        internal static AttachedDataNetworkListResult DeserializeAttachedDataNetworkListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AttachedDataNetworkData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AttachedDataNetworkData> array = new List<AttachedDataNetworkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AttachedDataNetworkData.DeserializeAttachedDataNetworkData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AttachedDataNetworkListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
