### Example 1: Test Failover Cleanup
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pcm = Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
Test-AzRecoveryServicesReplicationProtectedItemFailoverCleanup -ProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Comment "Test"
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV…
```

Cleans up the resources and VM created during the Test Failover command.

