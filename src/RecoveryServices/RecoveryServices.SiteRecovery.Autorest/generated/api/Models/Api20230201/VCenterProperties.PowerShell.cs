// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>vCenter properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(VCenterPropertiesTypeConverter))]
    public partial class VCenterProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VCenterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VCenterProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VCenterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VCenterProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VCenterProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VCenterProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VCenterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VCenterProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("InternalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InternalId = (string) content.GetValueForProperty("InternalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InternalId, global::System.Convert.ToString);
            }
            if (content.Contains("LastHeartbeat"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).LastHeartbeat = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeat",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).LastHeartbeat, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DiscoveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).DiscoveryStatus = (string) content.GetValueForProperty("DiscoveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).DiscoveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessServerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).ProcessServerId, global::System.Convert.ToString);
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InfrastructureId = (string) content.GetValueForProperty("InfrastructureId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InfrastructureId, global::System.Convert.ToString);
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).Port = (string) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).Port, global::System.Convert.ToString);
            }
            if (content.Contains("RunAsAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).RunAsAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricArmResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FabricArmResourceName = (string) content.GetValueForProperty("FabricArmResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FabricArmResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.VCenterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VCenterProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("InternalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InternalId = (string) content.GetValueForProperty("InternalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InternalId, global::System.Convert.ToString);
            }
            if (content.Contains("LastHeartbeat"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).LastHeartbeat = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeat",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).LastHeartbeat, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DiscoveryStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).DiscoveryStatus = (string) content.GetValueForProperty("DiscoveryStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).DiscoveryStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ProcessServerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).ProcessServerId, global::System.Convert.ToString);
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("InfrastructureId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InfrastructureId = (string) content.GetValueForProperty("InfrastructureId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).InfrastructureId, global::System.Convert.ToString);
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).Port = (string) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).Port, global::System.Convert.ToString);
            }
            if (content.Contains("RunAsAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).RunAsAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricArmResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FabricArmResourceName = (string) content.GetValueForProperty("FabricArmResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).FabricArmResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVCenterPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// vCenter properties.
    [System.ComponentModel.TypeConverter(typeof(VCenterPropertiesTypeConverter))]
    public partial interface IVCenterProperties

    {

    }
}