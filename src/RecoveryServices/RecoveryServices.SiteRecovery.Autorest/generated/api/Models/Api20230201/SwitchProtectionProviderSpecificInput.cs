// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Provider specific switch protection input.</summary>
    public partial class SwitchProtectionProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInputInternal
    {

        /// <summary>Backing field for <see cref="ReplicationScenario" /> property.</summary>
        private string _replicationScenario;

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ReplicationScenario { get => this._replicationScenario; set => this._replicationScenario = value; }

        /// <summary>Creates an new <see cref="SwitchProtectionProviderSpecificInput" /> instance.</summary>
        public SwitchProtectionProviderSpecificInput()
        {

        }
    }
    /// Provider specific switch protection input.
    public partial interface ISwitchProtectionProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets the Instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationScenario { get; set; }

    }
    /// Provider specific switch protection input.
    internal partial interface ISwitchProtectionProviderSpecificInputInternal

    {
        /// <summary>Gets the Instance type.</summary>
        string ReplicationScenario { get; set; }

    }
}