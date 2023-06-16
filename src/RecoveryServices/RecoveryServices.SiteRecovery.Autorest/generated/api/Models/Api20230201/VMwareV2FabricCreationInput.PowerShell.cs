// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>VMwareV2 fabric provider specific settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMwareV2FabricCreationInputTypeConverter))]
    public partial class VMwareV2FabricCreationInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareV2FabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareV2FabricCreationInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareV2FabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareV2FabricCreationInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareV2FabricCreationInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMwareV2FabricCreationInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareV2FabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareV2FabricCreationInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VmwareSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).VmwareSiteId = (string) content.GetValueForProperty("VmwareSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).VmwareSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("PhysicalSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).PhysicalSiteId = (string) content.GetValueForProperty("PhysicalSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).PhysicalSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationSolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).MigrationSolutionId = (string) content.GetValueForProperty("MigrationSolutionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).MigrationSolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationScenario"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInputInternal)this).ReplicationScenario = (string) content.GetValueForProperty("ReplicationScenario",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInputInternal)this).ReplicationScenario, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareV2FabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareV2FabricCreationInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VmwareSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).VmwareSiteId = (string) content.GetValueForProperty("VmwareSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).VmwareSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("PhysicalSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).PhysicalSiteId = (string) content.GetValueForProperty("PhysicalSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).PhysicalSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationSolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).MigrationSolutionId = (string) content.GetValueForProperty("MigrationSolutionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareV2FabricCreationInputInternal)this).MigrationSolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationScenario"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInputInternal)this).ReplicationScenario = (string) content.GetValueForProperty("ReplicationScenario",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInputInternal)this).ReplicationScenario, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMwareV2 fabric provider specific settings.
    [System.ComponentModel.TypeConverter(typeof(VMwareV2FabricCreationInputTypeConverter))]
    public partial interface IVMwareV2FabricCreationInput

    {

    }
}