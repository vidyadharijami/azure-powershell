
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
The operation to create an ASR replication protected item (Enable replication).
.Description
The operation to create an ASR replication protected item (Enable replication).
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PROVIDERSPECIFICDETAIL <IEnableProtectionProviderSpecificInput>: The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
  InstanceType <String>: The class type.
.Link
https://docs.microsoft.com/powershell/module/az.recoveryservices/new-azrecoveryservicesreplicationprotecteditem
#>
function New-AzRecoveryServicesReplicationProtectedItem {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJob])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMapping]
    # Protection container mapping object.
    ${ProtectionContainerMapping},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # A name for the replication protected item.
    ${ReplicatedProtectedItemName},

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
    [System.String]
    # The subscription Id.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectableItem]
    # The protectable item Object.
    ${ProtectableItem},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEnableProtectionProviderSpecificInput]
    # The ReplicationProviderInput.
    # For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object.
    # For San provider, it will be SanEnableProtectionInput object.
    # For HyperVReplicaAzure provider, it can be null.
    # To construct, see NOTES section for PROVIDERSPECIFICDETAIL properties and create a hash table.
    ${ProviderSpecificDetail},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [System.String]
    # The Policy Id.
    ${PolicyId},


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
        $fabricName = $ProtectionContainerMapping.SourceFabricFriendlyName
        $protectionContainerName = $ProtectionContainerMapping.Id.Split("/")[-3]
        $policyId = $ProtectionContainerMapping.PolicyId
        $protectableItemId = $ProtectableItem.Id
        $null = $PSBoundParameters.Remove("ProtectionContainerMapping")
        $null = $PSBoundParameters.Remove("ProtectableItem")
        $null = $PSBoundParameters.Add("FabricName", $fabricName)
        $null = $PSBoundParameters.Add("ProtectionContainerName", $protectionContainerName)
        $null = $PSBoundParameters.Add("PolicyId",$policyId)
        $null = $PSBoundParameters.Add("ProtectableItemId",$protectableItemId)
        $PSBoundParameters["NoWait"] = $true
        $res = Az.RecoveryServices.internal\New-AzRecoveryServicesReplicationProtectedItem @PSBoundParameters
        $jobName = $res.Target.Split("/")[-1].Split("?")[0]
        $null = $PSBoundParameters.Remove("FabricName")
        $null = $PSBoundParameters.Remove("ProtectionContainerName")
        $null = $PSBoundParameters.Remove("NoWait")
        $null = $PSBoundParameters.Remove("ProviderSpecificDetail")
        $null = $PSBoundParameters.Remove("ProtectionContainerMapping")
        $null = $PSBoundParameters.Remove("ReplicatedProtectedItemName")
        $null = $PSBoundParameters.Remove("PolicyId")
        $null = $PSBoundParameters.Remove("ProtectableItemId")
        $null = $PSBoundParameters.Add("JobName",$jobName)
        return Get-AzRecoveryServicesReplicationJob  @PSBoundParameters
    } catch {
        throw
        }
    }
}
