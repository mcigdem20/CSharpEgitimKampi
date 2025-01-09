using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("-------------------------");

            //double applePrice, orangePrice, strawPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawPrice = 45;
            //potatoPrice = 12.25;
            //tomatoPrice = 6.88;


            //Console.WriteLine("Elma Kg Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("Portakal Kg Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("Çilek Kg Fiyatı : " + strawPrice + " TL");
            //Console.WriteLine("Patates Kg Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("Domates Kg Fiyatı : " + tomatoPrice + " TL");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 3.245;
            //orangeGram = 2.655;
            //strawGram = 1.105;
            //potatoGram = 4.856;
            //tomatoGram = 0.650;

            //double totalApplePrice = appleGram * applePrice;
            //double totalStrawPrice = strawGram * strawPrice;

            //Console.WriteLine("Alınan Ürün: Elma, Kg Fiyatı: " + applePrice + " TL, Miktarı: " + appleGram + " Gr, Toplam Tutar : " + totalApplePrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek, Kg Fiyatı: " + strawPrice + " TL, Miktarı: " + strawGram + " Gr, Toplam Tutar: " + totalStrawPrice + " TL");
            //Console.WriteLine();

            //double shoppingTotalPrice = totalApplePrice + totalStrawPrice;

            //Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"  ' 

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi*****");

            //String passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerTCKN;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("TCKN giriniz: ");
            //passengerTCKN = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Sayın Yolcumuz, " + passengerName + " " + passengerSurname);
            //Console.WriteLine("TCKN: "+passengerTCKN+ ", Şehir :" + passengerDistrict);
            //Console.WriteLine();

            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, tvCount;

            //Console.Write("Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Tv Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + tvCount * tvPrice;

            //Console.WriteLine("Toplam Tutar : " +  totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notu :");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine ("Sınav Ortalaması: " + result);


            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Cinsiyet Seçiniz (Erkek için E, Kadın için K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender );

            char choice;
            Console.Write("Devam Etmek İstiyormusunuz? (Y/N): ");
            choice = char.Parse(Console.ReadLine());

            Console.WriteLine("Tercihiniz: " + choice );


            #endregion

            Console.Read();

        }
    }
}
