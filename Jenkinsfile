String workspace
node {
  stage 'BUILD'
  workspace = pwd()
  git url: 'https://github.com/timvanrooijen63/phoneshop/', branch: 'master', credentialsId: '3ad019e6-6217-4f0a-96c4-58f98f80e9ae'
  bat "C:\\tools\\nuget.exe restore   \"${workspace}\\PhoneShop.sln\""
  bat '"C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\MSBuild.exe"' "${workspace}\\PhoneShop.sln"
}


