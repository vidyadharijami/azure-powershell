// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Site details provided during the time of site creation.</summary>
    public partial class FabricCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputInternal
    {

        /// <summary>Fabric provider specific creation input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInput CustomDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputPropertiesInternal)Property).CustomDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputPropertiesInternal)Property).CustomDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricCreationInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputProperties _property;

        /// <summary>Fabric creation input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricCreationInputProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="FabricCreationInput" /> instance.</summary>
        public FabricCreationInput()
        {

        }
    }
    /// Site details provided during the time of site creation.
    public partial interface IFabricCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Fabric provider specific creation input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fabric provider specific creation input.",
        SerializedName = @"customDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInput CustomDetail { get; set; }

    }
    /// Site details provided during the time of site creation.
    internal partial interface IFabricCreationInputInternal

    {
        /// <summary>Fabric provider specific creation input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricSpecificCreationInput CustomDetail { get; set; }
        /// <summary>Fabric creation input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabricCreationInputProperties Property { get; set; }

    }
}