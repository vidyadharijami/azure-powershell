### Example 1: List all replication fabrics in a recovery services vault.
```powershell
Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
```

```output
Location Name                     Type
-------- ----                     ----
         HyperV2AzureSite         Microsoft.RecoveryServices/vaults/replicationFabrics
         HyperV2AzureSiteFriendly Microsoft.RecoveryServices/vaults/replicationFabrics
```

Gets all the replication fabrics in the specified vault in the specified resource group.

### Example 2: Get the details of a replication fabric using the fabric name.
```powershell
Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
```

```output
Location Name             Type
-------- ----             ----
         HyperV2AzureSite Microsoft.RecoveryServices/vaults/replicationFabrics
```

Gets info for a specific replication fabric by its name in the specified vault in the specified resource group.


### Example 3: Get the details of a replication fabric using the friendly name of the fabric.
```powershell
Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FriendlyName "HyperV2AzureSiteFriendly"
```

```output
Location Name                     Type
-------- ----                     ----
         HyperV2AzureSiteFriendly Microsoft.RecoveryServices/vaults/replicationFabrics
```

Gets info for a specific replication policy by its friendly name in the specified vault in the specified resource group.


