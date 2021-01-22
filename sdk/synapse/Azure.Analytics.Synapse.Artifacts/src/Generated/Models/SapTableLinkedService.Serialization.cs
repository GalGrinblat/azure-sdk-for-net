// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SapTableLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server");
                writer.WriteObjectValue(Server);
            }
            if (Optional.IsDefined(SystemNumber))
            {
                writer.WritePropertyName("systemNumber");
                writer.WriteObjectValue(SystemNumber);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteObjectValue(ClientId);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteObjectValue(Language);
            }
            if (Optional.IsDefined(SystemId))
            {
                writer.WritePropertyName("systemId");
                writer.WriteObjectValue(SystemId);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName");
                writer.WriteObjectValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(MessageServer))
            {
                writer.WritePropertyName("messageServer");
                writer.WriteObjectValue(MessageServer);
            }
            if (Optional.IsDefined(MessageServerService))
            {
                writer.WritePropertyName("messageServerService");
                writer.WriteObjectValue(MessageServerService);
            }
            if (Optional.IsDefined(SncMode))
            {
                writer.WritePropertyName("sncMode");
                writer.WriteObjectValue(SncMode);
            }
            if (Optional.IsDefined(SncMyName))
            {
                writer.WritePropertyName("sncMyName");
                writer.WriteObjectValue(SncMyName);
            }
            if (Optional.IsDefined(SncPartnerName))
            {
                writer.WritePropertyName("sncPartnerName");
                writer.WriteObjectValue(SncPartnerName);
            }
            if (Optional.IsDefined(SncLibraryPath))
            {
                writer.WritePropertyName("sncLibraryPath");
                writer.WriteObjectValue(SncLibraryPath);
            }
            if (Optional.IsDefined(SncQop))
            {
                writer.WritePropertyName("sncQop");
                writer.WriteObjectValue(SncQop);
            }
            if (Optional.IsDefined(LogonGroup))
            {
                writer.WritePropertyName("logonGroup");
                writer.WriteObjectValue(LogonGroup);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SapTableLinkedService DeserializeSapTableLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            Optional<object> server = default;
            Optional<object> systemNumber = default;
            Optional<object> clientId = default;
            Optional<object> language = default;
            Optional<object> systemId = default;
            Optional<object> userName = default;
            Optional<SecretBase> password = default;
            Optional<object> messageServer = default;
            Optional<object> messageServerService = default;
            Optional<object> sncMode = default;
            Optional<object> sncMyName = default;
            Optional<object> sncPartnerName = default;
            Optional<object> sncLibraryPath = default;
            Optional<object> sncQop = default;
            Optional<object> logonGroup = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
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
                        if (property0.NameEquals("server"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            server = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemNumber"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemNumber = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("language"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            language = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("userName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageServer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageServer = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("messageServerService"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageServerService = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMyName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncMyName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncPartnerName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncPartnerName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncLibraryPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncLibraryPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncQop"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncQop = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("logonGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logonGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapTableLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, server.Value, systemNumber.Value, clientId.Value, language.Value, systemId.Value, userName.Value, password.Value, messageServer.Value, messageServerService.Value, sncMode.Value, sncMyName.Value, sncPartnerName.Value, sncLibraryPath.Value, sncQop.Value, logonGroup.Value, encryptedCredential.Value);
        }
    }
}