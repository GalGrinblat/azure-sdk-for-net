// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A private endpoint connection. </summary>
    public partial class PrivateEndpointConnection : ProxyResource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        public PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        internal PrivateEndpointConnection(string id, string name, string type, PrivateEndpointProperty privateEndpoint, PrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState, string provisioningState) : base(id, name, type)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        public PrivateEndpointProperty PrivateEndpoint { get; set; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public PrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
        /// <summary> State of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}