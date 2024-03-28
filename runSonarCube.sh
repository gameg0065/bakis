
# EASY APP

# Original (human-made) tests run.
dotnet sonarscanner begin /k:"UnitTestGeneration.Easy.App.Human" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_29439e79386dff0dec10d9ae124abaadc280bcf0" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html

dotnet build UnitTestGeneration.Easy.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Easy.Tests/UnitTestGeneration.Easy.Tests.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_29439e79386dff0dec10d9ae124abaadc280bcf0"   

# MODERATE APP

# Original (human-made) tests run.
dotnet sonarscanner begin /k:"UnitTestGeneration.Moderate.App.Human" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_3dd2c08917fc3aa191ceba7eebb6c46482430b4b" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html

dotnet build UnitTestGeneration.Moderate.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Moderate.Tests/UnitTestGeneration.Moderate.Tests.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_3dd2c08917fc3aa191ceba7eebb6c46482430b4b"   


# DIFFICULT APP

# Original (human-made) tests run.
dotnet sonarscanner begin /k:"UnitTestGeneration.Difficult.App.Human" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_b8dd9cd1afe6d1f3dd96d389bf1502f9cb03ef1c" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html

dotnet build UnitTestGeneration.Difficult.App --no-incremental     
dotnet dotcover test UnitTestGeneration.Difficult.Tests/UnitTestGeneration.Difficult.Tests.csproj --dcReportType=HTML
dotnet sonarscanner end /d:sonar.token="sqp_b8dd9cd1afe6d1f3dd96d389bf1502f9cb03ef1c"   