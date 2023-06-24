### Example 1: Create a new replication fabric in a specific recovery services vault
```powershell
$fabric = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.AzureFabricCreationInput]::new()
$fabric.ReplicationScenario="ReplicateAzureToAzure"
$fabric.Location="East US"
New-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "demofabric" -ProviderDetail $fabric
```

```output
Id                                                                                                                                                                             Location Name          Type
--                                                                                                                                                                             -------- ----          ----
/Subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/a2arecoveryrg/providers/Microsoft.RecoveryServices/vaults/a2arecoveryvault/replicationFabrics/testfabriccmd          testfabriccmd Microsoft.RecoveryServices/vaults/replicationFabrics
```

Creates a new replication fabric in a specified recovery services vault for a replicateAzuretoAzure instance type.

### Example 2: Create a new replication fabric in a specific recovery services vault
```powershell
$fabr = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificCreationInput]::new()
$fabr.ReplicationScenario = "FabricSpecificCreationInput"
New-AzRecoveryServicesReplicationFabric -FabricName "hyperv2azure2replicafabric" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderDetail $fabr
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationFabri…
```

Creates a new replication fabric in a specified recovery services vault for a replicateHyperV to Azure instance type.

