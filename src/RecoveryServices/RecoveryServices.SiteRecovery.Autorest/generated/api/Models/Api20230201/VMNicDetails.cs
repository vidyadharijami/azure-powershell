// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Hyper V VM network details.</summary>
    public partial class VMNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IVMNicDetailsInternal
    {

        /// <summary>
        /// Backing field for <see cref="EnableAcceleratedNetworkingOnRecovery" /> property.
        /// </summary>
        private bool? _enableAcceleratedNetworkingOnRecovery;

        /// <summary>A value indicating whether the NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworkingOnRecovery { get => this._enableAcceleratedNetworkingOnRecovery; set => this._enableAcceleratedNetworkingOnRecovery = value; }

        /// <summary>Backing field for <see cref="EnableAcceleratedNetworkingOnTfo" /> property.</summary>
        private bool? _enableAcceleratedNetworkingOnTfo;

        /// <summary>Whether the TFO NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworkingOnTfo { get => this._enableAcceleratedNetworkingOnTfo; set => this._enableAcceleratedNetworkingOnTfo = value; }

        /// <summary>Backing field for <see cref="IPConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IIPConfigDetails[] _iPConfig;

        /// <summary>The IP configurations of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IIPConfigDetails[] IPConfig { get => this._iPConfig; set => this._iPConfig = value; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>The nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; set => this._nicId = value; }

        /// <summary>Backing field for <see cref="RecoveryNetworkSecurityGroupId" /> property.</summary>
        private string _recoveryNetworkSecurityGroupId;

        /// <summary>The id of the NSG associated with the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryNetworkSecurityGroupId { get => this._recoveryNetworkSecurityGroupId; set => this._recoveryNetworkSecurityGroupId = value; }

        /// <summary>Backing field for <see cref="RecoveryNicName" /> property.</summary>
        private string _recoveryNicName;

        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryNicName { get => this._recoveryNicName; set => this._recoveryNicName = value; }

        /// <summary>Backing field for <see cref="RecoveryNicResourceGroupName" /> property.</summary>
        private string _recoveryNicResourceGroupName;

        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryNicResourceGroupName { get => this._recoveryNicResourceGroupName; set => this._recoveryNicResourceGroupName = value; }

        /// <summary>Backing field for <see cref="RecoveryVMNetworkId" /> property.</summary>
        private string _recoveryVMNetworkId;

        /// <summary>Recovery VM network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryVMNetworkId { get => this._recoveryVMNetworkId; set => this._recoveryVMNetworkId = value; }

        /// <summary>Backing field for <see cref="ReplicaNicId" /> property.</summary>
        private string _replicaNicId;

        /// <summary>The replica nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ReplicaNicId { get => this._replicaNicId; set => this._replicaNicId = value; }

        /// <summary>Backing field for <see cref="ReuseExistingNic" /> property.</summary>
        private bool? _reuseExistingNic;

        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public bool? ReuseExistingNic { get => this._reuseExistingNic; set => this._reuseExistingNic = value; }

        /// <summary>Backing field for <see cref="SelectionType" /> property.</summary>
        private string _selectionType;

        /// <summary>Selection type for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string SelectionType { get => this._selectionType; set => this._selectionType = value; }

        /// <summary>Backing field for <see cref="SourceNicArmId" /> property.</summary>
        private string _sourceNicArmId;

        /// <summary>The source nic ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string SourceNicArmId { get => this._sourceNicArmId; set => this._sourceNicArmId = value; }

        /// <summary>Backing field for <see cref="TargetNicName" /> property.</summary>
        private string _targetNicName;

        /// <summary>Target NIC name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TargetNicName { get => this._targetNicName; set => this._targetNicName = value; }

        /// <summary>Backing field for <see cref="TfoNetworkSecurityGroupId" /> property.</summary>
        private string _tfoNetworkSecurityGroupId;

        /// <summary>The NSG to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TfoNetworkSecurityGroupId { get => this._tfoNetworkSecurityGroupId; set => this._tfoNetworkSecurityGroupId = value; }

        /// <summary>Backing field for <see cref="TfoRecoveryNicName" /> property.</summary>
        private string _tfoRecoveryNicName;

        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TfoRecoveryNicName { get => this._tfoRecoveryNicName; set => this._tfoRecoveryNicName = value; }

        /// <summary>Backing field for <see cref="TfoRecoveryNicResourceGroupName" /> property.</summary>
        private string _tfoRecoveryNicResourceGroupName;

        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TfoRecoveryNicResourceGroupName { get => this._tfoRecoveryNicResourceGroupName; set => this._tfoRecoveryNicResourceGroupName = value; }

        /// <summary>Backing field for <see cref="TfoReuseExistingNic" /> property.</summary>
        private bool? _tfoReuseExistingNic;

        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public bool? TfoReuseExistingNic { get => this._tfoReuseExistingNic; set => this._tfoReuseExistingNic = value; }

        /// <summary>Backing field for <see cref="TfoVMNetworkId" /> property.</summary>
        private string _tfoVMNetworkId;

        /// <summary>The network to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TfoVMNetworkId { get => this._tfoVMNetworkId; set => this._tfoVMNetworkId = value; }

        /// <summary>Backing field for <see cref="VMNetworkName" /> property.</summary>
        private string _vMNetworkName;

        /// <summary>VM network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string VMNetworkName { get => this._vMNetworkName; set => this._vMNetworkName = value; }

        /// <summary>Creates an new <see cref="VMNicDetails" /> instance.</summary>
        public VMNicDetails()
        {

        }
    }
    /// Hyper V VM network details.
    public partial interface IVMNicDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating whether the NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the NIC has accelerated networking enabled.",
        SerializedName = @"enableAcceleratedNetworkingOnRecovery",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworkingOnRecovery { get; set; }
        /// <summary>Whether the TFO NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the TFO NIC has accelerated networking enabled.",
        SerializedName = @"enableAcceleratedNetworkingOnTfo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworkingOnTfo { get; set; }
        /// <summary>The IP configurations of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP configurations of the NIC.",
        SerializedName = @"ipConfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IIPConfigDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IIPConfigDetails[] IPConfig { get; set; }
        /// <summary>The nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The nic Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get; set; }
        /// <summary>The id of the NSG associated with the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the NSG associated with the NIC.",
        SerializedName = @"recoveryNetworkSecurityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NIC to be used when creating target NICs.",
        SerializedName = @"recoveryNicName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group of the NIC to be used when creating target NICs.",
        SerializedName = @"recoveryNicResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNicResourceGroupName { get; set; }
        /// <summary>Recovery VM network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery VM network Id.",
        SerializedName = @"recoveryVMNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVMNetworkId { get; set; }
        /// <summary>The replica nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replica nic Id.",
        SerializedName = @"replicaNicId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaNicId { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.",
        SerializedName = @"reuseExistingNic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReuseExistingNic { get; set; }
        /// <summary>Selection type for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selection type for failover.",
        SerializedName = @"selectionType",
        PossibleTypes = new [] { typeof(string) })]
        string SelectionType { get; set; }
        /// <summary>The source nic ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source nic ARM Id.",
        SerializedName = @"sourceNicArmId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceNicArmId { get; set; }
        /// <summary>Target NIC name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target NIC name.",
        SerializedName = @"targetNicName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNicName { get; set; }
        /// <summary>The NSG to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The NSG to be used by NIC during test failover.",
        SerializedName = @"tfoNetworkSecurityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TfoNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NIC to be used when creating target NICs in TFO.",
        SerializedName = @"tfoRecoveryNicName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoRecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group of the NIC to be used when creating target NICs in TFO.",
        SerializedName = @"tfoRecoveryNicResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoRecoveryNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.",
        SerializedName = @"tfoReuseExistingNic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TfoReuseExistingNic { get; set; }
        /// <summary>The network to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network to be used by NIC during test failover.",
        SerializedName = @"tfoVMNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TfoVMNetworkId { get; set; }
        /// <summary>VM network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM network name.",
        SerializedName = @"vMNetworkName",
        PossibleTypes = new [] { typeof(string) })]
        string VMNetworkName { get; set; }

    }
    /// Hyper V VM network details.
    internal partial interface IVMNicDetailsInternal

    {
        /// <summary>A value indicating whether the NIC has accelerated networking enabled.</summary>
        bool? EnableAcceleratedNetworkingOnRecovery { get; set; }
        /// <summary>Whether the TFO NIC has accelerated networking enabled.</summary>
        bool? EnableAcceleratedNetworkingOnTfo { get; set; }
        /// <summary>The IP configurations of the NIC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IIPConfigDetails[] IPConfig { get; set; }
        /// <summary>The nic Id.</summary>
        string NicId { get; set; }
        /// <summary>The id of the NSG associated with the NIC.</summary>
        string RecoveryNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        string RecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        string RecoveryNicResourceGroupName { get; set; }
        /// <summary>Recovery VM network Id.</summary>
        string RecoveryVMNetworkId { get; set; }
        /// <summary>The replica nic Id.</summary>
        string ReplicaNicId { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        bool? ReuseExistingNic { get; set; }
        /// <summary>Selection type for failover.</summary>
        string SelectionType { get; set; }
        /// <summary>The source nic ARM Id.</summary>
        string SourceNicArmId { get; set; }
        /// <summary>Target NIC name.</summary>
        string TargetNicName { get; set; }
        /// <summary>The NSG to be used by NIC during test failover.</summary>
        string TfoNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        string TfoRecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        string TfoRecoveryNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        bool? TfoReuseExistingNic { get; set; }
        /// <summary>The network to be used by NIC during test failover.</summary>
        string TfoVMNetworkId { get; set; }
        /// <summary>VM network name.</summary>
        string VMNetworkName { get; set; }

    }
}