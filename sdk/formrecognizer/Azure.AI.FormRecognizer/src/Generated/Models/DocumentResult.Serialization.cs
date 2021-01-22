// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class DocumentResult
    {
        internal static DocumentResult DeserializeDocumentResult(JsonElement element)
        {
            string docType = default;
            Optional<Guid> modelId = default;
            IReadOnlyList<int> pageRange = default;
            Optional<float> docTypeConfidence = default;
            IReadOnlyDictionary<string, FieldValue_internal> fields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docType"))
                {
                    docType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("pageRange"))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    pageRange = array;
                    continue;
                }
                if (property.NameEquals("docTypeConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    docTypeConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    Dictionary<string, FieldValue_internal> dictionary = new Dictionary<string, FieldValue_internal>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, FieldValue_internal.DeserializeFieldValue_internal(property0.Value));
                        }
                    }
                    fields = dictionary;
                    continue;
                }
            }
            return new DocumentResult(docType, Optional.ToNullable(modelId), pageRange, Optional.ToNullable(docTypeConfidence), fields);
        }
    }
}