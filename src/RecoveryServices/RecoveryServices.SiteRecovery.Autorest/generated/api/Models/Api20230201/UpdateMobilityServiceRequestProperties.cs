// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>The properties of an update mobility service request.</summary>
    public partial class UpdateMobilityServiceRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateMobilityServiceRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUpdateMobilityServiceRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="RunAsAccountId" /> property.</summary>
        private string _runAsAccountId;

        /// <summary>The CS run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string RunAsAccountId { get => this._runAsAccountId; set => this._runAsAccountId = value; }

        /// <summary>Creates an new <see cref="UpdateMobilityServiceRequestProperties" /> instance.</summary>
        public UpdateMobilityServiceRequestProperties()
        {

        }
    }
    /// The properties of an update mobility service request.
    public partial interface IUpdateMobilityServiceRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The CS run as account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CS run as account Id.",
        SerializedName = @"runAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RunAsAccountId { get; set; }

    }
    /// The properties of an update mobility service request.
    internal partial interface IUpdateMobilityServiceRequestPropertiesInternal

    {
        /// <summary>The CS run as account Id.</summary>
        string RunAsAccountId { get; set; }

    }
}