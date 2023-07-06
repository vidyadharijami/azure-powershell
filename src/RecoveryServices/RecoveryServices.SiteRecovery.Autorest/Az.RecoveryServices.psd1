@{
  GUID = 'cf85108a-4c89-4e06-b739-fd0910c5a866'
  RootModule = './Az.RecoveryServices.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: RecoveryServices cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.RecoveryServices.private.dll'
  FormatsToProcess = './Az.RecoveryServices.format.ps1xml'
  FunctionsToExport = 'Add-AzRecoveryServicesReplicationProtectedItemDisk', 'Clear-AzRecoveryServicesReplicationFabric', 'Clear-AzRecoveryServicesReplicationProtectedItem', 'Clear-AzRecoveryServicesReplicationRecoveryServicesProvider', 'Export-AzRecoveryServicesReplicationJob', 'Find-AzRecoveryServicesReplicationProtectionContainerProtectableItem', 'Get-AzRecoveryServicesMigrationRecoveryPoint', 'Get-AzRecoveryServicesRecoveryPoint', 'Get-AzRecoveryServicesReplicationAlertSetting', 'Get-AzRecoveryServicesReplicationAppliance', 'Get-AzRecoveryServicesReplicationEligibilityResult', 'Get-AzRecoveryServicesReplicationEvent', 'Get-AzRecoveryServicesReplicationFabric', 'Get-AzRecoveryServicesReplicationJob', 'Get-AzRecoveryServicesReplicationLogicalNetwork', 'Get-AzRecoveryServicesReplicationMigrationItem', 'Get-AzRecoveryServicesReplicationNetwork', 'Get-AzRecoveryServicesReplicationNetworkMapping', 'Get-AzRecoveryServicesReplicationPolicy', 'Get-AzRecoveryServicesReplicationProtectableItem', 'Get-AzRecoveryServicesReplicationProtectedItem', 'Get-AzRecoveryServicesReplicationProtectionContainer', 'Get-AzRecoveryServicesReplicationProtectionContainerMapping', 'Get-AzRecoveryServicesReplicationProtectionIntent', 'Get-AzRecoveryServicesReplicationRecoveryPlan', 'Get-AzRecoveryServicesReplicationRecoveryServiceProvider', 'Get-AzRecoveryServicesReplicationRecoveryServicesProvider', 'Get-AzRecoveryServicesReplicationStorageClassification', 'Get-AzRecoveryServicesReplicationStorageClassificationMapping', 'Get-AzRecoveryServicesReplicationVaultHealth', 'Get-AzRecoveryServicesReplicationVaultSetting', 'Get-AzRecoveryServicesReplicationvCenter', 'Get-AzRecoveryServicesSupportedOperatingSystem', 'Get-AzRecoveryServicesTargetComputeSize', 'Invoke-AzRecoveryServicesCommitReplicationProtectedItemFailover', 'Invoke-AzRecoveryServicesCommitReplicationRecoveryPlanFailover', 'Invoke-AzRecoveryServicesPlannedReplicationProtectedItemFailover', 'Invoke-AzRecoveryServicesPlannedReplicationRecoveryPlanFailover', 'Invoke-AzRecoveryServicesRenewReplicationFabricCertificate', 'Invoke-AzRecoveryServicesReplicationProtectedItemApplyRecoveryPoint', 'Invoke-AzRecoveryServicesReprotectReplicationProtectedItem', 'Invoke-AzRecoveryServicesReprotectReplicationRecoveryPlan', 'Invoke-AzRecoveryServicesResyncReplicationMigrationItem', 'Invoke-AzRecoveryServicesReverseReplicationProtectedItem', 'Invoke-AzRecoveryServicesUnplannedReplicationProtectedItemFailover', 'Invoke-AzRecoveryServicesUnplannedReplicationRecoveryPlanFailover', 'Move-AzRecoveryServicesReplicationFabricGateway', 'Move-AzRecoveryServicesReplicationFabricToAad', 'Move-AzRecoveryServicesReplicationMigrationItem', 'New-AzRecoveryServicesReplicationAlertSetting', 'New-AzRecoveryServicesReplicationFabric', 'New-AzRecoveryServicesReplicationMigrationItem', 'New-AzRecoveryServicesReplicationNetworkMapping', 'New-AzRecoveryServicesReplicationPolicy', 'New-AzRecoveryServicesReplicationProtectedItem', 'New-AzRecoveryServicesReplicationProtectionContainer', 'New-AzRecoveryServicesReplicationProtectionContainerMapping', 'New-AzRecoveryServicesReplicationProtectionIntent', 'New-AzRecoveryServicesReplicationRecoveryPlan', 'New-AzRecoveryServicesReplicationRecoveryServicesProvider', 'New-AzRecoveryServicesReplicationStorageClassificationMapping', 'New-AzRecoveryServicesReplicationVaultSetting', 'New-AzRecoveryServicesReplicationvCenter', 'New-AzRecoveryServicesReplicationVmNicConfig', 'New-AzRecoveryServicesReplicationVmNicIPConfig', 'Remove-AzRecoveryServicesReplicationFabric', 'Remove-AzRecoveryServicesReplicationMigrationItem', 'Remove-AzRecoveryServicesReplicationNetworkMapping', 'Remove-AzRecoveryServicesReplicationPolicy', 'Remove-AzRecoveryServicesReplicationProtectedItem', 'Remove-AzRecoveryServicesReplicationProtectedItemDisk', 'Remove-AzRecoveryServicesReplicationProtectionContainer', 'Remove-AzRecoveryServicesReplicationProtectionContainerMapping', 'Remove-AzRecoveryServicesReplicationRecoveryPlan', 'Remove-AzRecoveryServicesReplicationRecoveryServicesProvider', 'Remove-AzRecoveryServicesReplicationStorageClassificationMapping', 'Remove-AzRecoveryServicesReplicationvCenter', 'Repair-AzRecoveryServicesReplicationProtectedItemReplication', 'Resolve-AzRecoveryServicesReplicationProtectedItemHealthError', 'Restart-AzRecoveryServicesReplicationJob', 'Resume-AzRecoveryServicesReplicationJob', 'Resume-AzRecoveryServicesReplicationMigrationItemReplication', 'Stop-AzRecoveryServicesReplicationJob', 'Stop-AzRecoveryServicesReplicationProtectedItemFailover', 'Stop-AzRecoveryServicesReplicationRecoveryPlanFailover', 'Suspend-AzRecoveryServicesReplicationMigrationItemReplication', 'Switch-AzRecoveryServicesReplicationProtectedItemProvider', 'Test-AzRecoveryServicesReplicationFabricConsistency', 'Test-AzRecoveryServicesReplicationMigrationItemMigrate', 'Test-AzRecoveryServicesReplicationMigrationItemMigrateCleanup', 'Test-AzRecoveryServicesReplicationProtectedItemFailover', 'Test-AzRecoveryServicesReplicationProtectedItemFailoverCleanup', 'Test-AzRecoveryServicesReplicationRecoveryPlanFailover', 'Test-AzRecoveryServicesReplicationRecoveryPlanFailoverCleanup', 'Update-AzRecoveryServicesReplicationMigrationItem', 'Update-AzRecoveryServicesReplicationNetworkMapping', 'Update-AzRecoveryServicesReplicationPolicy', 'Update-AzRecoveryServicesReplicationProtectedItem', 'Update-AzRecoveryServicesReplicationProtectedItemAppliance', 'Update-AzRecoveryServicesReplicationProtectedItemMobilityService', 'Update-AzRecoveryServicesReplicationProtectionContainerMapping', 'Update-AzRecoveryServicesReplicationRecoveryPlan', 'Update-AzRecoveryServicesReplicationRecoveryServiceProvider', 'Update-AzRecoveryServicesReplicationVaultHealth', 'Update-AzRecoveryServicesReplicationvCenter', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'RecoveryServices'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
