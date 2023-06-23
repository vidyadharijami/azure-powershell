### Example 1: Create a new replication protection container mapping
```powershell
$psi = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.ReplicationProviderSpecificContainerMappingInput]::new()
$psi.InstanceType = "ReplicationProviderSpecificContainerMappingInput"
$ppc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fabric -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b"
$fabric = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$policy = Get-AzRecoveryServicesReplicationPolicy -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -PolicyName "replicapolicyh2a"
New-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -PrimaryProtectionContainer $ppc  -Policy $policy -MappingName "hyperv2azurenm" -ProviderSpecificInput $psi
```

```output
Location Name           Type
-------- ----           ----
         hyperv2azurenm Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectionContainerMappings
```

Creates a New Hyper-V to Azure protection container mapping in a recovery services vault.


