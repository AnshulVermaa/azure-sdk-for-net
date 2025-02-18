// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Gets or sets maintenanceScope of the configuration. </summary>
    public readonly partial struct MaintenanceScope : IEquatable<MaintenanceScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MaintenanceScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MaintenanceScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HostValue = "Host";
        private const string OSImageValue = "OSImage";
        private const string ExtensionValue = "Extension";
        private const string InGuestPatchValue = "InGuestPatch";
        private const string SqlDBValue = "SQLDB";
        private const string SqlManagedInstanceValue = "SQLManagedInstance";

        /// <summary> This maintenance scope controls installation of azure platform updates i.e. services on physical nodes hosting customer VMs. </summary>
        public static MaintenanceScope Host { get; } = new MaintenanceScope(HostValue);
        /// <summary> This maintenance scope controls os image installation on VM/VMSS. </summary>
        public static MaintenanceScope OSImage { get; } = new MaintenanceScope(OSImageValue);
        /// <summary> This maintenance scope controls extension installation on VM/VMSS. </summary>
        public static MaintenanceScope Extension { get; } = new MaintenanceScope(ExtensionValue);
        /// <summary> This maintenance scope controls installation of windows and linux packages on VM/VMSS. </summary>
        public static MaintenanceScope InGuestPatch { get; } = new MaintenanceScope(InGuestPatchValue);
        /// <summary> This maintenance scope controls installation of SQL server platform updates. </summary>
        public static MaintenanceScope SqlDB { get; } = new MaintenanceScope(SqlDBValue);
        /// <summary> This maintenance scope controls installation of SQL managed instance platform update. </summary>
        public static MaintenanceScope SqlManagedInstance { get; } = new MaintenanceScope(SqlManagedInstanceValue);
        /// <summary> Determines if two <see cref="MaintenanceScope"/> values are the same. </summary>
        public static bool operator ==(MaintenanceScope left, MaintenanceScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MaintenanceScope"/> values are not the same. </summary>
        public static bool operator !=(MaintenanceScope left, MaintenanceScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MaintenanceScope"/>. </summary>
        public static implicit operator MaintenanceScope(string value) => new MaintenanceScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MaintenanceScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MaintenanceScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
