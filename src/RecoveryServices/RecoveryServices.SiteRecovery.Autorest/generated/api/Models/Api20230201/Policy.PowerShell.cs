// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Protection profile details.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyTypeConverter))]
    public partial class Policy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.Policy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Policy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.Policy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Policy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Policy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Policy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.Policy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Policy(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetails) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyProviderSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetailInstanceType = (string) content.GetValueForProperty("ProviderSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.Policy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Policy(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetails) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyProviderSpecificDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderSpecificDetailInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetailInstanceType = (string) content.GetValueForProperty("ProviderSpecificDetailInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyInternal)this).ProviderSpecificDetailInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Protection profile details.
    [System.ComponentModel.TypeConverter(typeof(PolicyTypeConverter))]
    public partial interface IPolicy

    {

    }
}