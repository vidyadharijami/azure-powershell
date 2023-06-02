if(($null -eq $TestName) -or ($TestName -contains 'Clear-AzRecoveryServicesReplicationProtectionContainerMapping'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Clear-AzRecoveryServicesReplicationProtectionContainerMapping.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Clear-AzRecoveryServicesReplicationProtectionContainerMapping' {
    It 'Purge' {
        $fabric = Get-AzRecoveryServicesReplicationFabric -ResourceGroupName $env.a2aResourceGroupName -ResourceName $env.a2aVaultName -FabricName $env.a2ampfabricname -SubscriptionId $env.a2aSubscriptionId
        $protectioncontainer = Get-AzRecoveryServicesReplicationProtectionContainer -ResourceGroupName $env.a2aResourceGroupName -ResourceName $env.a2aVaultName -Fabric $fabric -ProtectionContainer $env.a2amppcname -SubscriptionId $env.a2aSubscriptionId
        $pcmapping = Get-AzRecoveryServicesReplicationProtectionContainerMapping -ResourceGroupName $env.a2aResourceGroupName -ResourceName $env.a2aVaultName -ProtectionContainer $protectioncontainer -MappingName $env.mappingName -SubscriptionId $env.a2aSubscriptionId
        {Clear-AzRecoveryServicesReplicationProtectionContainerMapping -InputObject $pcmapping -ResourceGroupName $env.a2aResourceGroupName -ResourceName $env.a2aVaultName -SubscriptionId $env.a2aSubscriptionId} | Should Not Throw
    }
}
