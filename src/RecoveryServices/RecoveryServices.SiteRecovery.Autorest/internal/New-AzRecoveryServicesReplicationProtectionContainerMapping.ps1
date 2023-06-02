
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
The operation to create a protection container mapping.
.Description
The operation to create a protection container mapping.
.Example
$policy=Get-AzRecoveryServicesReplicationPolicy -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -PolicyName "A2APolicy"
$mappingInput=[Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AContainerMappingInput]::new()
$mappingInput.InstanceType="A2A"
$primaryfabric=Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "A2Ademo-EastUS"
$primaryprotectioncontainer=Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -Fabric $primaryfabric -ProtectionContainer "A2AEastUSProtectionContainer"
$recoveryfabric=Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "A2Aprimaryfabric"
$recoveryprotectioncontainer=Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -Fabric $recoveryfabric -ProtectionContainer "demoProtectionContainer"
New-AzRecoveryServicesReplicationProtectionContainerMapping -MappingName "demomap" -PrimaryProtectionContainer $primaryprotectioncontainer -ResourceName "a2arecoveryvault" -ResourceGroupName "a2arecoveryrg" -ProviderSpecificInput $mappingInput -Policy $policy -RecoveryProtectionContainer $recoveryprotectioncontainer

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMapping
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PROVIDERSPECIFICINPUT <IReplicationProviderSpecificContainerMappingInput>: Provider specific input for pairing.
  InstanceType <String>: The class type.
.Link
https://docs.microsoft.com/powershell/module/az.recoveryservices/new-azrecoveryservicesreplicationprotectioncontainermapping
#>
function New-AzRecoveryServicesReplicationProtectionContainerMapping {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMapping])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # Fabric name.
    ${FabricName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # Protection container mapping name.
    ${MappingName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
    [System.String]
    # Protection container name.
    ${ProtectionContainerName},

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
    # Applicable policy.
    ${PolicyId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProviderSpecificContainerMappingInput]
    # Provider specific input for pairing.
    # To construct, see NOTES section for PROVIDERSPECIFICINPUT properties and create a hash table.
    ${ProviderSpecificInput},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
    [System.String]
    # The target unique protection container name.
    ${TargetProtectionContainerId},

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

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.RecoveryServices.private\New-AzRecoveryServicesReplicationProtectionContainerMapping_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
