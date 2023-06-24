---
external help file:
Module Name: Az.RecoveryServices
online version: https://docs.microsoft.com/powershell/module/az.recoveryservices/new-azrecoveryservicesreplicationprotecteditem
schema: 2.0.0
---

# New-AzRecoveryServicesReplicationProtectedItem

## SYNOPSIS
The operation to create an ASR replication protected item (Enable replication).

## SYNTAX

```
New-AzRecoveryServicesReplicationProtectedItem -ProtectionContainerMapping <IProtectionContainerMapping>
 -ReplicatedProtectedItemName <String> -ResourceGroupName <String> -ResourceName <String>
 -ProtectableItem <IProtectableItem> -ProviderSpecificDetail <IEnableProtectionProviderSpecificInput>
 [-SubscriptionId <String>] [-PolicyId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The operation to create an ASR replication protected item (Enable replication).

## EXAMPLES

### Example 2: Enable Protection
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pri = Get-AzRecoveryServicesReplicationProtectableItem -FabricName "HyperV2AzureSite" -ProtectionContainerName "cloud_50c02c4e-3f5a-5e54-a971-8874f186019b" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProtectableItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$pcm = Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault"
$ump = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureEnableProtectionInput]::new()
$ump.VMName = "MihirVM2"
$ump.TargetAzureV2ResourceGroupId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting"
$ump.TargetStorageAccountId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.Storage/storageAccounts/hyperv2azurestorageeus"
$ump.TargetAzureV2ResourceGroupId = "/subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting"
$ump.InstanceType = "HyperVReplicaAzure"
$ump.OSType = "Linux"
$ump.HvHostVMId = "14f0d8bf-5804-407b-b1e1-c7a224c1010a"
$ump.TargetAzureVMName = "MihirVM2"
New-AzRecoveryServicesReplicationProtectedItem -ProtectionContainerMapping $pcm -ReplicatedProtectedItemName "14f0d8bf-5804-407b-b1e1-c7a224c1010a" -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $ump -ProtectableItem $pri
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationJobs…
```

Enable Protection for a protectable item that is passed.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

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

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyId
The Policy Id.

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

### -ProtectableItem
The protectable item Object.
To construct, see NOTES section for PROTECTABLEITEM properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectableItem
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectionContainerMapping
Protection container mapping object.
To construct, see NOTES section for PROTECTIONCONTAINERMAPPING properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IProtectionContainerMapping
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProviderSpecificDetail
The ReplicationProviderInput.
For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object.
For San provider, it will be SanEnableProtectionInput object.
For HyperVReplicaAzure provider, it can be null.
To construct, see NOTES section for PROVIDERSPECIFICDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IEnableProtectionProviderSpecificInput
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicatedProtectedItemName
A name for the replication protected item.

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
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IJob

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`PROTECTABLEITEM <IProtectableItem>`: The protectable item Object.
  - `[Location <String>]`: Resource Location
  - `[CustomDetailInstanceType <String>]`: Gets the class type. Overridden in derived classes.
  - `[FriendlyName <String>]`: The name.
  - `[ProtectionReadinessError <String[]>]`: The Current protection readiness errors.
  - `[ProtectionStatus <String>]`: The protection status.
  - `[RecoveryServicesProviderId <String>]`: The recovery provider ARM Id.
  - `[ReplicationProtectedItemId <String>]`: The ARM resource of protected items.
  - `[SupportedReplicationProvider <String[]>]`: The list of replication providers supported for the protectable item.

`PROTECTIONCONTAINERMAPPING <IProtectionContainerMapping>`: Protection container mapping object.
  - `[Location <String>]`: Resource Location
  - `[Health <String>]`: Health of pairing.
  - `[HealthErrorDetail <IHealthError[]>]`: Health error.
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
  - `[PolicyFriendlyName <String>]`: Friendly name of replication policy.
  - `[PolicyId <String>]`: Policy ARM Id.
  - `[ProviderSpecificDetailInstanceType <String>]`: Gets the class type. Overridden in derived classes.
  - `[SourceFabricFriendlyName <String>]`: Friendly name of source fabric.
  - `[SourceProtectionContainerFriendlyName <String>]`: Friendly name of source protection container.
  - `[State <String>]`: Association Status.
  - `[TargetFabricFriendlyName <String>]`: Friendly name of target fabric.
  - `[TargetProtectionContainerFriendlyName <String>]`: Friendly name of paired container.
  - `[TargetProtectionContainerId <String>]`: Paired protection container ARM ID.

`PROVIDERSPECIFICDETAIL <IEnableProtectionProviderSpecificInput>`: The ReplicationProviderInput. For HyperVReplicaAzure provider, it will be AzureEnableProtectionInput object. For San provider, it will be SanEnableProtectionInput object. For HyperVReplicaAzure provider, it can be null.
  - `InstanceType <String>`: The class type.

## RELATED LINKS

