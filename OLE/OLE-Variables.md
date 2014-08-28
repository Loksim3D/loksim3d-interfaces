# OLE Variablen

Work in progress....

| Variablenname                             | Beschreibung                                         | Datentyp |
| ----------------------------------------- |------------------------------------------------------|----------|        
| LOK.COMMON.ACTSPEED                       | Aktuelle Geschwindigkeit in km/h                     | Float    |
| LOK.COMMON.MAXSPEED                       | Maximalgeschwindigkeit Lok in km/h                   | Float    |
| LOK.COMMON.ZUGSICHERUNGSSYSTEME           | Vorhandene Zugsicherungssysteme (siehe unten)        | String   |
| LOK.SYSTEM.1000HZUEBERWACHUNG             | 1000Hz Überwachung aktiv                             | Bool     |
| LOK.SYSTEM.500HZUEBERWACHUNG              | 500Hz Überwachung aktiv                              | Bool     |
| LOK.ANZEIGE.SCHLEUDERN                    | Lok schleudert gerade                                | Bool     |
| LOK.ANZEIGE.SANDEN                        | Sanden aktiv                                         | Bool     |
| LOK.ANZEIGE.HAUPTSCHALTER                 | Hauptschalter eingeschalten                          | Bool     |
| LOK.ANZEIGE.SIFA                          | Sifa Melder leuchtet                                 | Bool     |
| LOK.ANZEIGE.INDUSIHZ1000                  | 1000Hz Anzeige leuchtet                              | Bool     |
| LOK.ANZEIGE.INDUSIHZ500                   | 500Hz Anzeige leuchtet                               | Bool     |
| LOK.ANZEIGE.INDUSI95                      | Leuchtmelder Indusi95 leuchtet                       | Bool     |
| LOK.ANZEIGE.INDUSI75                      | Leuchtmelder Indusi75 leuchtet                       | Bool     |
| LOK.ANZEIGE.INDUSI60                      | Leuchtmelder Indusi60 leuchtet                       | Bool     |
| LOK.ANZEIGE.INDUSIBEFEHL                  | Leuchtmelder Indusi Befehl leuchtet                  | Bool     |
| LOK.INSTRUMENT.INDUSIVZIEL                | Zielgeschwindigkeit laut Indusi Überwachung          | Float    |
| LOK.INSTRUMENT.INDUSIVZIELKURVE           | Aktuell erlaubte Höchstgeschwindigkeit laut Indusi Überwachungskurve   | Float    |
| LOK.INSTRUMENT.AKTBREMSSTUFE              | Aktuelle Bremsstufe                                  | Float    |
| LOK.ANZEIGE.WECHSELBLINKEN                | Wechselblinken aktiv                                 | Bool     |


## LOK.COMMON.ZUGSICHERUNGSSYSTEME

## Nicht mehr genutzte Variablen

| Variablenname                             | Beschreibung                                         | Datentyp |
| ----------------------------------------- |------------------------------------------------------|----------| 
| LOK.ANZEIGE.STARTWECHSELBLINKEN           | Wechselblinken PZB Startprogramm aktiv               | Bool     |  


## TODO


#define cLOK_ANZEIGE_LZBBETRIEB _T("LOK.ANZEIGE.LZBBETRIEB")
#define cLOK_ANZEIGE_LZBG _T("LOK.ANZEIGE.LZBG")
#define cLOK_ANZEIGE_LZBU _T("LOK.ANZEIGE.LZBU")
#define cLOK_ANZEIGE_LZBENDE _T("LOK.ANZEIGE.LZBENDE")
#define cLOK_ANZEIGE_SCHNELLBREMSUNG _T("LOK.ANZEIGE.SCHNELLBREMSUNG")
#define cLOK_ANZEIGE_MAGNETBREMSEAKTIV _T("LOK.ANZEIGE.MAGNETBREMSEAKTIV")
#define cLOK_ANZEIGE_MAGNETBREMSE _T("LOK.ANZEIGE.MAGNETBREMSE")
#define cLOK_ANZEIGE_HALTEBREMSE _T("LOK.ANZEIGE.HALTEBREMSE")
#define cLOK_ANZEIGE_HOHEABBREMSUNGVORH _T("LOK.ANZEIGE.HOHEABBREMSUNGVORH")
#define cLOK_ANZEIGE_TUER1 _T("LOK.ANZEIGE.TUER1")
#define cLOK_ANZEIGE_TUER2 _T("LOK.ANZEIGE.TUER2")
#define cLOK_ANZEIGE_TUER1_2 _T("LOK.ANZEIGE.TUER1_2")
#define cLOK_ANZEIGE_TUER2_2 _T("LOK.ANZEIGE.TUER2_2")
#define cLOK_ANZEIGE_TUERVERRIEGELUNG _T("LOK.ANZEIGE.TUERVERRIEGELUNG")
#define cLOK_ANZEIGE_TUERVERRIEGELUNGVORHANDEN  _T("LOK.ANZEIGE.TUERVERRIEGELUNGVORHANDEN")
#define cLOK_ANZEIGE_LICHT _T("LOK.ANZEIGE.LICHT")
#define cLOK_ANZEIGE_FERNLICHT _T("LOK.ANZEIGE.FERNLICHT")
#define cLOK_ANZEIGE_MESS _T("LOK.ANZEIGE.MESS")
#define cLOK_ANZEIGE_AFB _T("LOK.ANZEIGE.AFB")
#define cLOK_ANZEIGE_TRAKTIONGESPERRT _T("LOK.ANZEIGE.TRAKTIONGESPERRT")
#define cLOK_ANZEIGE_FEDERSPEICHERBREMSE _T("LOK.ANZEIGE.FEDERSPEICHERBREMSE")
#define cLOK_ANZEIGE_AKTIVZUGKRAFTSTELLER _T("LOK.ANZEIGE.ZUGKRAFTSTELLERAKTIV")
#define cLOK_ANZEIGE_BUEGELPANTO _T("LOK.ANZEIGE.BUEGELPANTO")
#define cLOK_ANZEIGE_RICHTUNGSWALZE _T("LOK.ANZEIGE.RICHTUNGSWALZE")

