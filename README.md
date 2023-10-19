# SuperMarioKata


Hier stelle ich meine Lösung für das sagenumwobene SuperMarioKata von Uli Armbruster vor: 
### Iterationen

#### Iteration 1
-	Wenn Super Mario startet, ist er klein.
-	Wenn der kleine Mario vom Gegner getroffen wird, ist er tot und mit ihm kann nicht mehr gespielt werden.


#### Iteration 2
-	Wenn ein kleiner Super Mario einen Pilz findet,  wird er ein Super Mario mit Pilz.
-	Wenn Super Mario mit Pilz einen Pilz findet, bleibt er im Zustand Super Mario mit 	Pilz.
-	Wenn Super Mario mit Pilz vom Gegner getroffen wird, wird er zum kleinen Mario.


#### Iteration 3
-	Wenn Super Mario startet, soll er 3 Leben haben.
-	Wenn Super Mario stirbt, verliert er ein Leben.
-	Wenn alle Leben aufgebraucht sind, ist Super Mario tot und mit ihm kann nicht mehr gespielt werden.


#### Iteration 4
-	Wenn Super Mario ein Leben findet, erhöhen sich seine verfügbaren Leben.
-	Wenn ein toter Super Mario ein Leben findet, kann wieder mit ihm gespielt werden.


#### Iteration 5
-	Wenn Super Mario eine Feuerblume findet, wächst er.
-	Wenn Super Mario mit Feuerblume vom Gegner getroffen wird, wird er zum Mario mit Pilz.
-	Wenn Super Mario mit Feuerblume einen Pilz findet, behält er seine Feuerblume.


#### Iteration 6
-	Wenn Super Mario eine Eisblume findet, wächst er.
-	Wenn Super Mario mit Eisblume vom Gegner getroffen wird, wird er zum Mario mit Pilz.
-	Wenn Super Mario mit Eisblume einen Pilz findet, behält er seine Eisblume.
-	Wenn Super Mario mit Eisblume eine Feuerblume findet, wechselt er zur Feuerblume (vice versa).

Es gibt noch weiter Iterationen, die ich nach und nach implementieren werden.
