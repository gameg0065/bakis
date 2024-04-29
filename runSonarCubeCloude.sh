
# EASY APP

## Cloude tests run.

# UnitTestGeneration.Easy.Tests.Cloude.Prompt1

### Prompt 1

#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Cloude.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_d5a336162e46cfd8590bcdf23258e136868b6d09" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.Cloude.Prompt1/UnitTestGeneration.Easy.Tests.Cloude.Prompt1.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_d5a336162e46cfd8590bcdf23258e136868b6d09"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

## Prompt 2

#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Cloude.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_baa170fd10fbe5cbc79c709f5a23f78d2eaf8444" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.Cloude.Prompt2/UnitTestGeneration.Easy.Tests.Cloude.Prompt2.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_baa170fd10fbe5cbc79c709f5a23f78d2eaf8444"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

### Prompt 3

#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Cloude.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_2e0511112c95d4d6ab5d7574992ef4008645eeb4" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.Cloude.Prompt3/UnitTestGeneration.Easy.Tests.Cloude.Prompt3.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_2e0511112c95d4d6ab5d7574992ef4008645eeb4"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

# UnitTestGeneration.Moderate.Tests.Cloude.Prompt1

### Prompt 1

#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Cloude.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_35b02fd9700a3cfacebdeb5ffe349aeb2fefd9c9" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.Cloude.Prompt1/UnitTestGeneration.Moderate.Tests.Cloude.Prompt1.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_35b02fd9700a3cfacebdeb5ffe349aeb2fefd9c9"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

### Prompt 2

#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Cloude.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_5768467b69fdd9c82c30c545086aa03e9f747246" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.Cloude.Prompt2/UnitTestGeneration.Moderate.Tests.Cloude.Prompt2.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_5768467b69fdd9c82c30c545086aa03e9f747246"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

### Prompt 3

#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Cloude.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_72a6fede6d8f72a8c8f51e7d0b559b5dfb4b5522" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.Cloude.Prompt3/UnitTestGeneration.Moderate.Tests.Cloude.Prompt3.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_72a6fede6d8f72a8c8f51e7d0b559b5dfb4b5522"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

 UnitTestGeneration.Difficult.Tests.Cloude.Prompt1

### Prompt 1

#dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Cloude.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_58b066417acb64d9e51c9a08284f7768ad5d4f5c" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Difficult.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Difficult.Tests.Cloude.Prompt1/UnitTestGeneration.Difficult.Tests.Cloude.Prompt1.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_58b066417acb64d9e51c9a08284f7768ad5d4f5c"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

### Prompt 2

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Cloude.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_222818f5dae0ca3509c3c28aa93c29ac8c16d19b" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.Cloude.Prompt2/UnitTestGeneration.Difficult.Tests.Cloude.Prompt2.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_222818f5dae0ca3509c3c28aa93c29ac8c16d19b"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 3

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Cloude.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_922cb1980c1d9f27fefc37879d4ae6e284f87306" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.Cloude.Prompt3/UnitTestGeneration.Difficult.Tests.Cloude.Prompt3.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_922cb1980c1d9f27fefc37879d4ae6e284f87306"   
rm dotCover.Output.html
rm -rf dotCover.Output
