using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

[TestFixture]
public class GildedRoseTest
{
    [Test]
    public void NormalItemQualityDecreases()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(9, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void NormalItemQualityDecreasesTwiceAfterSellIn()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 0, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(8, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void AgedBrieQualityIncreases()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(13, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void AgedBrieQualityIDropsToZeroAfterSellIn()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityIncreases()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(11, items[0].Quality);
        Assert.AreEqual(14, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityIncreasesTwiceWithin10Days()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(12, items[0].Quality);
        Assert.AreEqual(9, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityIncreasesThriceWithin5Days()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(13, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityDropsToZeroAfterConcert()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void ConjuredItemQualityDecreasesTwiceAsFast()
    {
        var items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(8, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void ConjuredItemQualityDecreasesTwiceAsFastAfterSellIn()
    {
        var items = new List<Item> { new Item { Name = "Conjured", SellIn = 0, Quality = 10 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(8, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void LegendaryItemQualityDoesNotChange()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(80, items[0].Quality);
        Assert.AreEqual(5, items[0].SellIn);
    }
    [Test]
    public void QualityNeverNegative()
    {
        var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 0 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void AgedBrieQualityNeverExceeds50()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(50, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityNeverExceeds50()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 49 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(50, items[0].Quality);
        Assert.AreEqual(14, items[0].SellIn);
    }

    [Test]
    public void ConjuredItemQualityNeverNegative()
    {
        var items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 1 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void ConjuredItemQualityNeverExceeds50()
    {
        var items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 49 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(47, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityIncreasesThriceWithin5DaysAndNeverExceeds50()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 48 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(50, items[0].Quality);
        Assert.AreEqual(4, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityDropsToZeroAfterConcertAndNeverNegative()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 1 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

    [Test]
    public void BackstagePassQualityDropsToZeroAfterConcertAndNeverExceeds50()
    {
        var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 49 } };
        var app = new GildedRoseKata.GildedRose(items);

        app.UpdateQuality();

        Assert.AreEqual(0, items[0].Quality);
        Assert.AreEqual(-1, items[0].SellIn);
    }

}
