### Example 1: Disable Protection
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "fec2a27c-8e47-4063-81a9-42933bd18bd7"
$rrpi = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.DisableProtectionProviderSpecificInput]::new()
$rrpi.InstanceType = "DisableProtectionProviderSpecificInput"
Remove-AzRecoveryServicesReplicationProtectedItem -ProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicationProviderInput $rrpi
```

```output

```
Disables the protection for the specified replicated protected item in the given vault.

