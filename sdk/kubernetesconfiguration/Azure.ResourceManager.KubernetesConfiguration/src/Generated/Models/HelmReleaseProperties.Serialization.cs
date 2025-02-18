// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmReleaseProperties
    {
        internal static HelmReleaseProperties DeserializeHelmReleaseProperties(JsonElement element)
        {
            Optional<long?> lastRevisionApplied = default;
            Optional<KubernetesObjectReference> helmChartRef = default;
            Optional<long?> failureCount = default;
            Optional<long?> installFailureCount = default;
            Optional<long?> upgradeFailureCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastRevisionApplied"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastRevisionApplied = null;
                        continue;
                    }
                    lastRevisionApplied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("helmChartRef"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmChartRef = null;
                        continue;
                    }
                    helmChartRef = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value);
                    continue;
                }
                if (property.NameEquals("failureCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        failureCount = null;
                        continue;
                    }
                    failureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("installFailureCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        installFailureCount = null;
                        continue;
                    }
                    installFailureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("upgradeFailureCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        upgradeFailureCount = null;
                        continue;
                    }
                    upgradeFailureCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new HelmReleaseProperties(Optional.ToNullable(lastRevisionApplied), helmChartRef.Value, Optional.ToNullable(failureCount), Optional.ToNullable(installFailureCount), Optional.ToNullable(upgradeFailureCount));
        }
    }
}
