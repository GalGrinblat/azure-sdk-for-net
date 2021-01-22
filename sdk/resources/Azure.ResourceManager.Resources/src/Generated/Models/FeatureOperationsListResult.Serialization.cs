// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class FeatureOperationsListResult
    {
        internal static FeatureOperationsListResult DeserializeFeatureOperationsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<FeatureResult>> value = default;
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
                    List<FeatureResult> array = new List<FeatureResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FeatureResult.DeserializeFeatureResult(item));
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
            return new FeatureOperationsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}