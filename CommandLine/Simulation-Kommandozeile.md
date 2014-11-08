# Kommandozeile

Loksim (Simulationsprogramm) ermöglicht mit folgenden Komandozeilenargumenten einen Schnellstart:

| Name | Parameter | Beschreibung |
|------|-----------|--------------|
| /hidemsg | | Keine Meldungsfenster (Planhalt überfahren, Vmax um mehr als 20 km/h überschritten, ...) |
| /Fahrplan:%1 | %1: Absoluter Pfad zur Fahrplandatei | Startet Loksim mit dem angegebenen Fahrplan |
| /Lok:%1 | %1: Absoluter Pfad zur Lokdatei | Startet Loksim mit der angegebenen Lok |
| /StartBahnhof:%1 | %1: Name des Bahnhofes | Startet Loksim am angegebenen Bahnof |
| /StartIndex:%1 | %1: Nullbasierter Index der Anfangszeit | Startet Loksim zur angegebenen Startzeit |
| /WetterIndex:%1 | %1: Nullbasierter Index aus der Wetterdatei | Startet Loksim mit dem Wetter, das im Fahrplan angegen wird, und das in der Wetterdatei den angegebenen Index hat. Wird dieser Parameter Weggelassen, wird das Wetter zufällig bestimmt. Ist im Fahrplan kein Wetter angegeben, wird die klassische Himmelsdarstellung umgesetzt. 

Argumente die zur Auswahl des Szenarios dienen (alle außer /hidemsg) dürfen dabei nicht durch ein Leerzeichen getrennt werden. Leerzeichen in den Pfaden werden korrekt verarbeitet, die Pfade dürfen jedoch nicht durch Anführungszeichen abgegrenzt sein. Ein beispielhafter Aufruft lautet somit:

    C:\Users\Max>"C:\Loksim3D\Loksim3D.exe" Fahrplan:C:\Loksim-Data\Fahrplan\Demo2\ICE\ICE ab Hainfurt.l3dfpl/Lok:C:\Loksim-Data\Loksim-Data\Lok\Triebwagen-E\BR 406\UPeters\406_einfach.l3dlok/StartBahnhof:Hainfurt/StartIndex:1/WetterIndex:1

Siehe auch: http://www.loksim.de/Wiki/index.php/Kommandozeilenargumente

## Standardhinweise: Batch-Dateien

Wenn man regelmäßig eine Strecke starten möchte, kann man entwder die Verknüpfung für Loksim kopieren und entsprechend bearbeiten, oder man legt eine Batch-Datei (*.bat) an.
Bei letzterer Vorgehensweise soll darauf hingewiesen werden, dass die Eingabeaufforderung in Windows normalerweise mit der Codepage 850 arbeitet. Wer also mit Notepad eine bat-Datei anlegt, bekommt möglicherweise Probleme mit nicht korrekt erkannten Umlauten. Wenn man die Datei in der Codierung "ANSI" speichert, entspricht dies in Deutschland im Allgemeinen der Codepage 1252. Die Umstellung der Eingabeaufforderung auf Codepage 1252 erfolgt mit dem Befehl chcp 1252. Damit können ANSI-Codierte Bat-Dateien korrekt erkannt werden. Soll die Codepage wieder zurück gestellt werden müssen, erfolgt das analog mit chcp 850.
