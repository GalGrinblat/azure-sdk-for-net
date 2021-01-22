// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Compute OS Type. </summary>
    public readonly partial struct OsType : IEquatable<OsType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OsType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Linux. </summary>
        public static OsType Linux { get; } = new OsType(LinuxValue);
        /// <summary> Windows. </summary>
        public static OsType Windows { get; } = new OsType(WindowsValue);
        /// <summary> Determines if two <see cref="OsType"/> values are the same. </summary>
        public static bool operator ==(OsType left, OsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OsType"/> values are not the same. </summary>
        public static bool operator !=(OsType left, OsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OsType"/>. </summary>
        public static implicit operator OsType(string value) => new OsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}