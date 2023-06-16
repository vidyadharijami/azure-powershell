// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support
{

    /// <summary>The ALR option.</summary>
    public partial struct AlternateLocationRecoveryOption :
        System.IEquatable<AlternateLocationRecoveryOption>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption CreateVMIfNotFound = @"CreateVmIfNotFound";

        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption NoAction = @"NoAction";

        /// <summary>
        /// the value for an instance of the <see cref="AlternateLocationRecoveryOption" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="AlternateLocationRecoveryOption"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AlternateLocationRecoveryOption(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AlternateLocationRecoveryOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlternateLocationRecoveryOption" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AlternateLocationRecoveryOption(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AlternateLocationRecoveryOption</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type AlternateLocationRecoveryOption (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AlternateLocationRecoveryOption && Equals((AlternateLocationRecoveryOption)obj);
        }

        /// <summary>Returns hashCode for enum AlternateLocationRecoveryOption</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AlternateLocationRecoveryOption</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AlternateLocationRecoveryOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlternateLocationRecoveryOption" />.</param>

        public static implicit operator AlternateLocationRecoveryOption(string value)
        {
            return new AlternateLocationRecoveryOption(value);
        }

        /// <summary>Implicit operator to convert AlternateLocationRecoveryOption to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AlternateLocationRecoveryOption" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AlternateLocationRecoveryOption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AlternateLocationRecoveryOption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.AlternateLocationRecoveryOption e2)
        {
            return e2.Equals(e1);
        }
    }
}