// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Task details based on specific task type.</summary>
    public partial class TaskTypeDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITaskTypeDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ITaskTypeDetailsInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="TaskTypeDetails" /> instance.</summary>
        public TaskTypeDetails()
        {

        }
    }
    /// Task details based on specific task type.
    public partial interface ITaskTypeDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of task details.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Task details based on specific task type.
    internal partial interface ITaskTypeDetailsInternal

    {
        /// <summary>The type of task details.</summary>
        string InstanceType { get; set; }

    }
}