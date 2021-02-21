# anniversaryreminder

anniversaryreminder is a program that do you remind you to anniversaries in a company. i.e. The employee is 10 Years, 25 years in the company. Or the employee has birthday.

---

[![Gitpod Ready Code][gitpod-shield]][gitpod-url]
[![Codacy Badge][codacy-shield]][codacy-url]
[![Total Alerts][lgtm-alerts-shield]][lgtm-alerts-url]
[![Language grade: c#][lgtm-csharp-shield]][lgtm-csharp-url]
[![Language grade: Python][lgtm-python-shield]][lgtm-python-url]
[![Language grade: JavaScript][lgtm-js-shield]][lgtm-js-url]
[![GitHub All Releases][downloads_all-shield]][downloads_all-url]
[![Issues][issues-shield]][issues-url]
[![Help wanted issues][help-issues-shield]][help-issues-url]
[![Pull Requests][pr-shield]][pr-url] [![pre-commit][pre-commit-shield]][pre-commit-url]
[![Codecov][codecov-shield]][codecov-url]
[![Misspell fixer][misspell_fixer-shield]][misspell_fixer-url]
[![Documentation][documentation-shield]][documentation-url]
[![License][license-shield]][license-url]

[Features](https://github.com/jmuelbert/anniversaryreminder) | [Documentation](https://jmuelbert.github.io/anniversaryreminder/) | [Changelog](CHANGELOG.md) | [Contributing](CONTRIBUTING.md) | [FAQ](https://github.com/jmuelbert/anniversaryreminder/wiki/FAQ) | [deutsch](README_de-DE.md)


anniversaryreminder is free software; you can redistribute it and/or modify it under the terms
of the [European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the [LICENSE](https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE.EUPL-1_2.txt) for additional information.

 |  type  |                                 branch                                 |                                                                                                                   build                                                                                                                    |                                                                                downloads                                                                                 |
 | :----: | :--------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
 | alpha  | [master](https://github.com/jmuelbert/anniversaryreminder/tree/master) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=master&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3Amaster) |                                                                                    -                                                                                     |
 |  beta  | [v0.0.0](https://github.com/jmuelbert/anniversaryreminder/tree/v0.0.0) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=v0.0.0&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3Av0.0.0) | [![Downloads](https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/v0.0.0/total)](https://github.com/jmuelbert/anniversaryreminder/releases/tag/v0.0.0) |
 | stable | [v0.0.0](https://github.com/jmuelbert/anniversaryreminder/tree/v0.0.0) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=v0.0.0&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3v0.0.0)  | [![Downloads](https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/v0.0.0/total)](https://github.com/jmuelbert/anniversaryreminder/releases/tag/v0.0.0) |

The master branch represents the latest pre-release code.

- [Releases](https://github.com/jmuelbert/anniversaryreminder/releases)

- [Milestones](https://github.com/jmuelbert/anniversaryreminder/milestones)

## Requests and Bug reports

- [GitHub issues (preferred)](https://github.com/jmuelbert/anniversaryreminder/issues)

## Questions or Comments

## Wiki

- [Main Page](https://github.com/jmuelbert/anniversaryreminder/wiki)
- [User Manual](http://jmuelbert.github.io/anniversaryreminder/)

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

- Open a command prompt

    ```cmd
        cd src\anniversaryreminder
        dotnet build
        dotnet ef database update
    ```

- Create the app and a new blank database.

### Linux or macOS

- Open a command prompt and execute

    ```bash
        cd src/anniversaryreminder
        dotnet build
        dotnet ef database update
    ```

- Create the app and a new blank database.

## Run the anniversaryreminder App

### Run on Windows

- Open a command prompt and execute

    ```cmd
        cd src\anniversaryreminder
        dotnet run
    ```

- This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**.


### Run on Linux or macOS

- Open a command prompt and execute

    ```bash
        cd src/anniversaryreminder
        dotnet run
    ```

- This hosts the app in a console application - Application started at URL **`http://localhost:5000/`**.

## Publish the anniversaryreminder App

### Publish on Windows

- Open a command prompt and execute

    ```cmd
        cd src\anniversaryreminder
        dotnet publish -c Release -o [RELEASEDIRECTORY]
    ```

### Publish on Linux or macOS

- Open a command prompt and execute

    ```bash
        cd src/anniversaryreminder
        dotnet publish -c Release -o [RELEASEDIRECTORY]
    ```

## License

EUPL-1.2 © [Jürgen Mülbert](https:/github.com/jmuelbert/anniversaryreminder/)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/jmuelbert/anniversaryreminder
[contributors-url]: https://github.com/jmuelbert/anniversaryreminder/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/jmuelbert/anniversaryreminder
[forks-url]: https://github.com/jmuelbert/anniversaryreminder/network/members
[issues-shield]: https://img.shields.io/github/issues-raw/jmuelbert/anniversaryreminder
[issues-url]: https://github.com//jmuelbert/anniversaryreminder/issues
[license-shield]: https://img.shields.io/badge/license-EUPL-blue.svg
[license-url]: https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE
[product-screenshot]: images/doc/images/Logo_template.png
[build-shield]:
    https://img.shields.io/github/workflow/status/jmuelbert/anniversaryreminder/Build/release
[build-url]: https://github.com/jmuelbert/anniversaryreminder/workflows/Build
[gitpod-shield]: https://img.shields.io/badge/Gitpod-Ready--to--Code-blue?logo=gitpod
[gitpod-url]: https://gitpod.io/#https://github.com/jmuelbert/anniversaryreminder
[codacy-shield]:
    https://api.codacy.com/project/badge/Grade/c63d1cf887384176977da4e7ba43495e
[codacy-url]:
    https://app.codacy.com/manual/jmuelbert/anniversaryreminder?utm_source=github.com&utm_medium=referral&utm_content=jmuelbert/anniversaryreminder&utm_campaign=Badge_Grade_Dashboard
[downloads_all-shield]:
    https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/total?label=downloads%40all
[downloads_all-url]: https://github.com/jmuelbert/anniversaryreminder/releases
[pre-commit-shield]:
    https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white
[pre-commit-url]: https://github.com/pre-commit/pre-commit
[misspell_fixer-shield]:
    https://github.com/jmuelbert/anniversaryreminder/workflows/Misspell%20fixer/badge.svg
[misspell_fixer-url]: https://github.com/marketplace/actions/misspell-fixer-action
[help-issues-shield]:
    https://img.shields.io/github/issues/jmuelbert/anniversaryreminder/help%20wanted
[help-issues-url]:
    https://github.com/jmuelbert/anniversaryreminder/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22
[documentation-shield]: https://img.shields.io/badge/Documentation-latest-blue.svg
[documentation-url]: https://jmuelbert.github.io/anniversaryreminder
[lgtm-alerts-shield]: https://img.shields.io/lgtm/alerts/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18
[lgtm-alerts-url]: https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/alerts/
[lgtm-csharp-shield]:
    https://img.shields.io/lgtm/grade/csharp/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18
[lgtm-csharp-url]: https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:csharp
[lgtm-python-shield]: https://img.shields.io/lgtm/grade/python/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18
[lgtm-python-url]: https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:python
[lgtm-js-shield]: https://img.shields.io/lgtm/grade/javascript/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18
[lgtm-js-url]: https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:javascript
[cdash-shield]: https://img.shields.io/badge/CDash-Access-blue.svg
[cdash-url]: http://my.cdash.org/index.php?project=anniversaryreminder
[pr-shield]: https://img.shields.io/github/issues-pr-raw/jmuelbert/anniversaryreminder.svg
[pr-url]: https://github.com/jmuelbert/anniversaryreminder/pulls
[codecov-shield]: https://codecov.io/gh/jmuelbert/anniversaryreminder/branch/master/graph/badge.svg
[codecov-url]: https://codecov.io/gh/jmuelbert/anniversaryreminder
