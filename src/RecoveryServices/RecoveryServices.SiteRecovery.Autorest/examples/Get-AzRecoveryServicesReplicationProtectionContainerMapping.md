### Example 1: Get all the protection container mapping
```powershell
Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
```

```output
Location Name             Type
-------- ----             ----
         h2apolicyMapping Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectionContainerMappings
```

Gets all the protection container mapping in a vault.

### Example 2: Get the protection container in a container.
```powershell
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b"
Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProtectionContainer $pc
```

```output
Location Name             Type
-------- ----             ----
         h2apolicyMapping Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectionContainerMappings
```

Gets all the protection container mapping in the protection container.

### Example 3: Get the protection container mapping with the given specification.
```powershell
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b"
Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProtectionContainer $pc -MappingName "h2apolicyMapping"
```

```output
Location Name             Type
-------- ----             ----
         h2apolicyMapping Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectionContainerMappings
```

Gets the protection container mapping object with the given details.
