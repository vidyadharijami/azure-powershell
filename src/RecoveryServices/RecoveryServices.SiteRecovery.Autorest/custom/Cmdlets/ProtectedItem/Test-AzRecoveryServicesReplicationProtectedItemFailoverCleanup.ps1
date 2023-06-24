
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Operation to clean up the test failover of a replication protected item.
.Description
Operation to clean up the test failover of a replication protected item.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem
.Link
https://docs.microsoft.com/powershell/module/az.recoveryservices/test-azrecoveryservicesreplicationprotecteditemfailovercleanup
#>
function Test-AzRecoveryServicesReplicationProtectedItemFailoverCleanup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJob])]
[CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem]
    # Replication protected item object.
    ${ProtectedItem},

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

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [System.String]
    # Test failover cleanup comments.
    ${Comment},

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
        $fabricName = $ProtectedItem.PrimaryFabricFriendlyName
        $protectionContainerName = $ProtectedItem.Id.Split("/")[-3]
        $replicatedProtectedItemName = $ProtectedItem.Name
        $null = $PSBoundParameters.Remove("ProtectedItem")
        $null = $PSBoundParameters.Add("FabricName", $fabricName)
        $null = $PSBoundParameters.Add("ProtectionContainerName", $protectionContainerName)
        $null = $PSBoundParameters.Add("ReplicatedProtectedItemName",$replicatedProtectedItemName)
        $PSBoundParameters["NoWait"] = $true
        $res = Az.RecoveryServices.internal\Test-AzRecoveryServicesReplicationProtectedItemFailoverCleanup @PSBoundParameters
        $jobName = $res.Target.Split("/")[-1].Split("?")[0]
        $null = $PSBoundParameters.Remove("FabricName")
        $null = $PSBoundParameters.Remove("Comment")
        $null = $PSBoundParameters.Remove("ReplicatedProtectedItemName")
        $null = $PSBoundParameters.Remove("ProtectionContainerName")
        $null = $PSBoundParameters.Remove("NoWait")
        $null = $PSBoundParameters.Add("JobName",$jobName)
        return Get-AzRecoveryServicesReplicationJob  @PSBoundParameters
    } 
    catch 
    {
        throw
    }
} 
}
