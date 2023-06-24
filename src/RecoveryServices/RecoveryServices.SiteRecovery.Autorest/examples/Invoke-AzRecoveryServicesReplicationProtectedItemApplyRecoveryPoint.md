### Example 2: Apply recovery point to a failover replicated protected item.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "4e7bca9e-cce0-4df2-963e-047724b7804c"
$rp = Get-AzRecoveryServicesRecoveryPoint -FabricName $fab.Name -ProtectionContainerName $pc.Name -ReplicatedProtectedItemName $pi.Name -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Name "8918b5ed-ce25-4715-bb33-106b90b84d8a"
$arp = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureApplyRecoveryPointInput]::new()
$arp.InstanceType = "HyperVReplicaAzure"
Invoke-AzRecoveryServicesReplicationProtectedItemApplyRecoveryPoint -RecoveryPointId $rp.Id -ReplicationProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $arp
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationJobs/…
```

Applies a recvery point to the already failed over protected item.

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}