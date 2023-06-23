### Example 1: Invoke a Unplanned Failover for a protected item.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pcm = Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$irpf = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureUnplannedFailoverInput]::new()
$irpf.InstanceType = "HyperVReplicaAzure"
Invoke-AzRecoveryServicesUnplannedReplicationProtectedItemFailover -ReplicationProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $irpf
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabri…
```

Invokes an unplnned failover for a replicated protected item to microsoft Azure.



