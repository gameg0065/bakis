
# EASY APP

# Google Gemini tests run.
dotnet sonarscanner begin /k:"GeminiEasyTestRun" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_68bb36a981ca754fe7d49dc0e5cc21b176a2dbfa" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html

dotnet build UnitTestGeneration.Easy.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Easy.Tests.Gemini/UnitTestGeneration.Easy.Tests.Gemini.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_68bb36a981ca754fe7d49dc0e5cc21b176a2dbfa"   








## MODERATE APP
#
## Original (human-made) tests run.
#dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.App.Human" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_3dd2c08917fc3aa191ceba7eebb6c46482430b4b" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#
#dotnet build UnitTestGeneration.Moderate.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Moderate.Tests/UnitTestGeneration.Moderate.Tests.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_3dd2c08917fc3aa191ceba7eebb6c46482430b4b"   
#
#
## DIFFICULT APP
#
## Original (human-made) tests run.
#dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.App.Human" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_b8dd9cd1afe6d1f3dd96d389bf1502f9cb03ef1c" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html
#
#dotnet build UnitTestGeneration.Difficult.App --no-incremental     
#dotnet dotcover test UnitTestGeneration.Difficult.Tests/UnitTestGeneration.Difficult.Tests.csproj --dcReportType=HTML
#dotnet sonarscanner end /d:sonar.token="sqp_b8dd9cd1afe6d1f3dd96d389bf1502f9cb03ef1c"   