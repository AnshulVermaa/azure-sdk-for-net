// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterWorkerItem
    {
        internal static RouterWorkerItem DeserializeRouterWorkerItem(JsonElement element)
        {
            Optional<RouterWorker> routerWorker = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routerWorker"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routerWorker = RouterWorker.DeserializeRouterWorker(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new RouterWorkerItem(routerWorker.Value, etag.Value);
        }
    }
}
