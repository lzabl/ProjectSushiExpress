using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest1.Test
{
    public class SushiTest : SushiBaseTest
    {

        [Test]
        public static void PatikrintiSushiNR1Kaina()
        {
            sushiMeniuPage.NavigateToPage();
            sushiMeniuPage.OpenFullMeniu();
            sushiMeniuPage.OpenSushiMeniuPage();
            sushiOrderPage.VerifyPrice("299");
        }
        [Test] 
        public static void MegstamiausiNigiriSushi()
        {
            sushiMeniuPage.NavigateToPage();
            sushiMeniuPage.OpenFullMeniu();
            sushiMeniuPage.OpenSushiMeniuPage();
            sushiMeniuPage.FaveSushiCheckboxes("Nigiri");
        }
        [Test]
        public void IsidetiIKrepseli2NR1Sushi()
        {
            sushiMeniuPage.NavigateToPage();
            sushiMeniuPage.OpenFullMeniu();
            sushiMeniuPage.OpenSushiMeniuPage();
            sushiOrderPage.AddToCart2xnr1("KREPŠELIS ( 2 )");

        }
        [Test]
        public void PakeistiUzsakyma()
        {
            sushiMeniuPage.NavigateToPage();
            sushiMeniuPage.OpenFullMeniu();
            sushiMeniuPage.OpenSushiMeniuPage();
            sushiOrderPage.AddToCartNr18();
            sushiOrderPage.ChangeQuantity("Krepšelis atnaujintas.");
        }
        [Test]
        public void PridetiGerimaPrieUzsakymo()
        {
            sushiMeniuPage.NavigateToPage();
            sushiMeniuPage.OpenFullMeniu();
            sushiMeniuPage.OpenSushiMeniuPage();
            sushiOrderPage.AddToCartNr18();
            drinksMeniuPage.GoBackToFullMeniu();
            drinksMeniuPage.OpenDrinksMeniu();
            drinksMeniuPage.AddKombucha("“SUN 365 KOMBUCHA MELISSA HERB” - įdėtas į krepšelį");
        }
    }
}
