// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Resolve health errors input properties.</summary>
    public partial class ResolveHealthError :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResolveHealthError,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IResolveHealthErrorInternal
    {

        /// <summary>Backing field for <see cref="HealthErrorId" /> property.</summary>
        private string _healthErrorId;

        /// <summary>Health error id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string HealthErrorId { get => this._healthErrorId; set => this._healthErrorId = value; }

        /// <summary>Creates an new <see cref="ResolveHealthError" /> instance.</summary>
        public ResolveHealthError()
        {

        }
    }
    /// Resolve health errors input properties.
    public partial interface IResolveHealthError :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Health error id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health error id.",
        SerializedName = @"healthErrorId",
        PossibleTypes = new [] { typeof(string) })]
        string HealthErrorId { get; set; }

    }
    /// Resolve health errors input properties.
    internal partial interface IResolveHealthErrorInternal

    {
        /// <summary>Health error id.</summary>
        string HealthErrorId { get; set; }

    }
}