---
external help file:
Module Name: Az.RecoveryServices
online version: https://docs.microsoft.com/powershell/module/az.recoveryservices/get-azrecoveryservicesreplicationprotectioncontainer
schema: 2.0.0
---

# Get-AzRecoveryServicesReplicationProtectionContainer

## SYNOPSIS
Lists the protection containers in a vault.

## SYNTAX

### List1 (Default)
```
Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName <String> -ResourceName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzRecoveryServicesReplicationProtectionContainer -Fabric <IFabric> -ProtectionContainerName <String>
 -ResourceGroupName <String> -ResourceName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List
```
Get-AzRecoveryServicesReplicationProtectionContainer -Fabric <IFabric> -ResourceGroupName <String>
 -ResourceName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Lists the protection containers in a vault.

## EXAMPLES

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

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -Fabric
To construct, see NOTES section for FABRIC properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IFabric
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionContainerName


```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group where the recovery services vault is present.

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
The name of the recovery services vault.

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
The subscription Id.

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


`FABRIC <IFabric>`: 
  - `[Location <String>]`: Resource Location
  - `[BcdrState <String>]`: BCDR state of the fabric.
  - `[CustomDetailInstanceType <String>]`: Gets the class type. Overridden in derived classes.
  - `[EncryptionDetailKekCertExpiryDate <DateTime?>]`: The key encryption key certificate expiry date.
  - `[EncryptionDetailKekCertThumbprint <String>]`: The key encryption key certificate thumbprint.
  - `[EncryptionDetailKekState <String>]`: The key encryption key state for the Vmm.
  - `[FriendlyName <String>]`: Friendly name of the fabric.
  - `[Health <String>]`: Health of fabric.
  - `[HealthErrorDetail <IHealthError[]>]`: Fabric health error details.
    - `[CreationTimeUtc <DateTime?>]`: Error creation time (UTC).
    - `[CustomerResolvability <HealthErrorCustomerResolvability?>]`: Value indicating whether the health error is customer resolvable.
    - `[EntityId <String>]`: ID of the entity.
    - `[ErrorCategory <String>]`: Category of error.
    - `[ErrorCode <String>]`: Error code.
    - `[ErrorId <String>]`: The health error unique id.
    - `[ErrorLevel <String>]`: Level of error.
    - `[ErrorMessage <String>]`: Error message.
    - `[ErrorSource <String>]`: Source of error.
    - `[ErrorType <String>]`: Type of error.
    - `[InnerHealthError <IInnerHealthError[]>]`: The inner health errors. HealthError having a list of HealthError as child errors is problematic. InnerHealthError is used because this will prevent an infinite loop of structures when Hydra tries to auto-generate the contract. We are exposing the related health errors as inner health errors and all API consumers can utilize this in the same fashion as Exception -&gt; InnerException.
      - `[CreationTimeUtc <DateTime?>]`: Error creation time (UTC).
      - `[CustomerResolvability <HealthErrorCustomerResolvability?>]`: Value indicating whether the health error is customer resolvable.
      - `[EntityId <String>]`: ID of the entity.
      - `[ErrorCategory <String>]`: Category of error.
      - `[ErrorCode <String>]`: Error code.
      - `[ErrorId <String>]`: The health error unique id.
      - `[ErrorLevel <String>]`: Level of error.
      - `[ErrorMessage <String>]`: Error message.
      - `[ErrorSource <String>]`: Source of error.
      - `[ErrorType <String>]`: Type of error.
      - `[PossibleCaus <String>]`: Possible causes of error.
      - `[RecommendedAction <String>]`: Recommended action to resolve error.
      - `[RecoveryProviderErrorMessage <String>]`: DRA error message.
      - `[SummaryMessage <String>]`: Summary message of the entity.
    - `[PossibleCaus <String>]`: Possible causes of error.
    - `[RecommendedAction <String>]`: Recommended action to resolve error.
    - `[RecoveryProviderErrorMessage <String>]`: DRA error message.
    - `[SummaryMessage <String>]`: Summary message of the entity.
  - `[InternalIdentifier <String>]`: Dra Registration Id.
  - `[RolloverEncryptionDetailKekCertExpiryDate <DateTime?>]`: The key encryption key certificate expiry date.
  - `[RolloverEncryptionDetailKekCertThumbprint <String>]`: The key encryption key certificate thumbprint.
  - `[RolloverEncryptionDetailKekState <String>]`: The key encryption key state for the Vmm.

## RELATED LINKS

