---
external help file:
Module Name: Az.RecoveryServices
online version: https://docs.microsoft.com/powershell/module/az.recoveryservices/add-azrecoveryservicesreplicationprotecteditemrecoverypoint
schema: 2.0.0
---

# Invoke-AzRecoveryServicesReplicationProtectedItemApplyRecoveryPoint

## SYNOPSIS
The operation to change the recovery point of a failed over replication protected item.

## SYNTAX

```
Invoke-AzRecoveryServicesReplicationProtectedItemApplyRecoveryPoint
 -ReplicationProtectedItem <IReplicationProtectedItem> -ResourceGroupName <String> -ResourceName <String>
 -ProviderSpecificDetail <IApplyRecoveryPointProviderSpecificInput> -RecoveryPointId <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [<CommonParameters>]
```

## DESCRIPTION
The operation to change the recovery point of a failed over replication protected item.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
$fab = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -FabricName "HyperV2AzureSite"
$pc = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Fabric $fab
$pi = Get-AzRecoveryServicesReplicationProtectedItem -ProtectionContainer $pc  -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ReplicatedProtectedItemName "4e7bca9e-cce0-4df2-963e-047724b7804c"
$rp = Get-AzRecoveryServicesRecoveryPoint -FabricName $fab.Name -ProtectionContainerName $pc.Name -ReplicatedProtectedItemName $pi.Name -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -Name "8918b5ed-ce25-4715-bb33-106b90b84d8a"
$arp = [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.HyperVReplicaAzureApplyRecoveryPointInput]::new()
$arp.InstanceType = "HyperVReplicaAzure"
Invoke-AzRecoveryServicesReplicationProtectedItemApplyRecoveryPoint -RecoveryPointId $rp.Id -ReplicationProtectedItem $pi -ResourceGroupName "ASRTesting" -ResourceName "HyperV2AzureVault" -ProviderSpecificDetail $arp
```

```output
Id
--
/Subscriptions/7c943c1b-5122-4097-90c8-861411bdd574/resourceGroups/ASRTesting/providers/Microsoft.RecoveryServices/vaults/HyperV2AzureVault/replicationJobs/…
```

{{ Add description here }}

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

### -ProviderSpecificDetail
Provider specific input for applying recovery point.
To construct, see NOTES section for PROVIDERSPECIFICDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IApplyRecoveryPointProviderSpecificInput
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecoveryPointId
The recovery point Id.

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

### -ReplicationProtectedItem
Replication Protected item
To construct, see NOTES section for REPLICATIONPROTECTEDITEM properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Api20230201.IReplicationProtectedItem
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
Default value: (Get-AzContext).Subscription.Id
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


`PROVIDERSPECIFICDETAIL <IApplyRecoveryPointProviderSpecificInput>`: Provider specific input for applying recovery point.
  - `InstanceType <String>`: The class type.

`REPLICATIONPROTECTEDITEM <IReplicationProtectedItem>`: Replication Protected item
  - `[Location <String>]`: Resource Location
  - `[ActiveLocation <String>]`: The Current active location of the PE.
  - `[AllowedOperation <String[]>]`: The allowed operations on the Replication protected item.
  - `[CurrentScenarioJobId <String>]`: ARM Id of the job being executed.
  - `[CurrentScenarioName <String>]`: Scenario name.
  - `[CurrentScenarioStartTime <DateTime?>]`: Start time of the workflow.
  - `[EventCorrelationId <String>]`: The correlation Id for events associated with this protected item.
  - `[FailoverHealth <String>]`: The consolidated failover health for the VM.
  - `[FailoverRecoveryPointId <String>]`: The recovery point ARM Id to which the Vm was failed over.
  - `[FriendlyName <String>]`: The name.
  - `[HealthError <IHealthError[]>]`: List of health errors.
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
  - `[LastSuccessfulFailoverTime <DateTime?>]`: The Last successful failover time.
  - `[LastSuccessfulTestFailoverTime <DateTime?>]`: The Last successful test failover time.
  - `[PolicyFriendlyName <String>]`: The name of Policy governing this PE.
  - `[PolicyId <String>]`: The ID of Policy governing this PE.
  - `[PrimaryFabricFriendlyName <String>]`: The friendly name of the primary fabric.
  - `[PrimaryFabricProvider <String>]`: The fabric provider of the primary fabric.
  - `[PrimaryProtectionContainerFriendlyName <String>]`: The name of primary protection container friendly name.
  - `[ProtectableItemId <String>]`: The protected item ARM Id.
  - `[ProtectedItemType <String>]`: The type of protected item type.
  - `[ProtectionState <String>]`: The protection status.
  - `[ProtectionStateDescription <String>]`: The protection state description.
  - `[ProviderSpecificDetailInstanceType <String>]`: Gets the Instance type.
  - `[RecoveryContainerId <String>]`: The recovery container Id.
  - `[RecoveryFabricFriendlyName <String>]`: The friendly name of recovery fabric.
  - `[RecoveryFabricId <String>]`: The Arm Id of recovery fabric.
  - `[RecoveryProtectionContainerFriendlyName <String>]`: The name of recovery container friendly name.
  - `[RecoveryServicesProviderId <String>]`: The recovery provider ARM Id.
  - `[ReplicationHealth <String>]`: The consolidated protection health for the VM taking any issues with SRS as well as all the replication units associated with the VM's replication group into account. This is a string representation of the ProtectionHealth enumeration.
  - `[SwitchProviderState <String>]`: The switch provider state.
  - `[SwitchProviderStateDescription <String>]`: The switch provider state description.
  - `[TestFailoverState <String>]`: The Test failover state.
  - `[TestFailoverStateDescription <String>]`: The Test failover state description.

## RELATED LINKS

