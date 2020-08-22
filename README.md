# AnniversaryReminder Application

[![Gitpod-Ready-Code](https://img.shields.io/badge/Gitpod-Ready--to--Code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/jmuelbert/AnniversaryReminder)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c63d1cf887384176977da4e7ba43495e)](https://app.codacy.com/manual/jmuelbert/AnniversaryReminder?utm_source=github.com&utm_medium=referral&utm_content=jmuelbert/AnniversaryReminder&utm_campaign=Badge_Grade_Dashboard)
[![Total alerts](https://img.shields.io/lgtm/alerts/g/jmuelbert/AnniversaryReminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/AnniversaryReminder/alerts/)
[![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/jmuelbert/AnniversaryReminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/AnniversaryReminder/context:javascript)
[![Language grade: C#](https://img.shields.io/lgtm/grade/csharp/g/jmuelbert/AnniversaryReminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/AnniversaryReminder/context:csharp)
[![AppVeyor](https://ci.appveyor.com/api/projects/status/ja8a7j6jscj7k3xa/branch/master?svg=true)](https://ci.appveyor.com/project/jmuelbert/AnniversaryReminder)
![Misspell fixer](https://github.com/jmuelbert/AnniversaryReminder/workflows/Misspell%20fixer/badge.svg)
[![GitHub license](https://img.shields.io/badge/license-EUPL-blue.svg)](https://joinup.ec.europa.eu/page/eupl-text-11-12)

AnniversaryReminder is a program that do you remind you to anniversaries in a company. i.e. The employee is 10 Years, 25 years in the company. Or the employee has birthday.

AnniversaryReminder is free software; you can redistribute it and/or modify it under the terms
of the [European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the [LICENSE](https://github.com/jmuelbert/AnniversaryReminder/blob/master/LICENSE.EUPL-1_2.txt) for additional information.

The master branch represents the latest pre-release code.

- [Releases](https://github.com/jmuelbert/AnniversaryReminder/releases)

- [Milestones](https://github.com/jmuelbert/AnniversaryReminder/milestones)

## Requests and Bug reports

- [GitHub issues (preferred)](https://github.com/jmuelbert/AnniversaryReminder/issues)

## Questions or Comments

## Wiki

- [Main Page](https://github.com/jmuelbert/AnniversaryReminder/wiki)
- [User Manual](http://jmuelbert.github.io/AnniversaryReminder/)

## Building

### Requirments

#### For Windows

- [.NET Core SDK 3.1 for Windows](https://www.microsoft.com/net/download/windows)

#### For Linux

- [.NET Core SDK 3.1 for Linux](https://www.microsoft.com/net/download/linux)

#### For Mac

- [.NET Core SDK 3.1 for MacOS](https://www.microsoft.com/net/download/macos)

## Prepare the App

### Windows

- Open a command prompt and cd `src\AnniversaryReminder`.
- Run `dotnet build`
- Run `dotnet ef database update`- Create a new blank database.

### Linux or macOS

- Open a command prompt and execute `cd src/jAnniversaryReminder`.
- Run `dotnet build`
- Run `dotnet ef database update`- Create a new blank database.

## Run the AnniversaryReminder App

### Run on Windows

- Open a command prompt and cd `src\AnniversaryReminder`.
- Run `dotnet run` (This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**).

### Run on Linux or macOS

- Open a command prompt and execute `cd src/AnniversaryReminder`.
- Try run `dotnet run` (This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**).

## Publish the AnniversaryReminder App

### Publish on Windows

- Open a command prompt and cd `src\AnniversaryReminder`.
- Run `dotnet publish -c Release -o [RELEASEDIRECTORY]`

### Publish on Linux or macOS

- Open a command prompt and execute `cd src/AnniversaryReminder`.
- Run `dotnet publish -c Release -o [RELEASEDIRECTORY]`

## License

EUPL-1.2 © [Jürgen Mülbert](https:/github.com/jmuelbert/AnniversaryReminder/)

[Return to top](#top)
