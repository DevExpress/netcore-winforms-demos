# .Net Core 3 WinForms Demos
 
This repository contains the Outlook-inspired and Stock Market Trader demo applications that support .Net Core 3.
 
## System requirements
1. **Visual Studio 2019 Preview 1** or **Visual Studio 2017 Update 15.8** with the following options installed:
 
    1. **.NET Framework 4.7.2 development tools**
 
    1. **.NET Core 2.1 development tools**
 
1. [.NET Core 3 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0)
 
 

## How to run the demos
 
### Stock Market Trader Demo
 
Open the following project in Visual Studio to see this demo:
 
`\StockMarketTraderApp\Devexpress.StockMarketTrader.csproj`
 
To run the demo in the console, navigate to the project's folder (`\StockMarketTraderApp\`) and call the following command:
 
`dotnet run Devexpress.StockMarketTrader`
 
### Outlook-inspired Demo
 
To run this demo, open the solution in Visual Studio and build the solution.
 
`\OutlookInspiredApp\DevExpress.OutlookInspiredApp.sln`
 
To build the demo in the console, navigate to the solution's folder (`\OutlookInspiredApp`) and call the following command:
 
`dotnet build DevExpress.OutlookInspiredApp.sln`
 
Navigate to the `bin` folder and run the demo (`.\DevExpress.OutlookInspiredApp.Win.exe`).
 
## How to integrate DevExpress WinForms Controls into a .NET Core 3 application
 
You need DevExpress NuGet packages to create a .Net Core 3 project. Follow the steps below to add packages to a solution:
 
1. Register the DevExpress Early Access feed in Visual Studio's NuGet Package Manager.
 
    `https://nuget.devexpress.com/early-access/api`
 
    See the [Setup Visual Studio's NuGet Package Manager](https://docs.devexpress.com/GeneralInformation/116698/installation/install-devexpress-controls-using-nuget-packages/setup-visual-studio%27s-nuget-package-manager) topic for more information.
 

1. Install the **DevExpress.WindowsDesktop.Win** package for .Net Core 3 development. This package provides the DevExpress WinForms components.
 
## Feedback
 
You can provide feedback via [DevExpress Support Center](https://www.devexpress.com/Support/Center/Question/Create).
 
## See Also
 
See the [.NET Core 3.0 Windows Forms Samples](https://github.com/dotnet/samples/tree/master/windowsforms) repository for more examples.
