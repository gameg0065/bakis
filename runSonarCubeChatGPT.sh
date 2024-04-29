
# EASY APP

## Google Gemini tests run.

# UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1

### Prompt 1

#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_98ab3789f1222b085e4b00019cd2639e233a4f10" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1/UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_98ab3789f1222b085e4b00019cd2639e233a4f10"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

### Prompt 2
#
#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_98b4e65bc5d1439fa4e9eb293e45275a5bee7ef5" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2/UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_98b4e65bc5d1439fa4e9eb293e45275a5bee7ef5"   
#rm dotCover.Output.html
#rm -rf dotCover.Output
#
#### Prompt 3
#
#dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_17d1f3ac61bc018b865d70c42404748d16a00533" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Easy.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3/UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_17d1f3ac61bc018b865d70c42404748d16a00533"   
#rm dotCover.Output.html
#rm -rf dotCover.Output
#
## UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1
#
#### Prompt 1
#
#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_7a9ba622102ab7e06ead44c432018e92e041103b" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1/UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_7a9ba622102ab7e06ead44c432018e92e041103b"   
#rm dotCover.Output.html
#rm -rf dotCover.Output
#
#### Prompt 2
#
#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_8f1beaa26b8370c100610474cf18d677c468105c" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2/UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_8f1beaa26b8370c100610474cf18d677c468105c"   
#rm dotCover.Output.html
#rm -rf dotCover.Output
#
#### Prompt 3
#
#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_021979ad230bad3b5a658d7113ea00930844b081" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3/UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_021979ad230bad3b5a658d7113ea00930844b081"   
#rm dotCover.Output.html
#rm -rf dotCover.Output

# UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1

#### Prompt 1
#
dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_dea1e3126eb7c75377697c98fadbe429ba3eb985" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1/UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_dea1e3126eb7c75377697c98fadbe429ba3eb985"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 2

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_7a95b9cbab7cd92370ffd280bb88d5fb999b6b40" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2/UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_7a95b9cbab7cd92370ffd280bb88d5fb999b6b40"   
rm dotCover.Output.html
rm -rf dotCover.Output

### Prompt 3

dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_3d3ba13409b390c874e84261b530bcabb18521c6" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3/UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_3d3ba13409b390c874e84261b530bcabb18521c6"   
rm dotCover.Output.html
rm -rf dotCover.Output
