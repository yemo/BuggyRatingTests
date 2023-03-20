# BuggyRating.RegressionTest

The goal of this project is to demo automation test sets for a web application. Follow Test pyramid structure to build a full set of automation solution

**Resources**
- [Testing pyramid](https://learn.cypress.io/testing-foundations/the-testing-pyramid)
- [SpecFlow](http://specflow.org/)
- [FluentAssertions](https://fluentassertions.com/)
- [Selenium](http://www.seleniumhq.org/)
- [Protractor .NET](https://www.nuget.org/packages/Protractor)
- [SpecFlow+LivingDoc](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/)
- [Azure DevOps](https://learn.microsoft.com/en-us/azure/devops/?view=azure-devops)




### TODO
- [x] SpecFlow E2E UI automation Framework
- [ ] SpecFlow API automation Framework
- [ ] Playwright JS UI automation Framework
- [ ] Angular UI Mock Data
- [ ] Azure DevOps test execution pipeline
- [ ] Azure DevOps SpecFlow+LivingDoc pages




### Setup - Windows OS

- Download and install [Visual Studio](https://visualstudio.microsoft.com/)

- Download and install [Chrome Browser](https://support.google.com/chrome/answer/95346?hl=en&co=GENIE.Platform%3DDesktop#zippy=%2Cwindows)

- Download and add to Environment Path [Chrome WebDriver](https://chromedriver.chromium.org/downloads)



### Visual Studio

Visual Studio needs a little extra configuration. Install these extensions;
- NUnit
- SpecFlow
- add vstest.concole.exe to Environment Path if run through the command line


### Git clone
```
> Git clone https://github.com/yemo/BuggyRatingTests.git
```


**Run Test using Visual Studio**
- Build the solution
- Right click the E2EUIautomation project and select 'Run Tests'


**Run Test using Windows Command Line**

Restore dependencies:
```
> nuget restore
```

Build:
```
> msbuild .\BuggyRatingTests.sln
```

Run tests by VSTest
```
> vstest.console.exe UIautomation\bin\Debug\netcoreapp3.1\E2EUIautomation.dll /Logger:trx
```

Run tests by SpecFlow
```
> specflow.exe stepdefinitionreport --ProjectFile UIautomation\E2EUIautomation.csproj /BinFolder:UIautomation\bin\debug
```