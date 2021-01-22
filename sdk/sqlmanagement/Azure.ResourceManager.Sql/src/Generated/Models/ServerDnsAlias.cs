// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A server DNS alias. </summary>
    public partial class ServerDnsAlias : ProxyResource
    {
        /// <summary> Initializes a new instance of ServerDnsAlias. </summary>
        public ServerDnsAlias()
        {
        }

        /// <summary> Initializes a new instance of ServerDnsAlias. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="azureDnsRecord"> The fully qualified DNS record for alias. </param>
        internal ServerDnsAlias(string id, string name, string type, string azureDnsRecord) : base(id, name, type)
        {
            AzureDnsRecord = azureDnsRecord;
        }

        /// <summary> The fully qualified DNS record for alias. </summary>
        public string AzureDnsRecord { get; }
    }
}