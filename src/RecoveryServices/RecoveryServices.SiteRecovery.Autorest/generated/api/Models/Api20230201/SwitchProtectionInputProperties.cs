// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Switch protection input properties.</summary>
    public partial class SwitchProtectionInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput _providerSpecificDetail;

        /// <summary>Provider specific switch protection input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.SwitchProtectionProviderSpecificInput()); set => this._providerSpecificDetail = value; }

        /// <summary>Backing field for <see cref="ReplicationProtectedItemName" /> property.</summary>
        private string _replicationProtectedItemName;

        /// <summary>The unique replication protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ReplicationProtectedItemName { get => this._replicationProtectedItemName; set => this._replicationProtectedItemName = value; }

        /// <summary>Creates an new <see cref="SwitchProtectionInputProperties" /> instance.</summary>
        public SwitchProtectionInputProperties()
        {

        }
    }
    /// Switch protection input properties.
    public partial interface ISwitchProtectionInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Provider specific switch protection input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider specific switch protection input.",
        SerializedName = @"providerSpecificDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The unique replication protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique replication protected item name.",
        SerializedName = @"replicationProtectedItemName",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationProtectedItemName { get; set; }

    }
    /// Switch protection input properties.
    internal partial interface ISwitchProtectionInputPropertiesInternal

    {
        /// <summary>Provider specific switch protection input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The unique replication protected item name.</summary>
        string ReplicationProtectedItemName { get; set; }

    }
}