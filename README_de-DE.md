# anniversaryreminder

anniversary reminder ist ein Programm, mit dem Sie an Jubiläen in einem Unternehmen erinnert werden, d.h. der Mitarbeiter ist 10 Jahre, 25 Jahre im Unternehmen. Oder der Mitarbeiter hat Geburtstag.

---

[![Gitpod-Ready-Code](https://img.shields.io/badge/Gitpod-Ready--to--Code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/jmuelbert/anniversaryreminder)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c63d1cf887384176977da4e7ba43495e)](https://app.codacy.com/manual/jmuelbert/anniversaryreminder?utm_source=github.com&utm_medium=referral&utm_content=jmuelbert/anniversaryreminder&utm_campaign=Badge_Grade_Dashboard)
[![Total alerts](https://img.shields.io/lgtm/alerts/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/alerts/)
[![Language grade: JavaScript](https://img.shields.io/lgtm/grade/javascript/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:javascript)
[![Language grade: C#](https://img.shields.io/lgtm/grade/csharp/g/jmuelbert/anniversaryreminder.svg?logo=lgtm&logoWidth=18)](https://lgtm.com/projects/g/jmuelbert/anniversaryreminder/context:csharp)
[![GitHub All Releases](https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/total?label=downloads%40all)](https://github.com/jmuelbert/anniversaryreminder/releases)
[![GitHub license](https://img.shields.io/badge/license-EUPL-blue.svg)](https://joinup.ec.europa.eu/page/eupl-text-11-12)
[![Build status](https://ci.appveyor.com/api/projects/status/62fnw26b3ka208o9?svg=true)](https://ci.appveyor.com/project/jmuelbert/anniversaryreminder-7whd2)
![Misspell fixer](https://github.com/jmuelbert/anniversaryreminder/workflows/Misspell%20fixer/badge.svg)
[![pre-commit](https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white)](https://github.com/pre-commit/pre-commit)
[![Help wanted issues](https://img.shields.io/github/issues/jmuelbert/anniversaryreminder/help%20wanted)](https://github.com/jmuelbert/anniversaryreminder/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22)

[Features](https://github.com/jmuelbert/anniversaryreminder) | [Documentation](https://jmuelbert.github.io/anniversaryreminder/) | [Changelog](CHANGELOG.md) | [Contributing](CONTRIBUTING.md) | [FAQ](https://github.com/jmuelbert/anniversaryreminder/wiki/FAQ) | [english](README.md)


anniversaryreminder is free software; you can redistribute it and/or modify it under the terms
of the [European Public License Version 1.2](https://joinup.ec.europa.eu/page/eupl-text-11-12).
Please read the [LICENSE](https://github.com/jmuelbert/anniversaryreminder/blob/master/LICENSE.EUPL-1_2.txt) for additional information.

 |  type  |                                 branch                                 |                                                                                                                   build                                                                                                                    |                                                                                downloads                                                                                 |
 | :----: | :--------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
 | alpha  | [master](https://github.com/jmuelbert/anniversaryreminder/tree/master) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=master&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3Amaster) |                                                                                    -                                                                                     |
 |  beta  | [v0.5.2](https://github.com/jmuelbert/anniversaryreminder/tree/v0.0.0) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=v0.0.0&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3Av0.0.0) | [![Downloads](https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/v0.0.0/total)](https://github.com/jmuelbert/anniversaryreminder/releases/tag/v0.0.0) |
 | stable | [v0.5.0](https://github.com/jmuelbert/anniversaryreminder/tree/v0.0.0) | [![GitHub Workflow Status](https://github.com/jmuelbert/anniversaryreminder/workflows/CI:%20Build%20Test/badge.svg?branch=v0.0.0&event=push)](https://github.com/jmuelbert/anniversaryreminder/actions?query=event%3Apush+branch%3v0.0.0)  | [![Downloads](https://img.shields.io/github/downloads/jmuelbert/anniversaryreminder/v0.0.0/total)](https://github.com/jmuelbert/anniversaryreminder/releases/tag/v0.0.0) |

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

- [.NET Core SDK 3.1 für Windows](https://www.microsoft.com/net/download/windows)

#### Für Linux

- [.NET Core SDK 3.1 für Linux](https://www.microsoft.com/net/download/linux)

#### Für Mac

- [.NET Core SDK 3.1 für MacOS](https://www.microsoft.com/net/download/macos)

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

[Nach oben zurückkehren](#top)
