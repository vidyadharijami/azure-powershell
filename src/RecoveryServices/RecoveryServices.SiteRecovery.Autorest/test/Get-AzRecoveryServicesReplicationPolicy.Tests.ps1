if(($null -eq $TestName) -or ($TestName -contains 'Get-AzRecoveryServicesReplicationPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzRecoveryServicesReplicationPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzRecoveryServicesReplicationPolicy' {
    It 'List' {
        $output = Get-AzRecoveryServicesReplicationPolicy -ResourceName $env.a2aVaultName -ResourceGroupName $env.a2aResourceGroupName -SubscriptionId $env.a2aSubscriptionId
<<<<<<< HEAD
        $output.Count | Should Not BeNullOrEmpty
=======
        $output.Count | Should -BeGreaterOrEqual 1 
>>>>>>> 9c081c4212d626ff5bb34be7af9539ac02be1b04
    }

    It 'Get' {
        $output = Get-AzRecoveryServicesReplicationPolicy -PolicyName $env.a2aPolicyName -ResourceName $env.a2aVaultName -ResourceGroupName $env.a2aResourceGroupName -SubscriptionId $env.a2aSubscriptionId
<<<<<<< HEAD
        $output.Count | Should Not BeNullOrEmpty
=======
        $output.Count | Should -BeGreaterOrEqual 1
>>>>>>> 9c081c4212d626ff5bb34be7af9539ac02be1b04
    }
}
