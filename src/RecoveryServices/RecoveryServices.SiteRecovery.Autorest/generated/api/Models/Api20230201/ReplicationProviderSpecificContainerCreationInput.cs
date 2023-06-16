// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Provider specific input for container creation operation.</summary>
    public partial class ReplicationProviderSpecificContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProviderSpecificContainerCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProviderSpecificContainerCreationInputInternal
    {

        /// <summary>Backing field for <see cref="ReplicationScenario" /> property.</summary>
        private string _replicationScenario;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ReplicationScenario { get => this._replicationScenario; set => this._replicationScenario = value; }

        /// <summary>
        /// Creates an new <see cref="ReplicationProviderSpecificContainerCreationInput" /> instance.
        /// </summary>
        public ReplicationProviderSpecificContainerCreationInput()
        {

        }
    }
    /// Provider specific input for container creation operation.
    public partial interface IReplicationProviderSpecificContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationScenario { get; set; }

    }
    /// Provider specific input for container creation operation.
    internal partial interface IReplicationProviderSpecificContainerCreationInputInternal

    {
        /// <summary>The class type.</summary>
        string ReplicationScenario { get; set; }

    }
}