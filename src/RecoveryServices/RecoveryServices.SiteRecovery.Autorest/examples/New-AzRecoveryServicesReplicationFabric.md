### Example 1: Create a new Azure to Azure replication fabric in a specific recovery services vault
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

### Example 2: Create a new HyperV to Azure replication fabric in a specific recovery services vault
```powershell
$fabric = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.FabricSpecificCreationInput]::new()
$fabric.instanceType = "HyperVSite"
New-AzRecoveryServicesReplicationFabric -FabricName "hyperv2azurereplicafabric" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -CustomDetail $fabric
```

```output
Location Name                      Type
-------- ----                      ----
         hyperv2azurereplicafabric Microsoft.RecoveryServices/vaults/replicationFabrics
```

Creates a new replication fabric in a specified recovery services vault for a replicate HyperV to Azure instance type.