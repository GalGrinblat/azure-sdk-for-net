// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </summary>
    public readonly partial struct VpnGatewayGeneration : IEquatable<VpnGatewayGeneration>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VpnGatewayGeneration"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnGatewayGeneration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string Generation1Value = "Generation1";
        private const string Generation2Value = "Generation2";

        /// <summary> None. </summary>
        public static VpnGatewayGeneration None { get; } = new VpnGatewayGeneration(NoneValue);
        /// <summary> Generation1. </summary>
        public static VpnGatewayGeneration Generation1 { get; } = new VpnGatewayGeneration(Generation1Value);
        /// <summary> Generation2. </summary>
        public static VpnGatewayGeneration Generation2 { get; } = new VpnGatewayGeneration(Generation2Value);
        /// <summary> Determines if two <see cref="VpnGatewayGeneration"/> values are the same. </summary>
        public static bool operator ==(VpnGatewayGeneration left, VpnGatewayGeneration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnGatewayGeneration"/> values are not the same. </summary>
        public static bool operator !=(VpnGatewayGeneration left, VpnGatewayGeneration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VpnGatewayGeneration"/>. </summary>
        public static implicit operator VpnGatewayGeneration(string value) => new VpnGatewayGeneration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnGatewayGeneration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnGatewayGeneration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}