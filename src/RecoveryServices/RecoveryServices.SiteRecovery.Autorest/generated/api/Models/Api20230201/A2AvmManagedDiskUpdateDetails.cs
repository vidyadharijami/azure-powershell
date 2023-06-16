// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>A2A Vm managed disk update details.</summary>
    public partial class A2AvmManagedDiskUpdateDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AvmManagedDiskUpdateDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AvmManagedDiskUpdateDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo _diskEncryptionInfo;

        /// <summary>The recovery os disk encryption information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo()); set => this._diskEncryptionInfo = value; }

        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoSecretIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier = value ?? null; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="FailoverDiskName" /> property.</summary>
        private string _failoverDiskName;

        /// <summary>The target disk name for unplanned failover operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string FailoverDiskName { get => this._failoverDiskName; set => this._failoverDiskName = value; }

        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier = value ?? null; }

        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AvmManagedDiskUpdateDetailsInternal.DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DiskEncryptionInfo()); set { {_diskEncryptionInfo = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionInfoDiskEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AvmManagedDiskUpdateDetailsInternal.DiskEncryptionInfoDiskEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for DiskEncryptionInfoKeyEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IKeyEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AvmManagedDiskUpdateDetailsInternal.DiskEncryptionInfoKeyEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo = value; }

        /// <summary>Backing field for <see cref="RecoveryReplicaDiskAccountType" /> property.</summary>
        private string _recoveryReplicaDiskAccountType;

        /// <summary>The replica disk type before failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryReplicaDiskAccountType { get => this._recoveryReplicaDiskAccountType; set => this._recoveryReplicaDiskAccountType = value; }

        /// <summary>Backing field for <see cref="RecoveryTargetDiskAccountType" /> property.</summary>
        private string _recoveryTargetDiskAccountType;

        /// <summary>The target disk type before failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryTargetDiskAccountType { get => this._recoveryTargetDiskAccountType; set => this._recoveryTargetDiskAccountType = value; }

        /// <summary>Backing field for <see cref="TfoDiskName" /> property.</summary>
        private string _tfoDiskName;

        /// <summary>The target disk name for test failover operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TfoDiskName { get => this._tfoDiskName; set => this._tfoDiskName = value; }

        /// <summary>Creates an new <see cref="A2AvmManagedDiskUpdateDetails" /> instance.</summary>
        public A2AvmManagedDiskUpdateDetails()
        {

        }
    }
    /// A2A Vm managed disk update details.
    public partial interface IA2AvmManagedDiskUpdateDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM id for secret.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secret url / identifier.",
        SerializedName = @"secretIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The target disk name for unplanned failover operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target disk name for unplanned failover operation.",
        SerializedName = @"failoverDiskName",
        PossibleTypes = new [] { typeof(string) })]
        string FailoverDiskName { get; set; }
        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key URL / identifier.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM Id for key.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The replica disk type before failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replica disk type before failover.",
        SerializedName = @"recoveryReplicaDiskAccountType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary>The target disk type before failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target disk type before failover.",
        SerializedName = @"recoveryTargetDiskAccountType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryTargetDiskAccountType { get; set; }
        /// <summary>The target disk name for test failover operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target disk name for test failover operation.",
        SerializedName = @"tfoDiskName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoDiskName { get; set; }

    }
    /// A2A Vm managed disk update details.
    internal partial interface IA2AvmManagedDiskUpdateDetailsInternal

    {
        /// <summary>The recovery os disk encryption information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary>The recovery KeyVault reference for secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IDiskEncryptionKeyInfo DiskEncryptionInfoDiskEncryptionKeyInfo { get; set; }
        /// <summary>The recovery KeyVault reference for key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IKeyEncryptionKeyInfo DiskEncryptionInfoKeyEncryptionKeyInfo { get; set; }
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The target disk name for unplanned failover operation.</summary>
        string FailoverDiskName { get; set; }
        /// <summary>The key URL / identifier.</summary>
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The replica disk type before failover.</summary>
        string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary>The target disk type before failover.</summary>
        string RecoveryTargetDiskAccountType { get; set; }
        /// <summary>The target disk name for test failover operation.</summary>
        string TfoDiskName { get; set; }

    }
}