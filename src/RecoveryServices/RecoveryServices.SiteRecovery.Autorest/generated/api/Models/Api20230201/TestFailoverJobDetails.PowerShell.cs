// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>This class represents the details for a test failover job.</summary>
    [System.ComponentModel.TypeConverter(typeof(TestFailoverJobDetailsTypeConverter))]
    public partial class TestFailoverJobDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TestFailoverJobDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TestFailoverJobDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TestFailoverJobDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TestFailoverJobDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TestFailoverJobDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TestFailoverStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).TestFailoverStatus = (string) content.GetValueForProperty("TestFailoverStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).TestFailoverStatus, global::System.Convert.ToString);
            }
            if (content.Contains("Comment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).Comment = (string) content.GetValueForProperty("Comment",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).Comment, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkName = (string) content.GetValueForProperty("NetworkName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkFriendlyName = (string) content.GetValueForProperty("NetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkType = (string) content.GetValueForProperty("NetworkType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).ProtectedItemDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFailoverReplicationProtectedItemDetails[]) content.GetValueForProperty("ProtectedItemDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).ProtectedItemDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFailoverReplicationProtectedItemDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FailoverReplicationProtectedItemDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).AffectedObjectDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsAffectedObjectDetails) content.GetValueForProperty("AffectedObjectDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).AffectedObjectDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobDetailsAffectedObjectDetailsTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TestFailoverJobDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TestFailoverStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).TestFailoverStatus = (string) content.GetValueForProperty("TestFailoverStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).TestFailoverStatus, global::System.Convert.ToString);
            }
            if (content.Contains("Comment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).Comment = (string) content.GetValueForProperty("Comment",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).Comment, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkName = (string) content.GetValueForProperty("NetworkName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkFriendlyName = (string) content.GetValueForProperty("NetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkType = (string) content.GetValueForProperty("NetworkType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).NetworkType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).ProtectedItemDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFailoverReplicationProtectedItemDetails[]) content.GetValueForProperty("ProtectedItemDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverJobDetailsInternal)this).ProtectedItemDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFailoverReplicationProtectedItemDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FailoverReplicationProtectedItemDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).AffectedObjectDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsAffectedObjectDetails) content.GetValueForProperty("AffectedObjectDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobDetailsInternal)this).AffectedObjectDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobDetailsAffectedObjectDetailsTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This class represents the details for a test failover job.
    [System.ComponentModel.TypeConverter(typeof(TestFailoverJobDetailsTypeConverter))]
    public partial interface ITestFailoverJobDetails

    {

    }
}