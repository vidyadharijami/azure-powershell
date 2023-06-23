---
external help file:
Module Name: Az.RecoveryServices
online version: https://docs.microsoft.com/powershell/module/az.recoveryservices/get-azrecoveryservicesreplicationprotecteditem
schema: 2.0.0
---

# Get-AzRecoveryServicesReplicationProtectedItem

## SYNOPSIS


## SYNTAX

```
Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer <IProtectionContainer>
 -ResourceGroupName <String> -ResourceName <String> [-ReplicatedProtectedItemName <String>]
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION


## EXAMPLES

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

## PARAMETERS

### -DefaultProfile


```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionContainer
To construct, see NOTES section for PROTECTIONCONTAINER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainer
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicatedProtectedItemName


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainer

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`PROTECTIONCONTAINER <IProtectionContainer>`: 
  - `[Location <String>]`: Resource Location
  - `[FabricFriendlyName <String>]`: Fabric friendly name.
  - `[FabricType <String>]`: The fabric type.
  - `[FriendlyName <String>]`: The name.
  - `[PairingStatus <String>]`: The pairing status of this cloud.
  - `[ProtectedItemCount <Int32?>]`: Number of protected PEs.
  - `[Role <String>]`: The role of this cloud.

## RELATED LINKS

