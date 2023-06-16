// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Provider specific reverse replication input.</summary>
    public partial class ReverseReplicationProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReverseReplicationProviderSpecificInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReverseReplicationProviderSpecificInputInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="ReverseReplicationProviderSpecificInput" /> instance.</summary>
        public ReverseReplicationProviderSpecificInput()
        {

        }
    }
    /// Provider specific reverse replication input.
    public partial interface IReverseReplicationProviderSpecificInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Provider specific reverse replication input.
    internal partial interface IReverseReplicationProviderSpecificInputInternal

    {
        /// <summary>The class type.</summary>
        string InstanceType { get; set; }

    }
}