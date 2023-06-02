### Example 1: Create a replication protection container in a fabric.
```powershell
$fabric=Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -FabricName "A2Aprimaryfabric"
$protectioncontainer=[Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.A2AContainerCreationInput]::new()
$protectioncontainer.InstanceType="A2A"
New-AzRecoveryServicesReplicationProtectionContainer -Fabric $fabric -ProtectionContainerName "demoProtectionContainerA2A" -ResourceGroupName "a2arecoveryrg" -ResourceName "a2arecoveryvault" -ProviderSpecificInput $protectioncontainer
```

```output
Location Name                       Type
-------- ----                       ----
         demoProtectionContainerA2A Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers
```

Creates a replication protection container in a fabric in a specific recovery services vault.