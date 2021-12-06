# percy-nunit

This repository demonstartes how to use [percy-csharp-selenium](https://www.nuget.org/packages/percy-csharp-selenium/1.0.0-alpha) with Nunit

### Requirements

1. Visual Studio 2019

    - If not installed, download and install Visual Studio 2019 from [here](https://visualstudio.microsoft.com/vs/)
2. .Net Core 3.1 or higher
    - On Mac OS, you can use Homebrew:
```bash
$ brew install --cask dotnet
```
3. Chromedriver

   - The Selenium tests use ChromeDriver, which you need to install separately for your system.

On Mac OS, you can use Homebrew:
```bash
$ brew tap homebrew/cask && brew install --cask chromedriver
```

On Windows, you can use Chocolatey:

```bash
$ choco install chromedriver
```
4. Install percy cli 

   -  Add the percy-cli 
```npm i -g @percy/cli```
   
    
### Getting Started

1. Configuring the test

    - Clone the repo
    - Give the path to your chromedriver path in [`UnitTest1.cs`](SeleniumPercyIntegration/UnitTest1.cs)
    - Create a new project on Percy as shown [here](https://docs.percy.io/docs/percy-platform-basics)
    - Once a new project is created on percy it will generate a PERCY_TOKEN unique to your project
    - Export the token to your project 
2. Running the Test
    - For running Nunit based test we need to first start the percy server using 
   ```percy exec:start``` You can get more details [here](https://docs.percy.io/docs/cli-exec#percy-execstart)
