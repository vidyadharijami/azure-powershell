// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>VMwareCbt provider specific container mapping details.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMwareCbtProtectionContainerMappingDetailsTypeConverter))]
    public partial class VMwareCbtProtectionContainerMappingDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareCbtProtectionContainerMappingDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareCbtProtectionContainerMappingDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareCbtProtectionContainerMappingDetails" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="VMwareCbtProtectionContainerMappingDetails" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareCbtProtectionContainerMappingDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultId = (string) content.GetValueForProperty("KeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultUri = (string) content.GetValueForProperty("KeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountSasSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountSasSecretName = (string) content.GetValueForProperty("StorageAccountSasSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountSasSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceBusConnectionStringSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ServiceBusConnectionStringSecretName = (string) content.GetValueForProperty("ServiceBusConnectionStringSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ServiceBusConnectionStringSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).TargetLocation = (string) content.GetValueForProperty("TargetLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).TargetLocation, global::System.Convert.ToString);
            }
            if (content.Contains("RoleSizeToNicCountMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).RoleSizeToNicCountMap = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsRoleSizeToNicCountMap) content.GetValueForProperty("RoleSizeToNicCountMap",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).RoleSizeToNicCountMap, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetailsRoleSizeToNicCountMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExcludedSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ExcludedSku = (string[]) content.GetValueForProperty("ExcludedSku",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ExcludedSku, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMappingProviderSpecificDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMappingProviderSpecificDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareCbtProtectionContainerMappingDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultId = (string) content.GetValueForProperty("KeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultUri = (string) content.GetValueForProperty("KeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).KeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountSasSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountSasSecretName = (string) content.GetValueForProperty("StorageAccountSasSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).StorageAccountSasSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceBusConnectionStringSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ServiceBusConnectionStringSecretName = (string) content.GetValueForProperty("ServiceBusConnectionStringSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ServiceBusConnectionStringSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).TargetLocation = (string) content.GetValueForProperty("TargetLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).TargetLocation, global::System.Convert.ToString);
            }
            if (content.Contains("RoleSizeToNicCountMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).RoleSizeToNicCountMap = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsRoleSizeToNicCountMap) content.GetValueForProperty("RoleSizeToNicCountMap",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).RoleSizeToNicCountMap, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtProtectionContainerMappingDetailsRoleSizeToNicCountMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExcludedSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ExcludedSku = (string[]) content.GetValueForProperty("ExcludedSku",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtProtectionContainerMappingDetailsInternal)this).ExcludedSku, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMappingProviderSpecificDetailsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMappingProviderSpecificDetailsInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMwareCbt provider specific container mapping details.
    [System.ComponentModel.TypeConverter(typeof(VMwareCbtProtectionContainerMappingDetailsTypeConverter))]
    public partial interface IVMwareCbtProtectionContainerMappingDetails

    {

    }
}