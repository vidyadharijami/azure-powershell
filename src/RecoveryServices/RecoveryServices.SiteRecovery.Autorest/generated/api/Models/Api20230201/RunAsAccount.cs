// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>CS Accounts Details.</summary>
    public partial class RunAsAccount :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRunAsAccount,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IRunAsAccountInternal
    {

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        /// <summary>The CS RunAs account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; set => this._accountId = value; }

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>The CS RunAs account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Creates an new <see cref="RunAsAccount" /> instance.</summary>
        public RunAsAccount()
        {

        }
    }
    /// CS Accounts Details.
    public partial interface IRunAsAccount :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The CS RunAs account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CS RunAs account Id.",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get; set; }
        /// <summary>The CS RunAs account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CS RunAs account name.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }

    }
    /// CS Accounts Details.
    internal partial interface IRunAsAccountInternal

    {
        /// <summary>The CS RunAs account Id.</summary>
        string AccountId { get; set; }
        /// <summary>The CS RunAs account name.</summary>
        string AccountName { get; set; }

    }
}