// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Replication agent details.</summary>
    public partial class ReplicationAgentDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal
    {

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The replication agent Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; }

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>The replication agent Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; }

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth? _health;

        /// <summary>The health of the replication agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth? Health { get => this._health; }

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[] _healthError;

        /// <summary>The health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[] HealthError { get => this._healthError; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The replication agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="LastHeartbeatUtc" /> property.</summary>
        private global::System.DateTime? _lastHeartbeatUtc;

        /// <summary>The last heartbeat received from the replication agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public global::System.DateTime? LastHeartbeatUtc { get => this._lastHeartbeatUtc; }

        /// <summary>Internal Acessors for BiosId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.BiosId { get => this._biosId; set { {_biosId = value;} } }

        /// <summary>Internal Acessors for FabricObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.FabricObjectId { get => this._fabricObjectId; set { {_fabricObjectId = value;} } }

        /// <summary>Internal Acessors for Fqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.Fqdn { get => this._fqdn; set { {_fqdn = value;} } }

        /// <summary>Internal Acessors for Health</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for HealthError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[] Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.HealthError { get => this._healthError; set { {_healthError = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LastHeartbeatUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.LastHeartbeatUtc { get => this._lastHeartbeatUtc; set { {_lastHeartbeatUtc = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationAgentDetailsInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The replication agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="ReplicationAgentDetails" /> instance.</summary>
        public ReplicationAgentDetails()
        {

        }
    }
    /// Replication agent details.
    public partial interface IReplicationAgentDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The replication agent Bios Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The replication agent Bios Id.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get;  }
        /// <summary>The fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fabric object Id.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get;  }
        /// <summary>The replication agent Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The replication agent Fqdn.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get;  }
        /// <summary>The health of the replication agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The health of the replication agent.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth? Health { get;  }
        /// <summary>The health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[] HealthError { get;  }
        /// <summary>The replication agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The replication agent Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The last heartbeat received from the replication agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last heartbeat received from the replication agent.",
        SerializedName = @"lastHeartbeatUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastHeartbeatUtc { get;  }
        /// <summary>The replication agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The replication agent name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Replication agent details.
    internal partial interface IReplicationAgentDetailsInternal

    {
        /// <summary>The replication agent Bios Id.</summary>
        string BiosId { get; set; }
        /// <summary>The fabric object Id.</summary>
        string FabricObjectId { get; set; }
        /// <summary>The replication agent Fqdn.</summary>
        string Fqdn { get; set; }
        /// <summary>The health of the replication agent.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Support.ProtectionHealth? Health { get; set; }
        /// <summary>The health errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IHealthError[] HealthError { get; set; }
        /// <summary>The replication agent Id.</summary>
        string Id { get; set; }
        /// <summary>The last heartbeat received from the replication agent.</summary>
        global::System.DateTime? LastHeartbeatUtc { get; set; }
        /// <summary>The replication agent name.</summary>
        string Name { get; set; }
        /// <summary>The version.</summary>
        string Version { get; set; }

    }
}