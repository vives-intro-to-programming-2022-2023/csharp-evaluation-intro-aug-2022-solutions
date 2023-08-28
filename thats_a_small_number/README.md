# Thats a Small Number

Met deze app kun je het kleinste getal van de drie bepalen. Er ontbreekt echter enige implementatie.

Voeg de logica toe om het kleinste getal binnen de methodes `SmallestValue` en `SmallestIndex` van de klasse `ArrayHelper` te bepalen. Zie ook `View => Task List` in Visual Studio.

* Implementeer de methode `SmallestValue` in de klasse `NumberArray` zodat deze **het kleinste getal** in de array `values` terug geeft.
  * Indien de array leeg of `null` is dien je `0` terug te geven.
  * Zorg er voor dat het ook werkt met negatieve getallen.

* Implementeer de methode `SmallestIndex` in de klasse `NumberArray` zodat deze de **index van het kleinste getal** in de array `values` terug geeft.
  * Indien de array leeg of `null` is dien je `-1` terug te geven.
  * Zorg er voor dat het ook werkt met negatieve getallen.

Je mag er vanuit gaan dat er geen duplicate waarden in de array zitten.

## Expected Output

```
Het kleinste getal in (1, -3, 104) is -3 op index [1]
Het kleinste getal in (-5, 11, 3) is -5 op index [0]
Het kleinste getal in (0, 109, 66) is 0 op index [0]
Het kleinste getal in (8, 19, 3) is 3 op index [2]
```

## Unit Tests

Bij dit project horen unittests. Zie [xUnit Tests](/README.md#xunit-tests) voor informatie over hoe u deze kunt uitvoeren.