### Example 1: Create a new replication fabric in a specific recovery services vault
```powershell
$fabric = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.AzureFabricCreationInput]::new()
$fabric.InstanceType="Azure"
$fabric.Location="East US"
New-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "demofabric" -CustomDetail $fabric
```

```output
Location Name       Type
-------- ----       ----
         demofabric Microsoft.RecoveryServices/vaults/replicationFabrics
```

Creates a new replication fabric in a specified recovery services vault for a replicateAzuretoAzure instance type.

