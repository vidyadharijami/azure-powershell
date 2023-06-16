// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Recovery disk encryption info (BEK and KEK).</summary>
    [System.ComponentModel.TypeConverter(typeof(DiskEncryptionInfoTypeConverter))]
    public partial class DiskEncryptionInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiskEncryptionInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiskEncryptionInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiskEncryptionInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IKeyEncryptionKeyInfo) content.GetValueForProperty("KeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiskEncryptionInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IKeyEncryptionKeyInfo) content.GetValueForProperty("KeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskEncryptionKeyInfoSecretIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DiskEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyInfoKeyVaultResourceArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiskEncryptionInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiskEncryptionInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery disk encryption info (BEK and KEK).
    [System.ComponentModel.TypeConverter(typeof(DiskEncryptionInfoTypeConverter))]
    public partial interface IDiskEncryptionInfo

    {

    }
}