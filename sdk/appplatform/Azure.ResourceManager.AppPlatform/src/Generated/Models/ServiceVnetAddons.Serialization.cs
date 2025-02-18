// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class ServiceVnetAddons : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsLogStreamPublicEndpoint))
            {
                writer.WritePropertyName("logStreamPublicEndpoint");
                writer.WriteBooleanValue(IsLogStreamPublicEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceVnetAddons DeserializeServiceVnetAddons(JsonElement element)
        {
            Optional<bool> logStreamPublicEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logStreamPublicEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logStreamPublicEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceVnetAddons(Optional.ToNullable(logStreamPublicEndpoint));
        }
    }
}
