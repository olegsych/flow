# clone
This repository contains submodules and symlinks.
```PowerShell
git clone --recurse-submodules -c core.symlinks=true https://github.com/olegsych/flow.git
```

# build
Use [Visual Studio](https://visualstudio.microsoft.com/downloads) or command line.
```PowerShell
dotnet build .\Athene.sln
```

# test
Use Visual Studio or command line.
```PowerShell
dotnet test .\Athene.sln
```

# pull request
Pull requests are automatically validated by [AppVeyor](https://ci.appveyor.com/project/olegsych/flow).

# continuous integration
The [AppVeyor build](https://ci.appveyor.com/project/olegsych/flow) is automatically triggered for the master branch.
Build settings are defined in [appveyor.yml](./appveyor.yml).

# release
Builds are [published](https://ci.appveyor.com/project/olegsych/flow/deployments) to the
[NuGet package feed](https://www.nuget.org/packages) when changes are ready for public consumption.
