// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>InMageRcm fabric provider specific settings.</summary>
    public partial class InMageRcmFabricCreationInput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageRcmFabricCreationInput.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageRcmFabricCreationInput.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageRcmFabricCreationInput FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json ? new InMageRcmFabricCreationInput(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject into a new instance of <see cref="InMageRcmFabricCreationInput" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InMageRcmFabricCreationInput(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __fabricSpecificCreationInput = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificCreationInput(json);
            {_sourceAgentIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("sourceAgentIdentity"), out var __jsonSourceAgentIdentity) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IdentityProviderInput.FromJson(__jsonSourceAgentIdentity) : SourceAgentIdentity;}
            {_vmwareSiteId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("vmwareSiteId"), out var __jsonVmwareSiteId) ? (string)__jsonVmwareSiteId : (string)VmwareSiteId;}
            {_physicalSiteId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("physicalSiteId"), out var __jsonPhysicalSiteId) ? (string)__jsonPhysicalSiteId : (string)PhysicalSiteId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InMageRcmFabricCreationInput" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InMageRcmFabricCreationInput" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __fabricSpecificCreationInput?.ToJson(container, serializationMode);
            AddIf( null != this._sourceAgentIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._sourceAgentIdentity.ToJson(null,serializationMode) : null, "sourceAgentIdentity" ,container.Add );
            AddIf( null != (((object)this._vmwareSiteId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._vmwareSiteId.ToString()) : null, "vmwareSiteId" ,container.Add );
            AddIf( null != (((object)this._physicalSiteId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._physicalSiteId.ToString()) : null, "physicalSiteId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}