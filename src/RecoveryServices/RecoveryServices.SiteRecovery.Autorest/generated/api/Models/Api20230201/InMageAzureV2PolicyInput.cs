// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>VMWare Azure specific policy Input.</summary>
    public partial class InMageAzureV2PolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageAzureV2PolicyInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IInMageAzureV2PolicyInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput __policyProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.PolicyProviderSpecificInput();

        /// <summary>Backing field for <see cref="AppConsistentFrequencyInMinute" /> property.</summary>
        private int? _appConsistentFrequencyInMinute;

        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? AppConsistentFrequencyInMinute { get => this._appConsistentFrequencyInMinute; set => this._appConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="CrashConsistentFrequencyInMinute" /> property.</summary>
        private int? _crashConsistentFrequencyInMinute;

        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public int? CrashConsistentFrequencyInMinute { get => this._crashConsistentFrequencyInMinute; set => this._crashConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="MultiVMSyncStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.SetMultiVMSyncStatus _multiVMSyncStatus;

        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get => this._multiVMSyncStatus; set => this._multiVMSyncStatus = value; }

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

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string ReplicationScenario { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).ReplicationScenario; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).ReplicationScenario = value ; }

        /// <summary>Creates an new <see cref="InMageAzureV2PolicyInput" /> instance.</summary>
        public InMageAzureV2PolicyInput()
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
            await eventListener.AssertNotNull(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
        }
    }
    /// VMWare Azure specific policy Input.
    public partial interface IInMageAzureV2PolicyInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInput
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app consistent snapshot frequency (in minutes).",
        SerializedName = @"appConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The crash consistent snapshot frequency (in minutes).",
        SerializedName = @"crashConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.",
        SerializedName = @"multiVmSyncStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.SetMultiVMSyncStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get; set; }
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
    /// VMWare Azure specific policy Input.
    internal partial interface IInMageAzureV2PolicyInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IPolicyProviderSpecificInputInternal
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        int? RecoveryPointHistory { get; set; }
        /// <summary>The recovery point threshold in minutes.</summary>
        int? RecoveryPointThresholdInMinute { get; set; }

    }
}