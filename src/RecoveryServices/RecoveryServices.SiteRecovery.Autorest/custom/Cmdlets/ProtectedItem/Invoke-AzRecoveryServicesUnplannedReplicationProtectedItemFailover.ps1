
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Operation to initiate a failover of the replication protected item.
.Description
Operation to initiate a failover of the replication protected item.

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverInput
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

FAILOVERINPUT <IUnplannedFailoverInput>: Input definition for unplanned failover.
  [FailoverDirection <String>]: Failover direction.
  [ProviderSpecificDetail <IUnplannedFailoverProviderSpecificInput>]: Provider specific settings.
    InstanceType <String>: The class type.
  [SourceSiteOperation <String>]: Source site operations status.
.Link
https://docs.microsoft.com/powershell/module/az.recoveryservices/invoke-azrecoveryservicesunplannedreplicationprotecteditemfailover
#>
function Invoke-AzRecoveryServicesUnplannedReplicationProtectedItemFailover {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJob])]
[CmdletBinding( PositionalBinding=$false, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem]
    #Replication Protected item
    ${ReplicationProtectedItem},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # The name of the resource group where the recovery services vault is present.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # The name of the recovery services vault.
    ${ResourceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The subscription Id.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [System.String]
    # Failover direction.
    ${FailoverDirection},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IUnplannedFailoverProviderSpecificInput]
    # Provider specific settings.
    # To construct, see NOTES section for PROVIDERSPECIFICDETAIL properties and create a hash table.
    ${ProviderSpecificDetail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [System.String]
    # Source site operations status.
    ${SourceSiteOperation},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)


process {
    try {
        $fabricName = $ReplicationProtectedItem.PrimaryFabricFriendlyName
        $protectionContainerName = $ReplicationProtectedItem.Id.Split("/")[-3]
        $replicationProtectedItemName = $ReplicationProtectedItem.Name
        $null = $PSBoundParameters.Remove("ReplicationProtectedItem")
        $null = $PSBoundParameters.Add("FabricName", $fabricName)
        $null = $PSBoundParameters.Add("ProtectionContainerName", $protectionContainerName)
        $null = $PSBoundParameters.Add("ReplicatedProtectedItemName",$replicationProtectedItemName)
        $PSBoundParameters["NoWait"] = $true
        $res = Az.RecoveryServices.internal\Invoke-AzRecoveryServicesUnplannedReplicationProtectedItemFailover @PSBoundParameters
        $jobName = $res.Target.Split("/")[-1].Split("?")[0]
        $null = $PSBoundParameters.Remove("FabricName")
        $null = $PSBoundParameters.Remove("ProtectionContainerName")
        $null = $PSBoundParameters.Remove("NoWait")
        $null = $PSBoundParameters.Remove("ProviderSpecificDetail")
        $null = $PSBoundParameters.Remove("ProtectionContainerMapping")
        $null = $PSBoundParameters.Remove("ReplicatedProtectedItemName")
        $null = $PSBoundParameters.Remove("ProtectableItemId")
        $null = $PSBoundParameters.Add("JobName",$jobName)
        return Get-AzRecoveryServicesReplicationJob  @PSBoundParameters
    } catch {
        throw
    }
} 
}
