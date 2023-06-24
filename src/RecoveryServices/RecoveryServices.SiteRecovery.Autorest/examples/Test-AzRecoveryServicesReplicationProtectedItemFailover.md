### Example 1: Test Failover
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName 
"14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$trpi = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureTestFailoverInput]::new()
$trpi.InstanceType = "HyperVReplicaAzure"
Test-AzRecoveryServicesReplicationProtectedItemFailover -ProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $trpi -NetworkId "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourcegroups/ASRTesting/providers/Microsoft.Network/virtualNetworks/HyperV2AzureNet" -NetworkType "VmNetworkAsInput"
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/c…
```

Invokes a test failover of the protected item to Microsoft azure.

