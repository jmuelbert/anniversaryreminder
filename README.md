# anniversaryreminder

anniversaryreminder is a program that do you remind you to anniversaries in a company.
i.e. The employee is 10 Years, 25 years in the company. Or the employee has birthday.

---

[![Gitpod Ready Code][gitpod-shield]][gitpod-url]
[![Release](https://img.shields.io/github/release/jmuelbert/anniversaryreminder.svg?style=flat-square)](https://github.com/jmuelbert/anniversaryreminder/releases)
[![CI on Branches and PRs](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/ci.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/ci.yml)
[![CodeQL](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codeql-analysis.yml)
[![Codacy Security Scan](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codacy-analysis.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codacy-analysis.yml)
[![MegaLinter](https://github.com/jmuelbert/anniversaryreminder/workflows/MegaLinter/badge.svg?branch=main)][mega-linter]
[![GitHub All Releases][downloads_all-shield]][downloads_all-url]
[![Issues][issues-shield]][issues-url]
[![Help wanted issues][help-issues-shield]][help-issues-url]
[![Pull Requests][pr-shield]][pr-url] [![pre-commit][pre-commit-shield]][pre-commit-url]
[![Codecov][codecov-shield]][codecov-url]
[![Misspell fixer][misspell_fixer-shield]][misspell_fixer-url]
[![Documentation][documentation-shield]][documentation-url]
[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-2.1-4baaaa.svg)](code_of_conduct.md)
[![License][license-shield]][license-url]

[Features](https://github.com/jmuelbert/anniversaryreminder) |
[Documentation](https://jmuelbert.github.io/anniversaryreminder/) |
[Changelog](CHANGELOG.md) | [Contributing](CONTRIBUTING.md) |
[FAQ](https://github.com/jmuelbert/anniversaryreminder/wiki/FAQ)

anniversaryreminder is free software; you can redistribute it and/or modify it under the
terms of the
[European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the
[LICENSE](https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE) for
additional information.

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

### Requirements

#### For Windows

- [.NET Core SDK 7.x for Windows](https://www.microsoft.com/net/download/windows)

#### For Linux

- [.NET Core SDK 7.x for Linux](https://www.microsoft.com/net/download/linux)

#### For Mac

- [.NET Core SDK 7.x for MacOS](https://www.microsoft.com/net/download/macos)

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

- This hosts the app in a console application - Application started at URL
  **`http://localhost:5000/`**.

### Run on Linux or macOS

- Open a command prompt and execute

  ```bash
      cd src/anniversaryreminder
      dotnet run
  ```

- This hosts the app in a console application - Application started at URL
  **`http://localhost:5000/`**.

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

[contributors-shield]:
 https://img.shields.io/github/contributors/jmuelbert/anniversaryreminder
[issues-shield]: https://img.shields.io/github/issues-raw/jmuelbert/anniversaryreminder
[issues-url]: https://github.com//jmuelbert/anniversaryreminder/issues
[license-shield]: https://img.shields.io/badge/license-EUPL-blue.svg
[license-url]: https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE
[build-shield]:
 https://img.shields.io/github/workflow/status/jmuelbert/anniversaryreminder/Build/release
[gitpod-shield]: https://img.shields.io/badge/Gitpod-Ready--to--Code-blue?logo=gitpod
[gitpod-url]: https://gitpod.io/#https://github.com/jmuelbert/anniversaryreminder
[codacy-shield]:
 https://api.codacy.com/project/badge/Grade/945eee726f39449ca83631edd119aee1
[codacy-url]:
 https://app.codacy.com/gh/jmuelbert/anniversaryreminder?utm_source=github.com&utm_medium=referral&utm_content=jmuelbert/anniversaryreminder&utm_campaign=Badge_Grade
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
[pr-shield]:
 https://img.shields.io/github/issues-pr-raw/jmuelbert/anniversaryreminder.svg
[pr-url]: https://github.com/jmuelbert/anniversaryreminder/pulls
[codecov-shield]:
 https://codecov.io/gh/jmuelbert/anniversaryreminder/branch/master/graph/badge.svg
[codecov-url]: https://codecov.io/gh/jmuelbert/anniversaryreminder
[mega-linter]:
 https://github.com/jmuelbert/anniversaryreminder/actions?query=workflow%3AMegaLinter+branch%3Amain
