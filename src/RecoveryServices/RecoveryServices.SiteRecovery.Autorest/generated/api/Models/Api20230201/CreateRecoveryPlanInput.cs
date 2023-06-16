// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Create recovery plan input class.</summary>
    public partial class CreateRecoveryPlanInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputInternal
    {

        /// <summary>The failover deployment model.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.FailoverDeploymentModel? FailoverDeploymentModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).FailoverDeploymentModel; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).FailoverDeploymentModel = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.FailoverDeploymentModel)""); }

        /// <summary>The recovery plan groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanGroup[] Group { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).Group = value ; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateRecoveryPlanInputProperties()); set { {_property = value;} } }

        /// <summary>The primary fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string PrimaryFabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).PrimaryFabricId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).PrimaryFabricId = value ; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputProperties _property;

        /// <summary>Recovery plan creation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.CreateRecoveryPlanInputProperties()); set => this._property = value; }

        /// <summary>The provider specific input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanProviderSpecificInput[] ProviderSpecificInput { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).ProviderSpecificInput; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).ProviderSpecificInput = value ?? null /* arrayOf */; }

        /// <summary>The recovery fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string RecoveryFabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).RecoveryFabricId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputPropertiesInternal)Property).RecoveryFabricId = value ; }

        /// <summary>Creates an new <see cref="CreateRecoveryPlanInput" /> instance.</summary>
        public CreateRecoveryPlanInput()
        {

        }
    }
    /// Create recovery plan input class.
    public partial interface ICreateRecoveryPlanInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The failover deployment model.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The failover deployment model.",
        SerializedName = @"failoverDeploymentModel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.FailoverDeploymentModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.FailoverDeploymentModel? FailoverDeploymentModel { get; set; }
        /// <summary>The recovery plan groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery plan groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanGroup[] Group { get; set; }
        /// <summary>The primary fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The primary fabric Id.",
        SerializedName = @"primaryFabricId",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryFabricId { get; set; }
        /// <summary>The provider specific input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provider specific input.",
        SerializedName = @"providerSpecificInput",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanProviderSpecificInput[] ProviderSpecificInput { get; set; }
        /// <summary>The recovery fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery fabric Id.",
        SerializedName = @"recoveryFabricId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryFabricId { get; set; }

    }
    /// Create recovery plan input class.
    internal partial interface ICreateRecoveryPlanInputInternal

    {
        /// <summary>The failover deployment model.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.FailoverDeploymentModel? FailoverDeploymentModel { get; set; }
        /// <summary>The recovery plan groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanGroup[] Group { get; set; }
        /// <summary>The primary fabric Id.</summary>
        string PrimaryFabricId { get; set; }
        /// <summary>Recovery plan creation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ICreateRecoveryPlanInputProperties Property { get; set; }
        /// <summary>The provider specific input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRecoveryPlanProviderSpecificInput[] ProviderSpecificInput { get; set; }
        /// <summary>The recovery fabric Id.</summary>
        string RecoveryFabricId { get; set; }

    }
}