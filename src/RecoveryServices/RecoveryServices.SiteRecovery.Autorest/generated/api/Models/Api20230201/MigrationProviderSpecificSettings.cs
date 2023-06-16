// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Migration provider specific settings.</summary>
    public partial class MigrationProviderSpecificSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IMigrationProviderSpecificSettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IMigrationProviderSpecificSettingsInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Gets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="MigrationProviderSpecificSettings" /> instance.</summary>
        public MigrationProviderSpecificSettings()
        {

        }
    }
    /// Migration provider specific settings.
    public partial interface IMigrationProviderSpecificSettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Gets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets the instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Migration provider specific settings.
    internal partial interface IMigrationProviderSpecificSettingsInternal

    {
        /// <summary>Gets the instance type.</summary>
        string InstanceType { get; set; }

    }
}