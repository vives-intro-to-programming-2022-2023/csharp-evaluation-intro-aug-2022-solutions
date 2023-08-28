# Rolling on the Floor

*Rolling on the Floor* is een applicatie die een `string` die een aantal woorden bevat, kan omzetten in een afkorting van die woorden. Het kan bijvoorbeeld "League of Legends" transformeren in "LOL".

De klasse `Abbreviator` moet de transformatie van de tekst naar de afkorting implementeren maar mist nog implementatie. Dat is jouw taak (zie ook `View => Task List` in Visual Studio).

* Implementeer de methode `Abbreviate` in de klasse `Abbreviator` zodat deze de string in `text` omzet naar een afkorting (eerste letter van elk woord)
* Zorg ervoor dat de letters in het eindresultaat allemaal hoofdletters zijn.
* Als de variabele `text` verwijst naar een lege `string`, zorg er dan voor dat je ook een lege string terug geeft.
* Als de variabele `text`  een `null` referentie bevat, zorg er dan voor dat je opnieuw een lege string terug geeft.

## Expected output

```
Welcome to Rolling on the Floor ...
League of Legends can be abbreviated to LOL
```

## Unit Tests

Bij dit project horen unittests. Zie [xUnit Tests](/README.md#xunit-tests) voor informatie over hoe u deze kunt uitvoeren.
