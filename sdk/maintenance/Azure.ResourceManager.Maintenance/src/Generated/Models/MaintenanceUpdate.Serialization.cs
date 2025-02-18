// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    public partial class MaintenanceUpdate
    {
        internal static MaintenanceUpdate DeserializeMaintenanceUpdate(JsonElement element)
        {
            Optional<MaintenanceScope> maintenanceScope = default;
            Optional<MaintenanceImpactType> impactType = default;
            Optional<MaintenanceUpdateStatus> status = default;
            Optional<int> impactDurationInSec = default;
            Optional<DateTimeOffset> notBefore = default;
            Optional<ResourceIdentifier> resourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maintenanceScope"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maintenanceScope = new MaintenanceScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    impactType = new MaintenanceImpactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new MaintenanceUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactDurationInSec"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    impactDurationInSec = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notBefore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    notBefore = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MaintenanceUpdate(Optional.ToNullable(maintenanceScope), Optional.ToNullable(impactType), Optional.ToNullable(status), Optional.ToNullable(impactDurationInSec), Optional.ToNullable(notBefore), resourceId.Value);
        }
    }
}
