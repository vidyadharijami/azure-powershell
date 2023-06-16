// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support
{

    /// <summary>The resync state.</summary>
    public partial struct ResyncState :
        System.IEquatable<ResyncState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState PreparedForResynchronization = @"PreparedForResynchronization";

        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState StartedResynchronization = @"StartedResynchronization";

        /// <summary>the value for an instance of the <see cref="ResyncState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResyncState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResyncState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResyncState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResyncState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResyncState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResyncState && Equals((ResyncState)obj);
        }

        /// <summary>Returns hashCode for enum ResyncState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResyncState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResyncState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResyncState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResyncState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResyncState" />.</param>

        public static implicit operator ResyncState(string value)
        {
            return new ResyncState(value);
        }

        /// <summary>Implicit operator to convert ResyncState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResyncState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResyncState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResyncState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ResyncState e2)
        {
            return e2.Equals(e1);
        }
    }
}