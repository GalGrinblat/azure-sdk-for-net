// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Container network interface configuration child resource. </summary>
    public partial class ContainerNetworkInterfaceConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of ContainerNetworkInterfaceConfiguration. </summary>
        public ContainerNetworkInterfaceConfiguration()
        {
            IpConfigurations = new ChangeTrackingList<IPConfigurationProfile>();
            ContainerNetworkInterfaces = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of ContainerNetworkInterfaceConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="type"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> A list of ip configurations of the container network interface configuration. </param>
        /// <param name="containerNetworkInterfaces"> A list of container network interfaces created from this container network interface configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface configuration resource. </param>
        internal ContainerNetworkInterfaceConfiguration(string id, string name, string type, string etag, IList<IPConfigurationProfile> ipConfigurations, IList<SubResource> containerNetworkInterfaces, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Type = type;
            Etag = etag;
            IpConfigurations = ipConfigurations;
            ContainerNetworkInterfaces = containerNetworkInterfaces;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sub Resource type. </summary>
        public string Type { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A list of ip configurations of the container network interface configuration. </summary>
        public IList<IPConfigurationProfile> IpConfigurations { get; }
        /// <summary> A list of container network interfaces created from this container network interface configuration. </summary>
        public IList<SubResource> ContainerNetworkInterfaces { get; }
        /// <summary> The provisioning state of the container network interface configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}