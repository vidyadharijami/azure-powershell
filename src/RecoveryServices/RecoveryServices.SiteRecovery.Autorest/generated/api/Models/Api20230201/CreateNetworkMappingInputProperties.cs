// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Common input details for network mapping operation.</summary>
    public partial class CreateNetworkMappingInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateNetworkMappingInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateNetworkMappingInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FabricSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInput _fabricSpecificDetail;

        /// <summary>Fabric specific input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInput FabricSpecificDetail { get => (this._fabricSpecificDetail = this._fabricSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificCreateNetworkMappingInput()); set => this._fabricSpecificDetail = value; }

        /// <summary>The instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string FabricSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInputInternal)FabricSpecificDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInputInternal)FabricSpecificDetail).InstanceType = value ?? null; }

        /// <summary>Internal Acessors for FabricSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInput Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateNetworkMappingInputPropertiesInternal.FabricSpecificDetail { get => (this._fabricSpecificDetail = this._fabricSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificCreateNetworkMappingInput()); set { {_fabricSpecificDetail = value;} } }

        /// <summary>Backing field for <see cref="RecoveryFabricName" /> property.</summary>
        private string _recoveryFabricName;

        /// <summary>Recovery fabric Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryFabricName { get => this._recoveryFabricName; set => this._recoveryFabricName = value; }

        /// <summary>Backing field for <see cref="RecoveryNetworkId" /> property.</summary>
        private string _recoveryNetworkId;

        /// <summary>Recovery network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryNetworkId { get => this._recoveryNetworkId; set => this._recoveryNetworkId = value; }

        /// <summary>Creates an new <see cref="CreateNetworkMappingInputProperties" /> instance.</summary>
        public CreateNetworkMappingInputProperties()
        {

        }
    }
    /// Common input details for network mapping operation.
    public partial interface ICreateNetworkMappingInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string FabricSpecificDetailInstanceType { get; set; }
        /// <summary>Recovery fabric Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery fabric Name.",
        SerializedName = @"recoveryFabricName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryFabricName { get; set; }
        /// <summary>Recovery network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Recovery network Id.",
        SerializedName = @"recoveryNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNetworkId { get; set; }

    }
    /// Common input details for network mapping operation.
    internal partial interface ICreateNetworkMappingInputPropertiesInternal

    {
        /// <summary>Fabric specific input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreateNetworkMappingInput FabricSpecificDetail { get; set; }
        /// <summary>The instance type.</summary>
        string FabricSpecificDetailInstanceType { get; set; }
        /// <summary>Recovery fabric Name.</summary>
        string RecoveryFabricName { get; set; }
        /// <summary>Recovery network Id.</summary>
        string RecoveryNetworkId { get; set; }

    }
}