# anniversaryreminder

anniversary reminder ist ein Programm, mit dem Sie an Jubiläen in einem Unternehmen erinnert werden, d.h. der Mitarbeiter ist 10 Jahre, 25 Jahre im Unternehmen. Oder der Mitarbeiter hat Geburtstag.

---

[![Gitpod Ready Code][gitpod-shield]][gitpod-url]
[![Release](https://img.shields.io/github/release/jmuelbert/anniversaryreminder.svg?style=flat-square)](https://github.com/jmuelbert/anniversaryreminder/releases)
[![Build](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/ci.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/ci.yml)
[![Release](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/cd.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/cd.yml)
[![CodeQL](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codeql-analysis.yml)
[![Codacy Security Scan](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codacy-analysis.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/codacy-analysis.yml)
[![flawfinder](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/flawfinder-analysis.yml/badge.svg)](https://github.com/jmuelbert/anniversaryreminder/actions/workflows/flawfinder-analysis.yml)
[![GitHub All Releases][downloads_all-shield]][downloads_all-url]
[![Issues][issues-shield]][issues-url]
[![Help wanted issues][help-issues-shield]][help-issues-url]
[![Pull Requests][pr-shield]][pr-url] [![pre-commit][pre-commit-shield]][pre-commit-url]
[![Codecov][codecov-shield]][codecov-url]
[![Misspell fixer][misspell_fixer-shield]][misspell_fixer-url]
[![Documentation][documentation-shield]][documentation-url]
[![License][license-shield]][license-url]

[Features](https://github.com/jmuelbert/anniversaryreminder) | [Documentation](https://jmuelbert.github.io/anniversaryreminder/) | [Changelog](CHANGELOG.md) | [Contributing](CONTRIBUTING.md) | [FAQ](https://github.com/jmuelbert/anniversaryreminder/wiki/FAQ) | [english](README.md)


anniversaryreminder is free software; you can redistribute it and/or modify it under the terms
of the [European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the [LICENSE](https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE.EUPL-1_2.txt) for additional information.


Der Hauptzweig stellt den neuesten Vorabcode dar.

- [Freigaben](https://github.com/jmuelbert/anniversaryreminder/releases)

- [Meilensteine](https://github.com/jmuelbert/anniversaryreminder/milestones)

## Anfragen und Fehlerberichte

- [GitHub-Ausgaben (bevorzugt)](https://github.com/jmuelbert/anniversaryreminder/issues)

## Fragen oder Kommentare

## Wiki

- [Hauptseite](https://github.com/jmuelbert/anniversaryreminder/wiki)
- [Benutzerhandbuch](http://jmuelbert.github.io/anniversaryreminder/)

## Gebäude

### Anfragen

#### Für Windows

- [.NET Core SDK 5.0.x für Windows](https://www.microsoft.com/net/download/windows)

#### Für Linux

- [.NET Core SDK 5.0.x für Linux](https://www.microsoft.com/net/download/linux)

#### Für Mac

- [.NET Core SDK 5.0.x für MacOS](https://www.microsoft.com/net/download/macos)

## Bereiten Sie die App vor

### Windows

- Öffnen Sie eine Eingabeaufforderung

    ```cmd
        cd src\anniversaryreminder
        dotnet build
        dotnet ef database update
    ```

- Damit wird die Anwendung und eine neue leere Datenbank erstellt.

### Linux oder MacOS

- Öffnen Sie eine Eingabeaufforderung

    ```bash
        cd src/anniversaryreminder
        dotnet build
        dotnet ef database update
    ```

- Damit wird die Anwendung und eine neue leere Datenbank erstellt.

## Starten Sie die Anniversaryreminder-App

### Ausführen unter Windows

- Öffnen Sie eine Eingabeaufforderung

  ```cmd
    cd src\anniversaryreminder
    dotnet run
  ```

- Dies hostet die Anwendung in einer Konsolenanwendung - Anwendung gestartet unter der URL **`http://localhost:5000/`**.

### Unter Linux oder MacOS ausführen

- Öffnen Sie eine Eingabeaufforderung

  ```bash
        cd src/anniversaryreminder
        dotnet run
  ```

- Dies hostet die Anwendung in einer Konsolenanwendung - Anwendung gestartet unter der URL **`http://localhost:5000/`**.

## Veröffentlichen Sie die AnniversaryReminder-Anwendung

### Unter Windows veröffentlichen

- Öffnen Sie eine Eingabeaufforderung

    ```cmd
        cd src\anniversaryreminder
        dotnet publish -c Release -o [RELEASEDIRECTORY]
    ```

### Veröffentlichen unter Linux oder MacOS

- Öffnen Sie eine Eingabeaufforderung

    ```bash
        cd src/anniversary reminder
        dotnet publish -c Release -o [RELEASEDIRECTORY]
    ```

## Lizenz

EUPL-1.2 © [Jürgen Mülbert](https:/github.com/jmuelbert/anniversaryreminder/)

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
