### Example 1: Remov the fabric passed as parameter.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "hyperv2azurereplicafabric"
Remove-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
```

```output

```

Removes the replication fabric passed as parameter.

