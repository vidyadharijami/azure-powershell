// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support
{

    /// <summary>Whether Multi VM group is auto created or specified by user.</summary>
    public partial struct MultiVMGroupCreateOption :
        System.IEquatable<MultiVMGroupCreateOption>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption AutoCreated = @"AutoCreated";

        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption UserSpecified = @"UserSpecified";

        /// <summary>the value for an instance of the <see cref="MultiVMGroupCreateOption" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MultiVMGroupCreateOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MultiVMGroupCreateOption" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MultiVMGroupCreateOption(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MultiVMGroupCreateOption</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MultiVMGroupCreateOption (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MultiVMGroupCreateOption && Equals((MultiVMGroupCreateOption)obj);
        }

        /// <summary>Returns hashCode for enum MultiVMGroupCreateOption</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MultiVMGroupCreateOption"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MultiVMGroupCreateOption(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MultiVMGroupCreateOption</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MultiVMGroupCreateOption</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MultiVMGroupCreateOption" />.</param>

        public static implicit operator MultiVMGroupCreateOption(string value)
        {
            return new MultiVMGroupCreateOption(value);
        }

        /// <summary>Implicit operator to convert MultiVMGroupCreateOption to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MultiVMGroupCreateOption" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MultiVMGroupCreateOption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MultiVMGroupCreateOption</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e1, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.MultiVMGroupCreateOption e2)
        {
            return e2.Equals(e1);
        }
    }
}