// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>
    /// This class contains the minimal job details required to navigate to the desired drill down.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(JobEntityTypeConverter))]
    public partial class JobEntity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobEntity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobEntity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobEntity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobEntity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobEntity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobEntity" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobEntity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobEntity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobId = (string) content.GetValueForProperty("JobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobId, global::System.Convert.ToString);
            }
            if (content.Contains("JobFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobFriendlyName = (string) content.GetValueForProperty("JobFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectId = (string) content.GetValueForProperty("TargetObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectName = (string) content.GetValueForProperty("TargetObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetInstanceType = (string) content.GetValueForProperty("TargetInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetInstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("JobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobScenarioName = (string) content.GetValueForProperty("JobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobScenarioName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.JobEntity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobEntity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("JobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobId = (string) content.GetValueForProperty("JobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobId, global::System.Convert.ToString);
            }
            if (content.Contains("JobFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobFriendlyName = (string) content.GetValueForProperty("JobFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectId = (string) content.GetValueForProperty("TargetObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectName = (string) content.GetValueForProperty("TargetObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetInstanceType = (string) content.GetValueForProperty("TargetInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).TargetInstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("JobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobScenarioName = (string) content.GetValueForProperty("JobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJobEntityInternal)this).JobScenarioName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This class contains the minimal job details required to navigate to the desired drill down.
    [System.ComponentModel.TypeConverter(typeof(JobEntityTypeConverter))]
    public partial interface IJobEntity

    {

    }
}