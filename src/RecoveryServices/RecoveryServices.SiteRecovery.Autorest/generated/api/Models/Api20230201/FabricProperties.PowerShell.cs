// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Fabric properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(FabricPropertiesTypeConverter))]
    public partial class FabricProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FabricProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FabricProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FabricProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEncryptionDetails) content.GetValueForProperty("EncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RolloverEncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEncryptionDetails) content.GetValueForProperty("RolloverEncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificDetails) content.GetValueForProperty("CustomDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("InternalIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).InternalIdentifier = (string) content.GetValueForProperty("InternalIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).InternalIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("BcdrState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).BcdrState = (string) content.GetValueForProperty("BcdrState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).BcdrState, global::System.Convert.ToString);
            }
            if (content.Contains("HealthErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).HealthErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).HealthErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekState = (string) content.GetValueForProperty("EncryptionDetailKekState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertThumbprint = (string) content.GetValueForProperty("EncryptionDetailKekCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekCertExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertExpiryDate = (global::System.DateTime?) content.GetValueForProperty("EncryptionDetailKekCertExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RolloverEncryptionDetailKekState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekState = (string) content.GetValueForProperty("RolloverEncryptionDetailKekState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekState, global::System.Convert.ToString);
            }
            if (content.Contains("RolloverEncryptionDetailKekCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertThumbprint = (string) content.GetValueForProperty("RolloverEncryptionDetailKekCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("RolloverEncryptionDetailKekCertExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertExpiryDate = (global::System.DateTime?) content.GetValueForProperty("RolloverEncryptionDetailKekCertExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetailInstanceType = (string) content.GetValueForProperty("CustomDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FabricProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEncryptionDetails) content.GetValueForProperty("EncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RolloverEncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEncryptionDetails) content.GetValueForProperty("RolloverEncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificDetails) content.GetValueForProperty("CustomDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("InternalIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).InternalIdentifier = (string) content.GetValueForProperty("InternalIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).InternalIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("BcdrState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).BcdrState = (string) content.GetValueForProperty("BcdrState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).BcdrState, global::System.Convert.ToString);
            }
            if (content.Contains("HealthErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).HealthErrorDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[]) content.GetValueForProperty("HealthErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).HealthErrorDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HealthErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("Health"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).Health = (string) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).Health, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekState = (string) content.GetValueForProperty("EncryptionDetailKekState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekState, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertThumbprint = (string) content.GetValueForProperty("EncryptionDetailKekCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekCertExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertExpiryDate = (global::System.DateTime?) content.GetValueForProperty("EncryptionDetailKekCertExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).EncryptionDetailKekCertExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RolloverEncryptionDetailKekState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekState = (string) content.GetValueForProperty("RolloverEncryptionDetailKekState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekState, global::System.Convert.ToString);
            }
            if (content.Contains("RolloverEncryptionDetailKekCertThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertThumbprint = (string) content.GetValueForProperty("RolloverEncryptionDetailKekCertThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertThumbprint, global::System.Convert.ToString);
            }
            if (content.Contains("RolloverEncryptionDetailKekCertExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertExpiryDate = (global::System.DateTime?) content.GetValueForProperty("RolloverEncryptionDetailKekCertExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).RolloverEncryptionDetailKekCertExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetailInstanceType = (string) content.GetValueForProperty("CustomDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricPropertiesInternal)this).CustomDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FabricProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FabricProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Fabric properties.
    [System.ComponentModel.TypeConverter(typeof(FabricPropertiesTypeConverter))]
    public partial interface IFabricProperties

    {

    }
}