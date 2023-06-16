// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Replication agent details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationAgentDetailsTypeConverter))]
    public partial class ReplicationAgentDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationAgentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationAgentDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationAgentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationAgentDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationAgentDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReplicationAgentDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationAgentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationAgentDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).BiosId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("LastHeartbeatUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth.CreateFrom);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationAgentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationAgentDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).BiosId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("LastHeartbeatUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth.CreateFrom);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Replication agent details.
    [System.ComponentModel.TypeConverter(typeof(ReplicationAgentDetailsTypeConverter))]
    public partial interface IReplicationAgentDetails

    {

    }
}