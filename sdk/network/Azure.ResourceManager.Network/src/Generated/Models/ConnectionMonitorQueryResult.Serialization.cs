// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorQueryResult
    {
        internal static ConnectionMonitorQueryResult DeserializeConnectionMonitorQueryResult(JsonElement element)
        {
            Optional<ConnectionMonitorSourceStatus> sourceStatus = default;
            Optional<IReadOnlyList<ConnectionStateSnapshot>> states = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceStatus = new ConnectionMonitorSourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("states"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectionStateSnapshot> array = new List<ConnectionStateSnapshot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionStateSnapshot.DeserializeConnectionStateSnapshot(item));
                    }
                    states = array;
                    continue;
                }
            }
            return new ConnectionMonitorQueryResult(Optional.ToNullable(sourceStatus), Optional.ToList(states));
        }
    }
}