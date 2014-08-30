# OLE Variablen

In dieser Datei sind sämtliche über OLE abrufbaren Variablen dokumentiert. 
In manchen Fällen ist die Beschreibung vermutlich etwas zu kurz, über die Zeit wird diese bei Bedarf ergänzt und jeder ist willkommen Ergänzungen durchzuführen um anderen Programmieren das Leben zu erleichtern.

In der Spalte "Version" wird bei zukünftigen Variablen dokumentiert ab welcher Loksim-Version sie vorhanden sind


| Variablenname                             | Beschreibung                                         | Datentyp | Version |
| ----------------------------------------- |------------------------------------------------------|----------|---------|
| LOK.COMMON.ACTSPEED                       | Aktuelle Geschwindigkeit in km/h                     | Float    |         |
| LOK.COMMON.MAXSPEED                       | Maximalgeschwindigkeit Lok in km/h                   | Float    |         |
| LOK.COMMON.ZUGSICHERUNGSSYSTEME           | Vorhandene Zugsicherungssysteme (siehe unten)        | String   | 2.9     |
| LOK.SYSTEM.1000HZUEBERWACHUNG             | 1000Hz Überwachung aktiv                             | Bool     |         |
| LOK.SYSTEM.500HZUEBERWACHUNG              | 500Hz Überwachung aktiv                              | Bool     |         |
| LOK.ANZEIGE.SCHLEUDERN                    | Lok schleudert gerade                                | Bool     |         |
| LOK.ANZEIGE.SANDEN                        | Sanden aktiv                                         | Bool     |         |
| LOK.ANZEIGE.HAUPTSCHALTER                 | Hauptschalter eingeschalten                          | Bool     |         |
| LOK.ANZEIGE.SIFA                          | Sifa Melder leuchtet                                 | Bool     |         |
| LOK.ANZEIGE.INDUSIHZ1000                  | 1000Hz Anzeige leuchtet                              | Bool     |         |
| LOK.ANZEIGE.INDUSIHZ500                   | 500Hz Anzeige leuchtet                               | Bool     |         |
| LOK.ANZEIGE.INDUSI95                      | Leuchtmelder Indusi95 leuchtet                       | Bool     |         |
| LOK.ANZEIGE.INDUSI75                      | Leuchtmelder Indusi75 leuchtet                       | Bool     |         |
| LOK.ANZEIGE.INDUSI60                      | Leuchtmelder Indusi60 leuchtet                       | Bool     |         |
| LOK.ANZEIGE.INDUSIBEFEHL                  | Leuchtmelder Indusi Befehl leuchtet                  | Bool     |         |
| LOK.INSTRUMENT.INDUSIVZIEL                | Zielgeschwindigkeit laut Indusi Überwachung          | Float    |         |
| LOK.INSTRUMENT.INDUSIVZIELKURVE           | Aktuell erlaubte Höchstgeschwindigkeit laut Indusi Überwachungskurve   | Float    | |
| LOK.INSTRUMENT.AKTBREMSSTUFE              | Aktuelle Bremsstufe                                  | Float    |         |
| LOK.ANZEIGE.WECHSELBLINKEN                | Wechselblinken aktiv                                 | Bool     |         |
| LOK.ANZEIGE.LZBBETRIEB                    | Zustand LZB Betriebsanzeige                          | Bool     |         |
| LOK.ANZEIGE.LZBG                          | Zustand LZB G-Melder                                 | Bool     |         |
| LOK.ANZEIGE.LZBU                          | Zustand LZB U-Melder                                 | Bool     |         |
| LOK.ANZEIGE.LZBENDE                       | Zustand LZB Endeanzeige                              | Bool     |         |
| LOK.ANZEIGE.SCHNELLBREMSUNG               | Zustand LZB/PZB S-Melder                             | Bool     |         |
| LOK.ANZEIGE.MAGNETBREMSEAKTIV             | Zustand Anzeige Magnetbremse aktiv                   | Bool     |         |
| LOK.ANZEIGE.MAGNETBREMSE                  | Zustand Anzeige Magnetbremse                         | Bool     |         |
| LOK.ANZEIGE.HALTEBREMSE                   | Zustand Anzeige Haltebremse                          | Bool     |         |
| LOK.ANZEIGE.HOHEABBREMSUNGVORH            | Zustand Anzeige Hohe Abbremsung                      | Bool     |         |
| LOK.ANZEIGE.TUER1                         | Zustand 1. Türmelder  		                       | Bool     |         |
| LOK.ANZEIGE.TUER2                         | Zustand 2. Türmelder			                       | Bool     |         |
| LOK.ANZEIGE.TUER1_2                       | Zustand 1. Türmelder ohne Blinken                    | Bool     |         |
| LOK.ANZEIGE.TUER2_2                       | Zustand 2. Türmelder ohne Blinken                    | Bool     |         |
| LOK.ANZEIGE.TUERVERRIEGELUNG              | Zustand Anzeige Türverriegelung                      | Bool     |         |
| LOK.ANZEIGE.TUERVERRIEGELUNGVORHANDEN     | Ist eine Türverriegelung vorhanden?                  | Bool     |         |
| LOK.ANZEIGE.LICHT                         | Zustand Melder Abblendlicht                          | Bool     |         |
| LOK.ANZEIGE.FERNLICHT                     | Zustand Melder Fernlicht                             | Bool     |         |
| LOK.ANZEIGE.AFB                           | Zustand des Melders AFB ein/aus                      | Bool     |         |
| LOK.ANZEIGE.TRAKTIONGESPERRT              | Zustand der Traktionssperre                          | Bool     |         |
| LOK.ANZEIGE.FEDERSPEICHERBREMSE           | Zustand der Federspeicherbremse                      | Bool     |         |
| LOK.ANZEIGE.ZUGKRAFTSTELLERAKTIV          | Zustand des Zugkraftstellers (ein/aus)               | Bool     |         |
| LOK.ANZEIGE.BUEGELPANTO                   | Zustand Bügel/Pantograph                             | Bool     |         |
| LOK.ANZEIGE.RICHTUNGSWALZE                | Zustand Richtungswalze (1=Vorwärts, -1=Rückwärts, 0=Neutral)| Float    |  |
| LOK.INSTRUMENT.TACHO                      | Aktuelle Geschwindigkeit in km/h                     | Float    |         |
| LOK.INSTRUMENT.LZBVZIEL                   | Aktuelle LZB V-Zielgeschwindigkeit                   | Float    |         |
| LOK.INSTRUMENT.LZBVZIELABSTANDDIGITAL     | Aktueller LZB V-Ziel-Abstand (Digitalanzeige         | Float    |         |
| LOK.INSTRUMENT.LZBVZIELABSTANDBALKEN      | Aktueller LZB V-Ziel-Abstand (Balkenanzeige)         | Float    |         |
| LOK.INSTRUMENT.LZBVSOLLBREMSKURVE         | Aktuelle LZB V-Soll Geschwindigkeit in km/h          | Float    |         |
| LOK.INSTRUMENT.AFB                        | Vorgewählte AFB-Geschwindigkeit in km/h              | Float    |         |
| LOK.INSTRUMENT.BREMSDRUCK                 | Bremsdruck in der HLL im Bereich 0-5                 | Float    |         |
| LOK.INSTRUMENT.BREMSZYLINDERDRUCK         | Bremsdruck in den Zylindern im Bereich 0-5           | Float    |         |
| LOK.INSTRUMENT.2BREMSZYLINDERDR           | 2. Bremsdruckanzeige in den Zylindern im Bereich 0-5 | Float    |         |
| LOK.INSTRUMENT.DYNBREMSSTUFE              | Dynamische Bremsstufe 							   | Float    |         |
| LOK.INSTRUMENT.DYNBREMSMAXSTUFE           | Maximale dynamische Bremsstufe 					   | Float    |         |
| LOK.INSTRUMENT.RICHTUNGSWALZE             | Zustand Richtungswalze (1=Vorwärts, -1=Rückwärts, 0=Neutral)| Float    |  |    
| LOK.INSTRUMENT.ISTSTUFE                   | Ist-Stufe des Schaltwerks                            | Float    |         |
| LOK.INSTRUMENT.SOLLSTUFE                  | Soll-Stufe des Schaltwerks                           | Float    |         |
| LOK.INSTRUMENT.MAXSTUFE                   | Maximale Stufe des Schaltwerks                       | Float    |         |
| LOK.INSTRUMENT.MOTORSTROM                 | Aktueller Motorstrom                                 | Float    |         |
| LOK.INSTRUMENT.OBERSTROM                  | Aktueller Oberstrom                                  | Float    |         |
| LOK.INSTRUMENT.KRAFT                      | Aktuelle Zugkraft                                    | Float    |         |
| LOK.INSTRUMENT.KRAFTPROZENT               | Aktuelle Zugkraft in Prozent vom Max-Wert            | Float    |         |
| LOK.INSTRUMENT.KRAFTPROZENTKPL            | Aktuelle Zugkraft in Prozent von -100% bis +100%     | Float    |         |
| LOK.INSTRUMENT.ZUGKRAFTSTELLER            | Aktuell vorgewählte Zugkraft                         | Float    |         |
| LOK.INSTRUMENT.VSOLLSTELLER               | Aktuell vorgewählte V-Soll der AFB                   | Float    |         |
| LOK.INSTRUMENT.FAHRSPANNUNG               | Aktuelle Fahrspannung                                | Float    |         |
| SIM.COMMON.SIMTIME                        | Zeit die in der Simulation vergangen ist in Sekunden | Float    |         |
| SIM.COMMON.ACTTIME                        | Aktuelle Simulations-Uhrzeit (Format SS:MM:SS)       | String   |         |
| SIM.COMMON.BUCHFAHRPLAN                   | Die nächsten 25 Zeilen des Buchfahrplans. Die Felder sind durch Tabulator etrennt und die Zeilen durch Zeilenumbruch | String |  |
| SIM.COMMON.FAHRPLAN                       | Inhalt des Fahrplans. Die Felder sind durch Tabulator getrennt und die Zeilen durch Zeilenumbruch | String | |
| SIM.COMMON.ACTPOS                         | Aktuelle Position im Simulator in Meter              | Float    |         |
| SIM.COMMON.NAECHSTERHALT                  | Name des nächsten Halts                              | String   |         |

### LOK.COMMON.ZUGSICHERUNGSSYSTEME
In dieser Variablen werden die in der Lok verfügbaren Zugsicherungssysteme ausgegeben.
Die einzelnen Zugsicherungssysteme werden dabei mittels Strichpunkt (';') getrennt. 
Zugsicherungssysteme können dabei weitere Optionen enthalten. Optionen innerhalb von Systemen werden mittels Beistrich (',') getrennt
Die Zugsicherungssysteme werden dabei folgendermaßen benannt:
- I60R/I80
- I60
- PZB90
- PZ80R
- LVZ
- FAHRSPERRE
- SBBSIGNUM
- SBBSIGNUM2
- NL
- LZB

#### Optionen PZB90
- Art
    - I60R
    - I60ER24
    - PZ80R
    - I80
- Version
    - V1.5
    - V1.6
    - V2.0
- Sonderbauform (nur enthalten wenn tatsächlich eine Sonderbauform)
    - STADTBAHN
- Zugart
    - O
    - M
    - U

#### Optionen LZB
- Art
    - 80
    - CE1
    - CE2


### Nicht mehr genutzte Variablen

| Variablenname                             | Beschreibung                                         | Datentyp |
| ----------------------------------------- |------------------------------------------------------|----------| 
| LOK.ANZEIGE.STARTWECHSELBLINKEN           | Wechselblinken PZB Startprogramm aktiv               | Bool     |  
