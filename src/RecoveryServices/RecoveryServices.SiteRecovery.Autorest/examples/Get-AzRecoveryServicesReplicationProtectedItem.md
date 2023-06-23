### Example 1: List all the replication protected item
```powershell
Get-AzRecoveryServicesReplicationProtectedItem -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault"
```

```output
Location Name              Type
-------- ----              ----
         replicatedvmtest  Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectedItems
         replicatedvmtest2 Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectedItems
```

Lists all the Azure to Azure replication protected item in a recovery services vault.

### Example 2: List all the replication protected item linked with a protection container
```powershell
$fabric=Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "A2Ademo-EastUS"
$protectioncontainer=Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -Fabric $fabric -ProtectionContainer "A2AEastUSProtectionContainer"
Get-AzRecoveryServicesReplicationProtectedItem -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -ProtectionContainer $protectioncontainer
```

```output
Location Name              Type
-------- ----              ----
         replicatedvmtest  Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectedItems
         replicatedvmtest2 Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectedItems
```

Lists all the replication protected item linked with a protection container in a recovery services vault

### Example 3: Get a replication protected item linked with a protection container with a replicated protected item name
```powershell
$fabric=Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "A2Ademo-EastUS"
$protectioncontainer=Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -Fabric $fabric -ProtectionContainer "A2AEastUSProtectionContainer"
Get-AzRecoveryServicesReplicationProtectedItem -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -ProtectionContainer $protectioncontainer -ReplicatedProtectedItemName "replicatedvmtest"
```

```output
Location Name              Type
-------- ----              ----
         replicatedvmtest  Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationProtectedItems
```

Gets a replication protected item linked with a protection container with a replicated protected item name in a recovery services vault

### Example 1: List all the replication protected item
```powershell
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b"
Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
```

```output
Id
--                                                                                                                                                                                                                 
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/cl…
```

Gets all the HyperV to Azure protected items.

### Example 2: {{ Add title here }}
```powershell
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b" 
Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabrics/HyperV2AzureSite/replicationProtectionContainers/c…
```
Gets the HyperV to Azure protected item with given specifications.

