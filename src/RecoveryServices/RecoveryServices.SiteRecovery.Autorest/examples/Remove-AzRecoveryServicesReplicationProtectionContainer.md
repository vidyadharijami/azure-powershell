### Example 1: Remove a Protection Container from the Vault.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b" 
Remove-AzRecoveryServicesReplicationProtectionContainer -fabric $fab -ProtectionContainer $pc -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
```

```output
```

Removes a specified protection container from the given vault.

