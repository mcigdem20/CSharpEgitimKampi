using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_rürü değişken_adı;

            //string name;
            //name = "Mehmet";
            //Console.WriteLine(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 530 300 20 10";
            //customerEmail = "deneme@gmail.com";
            //city = "İstanbul";
            //district = "Kadıköy";

            //Console.WriteLine("Rezervasyon Kartı");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + city + " / " +district);
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 535 800 10 10";
            //customerEmail = "test@gmail.com";
            //city = "Kocaeli";
            //district = "Sakarya";
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + city + " / " + district);
            //Console.WriteLine("--------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int cokePrice = 35;
            int lemonadePrice = 30;
            int friesPrice = 50;
            int waterPrice = 10;
            

            Console.WriteLine("***** Restoran Menu Fiyatı");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----Hamburger :" + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza :" + pizzaPrice + " TL");
            Console.WriteLine("-----Kola :" + cokePrice + " TL");
            Console.WriteLine("-----Limonata :" + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma :" + friesPrice + " TL");
            Console.WriteLine("-----Su :" + waterPrice + " TL");
            Console.WriteLine("-----------------------------");

            Console.WriteLine();

            int hamburgerCount;
            int pizzaCount;
            int cokeCount;
            int lemonadeCount;
            int friesCount;
            int waterCount;
            
            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalCokePrice;
            int totalLemonadePrice;
            int totalFriesPrice;
            int totalWaterPrice;
            
            hamburgerCount = 3;
            pizzaCount = 0;
            cokeCount = 3;
            lemonadeCount = 0;            
            friesCount = 1;
            waterCount = 3;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            

            Console.WriteLine("---------------------------------");
            Console.WriteLine(hamburgerCount + " Adet Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine(pizzaCount + " Adet Pizza Tutarı : " + totalPizzaPrice + " TL");
            Console.WriteLine(cokeCount + " Adet Kola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine(lemonadeCount + " Adet Limonata Tutarı : " + totalLemonadePrice + " TL");
            Console.WriteLine(friesCount + " Adet Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine(waterCount + " Adet Su Tutarı : " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalServicePrice = totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalLemonadePrice + totalFriesPrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar : " + totalServicePrice + " TL");

          







            

            #endregion

            Console.Read();
        }
    }
}
