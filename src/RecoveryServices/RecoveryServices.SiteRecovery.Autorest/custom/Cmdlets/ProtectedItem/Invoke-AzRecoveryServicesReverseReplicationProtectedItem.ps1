
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Operation to switch protection from one container to another or one replication provider to another.
.Description
Operation to switch protection from one container to another or one replication provider to another.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PROVIDERSPECIFICDETAIL <ISwitchProtectionProviderSpecificInput>: Provider specific switch protection input.
  ReplicationScenario <String>: Gets the Instance type.
.Link
https://docs.microsoft.com/powershell/module/az.recoveryservices/switch-azrecoveryservicesreplicationprotectioncontainerprotection
#>
function Invoke-AzRecoveryServicesReverseReplicationProtectedItem {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainer])]
    [CmdletBinding(DefaultParameterSetName='SwitchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMapping]
        # Protection container mapping object.
        ${ProtectionContainerMapping},

        [Parameter(Mandatory)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem]
        # Replication protected item Object.
        ${ReplicatedProtectedItem},

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Path')]
        [System.String]
        # The name of the resource group where the recovery services vault is present.
        ${ResourceGroupName},

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
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
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ISwitchProtectionProviderSpecificInput]
        # Provider specific switch protection input.
        # To construct, see NOTES section for PROVIDERSPECIFICDETAIL properties and create a hash table.
        ${ProviderSpecificDetail},

        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
        [System.String]
        # Primary Staging Azure Storage Account Id.
        ${LogStorageAccountId},

        [Parameter()]
        [ValidateNotNullOrEmpty()]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Category('Body')]
        [System.String]
        # Primary Staging Azure Storage Account Id.
        ${RecoveryAzureStorageAccountId},

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
            $replicationscenario = $ProviderSpecificDetail.ReplicationScenario
            if($replicationscenario -eq "ReplicateAzureToAzure") {
                $ProviderSpecificDetail.ReplicationScenario = "A2A"
            }
            else {
                throw "Provided replication scenario is not supported. Only ReplicateAzureToAzure is supported."
            }

            if($ProviderSpecificDetail.ReplicationScenario -ne $ProtectionContainerMapping.ProviderSpecificDetailInstanceType -or $ProviderSpecificDetail.ReplicationScenario -ne $ReplicatedProtectedItem.ProviderSpecificDetail.InstanceType) {
                throw "Input replication scenario and mapping replication scenario cannot be different"
            }

            CheckComputeModuleDependency

            if(-not [string]::IsNullOrEmpty($ReplicatedProtectedItem.ProviderSpecificDetail.RecoveryFabricObjectId)) {
                $Vmdetails = $ReplicatedProtectedItem.ProviderSpecificDetail.RecoveryFabricObjectId.Split("/")
            }
            else {
                throw 'Please provide fabric object id in provider specific detail input'
            }

            $VmResouceGroup = $Vmdetails[-5]
            $VmName = $Vmdetails[-1]
            $Vm = Get-AzVM -ResourceGroupName $VmResouceGroup -Name $VmName

            if($ProviderSpecificDetail.ReplicationScenario -eq "A2A") {
                if($ProviderSpecificDetail.VMManagedDisk -eq $null) {
                    if ($Vm.StorageProfile.OsDisk.ManagedDisk -ne $null) {
                        $diskInput = @()

                        $osDiskInput = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AVmManagedDiskInputDetails]::new()
                        $osDiskInput.DiskId = $Vm.StorageProfile.OsDisk.ManagedDisk.Id
                        $osDiskInput.PrimaryStagingAzureStorageAccountId = $LogStorageAccountId
                        $osDiskInput.RecoveryResourceGroupId = $ProviderSpecificDetail.RecoveryResourceGroupId
                        $osDiskInput.RecoveryReplicaDiskAccountType = $Vm.StorageProfile.OsDisk.ManagedDisk.StorageAccountType
                        $osDiskInput.RecoveryTargetDiskAccountType = $Vm.StorageProfile.OsDisk.ManagedDisk.StorageAccountType

                        $diskInput += $osDiskInput

                        if($Vm.StorageProfile.DataDisks.ManagedDisk -ne $null) {
                            $Vm.StorageProfile.DataDisks.ManagedDisk | ForEach-Object {
                                $dataDiskInput = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AVmManagedDiskInputDetails]::new()
                                $dataDiskInput.DiskId = $_.Id
                                $dataDiskInput.PrimaryStagingAzureStorageAccountId = $LogStorageAccountId
                                $dataDiskInput.RecoveryResourceGroupId = $ProviderSpecificDetail.RecoveryResourceGroupId
                                $dataDiskInput.RecoveryReplicaDiskAccountType = $_.StorageAccountType
                                $dataDiskInput.RecoveryTargetDiskAccountType = $_.StorageAccountType

                                $diskInput += $dataDiskInput
                            }
                        }

                        $ProviderSpecificDetail.VMManagedDisk = $diskInput
                    }
                    else {
                        if($RecoveryAzureStorageAccountId -ne $null) {
                            $vmdiskInput = @()

                            $osDiskInput = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AVmDiskInputDetails]::new()
                            $osDiskInput.DiskUri = $vm.StorageProfile.OsDisk.Vhd.Uri
                            $osDiskInput.PrimaryStagingAzureStorageAccountId = $LogStorageAccountId
                            $osDiskInput.RecoveryAzureStorageAccountId = $RecoveryAzureStorageAccountId

                            $vmdiskInput += $osDiskInput

                            if($Vm.StorageProfile.DataDisks -ne $null) {
                                $Vm.StorageProfile.DataDisks | ForEach-Object {
                                    $dataDiskInput = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AVmDiskInputDetails]::new()
                                    $dataDiskInput.DiskUri = $_.Vhd.Uri
                                    $dataDiskInput.PrimaryStagingAzureStorageAccountId = $LogStorageAccountId
                                    $dataDiskInput.RecoveryAzureStorageAccountId = $RecoveryAzureStorageAccountId

                                    $vmdiskInput += $dataDiskInput
                                }
                            }

                            $ProviderSpecificDetail.VMDisk = $vmdiskInput
                        }
                        else {
                            throw "Recovery Storage account is required for non-managed disk vm to protect"
                        }
                    }
                }
                else {
                    if ($Vm.StorageProfile.OsDisk.ManagedDisk -ne $null) {
                        $osDiskExist = $false

                        $ProviderSpecificDetail.VMManagedDisk | ForEach-Object {
                            if($_.DiskId -eq $Vm.StorageProfile.OsDisk.ManagedDisk.Id) {
                                $osDiskExist = $true
                            }
                        }

                        if($osDiskExist -eq $false) {
                            $osDiskInput = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AVmManagedDiskInputDetails]::new()
                            $osDiskInput.DiskId = $vm.StorageProfile.OsDisk.ManagedDisk.Id
                            $osDiskInput.PrimaryStagingAzureStorageAccountId = $LogStorageAccountId
                            $osDiskInput.RecoveryResourceGroupId = $ProviderSpecificDetail.RecoveryResourceGroupId
                            $osDiskInput.RecoveryReplicaDiskAccountType = $Vm.StorageProfile.OsDisk.ManagedDisk.StorageAccountType
                            $osDiskInput.RecoveryTargetDiskAccountType = $Vm.StorageProfile.OsDisk.ManagedDisk.StorageAccountType

                            $Vm.StorageProfile.OsDisk.ManagedDisk += $osDiskInput
                        }
                    }
                }
            } else {
                throw "Valid operation for Azure to Azure scenario only"
            }

            if(-not [string]::IsNullOrEmpty($ReplicatedProtectedItem.id)) {
                $replicatedItem = $ReplicatedProtectedItem.id.Split("/")
            }
            else {
                throw 'Replicated Item does not contain an ARM Id. Please check the replicated item details'
            }

            $replicatedItemName = $replicatedItem[-1]
            $protectionContainerName = $replicatedItem[-3]
            $fabricName = $replicatedItem[-5]

            if($ProviderSpecificDetail.PolicyId -eq $null){
                $ProviderSpecificDetail.PolicyId = $ProtectionContainerMapping.PolicyId
            }

            if($ProviderSpecificDetail.RecoveryContainerId -eq $null) {
                $ProviderSpecificDetail.RecoveryContainerId = $ProtectionContainerMapping.TargetProtectionContainerId
            }

            $null = $PSBoundParameters.Remove("ReplicatedProtectedItem")
            $null = $PSBoundParameters.Remove("LogStorageAccountId")
            $null = $PSBoundParameters.Remove("RecoveryAzureStorageAccountId")
            $null = $PSBoundParameters.Remove("ProtectionContainerMapping")
            $null = $PSBoundParameters.Add("ReplicationProtectedItemName", $replicatedItemName)
            $null = $PSBoundParameters.Add("FabricName", $fabricName)
            $null = $PSBoundParameters.Add("ProtectionContainerName", $protectionContainerName)
            $null = $PSBoundParameters.Add("NoWait", $true)

            $output = Az.RecoveryServices.internal\Switch-AzRecoveryServicesReplicationProtectionContainerProtection @PSBoundParameters
            
            if(-not [string]::IsNullOrEmpty($output.Target)) {
                $JobName = $output.Target.Split("/")[-1].Split("?")[0]
            }
            else {
                throw 'The process has not returned any job id.'
            }

            $null = $PSBoundParameters.Remove("ReplicationProtectedItemName")
            $null = $PSBoundParameters.Remove("FabricName")
            $null = $PSBoundParameters.Remove("ProtectionContainerName")
            $null = $PSBoundParameters.Remove("NoWait")
            $null = $PSBoundParameters.Remove("ProviderSpecificDetail")
            $null = $PSBoundParameters.Add("JobName", $JobName)

            return Get-AzRecoveryServicesReplicationJob @PSBoundParameters
        } catch {
            throw
        }
    } 
}
