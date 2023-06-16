// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Policy update properties.</summary>
    public partial class UpdatePolicyInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdatePolicyInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdatePolicyInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ReplicationProviderSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput _replicationProviderSetting;

        /// <summary>The ReplicationProviderSettings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput ReplicationProviderSetting { get => (this._replicationProviderSetting = this._replicationProviderSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyProviderSpecificInput()); set => this._replicationProviderSetting = value; }

        /// <summary>Creates an new <see cref="UpdatePolicyInputProperties" /> instance.</summary>
        public UpdatePolicyInputProperties()
        {

        }
    }
    /// Policy update properties.
    public partial interface IUpdatePolicyInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The ReplicationProviderSettings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ReplicationProviderSettings.",
        SerializedName = @"replicationProviderSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput ReplicationProviderSetting { get; set; }

    }
    /// Policy update properties.
    internal partial interface IUpdatePolicyInputPropertiesInternal

    {
        /// <summary>The ReplicationProviderSettings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput ReplicationProviderSetting { get; set; }

    }
}