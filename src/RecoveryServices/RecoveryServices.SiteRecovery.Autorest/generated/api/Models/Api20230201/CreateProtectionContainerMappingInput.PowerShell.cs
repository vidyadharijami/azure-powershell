// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Configure pairing input.</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateProtectionContainerMappingInputTypeConverter))]
    public partial class CreateProtectionContainerMappingInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateProtectionContainerMappingInput(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInputPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetProtectionContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).TargetProtectionContainerId = (string) content.GetValueForProperty("TargetProtectionContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).TargetProtectionContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).ProviderSpecificInput = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProviderSpecificContainerMappingInput) content.GetValueForProperty("ProviderSpecificInput",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).ProviderSpecificInput, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationProviderSpecificContainerMappingInputTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateProtectionContainerMappingInput(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInputPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetProtectionContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).TargetProtectionContainerId = (string) content.GetValueForProperty("TargetProtectionContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).TargetProtectionContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificInput"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).ProviderSpecificInput = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProviderSpecificContainerMappingInput) content.GetValueForProperty("ProviderSpecificInput",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInputInternal)this).ProviderSpecificInput, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationProviderSpecificContainerMappingInputTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateProtectionContainerMappingInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateProtectionContainerMappingInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateProtectionContainerMappingInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateProtectionContainerMappingInput" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="CreateProtectionContainerMappingInput" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateProtectionContainerMappingInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Configure pairing input.
    [System.ComponentModel.TypeConverter(typeof(CreateProtectionContainerMappingInputTypeConverter))]
    public partial interface ICreateProtectionContainerMappingInput

    {

    }
}