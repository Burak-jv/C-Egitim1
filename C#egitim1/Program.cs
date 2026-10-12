using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_egitim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari

            //Console.WriteLine("Hello World!");
            //Console.Write("Selam!");
            //Console.Read();

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Atıştırmalıklar");
            //Console.WriteLine();
            //Console.Write("Lütfen bir kategori seçin:");

            #endregion

            #region String Degiskenler

            //degisken_turu degisken_adi;
            // string

            //string name;
            //name = "Burak";
            //Console.Write(name);

            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;

            //passengerName = "Burak";
            //passengerSurname = "Dagdelen";
            //passengerPhone = "+90 553 642 84 67";
            //passengerEmail = "dagdelenburak51@gmail.com";
            //district = "Cankaya";
            //city = "Ankara";

            //Console.WriteLine("**** Rezervasyon Karti ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Musteri: " + passengerName + " " +passengerSurname);
            //Console.WriteLine("Iletisim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");

            //passengerName = "Aysegul";
            //passengerSurname = "Kaya";
            //passengerPhone = "+90 540 111 42 12";
            //passengerEmail = "aysegulkaya@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Musteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Iletisim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------");


            #endregion

            #region Int Degiskenler

            // int
            // int number = 24;
            // Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 90;
            //int waterPrice = 30;
            //int friesPrice = 150;
            //int pizzaPrice = 600;
            //int lemonadePrice = 100;

            //Console.WriteLine("**** Restoran Menu Fiyati ****");
            //Console.WriteLine();
            //Console.WriteLine("------ Hamburger Fiyati: " + hamburgerPrice + "TL");
            //Console.WriteLine("------ Kola Fiyati: " + cokePrice + "TL");
            //Console.WriteLine("------ Su Fiyati: " + waterPrice + "TL");
            //Console.WriteLine("------ Kizartma Fiyati: " + friesPrice + "TL");
            //Console.WriteLine("------ Pizza Fiyati: " + pizzaPrice + "TL");
            //Console.WriteLine("------ Limonata Fiyati: " + lemonadePrice + "TL");

            //Console.WriteLine();

            //int hamburgerCount;
            //int cokecount;
            //int watercount;
            //int friescount;
            //int pizzacount;
            //int lemonadecount;

            //int TotalHamburgerPrice = 0;

            //hamburgerCount = 3;
            //cokecount = 3;
            //watercount = 3;
            //friescount = 1;
            //pizzacount = 2;
            //lemonadecount = 1;

            //TotalHamburgerPrice = hamburgerCount * hamburgerPrice;

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Hamburger Tutari = " + TotalHamburgerPrice + "TL" + "'dir." + "Toplam " + hamburgerCount + " Hamburger yediniz.");

            #endregion

            #region Double Degiskenler  

            ////double number = 4.85;
            ////Console.WriteLine(number);
            ////Console.Read();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 8.15;
            //potatoPrice = 6.45;
            //tomatoPrice = 9.15;

            //Console.WriteLine("Elma Birim Fiyati: " + applePrice + " TL");
            //Console.WriteLine("Portakal Birim Fiyati: " + orangePrice + " TL");
            //Console.WriteLine("Cilek Birim Fiyati: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyati: " + potatoPrice + " TL");
            //Console.WriteLine("Domates Birim Fiyati: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 2.459;
            //tomatoGram = 1.453;

            //double appleTotalPrice = appleGram * applePrice;

            //Console.WriteLine("Tutan elma fiyati: " + appleTotalPrice + "'TL");
            //Console.Read();
            #endregion

            #region Char Degiskenler

            ////ABCDEFGH
            ////DEF...
            ////TOPLANTI SAAT 20.00'DE
            ////string " " ile tanımlanır. char ' ' ile tanımlanır.

            //char symbol = 'A';
            //Console.WriteLine(symbol);
            //Console.ReadLine();

            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yasi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarasi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " Yasi " + passengerAge + " Tc'si " + passengerIdentityNumber 
            //    + " Sehri " + passengerCity + " Ilcesi " + passengerDistrict);

            #endregion

            #region Klavyeden Tam sayi Girisleri ve Donusumler

            //ABC12D

            //int shoesPrice, chairPrice, computerPrice, ramPrice;

            //shoesPrice = 4000;
            //chairPrice = 7000;
            //computerPrice = 15800;
            //ramPrice = 5500;

            //int shoesCount, chairCount, computerCount, ramCount;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz ram sayisini giriniz: ");
            //ramCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //int totalPrice = shoesCount * shoesPrice + chairCount * chairPrice + computerCount * computerPrice + ramCount * ramPrice;
            //int totalCount = shoesCount + chairCount + computerCount + ramCount;

            //Console.WriteLine("Toplam aldiginiz esya sayisi: " + totalCount + " Toplam tutar ise " + totalPrice + " TL'dir.");




            #endregion

            #region Klavyeden ondalikli sayi islemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Ilk sinavi giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Ikinci sinavi giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Ucuncu sinavi giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav ortalamaniz: " + result);

            #endregion

            #region Klavyeden Karakter girisleri

            //char gender;
            //Console.Write("Lutfen cinsiyet seciniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz cinsiyet: " + gender);

            #endregion

        } 
    }
}
