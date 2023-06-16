// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>A2A provider specific input for unplanned failover.</summary>
    public partial class A2AUnplannedFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AUnplannedFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IA2AUnplannedFailoverInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInput __unplannedFailoverProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.UnplannedFailoverProviderSpecificInput();

        /// <summary>Backing field for <see cref="CloudServiceCreationOption" /> property.</summary>
        private string _cloudServiceCreationOption;

        /// <summary>A value indicating whether to use recovery cloud service for failover or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string CloudServiceCreationOption { get => this._cloudServiceCreationOption; set => this._cloudServiceCreationOption = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInputInternal)__unplannedFailoverProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInputInternal)__unplannedFailoverProviderSpecificInput).InstanceType = value ; }

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Creates an new <see cref="A2AUnplannedFailoverInput" /> instance.</summary>
        public A2AUnplannedFailoverInput()
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
            await eventListener.AssertNotNull(nameof(__unplannedFailoverProviderSpecificInput), __unplannedFailoverProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__unplannedFailoverProviderSpecificInput), __unplannedFailoverProviderSpecificInput);
        }
    }
    /// A2A provider specific input for unplanned failover.
    public partial interface IA2AUnplannedFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInput
    {
        /// <summary>A value indicating whether to use recovery cloud service for failover or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether to use recovery cloud service for failover or not.",
        SerializedName = @"cloudServiceCreationOption",
        PossibleTypes = new [] { typeof(string) })]
        string CloudServiceCreationOption { get; set; }
        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed.",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }

    }
    /// A2A provider specific input for unplanned failover.
    internal partial interface IA2AUnplannedFailoverInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInputInternal
    {
        /// <summary>A value indicating whether to use recovery cloud service for failover or not.</summary>
        string CloudServiceCreationOption { get; set; }
        /// <summary>
        /// The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null
        /// should be passed.
        /// </summary>
        string RecoveryPointId { get; set; }

    }
}