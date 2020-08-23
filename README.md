# anniversaryreminder Application

[![Gitpod-Ready-Code](https://img.shields.io/badge/Gitpod-Ready--to--Code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/jmuelbert/anniversaryreminder)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c63d1cf887384176977da4e7ba43495e)](https://app.codacy.com/manual/jmuelbert/anniversaryreminder?utm_source=github.com&utm_medium=referral&utm_content=jmuelbert/anniversaryreminder&utm_campaign=Badge_Grade_Dashboard)
[![Total alerts](https://img.shields.io/lgtm/alerts/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/alerts/)
[![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:javascript)
[![Language grade: C#](https://img.shields.io/lgtm/grade/csharp/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:csharp)
[![Build status](https://ci.appveyor.com/api/projects/status/62fnw26b3ka208o9?svg=true)](https://ci.appveyor.com/project/jmuelbert/anniversaryreminder-7whd2)
![Misspell fixer](https://github.com/jmuelbert/anniversaryreminder/workflows/Misspell%20fixer/badge.svg)
[![GitHub license](https://img.shields.io/badge/license-EUPL-blue.svg)](https://joinup.ec.europa.eu/page/eupl-text-11-12)

anniversaryreminder is a program that do you remind you to anniversaries in a company. i.e. The employee is 10 Years, 25 years in the company. Or the employee has birthday.

anniversaryreminder is free software; you can redistribute it and/or modify it under the terms
of the [European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the [LICENSE](https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE.EUPL-1_2.txt) for additional information.

The master branch represents the latest pre-release code.

-   [Releases](https://github.com/jmuelbert/anniversaryreminder/releases)

-   [Milestones](https://github.com/jmuelbert/anniversaryreminder/milestones)

## Requests and Bug reports

-   [GitHub issues (preferred)](https://github.com/jmuelbert/anniversaryreminder/issues)

## Questions or Comments

## Wiki

-   [Main Page](https://github.com/jmuelbert/anniversaryreminder/wiki)
-   [User Manual](http://jmuelbert.github.io/anniversaryreminder/)

## Building

### Requirments

#### For Windows

-   [.NET Core SDK 3.1 for Windows](https://www.microsoft.com/net/download/windows)

#### For Linux

-   [.NET Core SDK 3.1 for Linux](https://www.microsoft.com/net/download/linux)

#### For Mac

-   [.NET Core SDK 3.1 for MacOS](https://www.microsoft.com/net/download/macos)

## Prepare the App

### Windows

-   Open a command prompt and cd `src\anniversaryreminder`.
-   Run `dotnet build`
-   Run `dotnet ef database update`- Create a new blank database.

### Linux or macOS

-   Open a command prompt and execute `cd src/janniversaryreminder`.
-   Run `dotnet build`
-   Run `dotnet ef database update`- Create a new blank database.

## Run the anniversaryreminder App

### Run on Windows

-   Open a command prompt and cd `src\anniversaryreminder`.
-   Run `dotnet run` (This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**).

### Run on Linux or macOS

-   Open a command prompt and execute `cd src/anniversaryreminder`.
-   Try run `dotnet run` (This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**).

## Publish the anniversaryreminder App

### Publish on Windows

-   Open a command prompt and cd `src\anniversaryreminder`.
-   Run `dotnet publish -c Release -o [RELEASEDIRECTORY]`

### Publish on Linux or macOS

-   Open a command prompt and execute `cd src/anniversaryreminder`.
-   Run `dotnet publish -c Release -o [RELEASEDIRECTORY]`

## License

EUPL-1.2 © [Jürgen Mülbert](https:/github.com/jmuelbert/anniversaryreminder/)

[Return to top](#top)
