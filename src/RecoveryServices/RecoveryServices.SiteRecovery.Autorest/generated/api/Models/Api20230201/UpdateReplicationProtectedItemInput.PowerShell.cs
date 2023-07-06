// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Update replication protected item input.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateReplicationProtectedItemInputTypeConverter))]
    public partial class UpdateReplicationProtectedItemInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateReplicationProtectedItemInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateReplicationProtectedItemInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateReplicationProtectedItemInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="UpdateReplicationProtectedItemInput" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateReplicationProtectedItemInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInputPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LicenseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.LicenseType.CreateFrom);
            }
            if (content.Contains("RecoveryAzureVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMName = (string) content.GetValueForProperty("RecoveryAzureVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAzureVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMSize = (string) content.GetValueForProperty("RecoveryAzureVMSize",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedRecoveryAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedRecoveryAzureNetworkId = (string) content.GetValueForProperty("SelectedRecoveryAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedRecoveryAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedTfoAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedTfoAzureNetworkId = (string) content.GetValueForProperty("SelectedTfoAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedTfoAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedSourceNicId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedSourceNicId = (string) content.GetValueForProperty("SelectedSourceNicId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedSourceNicId, global::System.Convert.ToString);
            }
            if (content.Contains("EnableRdpOnTargetOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).EnableRdpOnTargetOption = (string) content.GetValueForProperty("EnableRdpOnTargetOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).EnableRdpOnTargetOption, global::System.Convert.ToString);
            }
            if (content.Contains("VMNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).VMNic = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicInputDetails[]) content.GetValueForProperty("VMNic",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).VMNic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMNicInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryAvailabilitySetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAvailabilitySetId = (string) content.GetValueForProperty("RecoveryAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAvailabilitySetId, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemProviderInput) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemProviderInputTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateReplicationProtectedItemInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemInputPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LicenseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.LicenseType.CreateFrom);
            }
            if (content.Contains("RecoveryAzureVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMName = (string) content.GetValueForProperty("RecoveryAzureVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryAzureVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMSize = (string) content.GetValueForProperty("RecoveryAzureVMSize",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedRecoveryAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedRecoveryAzureNetworkId = (string) content.GetValueForProperty("SelectedRecoveryAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedRecoveryAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedTfoAzureNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedTfoAzureNetworkId = (string) content.GetValueForProperty("SelectedTfoAzureNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedTfoAzureNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SelectedSourceNicId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedSourceNicId = (string) content.GetValueForProperty("SelectedSourceNicId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).SelectedSourceNicId, global::System.Convert.ToString);
            }
            if (content.Contains("EnableRdpOnTargetOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).EnableRdpOnTargetOption = (string) content.GetValueForProperty("EnableRdpOnTargetOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).EnableRdpOnTargetOption, global::System.Convert.ToString);
            }
            if (content.Contains("VMNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).VMNic = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicInputDetails[]) content.GetValueForProperty("VMNic",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).VMNic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMNicInputDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryAvailabilitySetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAvailabilitySetId = (string) content.GetValueForProperty("RecoveryAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).RecoveryAvailabilitySetId, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemProviderInput) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateReplicationProtectedItemInputInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UpdateReplicationProtectedItemProviderInputTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Update replication protected item input.
    [System.ComponentModel.TypeConverter(typeof(UpdateReplicationProtectedItemInputTypeConverter))]
    public partial interface IUpdateReplicationProtectedItemInput

    {

    }
}