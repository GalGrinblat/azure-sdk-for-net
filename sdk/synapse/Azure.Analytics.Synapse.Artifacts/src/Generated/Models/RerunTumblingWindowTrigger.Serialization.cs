// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class RerunTumblingWindowTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ParentTrigger))
            {
                writer.WritePropertyName("parentTrigger");
                writer.WriteObjectValue(ParentTrigger);
            }
            writer.WritePropertyName("requestedStartTime");
            writer.WriteStringValue(RequestedStartTime, "O");
            writer.WritePropertyName("requestedEndTime");
            writer.WriteStringValue(RequestedEndTime, "O");
            writer.WritePropertyName("maxConcurrency");
            writer.WriteNumberValue(MaxConcurrency);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RerunTumblingWindowTrigger DeserializeRerunTumblingWindowTrigger(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<TriggerRuntimeState> runtimeState = default;
            Optional<IList<object>> annotations = default;
            Optional<object> parentTrigger = default;
            DateTimeOffset requestedStartTime = default;
            DateTimeOffset requestedEndTime = default;
            int maxConcurrency = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runtimeState = new TriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("parentTrigger"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            parentTrigger = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("requestedStartTime"))
                        {
                            requestedStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requestedEndTime"))
                        {
                            requestedEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RerunTumblingWindowTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, parentTrigger.Value, requestedStartTime, requestedEndTime, maxConcurrency);
        }
    }
}