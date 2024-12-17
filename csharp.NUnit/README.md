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

## Les objets du domaine

On peut faire une breve descriptions des objets comme suit:

Caract�ristiques communes � tous les objets

- SellIn : Le nombre de jours restant pour vendre l'objet. Il diminue de 1 unit� chaque jour.
- Quality : La qualit� de l'objet (une sorte de valeur de l'objet).
    - Limite basse : La qualit� ne peut jamais descendre en dessous de 0.
    - Limite haute : La qualit� ne peut jamais d�passer 50, sauf pour certains objets exceptionnels.

On voit qu'il existe plusieurs types d'objets (les objets basique, les aged bries (des fromages ?), les sulfuras de ragnaros, les billets de concerts, les objets maudits (conjured items) )
On peut imaginer qu'on pourrait ajouter d'autres objets

Chaque objet �volue dans le temps d'une certaine fa�on et leur valeurs doit donc �tre mise a jour.

Objet | jour avant expiration (SellIn) | Qualit� 
 --- | --- | --- 
Basique | diminue de 1 par jour | diminue de 1 par jour. Diminue de 2 apres expiration
Aged Bries | diminue de 1 par jour  | Augmente de 1 par jour, augmente de 2 par jour apr�s expiration (limite 50)
Sulfuras | ne diminue pas | ne diminue pas (80) 
Billet de concert | diminue de 1 par jour | +1 (> 10 jours), +2 (6-10 jours), +3 (0-5 jours). Tombe � 0 apr�s expiration.
Maudit | diminue de 1 par jour | diminue de 2 par jour et de 4 par jour apr�s la date d'expiration (limite 0)







