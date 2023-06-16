// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>InMage specific protection profile details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMagePolicyDetailsTypeConverter))]
    public partial class InMagePolicyDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.InMagePolicyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMagePolicyDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.InMagePolicyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMagePolicyDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMagePolicyDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InMagePolicyDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.InMagePolicyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMagePolicyDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointThresholdInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointThresholdInMinute = (int?) content.GetValueForProperty("RecoveryPointThresholdInMinute",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointThresholdInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointHistory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointHistory = (int?) content.GetValueForProperty("RecoveryPointHistory",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AppConsistentFrequencyInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).AppConsistentFrequencyInMinute = (int?) content.GetValueForProperty("AppConsistentFrequencyInMinute",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).AppConsistentFrequencyInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MultiVMSyncStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).MultiVMSyncStatus = (string) content.GetValueForProperty("MultiVMSyncStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).MultiVMSyncStatus, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.InMagePolicyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMagePolicyDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointThresholdInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointThresholdInMinute = (int?) content.GetValueForProperty("RecoveryPointThresholdInMinute",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointThresholdInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointHistory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointHistory = (int?) content.GetValueForProperty("RecoveryPointHistory",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).RecoveryPointHistory, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AppConsistentFrequencyInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).AppConsistentFrequencyInMinute = (int?) content.GetValueForProperty("AppConsistentFrequencyInMinute",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).AppConsistentFrequencyInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MultiVMSyncStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).MultiVMSyncStatus = (string) content.GetValueForProperty("MultiVMSyncStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMagePolicyDetailsInternal)this).MultiVMSyncStatus, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMage specific protection profile details.
    [System.ComponentModel.TypeConverter(typeof(InMagePolicyDetailsTypeConverter))]
    public partial interface IInMagePolicyDetails

    {

    }
}