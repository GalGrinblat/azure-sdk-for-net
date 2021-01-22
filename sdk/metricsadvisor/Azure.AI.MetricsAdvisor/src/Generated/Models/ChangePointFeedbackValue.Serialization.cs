// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class ChangePointFeedbackValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("changePointValue");
            writer.WriteStringValue(ChangePointValue.ToString());
            writer.WriteEndObject();
        }

        internal static ChangePointFeedbackValue DeserializeChangePointFeedbackValue(JsonElement element)
        {
            ChangePointValue changePointValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changePointValue"))
                {
                    changePointValue = new ChangePointValue(property.Value.GetString());
                    continue;
                }
            }
            return new ChangePointFeedbackValue(changePointValue);
        }
    }
}