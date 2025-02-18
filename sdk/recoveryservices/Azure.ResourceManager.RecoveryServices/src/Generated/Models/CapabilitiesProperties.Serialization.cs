// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class CapabilitiesProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsZones))
            {
                writer.WritePropertyName("dnsZones");
                writer.WriteStartArray();
                foreach (var item in DnsZones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CapabilitiesProperties DeserializeCapabilitiesProperties(JsonElement element)
        {
            Optional<IList<DnsZone>> dnsZones = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsZones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DnsZone> array = new List<DnsZone>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DnsZone.DeserializeDnsZone(item));
                    }
                    dnsZones = array;
                    continue;
                }
            }
            return new CapabilitiesProperties(Optional.ToList(dnsZones));
        }
    }
}
