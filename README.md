# Lucian ínycsiklandó lasagnéja

Üdvözlünk a(z) Lucian ínycsiklandó lasagnéja feladatnál az Exercism C# kurzusán.
Ha segítségre van szükséged a tesztek futtatásához vagy a kódod beküldéséhez, nézd meg a `HELP.md` fájlt.
Ha elakadsz a feladatnál, nézd meg a `HINTS.md` fájlt, de először próbáld meg azok nélkül megoldani :)

## Introduction

## Alapok

A C# statikusan típusos nyelv, ami azt jelenti, hogy mindennek már fordításkor van típusa. Azt, hogy egy értéket egy névhez rendelünk, a változó definiálásának nevezzük. Egy változót definiálhatsz úgy, hogy explicit módon megadod a típusát, vagy úgy, hogy hagyod, hogy a C# fordítója a hozzárendelt érték alapján következtessen a típusára (ezt nevezik _típuskövetkeztetésnek_). Ezért a következő két változódefiníció egyenértékű:

```csharp
int explicitVar = 10; // Explicitly typed
var implicitVar = 10; // Implicitly typed
```

Egy változó értékét a `=` operátorral frissítheted. Miután definiáltad, a változó típusa soha nem változhat meg.

```csharp
var count = 1; // Assign initial value
count = 2;     // Update to new value

// Compiler error when assigning different type
// count = false;
```

A C# [objektumorientált nyelv][object-oriented-programming], és minden függvényt egy _osztályban_ kell definiálni. Egy osztályt a `class` kulcsszóval definiálunk. Az objektumokat (vagy _példányokat_) a `new` kulcsszóval hozzuk létre.

```csharp
class Calculator
{
    // ...
}

var calculator = new Calculator();
```

Az osztályon belüli függvényt _metódusnak_ nevezzük. Egy metódusnak nulla vagy több paramétere lehet. Minden paraméter típusát explicit módon meg kell adni, a paramétereknél nincs típuskövetkeztetés. Hasonlóképpen a visszatérési típust is explicit módon meg kell adni. A metódusok a `return` kulcsszóval adják vissza az értékeket. Ahhoz, hogy egy metódust más fájlok kódjából is meg lehessen hívni, hozzá kell adni a `public` hozzáférés-módosítót.

```csharp
class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}
```

A metódusokat egy példányon pont (`.`) szintaxissal hívod meg: megadod a hívni kívánt metódus nevét, és minden paraméteréhez átadsz egy argumentumot. Az argumentumoknál opcionálisan megadhatod a hozzá tartozó paraméter nevét.

```csharp
var calculator = new Calculator();
var sum_v1 = calculator.Add(1, 2);
var sum_v2 = calculator.Add(x: 1, y: 2);
```

A C#-ban a scope-ot a `{` és `}` karakterek határozzák meg.

A C# kétféle megjegyzést támogat. Az egysoros megjegyzéseket `//` előzi meg, a többsoros megjegyzéseket pedig a `/*` és `*/` közé írjuk.

[object-oriented-programming]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/object-oriented-programming

## Instructions

Lucian barátnője éppen hazafelé tart, és Lucian még nem főzte meg az évfordulós vacsorájukat!

Ebben a feladatban kódot írsz majd, hogy segíts Luciannak elkészíteni egy pazar lasagnét a kedvenc szakácskönyvéből.

Négy részfeladatot kapsz, amelyek mind a lasagna elkészítésére fordított időhöz kapcsolódnak.

## 1. Határozd meg a lasagna várható sütési idejét percben

Definiáld a `Lasagna.ExpectedMinutesInOven()` metódust, amely nem vesz át egyetlen paramétert sem, és visszaadja, hány percig kell a lasagnának a sütőben lennie. A szakácskönyv szerint a várható sütési idő 40 perc:

```csharp
var lasagna = new Lasagna();
lasagna.ExpectedMinutesInOven();
// => 40
```

## 2. Számítsd ki a hátralévő sütési időt percben

Definiáld a `Lasagna.RemainingMinutesInOven()` metódust, amely paraméterként átveszi a lasagna tényleges sütőben töltött perceinek számát, és visszaadja, hány percet kell még a lasagnának a sütőben maradnia, az előző részfeladatban megadott várható sütési idő alapján.

```csharp
var lasagna = new Lasagna();
lasagna.RemainingMinutesInOven(30);
// => 10
```

## 3. Számítsd ki az előkészítési időt percben

Definiáld a `Lasagna.PreparationTimeInMinutes()` metódust, amely paraméterként átveszi a lasagnára rakott rétegek számát, és visszaadja, hány percet töltöttél a lasagna előkészítésével, feltételezve, hogy egy réteg elkészítése 2 percet vesz igénybe.

```csharp
var lasagna = new Lasagna();
lasagna.PreparationTimeInMinutes(2);
// => 4
```

## 4. Számítsd ki az eltelt időt percben

Definiáld a `Lasagna.ElapsedTimeInMinutes()` metódust, amely két paramétert vesz át: az első paraméter a lasagnára rakott rétegek száma, a második pedig az, hogy hány percet töltött a lasagna a sütőben. A függvénynek vissza kell adnia, hány percet dolgoztál a lasagna elkészítésén, ami az előkészítési idő és a lasagna által a sütőben eddig eltöltött idő összege.

```csharp
var lasagna = new Lasagna();
lasagna.ElapsedTimeInMinutes(3, 20);
// => 26
```

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @yzAlvin