// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>A2A provider specific recovery point details.</summary>
    public partial class A2ARecoveryPointDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2ARecoveryPointDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2ARecoveryPointDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetails __providerSpecificRecoveryPointDetails = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ProviderSpecificRecoveryPointDetails();

        /// <summary>Backing field for <see cref="Disk" /> property.</summary>
        private string[] _disk;

        /// <summary>List of disk ids representing a recovery point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string[] Disk { get => this._disk; set => this._disk = value; }

        /// <summary>Gets the provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetailsInternal)__providerSpecificRecoveryPointDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetailsInternal)__providerSpecificRecoveryPointDetails).InstanceType = value ; }

        /// <summary>Backing field for <see cref="RecoveryPointSyncType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.RecoveryPointSyncType? _recoveryPointSyncType;

        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.RecoveryPointSyncType? RecoveryPointSyncType { get => this._recoveryPointSyncType; set => this._recoveryPointSyncType = value; }

        /// <summary>Creates an new <see cref="A2ARecoveryPointDetails" /> instance.</summary>
        public A2ARecoveryPointDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__providerSpecificRecoveryPointDetails), __providerSpecificRecoveryPointDetails);
            await eventListener.AssertObjectIsValid(nameof(__providerSpecificRecoveryPointDetails), __providerSpecificRecoveryPointDetails);
        }
    }
    /// A2A provider specific recovery point details.
    public partial interface IA2ARecoveryPointDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetails
    {
        /// <summary>List of disk ids representing a recovery point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of disk ids representing a recovery point.",
        SerializedName = @"disks",
        PossibleTypes = new [] { typeof(string) })]
        string[] Disk { get; set; }
        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the recovery point is multi VM consistent.",
        SerializedName = @"recoveryPointSyncType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.RecoveryPointSyncType) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.RecoveryPointSyncType? RecoveryPointSyncType { get; set; }

    }
    /// A2A provider specific recovery point details.
    internal partial interface IA2ARecoveryPointDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProviderSpecificRecoveryPointDetailsInternal
    {
        /// <summary>List of disk ids representing a recovery point.</summary>
        string[] Disk { get; set; }
        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.RecoveryPointSyncType? RecoveryPointSyncType { get; set; }

    }
}