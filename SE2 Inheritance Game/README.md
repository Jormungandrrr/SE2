# Inheritance

Voor deze opdracht gaan we er van uit dat je reeds [unit tests geïmplementeerd
hebt](7851517). De volgende stap in de ontwikkeling van de applicatie is het
elimineren van code die op meerdere plekken staat en (nagenoeg) dezelfde
functionaliteit heeft.

## De opdracht

Met name de `Player` en `Enemy` klassen hebben veel overeenkomsten in de
huidige implementatie. Maak een nieuwe klasse aan genaamd `Character` die de
gedeelde stukken code kan bevatten. Zorg er dan voor dat de eerder genoemde
klassen overerven van deze nieuwe klasse. Je unit testen zullen ook moeten
blijven werken: enerzijds helpen deze je bij het controleren of alles nog naar
behoren werkt, maar kleine wijzigingen kunnen noodzakelijk zijn.

Een andere nieuwe functionaliteit is dat het spel ook meerdere tegenstanders
moet kunnen bevatten. In plaats van een enkele `Enemy` instantie in de `World`
klasse zal dit vervangen moeten worden door een lijst. Voeg hier ondersteuning
voor toe aan de applicatie, en zorg ook dat de gebruiker op kan geven hoeveel
tegenstanders hij wenst.

Daarnaast zijn er mogelijk nog wat stukken code die beter op een andere plek
kunnen staan. Kijk dus nog eens kritisch naar je applicatie, overleg met
anderen over wat een goede wijziging zou kunnen zijn en voer deze vervolgens
door.

Tot slot zullen deze wijzigingen leiden tot een bijgewerkt klassendiagram. Pas
deze aan voor je applicatie zodat je ook hierop feedback kunt krijgen.

## Inleveren

Ben je zover gekomen als je kon? Lever dan bij de assignment op Canvas de link
in naar je GitLab-project. Geef als toelichting aan wat er goed ging of waar je
juist niet uit kwam zodat de docent zo gericht mogelijk feedback kan geven.

