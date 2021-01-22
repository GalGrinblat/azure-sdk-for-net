// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DedicatedHostAllocatableVM
    {
        internal static DedicatedHostAllocatableVM DeserializeDedicatedHostAllocatableVM(JsonElement element)
        {
            Optional<string> vmSize = default;
            Optional<double> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetDouble();
                    continue;
                }
            }
            return new DedicatedHostAllocatableVM(vmSize.Value, Optional.ToNullable(count));
        }
    }
}