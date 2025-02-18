// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    internal partial class PostgreSqlFlexibleServerDatabaseListResult
    {
        internal static PostgreSqlFlexibleServerDatabaseListResult DeserializePostgreSqlFlexibleServerDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PostgreSqlFlexibleServerDatabaseData>> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlFlexibleServerDatabaseData> array = new List<PostgreSqlFlexibleServerDatabaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerDatabaseListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
