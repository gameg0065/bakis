
# EASY APP

## Google Gemini tests run.

# UnitTestGeneration.Easy.Tests.Gemini.Prompt1

### Prompt 1

dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Gemini.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_a253ec8cda16d4d18832a440eb9f182fe401442e" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Easy.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Easy.Tests.Gemini.Prompt1/UnitTestGeneration.Easy.Tests.Gemini.Prompt1.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_a253ec8cda16d4d18832a440eb9f182fe401442e"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 2

dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Gemini.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_a765d3a4b697fc6c8a8e71d556ec4ab97692dcd3" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Easy.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Easy.Tests.Gemini.Prompt2/UnitTestGeneration.Easy.Tests.Gemini.Prompt2.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_a765d3a4b697fc6c8a8e71d556ec4ab97692dcd3"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 3

dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.Gemini.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_93cd14bbf59ffe9011a388bd927741a5d69f3730" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Easy.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Easy.Tests.Gemini.Prompt3/UnitTestGeneration.Easy.Tests.Gemini.Prompt3.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_93cd14bbf59ffe9011a388bd927741a5d69f3730"   
rm dotCover.Output.html
rm -rf dotCover.Output

# UnitTestGeneration.Moderate.Tests.Gemini.Prompt1

### Prompt 1

dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Gemini.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_9ac82cbf530c045461152223a2fe0fb289170b4f" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Moderate.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Moderate.Tests.Gemini.Prompt1/UnitTestGeneration.Moderate.Tests.Gemini.Prompt1.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_9ac82cbf530c045461152223a2fe0fb289170b4f"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 2

dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Gemini.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_31d9a1f842bbb57dbefdc33fe8a4b2a766770277" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Moderate.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Moderate.Tests.Gemini.Prompt2/UnitTestGeneration.Moderate.Tests.Gemini.Prompt2.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_31d9a1f842bbb57dbefdc33fe8a4b2a766770277"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 3

dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.Gemini.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_59d0720ce3df31a4faec02fdc93acb6476bdd550" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Moderate.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Moderate.Tests.Gemini.Prompt3/UnitTestGeneration.Moderate.Tests.Gemini.Prompt3.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_59d0720ce3df31a4faec02fdc93acb6476bdd550"   
rm dotCover.Output.html
rm -rf dotCover.Output

# UnitTestGeneration.Difficult.Tests.Gemini.Prompt1

### Prompt 1

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Gemini.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_097d2984944d2b193afb98155a1db60efb163f2e" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.Gemini.Prompt1/UnitTestGeneration.Difficult.Tests.Gemini.Prompt1.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_097d2984944d2b193afb98155a1db60efb163f2e"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 2

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Gemini.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_989e94110e3d9905ac9a5956c6ef53ee56c59a22" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.Gemini.Prompt2/UnitTestGeneration.Difficult.Tests.Gemini.Prompt2.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_989e94110e3d9905ac9a5956c6ef53ee56c59a22"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 3

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.Gemini.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_1c5745a6a9995bbcfc67fee5d533f0d27f7d7220" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.Gemini.Prompt3/UnitTestGeneration.Difficult.Tests.Gemini.Prompt3.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_1c5745a6a9995bbcfc67fee5d533f0d27f7d7220"   
rm dotCover.Output.html
rm -rf dotCover.Output
