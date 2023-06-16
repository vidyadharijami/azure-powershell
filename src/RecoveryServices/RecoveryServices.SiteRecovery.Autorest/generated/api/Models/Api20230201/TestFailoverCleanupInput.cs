// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Input definition for test failover cleanup.</summary>
    public partial class TestFailoverCleanupInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputInternal
    {

        /// <summary>Test failover cleanup comments.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Comment { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputPropertiesInternal)Property).Comment; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputPropertiesInternal)Property).Comment = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverCleanupInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputProperties _property;

        /// <summary>Test failover cleanup input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.TestFailoverCleanupInputProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="TestFailoverCleanupInput" /> instance.</summary>
        public TestFailoverCleanupInput()
        {

        }
    }
    /// Input definition for test failover cleanup.
    public partial interface ITestFailoverCleanupInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Test failover cleanup comments.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Test failover cleanup comments.",
        SerializedName = @"comments",
        PossibleTypes = new [] { typeof(string) })]
        string Comment { get; set; }

    }
    /// Input definition for test failover cleanup.
    internal partial interface ITestFailoverCleanupInputInternal

    {
        /// <summary>Test failover cleanup comments.</summary>
        string Comment { get; set; }
        /// <summary>Test failover cleanup input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITestFailoverCleanupInputProperties Property { get; set; }

    }
}