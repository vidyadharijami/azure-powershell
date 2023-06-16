// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>InMage Azure v2 specific protection profile details.</summary>
    public partial class InMageAzureV2PolicyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageAzureV2PolicyDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageAzureV2PolicyDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetails __policyProviderSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyProviderSpecificDetails();

        /// <summary>Backing field for <see cref="AppConsistentFrequencyInMinute" /> property.</summary>
        private int? _appConsistentFrequencyInMinute;

        /// <summary>The app consistent snapshot frequency in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? AppConsistentFrequencyInMinute { get => this._appConsistentFrequencyInMinute; set => this._appConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="CrashConsistentFrequencyInMinute" /> property.</summary>
        private int? _crashConsistentFrequencyInMinute;

        /// <summary>The crash consistent snapshot frequency in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? CrashConsistentFrequencyInMinute { get => this._crashConsistentFrequencyInMinute; set => this._crashConsistentFrequencyInMinute = value; }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)__policyProviderSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal)__policyProviderSpecificDetails).InstanceType = value ; }

        /// <summary>Backing field for <see cref="MultiVMSyncStatus" /> property.</summary>
        private string _multiVMSyncStatus;

        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string MultiVMSyncStatus { get => this._multiVMSyncStatus; set => this._multiVMSyncStatus = value; }

        /// <summary>Backing field for <see cref="RecoveryPointHistory" /> property.</summary>
        private int? _recoveryPointHistory;

        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? RecoveryPointHistory { get => this._recoveryPointHistory; set => this._recoveryPointHistory = value; }

        /// <summary>Backing field for <see cref="RecoveryPointThresholdInMinute" /> property.</summary>
        private int? _recoveryPointThresholdInMinute;

        /// <summary>The recovery point threshold in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? RecoveryPointThresholdInMinute { get => this._recoveryPointThresholdInMinute; set => this._recoveryPointThresholdInMinute = value; }

        /// <summary>Creates an new <see cref="InMageAzureV2PolicyDetails" /> instance.</summary>
        public InMageAzureV2PolicyDetails()
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
            await eventListener.AssertNotNull(nameof(__policyProviderSpecificDetails), __policyProviderSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__policyProviderSpecificDetails), __policyProviderSpecificDetails);
        }
    }
    /// InMage Azure v2 specific protection profile details.
    public partial interface IInMageAzureV2PolicyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetails
    {
        /// <summary>The app consistent snapshot frequency in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app consistent snapshot frequency in minutes.",
        SerializedName = @"appConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The crash consistent snapshot frequency in minutes.",
        SerializedName = @"crashConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether multi-VM sync has to be enabled.",
        SerializedName = @"multiVmSyncStatus",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMSyncStatus { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration in minutes until which the recovery points need to be stored.",
        SerializedName = @"recoveryPointHistory",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPointHistory { get; set; }
        /// <summary>The recovery point threshold in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point threshold in minutes.",
        SerializedName = @"recoveryPointThresholdInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPointThresholdInMinute { get; set; }

    }
    /// InMage Azure v2 specific protection profile details.
    internal partial interface IInMageAzureV2PolicyDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificDetailsInternal
    {
        /// <summary>The app consistent snapshot frequency in minutes.</summary>
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency in minutes.</summary>
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>A value indicating whether multi-VM sync has to be enabled.</summary>
        string MultiVMSyncStatus { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        int? RecoveryPointHistory { get; set; }
        /// <summary>The recovery point threshold in minutes.</summary>
        int? RecoveryPointThresholdInMinute { get; set; }

    }
}