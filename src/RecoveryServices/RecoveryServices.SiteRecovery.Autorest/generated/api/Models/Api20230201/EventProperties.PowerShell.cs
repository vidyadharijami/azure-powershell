// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>The properties of a monitoring event.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventPropertiesTypeConverter))]
    public partial class EventProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProviderSpecificDetails) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProviderSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventSpecificDetails) content.GetValueForProperty("EventSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventCode = (string) content.GetValueForProperty("EventCode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventCode, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventType = (string) content.GetValueForProperty("EventType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventType, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectFriendlyName = (string) content.GetValueForProperty("AffectedObjectFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectCorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectCorrelationId = (string) content.GetValueForProperty("AffectedObjectCorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectCorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("TimeOfOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).TimeOfOccurrence = (global::System.DateTime?) content.GetValueForProperty("TimeOfOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).TimeOfOccurrence, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("EventSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetailInstanceType = (string) content.GetValueForProperty("EventSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetailInstanceType = (string) content.GetValueForProperty("ProviderSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProviderSpecificDetails) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventProviderSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventSpecificDetails) content.GetValueForProperty("EventSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EventSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventCode = (string) content.GetValueForProperty("EventCode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventCode, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventType = (string) content.GetValueForProperty("EventType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventType, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectFriendlyName = (string) content.GetValueForProperty("AffectedObjectFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("AffectedObjectCorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectCorrelationId = (string) content.GetValueForProperty("AffectedObjectCorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).AffectedObjectCorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("TimeOfOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).TimeOfOccurrence = (global::System.DateTime?) content.GetValueForProperty("TimeOfOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).TimeOfOccurrence, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("EventSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetailInstanceType = (string) content.GetValueForProperty("EventSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).EventSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetailInstanceType = (string) content.GetValueForProperty("ProviderSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventPropertiesInternal)this).ProviderSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEventProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a monitoring event.
    [System.ComponentModel.TypeConverter(typeof(EventPropertiesTypeConverter))]
    public partial interface IEventProperties

    {

    }
}