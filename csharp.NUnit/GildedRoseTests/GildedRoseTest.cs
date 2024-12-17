using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Application;
using GildedRoseKata.Domaine;
using NUnit.Framework;

namespace GildedRoseTests;

[TestFixture]
public class GildedRoseTest
{

    private GildedRoseService _gildedRoseService;
    private List<Item> _items;

    [SetUp]
    public void Setup()
    {
        _items = new List<Item>();
        _gildedRoseService = new GildedRoseService(_items);
    }

    [Test]
    public void BasiqueItem_QualityReducedByOne_SellInAbove0()
    {
        _items.Add(new Item { Name = "Basique Item", SellIn = 5, Quality = 10 });

        _gildedRoseService.UpdateQuality();

        Assert.That(_items[0].SellIn, Is.EqualTo(4));
        Assert.That(_items[0].Quality, Is.EqualTo(9));
    }

    [Test]
    public void BasiqueItem_QualityReducedBy2_SellInBelow0()
    {
        // Arrange
        _items.Add(new Item { Name = "Basique Item", SellIn = 0, Quality = 20 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(18));
        Assert.That(_items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
    public void AgedBrie_QualityIncreasesBy1_SellInAbove0()
    {
        // Arrange
        _items.Add(new Item { Name = "Aged Brie", SellIn = 10, Quality = 30 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(31));
        Assert.That(_items[0].SellIn, Is.EqualTo(9));
    }

    [Test]
    public void AgedBrie_QualityIncreasesBy2_SellInBelow0()
    {
        // Arrange
        _items.Add(new Item { Name = "Aged Brie", SellIn = 0, Quality = 30 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(32));
        Assert.That(_items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
    public void Sulfuras_QualityAndSellInAreConstant()
    {
        // Arrange
        _items.Add(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(80));
        Assert.That(_items[0].SellIn, Is.EqualTo(5));
    }

    [Test]
    public void BackstagePasses_QualityIncreasesBy2_SellInIsTenOrLess()
    {
        // Arrange
        _items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(22));
        Assert.That(_items[0].SellIn, Is.EqualTo(9));
    }

    [Test]
    public void BackstagePasses_QualityIncreasesBy3_SellInIsFiveOrLess()
    {
        // Arrange
        _items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(23));
        Assert.That(_items[0].SellIn, Is.EqualTo(4));
    }

    [Test]
    public void BackstagePasses_QualityIs0_AfterConcert()
    {
        // Arrange
        _items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(0));
        Assert.That(_items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
    public void ConjuredItem_QualityReducedBy2_SellInAbove0()
    {
        // Arrange
        _items.Add(new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(4));
        Assert.That(_items[0].SellIn, Is.EqualTo(2));
    }

    [Test]
    public void ConjuredItem_QualityReducedBy4_SellinBelow0()
    {
        // Arrange
        _items.Add(new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 });

        // Act
        _gildedRoseService.UpdateQuality();

        // Assert
        Assert.That(_items[0].Quality, Is.EqualTo(2));
        Assert.That(_items[0].SellIn, Is.EqualTo(-1));
    }


}