#define cLOK_INSTRUMENT_TACHO _T("LOK.INSTRUMENT.TACHO")
#define cLOK_INSTRUMENT_LZBVZIEL _T("LOK.INSTRUMENT.LZBVZIEL")
#define cLOK_INSTRUMENT_LZBVZIELABSTANDDIGITAL _T("LOK.INSTRUMENT.LZBVZIELABSTANDDIGITAL")
#define cLOK_INSTRUMENT_LZBVZIELABSTANDBALKEN _T("LOK.INSTRUMENT.LZBVZIELABSTANDBALKEN")
#define cLOK_INSTRUMENT_LZBVSOLLBREMSKURVE  _T("LOK.INSTRUMENT.LZBVSOLLBREMSKURVE")
#define cLOK_INSTRUMENT_AFB _T("LOK.INSTRUMENT.AFB")
#define cLOK_INSTRUMENT_BREMSDRUCK _T("LOK.INSTRUMENT.BREMSDRUCK")
#define cLOK_INSTRUMENT_BREMSZYLINDERDRUCK _T("LOK.INSTRUMENT.BREMSZYLINDERDRUCK")
#define cLOK_INSTRUMENT_2BREMSZYLINDERDR _T("LOK.INSTRUMENT.2BREMSZYLINDERDR")
#define cLOK_INSTRUMENT_DYNBREMSSTUFE _T("LOK.INSTRUMENT.DYNBREMSSTUFE")
#define cLOK_INSTRUMENT_DYNBREMSMAXSTUFE _T("LOK.INSTRUMENT.DYNBREMSMAXSTUFE")
#define cLOK_INSTRUMENT_RICHTUNGSWALZE _T("LOK.INSTRUMENT.RICHTUNGSWALZE")

#define cLOK_INSTRUMENT_ISTSTUFE _T("LOK.INSTRUMENT.ISTSTUFE")
#define cLOK_INSTRUMENT_SOLLSTUFE _T("LOK.INSTRUMENT.SOLLSTUFE")
#define cLOK_INSTRUMENT_MAXSTUFE _T("LOK.INSTRUMENT.MAXSTUFE")
#define cLOK_INSTRUMENT_MOTORSTROM _T("LOK.INSTRUMENT.MOTORSTROM")
#define cLOK_INSTRUMENT_OBERSTROM _T("LOK.INSTRUMENT.OBERSTROM")
#define cLOK_INSTRUMENT_KRAFT _T("LOK.INSTRUMENT.KRAFT")
#define cLOK_INSTRUMENT_KRAFTPROZENT  _T("LOK.INSTRUMENT.KRAFTPROZENT")
#define cLOK_INSTRUMENT_KRAFTPROZENTKPL  _T("LOK.INSTRUMENT.KRAFTPROZENTKPL")
#define cLOK_INSTRUMENT_ZUGKRAFTSTELLER _T("LOK.INSTRUMENT.ZUGKRAFTSTELLER")
#define cLOK_INSTRUMENT_VSOLLSTELLER _T("LOK.INSTRUMENT.VSOLLSTELLER")
#define cLOK_INSTRUMENT_FAHRSPANNUNG _T("LOK.INSTRUMENT.FAHRSPANNUNG")
#define cSIM_COMMON_SIMTIME _T("SIM.COMMON.SIMTIME") //Zeit die in der Simulation vergangen ist in Sekunden
#define cSIM_COMMON_ACTTIME  _T("SIM.COMMON.ACTTIME")
#define cSIM_COMMON_BUCHFAHRPLAN  _T("SIM.COMMON.BUCHFAHRPLAN")
#define cSIM_COMMON_FAHRPLAN  _T("SIM.COMMON.FAHRPLAN")
#define cSIM_COMMON_AKTPOS  _T("SIM.COMMON.ACTPOS")
#define cSIM_COMMON_NAECHSTERHALT _T("SIM.COMMON.NAECHSTERHALT")


