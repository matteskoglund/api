@echo off

SET dotnet="C:/Program Files/dotnet/dotnet.exe"  
SET opencover=C:\Users\mats\.nuget\packages\OpenCover\4.6.519\tools\OpenCover.Console.exe
SET reportgenerator=C:\Users\mats\.nuget\packages\ReportGenerator\2.4.5\tools\ReportGenerator.exe
SET converter=C:\Users\mats\.nuget\packages\OpenCoverToCoberturaConverter\0.2.4\tools\OpenCoverToCoberturaConverter.exe
SET targetargs="test"  
SET filter="+[*]*.* -[xunit.*]* -[FluentValidation]*"  
SET coveragefile=Coverage.xml  
SET coveragedir=Coverage

REM Run code coverage analysis  
%opencover% -oldStyle -register:user -target:%dotnet% -output:%coveragefile% -targetargs:%targetargs% -filter:%filter% -skipautoprops -hideskipped:All


%converter% -input:Coverage.xml -output:Cobertura.xml

REM Generate the report  
%reportgenerator% -targetdir:%coveragedir% -reporttypes:Html;Badges -reports:%coveragefile% -verbosity:Verbose

REM Open the report  
REM start "report" "%coveragedir%\index.htm"  
