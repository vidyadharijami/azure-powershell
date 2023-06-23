### Example 2: Enable Protection
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pri = Get-AzRecoveryServicesReplicationProtectableItem -FabricName "HyperV2AzureSite" -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProtectableItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$pcm = Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
$ump = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureEnableProtectionInput]::new()
$ump.VMName = "MihirVM2"
$ump.TargetAzureV2ResourceGroupId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting"
$ump.TargetStorageAccountId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.Storage/storageAccounts/hyperv2azurestorageeus"
$ump.TargetAzureV2ResourceGroupId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting"
$ump.InstanceType = "HyperVReplicaAzure"
$ump.OSType = "Linux"
$ump.HvHostVMId = "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$ump.TargetAzureVMName = "MihirVM2"
New-AzRecoveryServicesReplicationProtectedItem -ProtectionContainerMapping $pcm -ReplicatedProtectedItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $ump -ProtectableItem $pri
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationJobs…
```

Enable Protection for a protectable item that is passed.
