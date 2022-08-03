# DotNet
Sample DotNet project

# Commands
```dotnet build HelloWorld.sln```

```dotnet test HelloWorld.sln --logger:"nunit;LogFilePath=TestResult.xml"```

```OpenCover.Console.exe -target:dotnet.exe -targetargs:"test HelloWorldTest\HelloWorldTest.csproj" -output:"OpenCover.xml" -oldstyle -register:user"```
