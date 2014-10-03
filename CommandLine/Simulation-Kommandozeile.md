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
