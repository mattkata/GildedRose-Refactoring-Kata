# Gilded Rose starting position in C# NUnit

## Build the project

Use your normal build tools to build the projects in Debug mode.
For example, you can use the `dotnet` command line tool:

``` cmd
dotnet build GildedRose.sln -c Debug
```

## Run the Gilded Rose Command-Line program

For e.g. 10 days:

``` cmd
GildedRose/bin/Debug/net8.0/GildedRose 10
```

## Run all the unit tests

``` cmd
dotnet test
```

# Solution envisag�es:

## Architecture

Je propose une approche SOLID en utilisant des designs pattern

- Principe de responsabilit� unique : Chaque classe a une responsabilit� unique
- Principe Open/Close: Ajouter de nouveau comportement sans modifier le code existant
- Polymorphisme: Remplacer les comportement sans affecter le code existant
- Pattern Strategy pour encapsuler les variations et mettre a jour les objets

Architecture:

- Couche Domaine: Repr�sentation des objets (items) et des comportement sous forme de strategies
- Couche Application: Orchestration de la logique m�tier
- Strategy: Chaque type d'item d�fini son propre systeme pour gerer les mises a jour
- Factory: Permet de s�lectionner dynamiquement la strat�gie adapt� a chaque item.





