### Example 1:  List all replication protection containers in a recovery services vault.
```powershell
Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
```

```output
Location Name                                       Type
-------- ----                                       ----
         cloud_50c02c4e-3f5a-5e54-a971-8874f186019b Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers
         HyperV2AzureContainer                      Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers
```

Gets all the replication protection containers in the specified vault in the specified resource group.

### Example 2: List all replication protection containers in a recovery services vault associated to a fabric.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
```

```output
Location Name                                       Type
-------- ----                                       ----
         cloud_50c02c4e-3f5a-5e54-a971-8874f186019b Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers
```

Gets all the replication protection containers in the specified vault in the specified resource group associated to specified fabric.

### Example 3: Get the details of a replication protection container using the fabric and protection container name.
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b"
```

```output
Location Name                                       Type
-------- ----                                       ----
         cloud_50c02c4e-3f5a-5e54-a971-8874f186019b Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers
```

Get all the details of specified replication protection container.
