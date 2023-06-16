// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>VMwareCbt disk input.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMwareCbtDiskInputTypeConverter))]
    public partial class VMwareCbtDiskInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtDiskInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareCbtDiskInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtDiskInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareCbtDiskInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareCbtDiskInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMwareCbtDiskInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtDiskInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareCbtDiskInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskId, global::System.Convert.ToString);
            }
            if (content.Contains("DiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.DiskAccountType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.DiskAccountType.CreateFrom);
            }
            if (content.Contains("IsOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).IsOSDisk = (string) content.GetValueForProperty("IsOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).IsOSDisk, global::System.Convert.ToString);
            }
            if (content.Contains("LogStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("LogStorageAccountSasSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountSasSecretName = (string) content.GetValueForProperty("LogStorageAccountSasSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountSasSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VMwareCbtDiskInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareCbtDiskInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskId = (string) content.GetValueForProperty("DiskId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskId, global::System.Convert.ToString);
            }
            if (content.Contains("DiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskType = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.DiskAccountType?) content.GetValueForProperty("DiskType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskType, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.DiskAccountType.CreateFrom);
            }
            if (content.Contains("IsOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).IsOSDisk = (string) content.GetValueForProperty("IsOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).IsOSDisk, global::System.Convert.ToString);
            }
            if (content.Contains("LogStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("LogStorageAccountSasSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountSasSecretName = (string) content.GetValueForProperty("LogStorageAccountSasSecretName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).LogStorageAccountSasSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMwareCbtDiskInputInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMwareCbt disk input.
    [System.ComponentModel.TypeConverter(typeof(VMwareCbtDiskInputTypeConverter))]
    public partial interface IVMwareCbtDiskInput

    {

    }
}