// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class NotebookMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kernelspec))
            {
                writer.WritePropertyName("kernelspec");
                writer.WriteObjectValue(Kernelspec);
            }
            if (Optional.IsDefined(LanguageInfo))
            {
                if (LanguageInfo != null)
                {
                    writer.WritePropertyName("language_info");
                    writer.WriteObjectValue(LanguageInfo);
                }
                else
                {
                    writer.WriteNull("language_info");
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static NotebookMetadata DeserializeNotebookMetadata(JsonElement element)
        {
            Optional<NotebookKernelSpec> kernelspec = default;
            Optional<NotebookLanguageInfo> languageInfo = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kernelspec"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kernelspec = NotebookKernelSpec.DeserializeNotebookKernelSpec(property.Value);
                    continue;
                }
                if (property.NameEquals("language_info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        languageInfo = null;
                        continue;
                    }
                    languageInfo = NotebookLanguageInfo.DeserializeNotebookLanguageInfo(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new NotebookMetadata(kernelspec.Value, languageInfo.Value, additionalProperties);
        }
    }
}