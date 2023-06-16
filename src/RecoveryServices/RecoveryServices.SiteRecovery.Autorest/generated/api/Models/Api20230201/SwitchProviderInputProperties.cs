// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Input definition for switch provider input properties.</summary>
    public partial class SwitchProviderInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderInputPropertiesInternal
    {

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInput Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderInputPropertiesInternal.ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.SwitchProviderSpecificInput()); set { {_providerSpecificDetail = value;} } }

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInput _providerSpecificDetail;

        /// <summary>Provider specific settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInput ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.SwitchProviderSpecificInput()); set => this._providerSpecificDetail = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInputInternal)ProviderSpecificDetail).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="TargetInstanceType" /> property.</summary>
        private string _targetInstanceType;

        /// <summary>Target provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string TargetInstanceType { get => this._targetInstanceType; set => this._targetInstanceType = value; }

        /// <summary>Creates an new <see cref="SwitchProviderInputProperties" /> instance.</summary>
        public SwitchProviderInputProperties()
        {

        }
    }
    /// Input definition for switch provider input properties.
    public partial interface ISwitchProviderInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>Target provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target provider type.",
        SerializedName = @"targetInstanceType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInstanceType { get; set; }

    }
    /// Input definition for switch provider input properties.
    internal partial interface ISwitchProviderInputPropertiesInternal

    {
        /// <summary>Provider specific settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProviderSpecificInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>Target provider type.</summary>
        string TargetInstanceType { get; set; }

    }
}