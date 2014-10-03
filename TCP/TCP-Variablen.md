# TCP-Datenausgabe

Die TCP-Schnittstelle wurde von Zusi 2 übernommen. Informationen finden sich in [diesem] (http://forum.zusi.de/viewtopic.php?f=39&t=11779) Sammelthread aus dem Zusi-Forum.

Zur Implentierung empfiehlt es sich, einer der dort aufgeführten Wraper zu verwenden. (Zur Zeit stehen Wraper für .Net, Java und C++/Win32 zur Verfügung.)

Folgende Daten werden von dem Protokoll unterstützt. Größen, die von Loksim nicht unterstützt werden, werden dennoch zur Anforderung akzeptiert, auch wenn Loksim sie nicht liefern kann.

| ID | ID (hex) | Funktion | Unterstützung |Bemerkungen|
|----|----------|----------|---------------|-----------|
| 2560 | 0A00 | (ohne Funktion) | (Keine Nutzdaten) | |
| **2561** | **0A01** | **Geschwindigkeit** | **Ja** | |
| **2562** | **0A02** | **Druck Hauptluftleitung** | **Ja** | |
| **2563** | **0A03** | **Druck Bremszylinder** | **Ja** | |
| 2564 | 0A04 | Druck Hauptluftbehälter | Nein | (kein HLB in Loksim) |
| **2565** | **0A05** | **Zugkraft gesamt** | **Ja** | |
| 2566 | 0A06 | Zugkraft pro Achse | Nein | (keine Achsen im l3dfpl) |
| **2567** | **0A07** | **Strom** | **Ja** | |
| **2568** | **0A08** | **Spannung** | **Ja** | |
| 2569 | 0A09 | Motordrehzahl | Nein | (vereinfachtes Antriebsmodell) |
| **2570** | **0A0A** | **Uhrzeit Stunde** | **Ja** | |
| **2571** | **0A0B** | **Uhrzeit Minute** | **Ja** | |
| **2572** | **0A0C** | **Uhrzeit Sekunde** | **Ja** | |
| **2573** | **0A0D** | **LZB Ziel-Geschwindigkeit** | **Ja** | |
| **2574** | **0A0E** | **LZB/AFB Soll-Geschwindigkeit** | **Ja** | |
| 2575 | 0A0F | LZB Zielweg | Nein (siehe 0A4B) | Zielweg mit Skalierung, siehe auch 2635 / 0A4B |
| **2576** | **0A10** | **Fahrstufe** | **Ja** | Istwert |
| 2577 | 0A11 | 3D-Fenster | (Keine Nutzdaten) | |
| **2578** | **0A12** | **AFB Soll-Geschwindigkeit** | **Ja** | |
| 2579 | 0A13 | Druck Hilfsluftbehälter | Nein | (kein HLB in Loksim) |
| **2580** | **0A14** | **LM PZB 1000Hz / PZ80 60** | PZB: **Ja** PZ80: ? | |
| **2581** | **0A15** | **LM PZB 500Hz / PZ80 40** | PZB: **Ja** PZ80: ? | |
| **2582** | **0A16** | **LM PZB Befehl / PZ80 LM** | PZB: **Ja** PZ80: ? | |
| **2583** | **0A17** | **LM PZB Zugart U / PZ80 Geschwindigkeit** | PZB: **Ja** PZ80: ? | PZB 60 / 55 |
| **2584** | **0A18** | **LM PZB Zugart M / PZ80 Programm** | PZB: **Ja** PZ80: ? | PZB 75 / 70 |
| **2585** | **0A19** | **LM PZB Zugart O / PZ80 PZB** | PZB: **Ja** PZ80: ? | PZB 85 / 95 |
| 2586 | 0A1A | LM LZB H | Nein | Haltsingal überfahren, in Zusi 2 vermutlich unbenutzt |
| **2587** | **0A1B** | **LM LZB G** | **Ja** | Geschwindigkeitsanpassung |
| **2588** | **0A1C** | **LM LZB E40** | **Ja** | Ersatzsignal, in Zusi 2 unbenutzt |
| 2589 | 0A1D | LM LZB EL | N/A | Schutzstrecke, in Zusi 2 unbenutzt |
| **2590** | **0A1E** | **LM LZB Ende** | **Ja** | |
| **2591** | **0A1F** | **LM LZB V40** | **Ja** | Vorsichtssignal, in Zusi 2 unbenutzt |
| **2592** | **0A20** | **LM LZB B** | **Ja** | Bereitschaft |
| **2593** | **0A21** | **LM LZB S** | **Ja** | Schnellbremsung, in Zusi 2 unbenutzt |
| **2594** | **0A22** | **LM LZB Ü** | **Ja** | Überwachung |
| 2595 | 0A23 | LM LZB Prüfen | N/A | Prüftaster / Störmelder (?), in Zusi 2 unbenutzt |
| **2596** | **0A24** | **LM Sifa** | **Ja** | |
| **2597** | **0A25** | **LM Hauptschalter** | **Ja** | |
| 2598 | 0A26 | LM Getriebe | N/A | (vereinfachtes Antriebsmodell) |
| **2599** | **0A27** | **LM Schleudern** | **Ja** | |
| 2600 | 0A28 | LM Gleiten | N/A | |
| **2601** | **0A29** | **LM Mg-Bremse** | **Ja** | |
| 2602 | 0A2A | LM H-Bremse | N/A | |
| 2603 | 0A2B | LM R-Bremse | N/A | |
| **2604** | **0A2C** | **LM Hochabbremsung** |**Ja** | |
| **2605** | **0A2D** | **LM Schnellbremsung** | **Ja** | |
| 2606 | 0A2E | LM Notbremsung | N/A | (keine Verwendung) |
| **2607** | **0A2F** | **LM Türen** | **Ja** | |
| 2608 | 0A30 | LM Tfz-Nummer | Nein | (keine entspr. Angabe) |
| 2609 | 0A31 | LM max. Tfz-Geschwindidigkeit | Ausstehend | |
| **2610** | **0A32** | **LM Uhrzeit (digital)** | **Ja** | |
| **2611** | **0A33** | **Schalter Fahrstufen** | **Ja** | Sollwert |
| 2612 | 0A34 | Schalter Führerbremsventil | Nein | |
| 2613 | 0A35 | Schalter dyn. Bremse | Nein | |
| 2614 | 0A36 | Schalter Zusatzbremse | Nein | |
| 2615 | 0A37 | Schalter AFB-Geschwindigkeit | Ausstehend | |
| 2616 | 0A38 | Schalter AFB ein/aus | Ausstehend | |
| 2617 | 0A39 | Schalter Mg-Bremse | Nein | |
| **2618** | **0A3A** | **Schalter PZB Wachsam** | **Ja** | Herunterdrücken der Wachsam-Taste |
| **2619** | **0A3B** | **Schalter PZB Frei** | **Ja** | Herunterdrücken der Freitaste |
| **2620** | **0A3C** | **Schalter PZB Befehl** | **Ja** | Herunterdrücken der Befehlstaste |
| 2621 | 0A3D | Schalter Sifa | ? | Herunterdrücken eines Sifa-Knopfes |
| 2622 | 0A3E | Schalter Hauptschalter | Nein | |
| 2623 | 0A3F | Schalter Motor ein/aus | Nein | |
| 2624 | 0A40 | Schalter Fahrtrichtung | Ausstehend | |
| 2625 | 0A41 | Schalter Pfeife | Nein | Herunterdrücken des Pfeiftasters |
| 2626 | 0A42 | Schalter Sanden | Nein | |
| 2627 | 0A43 | Schalter Türen | Nein | |
| 2628 | 0A44 | Schalter Glocke | Nein | Herunterdrücken des Glockentasters |
| 2629 | 0A45 | Schalter Lokbremse entlüften | N/A | |
| 2630 | 0A46 | Schalter Schleuderschutzbremse | N/A | |
| 2631 | 0A47 | LM Drehzahlverstellung | N/A | |
| 2632 | 0A48 | LM Fahrtrichtung vor | Ausstehend | |
| 2633 | 0A49 | LM Fahrtrichtung zurück | Ausstehend | |
| 2634 | 0A4A | Schalter Signum | Ausstehend | |
| **2635** | **0A4B** | **LM LZB Zielweg (ab 0)** | **Ja** | Ohne Skalierung, siehe auch 2575 / 0A0F |
| **2636** | **0A4C** | **LZB Soll-Geschwindigkeit** | **Ja** | |
| 2637 | 0A4D | LM Block, bis zu dem die Strecke frei ist | N/A | (keine Signalnamen in Loksim) |
| 2638 | 0A4E | Schalter Lüfter | Nein | |
| 2639 | 0A4F | LM GNT G | N/A | (kein GNT in Loksim) |
| 2640 | 0A50 | LM GNT Ü | N/A | (kein GNT in Loksim) |
| 2641 | 0A51 | LM GNT B | N/A | (kein GNT in Loksim) |
| 2642 | 0A52 | LM GNT S | N/A | (kein GNT in Loksim) |
| 2643 | 0A54 | Hintergrundbild | (Keine Nutzdaten) | |
| 2644 | 0A55 | Platzhalter Nachtinstrument | (Keine Nutzdaten) | |
| 2645 | 0A55 | Strecken-Km | Ausstehend | |
| 2646 | 0A56 | Türen | Nein | Türen geschlossen, Fahrgastwechsel beendet, Zp9, etc. (vereinfachtes Abfertigungsmodell) |
| 2647 | 0A57 | Autopilot | N/A | (nicht implentiert) |
| 2648 | 0A58 | Reisezug | Ausstehend | |
| **2649** | **0A59** | **PZB-System** | **Ja** | Art der Zugsicherung |
| 2650 | 0A5A | Frames per Second | Ausstehend | |
| 2651 | 0A5B | Führerstand sichtbar | Ausstehend | |
| 2652 | 0A5C | Nächster Blockname | Nein | (keine Signalnamen in Loksim) |
| 2653 | 0A5D | Nächstes Gleis | Nein | (keine Signalnamen in Loksim) |
| 2654 | 0A5E | Bremshundertstel | Nein | |
| **2655** | **0A5F** | **Bremsstellung** | **Ja** | |
| 2656 | 0A60 | Zugdatei | Ausstehend | |
| 2657 | 0A61 | Längsbeschleunigung | Ausstehend | |
| 2658 | 0A62 | Querbeschleunigung | Ausstehend | |
| 2659 | 0A63 | Querneigung | Ausstehend | |
| 2660 | 0A64 | Aktuelle Höchstgeschwindigkeit | Ausstehend | Autopilot-Hilfsgröße: Aktuelle Vmax |
| 2661 | 0A65 | Aktuelle Zielgeschwindigkeit | Ausstehend | Autopilot-Hilfsgröße: Nächste Geschwindigkeitsbegrenzung in km/h oder -1, wenn keine Begrenzung mehr folgt. (Auch Begrenzungen durch Signale.) |
| 2662 | 0A66 | Zielweg | Ausstehend | Autopilot-Hilfsgröße: Distanz, in der 2661 gilt. |
| 2663 | 0A67 | Abstand nächster Reisezughalt | Ausstehend | |
| 2664 | 0A68 | Name nächster Reisezughalt | Ausstehend | |
| 2665 | 0A69 | Planzeit nächster Reisezughalt | Ausstehend | |
| **2666** | **0A6A** | **PZB restriktiv** | **Ja** | |
| **2667** | **0A6B** | **PZB-Zwansgbremsung** | **Ja** | |
| **2680** | **0A78** | **Oberstrom** | **Ja, nur Loksim** | In Zusi 2 durch 2565/0A05/Zugkraft geregelt |
