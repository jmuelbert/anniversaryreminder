## Willkommen!

Sie sind hier, um bei AnniversaryReminder zu helfen? Wunderbar, zögern Sie nicht und lesen Sie die folgenden Abschnitte, um zu wissen, wie man an etwas arbeitet und woher man Hilfe bekommen kann. Ihr Beitrag ist sehr wichtig, die AnniversaryReminder wird durch Menschen wie Sie immer besser und besser. :smile:

## Welche Art von Beiträgen suchen wir?

- Wenn Ihnen AnniversaryReminder gefällt, starten Sie dieses Projekt und teilen Sie es mit Ihren Freunden.
- Melden Sie Fehler oder fordern Sie neue Funktionen an, indem Sie [opening issues](https://github.com/jmuelbert/anniversaryreminder/issues/new/choose). Bitte folgen Sie den Problemvorlagen und stellen Sie detaillierte Informationen zur Verfügung, dies wird den Entwicklern helfen, den Grund des Fehlers zu finden und zu verstehen, welche Funktion Sie genau anfordern.
- Helfen Sie anderen Personen bei Problemen/pull requests/anderen Plattformen, wenn Sie in der Lage sind, ihnen zu helfen.
- Schreiben Sie Tutorials und Blogs über die Verwendung für AnniversaryReminder.
- Verbessern Sie die Dokumentation, einschließlich der Markdown-Dateien und der Kommentare in den Codes.
- Schreiben Sie Codes für neue Funktionen oder Fehlerbehebungen.

## Ihr erster Beitrag

**Arbeiten Sie an Ihrer ersten Pull-Anfrage?** Sie können von dieser *freien* Serie [Wie man zu einem Open-Source-Projekt auf GitHub beiträgt](https://egghead.io/series/how-to-contribute-to-an-open-source-project-on-github) lernen. Im Grunde genommen müssen Sie dieses Repository abspalten, Codes auf Ihre Abspaltung schreiben, eine Pull-Anfrage öffnen, wenn Sie fertig sind, auf Überprüfungen warten und Vorschläge von den Betreuern einbringen.

**Es gibt einen großen Unterschied zwischen Entwickeln und fortgeschrittener Programmierung, aber das ist nicht schwer. Das erste, was Sie wissen sollten, ist objektorientierte Programmierung. Im Grunde genommen müssen Sie wissen, wie Klassen in C# funktionieren. Der Quellcode der Jubiläumserinnerung ist ein gutes Beispiel. Google für das, was Sie implementieren möchten, ist normalerweise hilfreich. Kopieren und modifizieren Sie die Quelltexte, wenn Sie etwas Ähnliches wie eine bestehende Funktion implementieren wollen. Wenn Sie nach einer IDE zum Entwickeln suchen, ist [VS Code](https://code.visualstudio.com/) wahrscheinlich eine gute Wahl.

**Wissen nicht, wo Sie anfangen sollen?** Sie können damit beginnen, die [issues](https://github.com/jmuelbert/anniversaryreminder/issues) durchzusehen und eine zu finden, an der Sie interessiert sind. Die [guten Erstausgaben](https://github.com/jmuelbert/anniversaryreminder/issues?q=is%3Aissue+ist%3Aopen+Label%3A%22gute+Erste+Erste+Ausgabe%22) könnte für Sie geeignet sein.

## Vor dem Schreiben von Codes

Bitte öffnen Sie ein Problem (beschreiben Sie das Merkmal/den Fehler wie normale Probleme und sagen Sie, dass Sie daran arbeiten werden, wahrscheinlich mit einem Entwurf, wie Sie es implementieren möchten), bevor Sie Codes für eine Pull-Anfrage schreiben, aus diesen Gründen:

1. Sie können Hilfe von anderen erhalten.
2. Andere können wissen, dass Sie daran arbeiten, dies erspart Ihnen mögliche Doppelarbeiten.
3. Sie werden benachrichtigt, wenn diese Funktion nicht akzeptiert wird, oder wenn der "Fehler" tatsächlich kein Fehler ist usw., was Ihnen Zeit spart.

## Regeln für das Beitragen

- Denken Sie daran, dass es das Ziel ist, eine Jubiläumserinnerung für Benutzer, nicht für Entwickler zu erstellen.
- Tun Sie eine Sache bei einer Pull-Anfrage. Wenn Sie mehrere Funktionen hinzufügen/mehrere Fehler beheben wollen und diese nicht relevant sind, öffnen Sie mehrere Pull-Requests. Möglicherweise müssen Sie mehrere Zweige erstellen, um mehrere Pull-Anfragen zu öffnen. Sie können das Verzweigen von Git [hier] lernen (https://learngitbranching.js.org/).
- Fügen Sie neue Funktionen auf dem Master-Zweig hinzu und beheben Sie den Fehler auf dem letzten aktiven Zweig (Master-, Beta- und Stable-Zweig), in dem der Fehler aufgetreten ist.
- Bitte schreiben Sie [clear commit messages](https://chris.beams.io/posts/git-commit/). Es wird auch empfohlen, [Konventionelle Commits](https://www.conventionalcommits.org/) zu schreiben. Sie können [commitizen/cz-cli](https://github.com/commitizen/cz-cli) verwenden, um Commit-Nachrichten zu schreiben. Die Regeln sind jedoch optional, der Schlüssel ist, dass andere und Sie selbst in Zukunft verstehen sollten, was geändert wurde und warum diese Änderungen vorgenommen wurden.
- Entfernen Sie keine Funktionen, es sei denn, es ist notwendig. Fügen Sie stattdessen eine Option zur Deaktivierung einer Funktion hinzu.
- Halten Sie die Einstellungsdatei die ganze Zeit abwärtskompatibel.
- Windows, Linux und Mac OS sollten unterstützt werden.
- Beide hell/dunkel Systemdesigns sollten unterstützt werden.
- Jeder sollte sich an den [Verhaltenskodex](CODE_OF_CONDUCT_de-DE.md) halten, um eine belästigungsfreie Gemeinschaft aufzubauen.

## FAQ

- Kann ich es gut machen, wenn ich gerade erst angefangen habe?
  - Jeder weiß am Anfang nichts. Machen Sie sich keine Sorgen, unsere coolen Beitragszahler helfen Ihnen, wenn Sie auf Schwierigkeiten stoßen. Wenn Sie :Herz: Open Source und weiter versuchen, wird alles besser und besser werden.
  - Wenn die CI-Tests bestanden werden, liegt das wahrscheinlich daran, dass die Untermodule aktualisiert werden. Sie können die folgenden Befehle ausführen:

    ```sh
    git add .
    git reset --hard
    git submodule update --init
    ```


    Sie können auch `git rm` alle Submodule versuchen und sie dann erneut initialisieren oder sogar das Repo auf Ihrer Platte löschen und erneut klonen.
