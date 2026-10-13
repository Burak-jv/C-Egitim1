using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_egitim2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF

            //Console.WriteLine("Lutfen sifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{

            //    Console.WriteLine("Sifre Dogru!");

            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis!");
            //}
            //Console.ReadLine();

            //string capital, country;
            //Console.Write("Baskenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" && country == "turkiye")
            //{

            //    Console.WriteLine("Veriler Dogrulandi!");

            //}
            //else
            //{
            //    Console.WriteLine("Hatali Bilgi!");
            //}

            //int sayi;
            //Console.Write("Sayiyi Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayi Dogru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Yanlis!");
            //}

            //double exam1, exam2, exam3, result;

            //Console.Write("Ilk sinavi giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Ikinci sinavi giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Ucuncu sinavi giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //if (result >= 90)
            //{
            //    Console.WriteLine("Notunuz = " + result + " A aldınız.");
            //}
            //else if (result >= 80)
            //{
            //    Console.WriteLine("Notunuz = " + result + " B aldınız.");
            //}
            //else if (result >= 70)
            //{
            //    Console.WriteLine("Notunuz = " + result + " C aldınız.");
            //}
            //else if (result >= 60)
            //{
            //    Console.WriteLine("Notunuz = " + result + " D aldınız.");
            //}
            //else if(result >= 0)
            //{
            //        Console.WriteLine("Notunuz = " + result + " F aldınız.");                
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Islem Yaptiniz!!");
            //}

            //string city;
            //Console.Write("Sehiri Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Dogru Sehri Girdiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis Sehri Girdiniz!");
            //}

            //string name;
            //int yas;

            //Console.Write("Lutfen Kullanici Adi Giriniz: ");
            //name = Console.ReadLine();

            //Console.Write("Yasinizi Giriniz: ");
            //yas = int.Parse(Console.ReadLine());

            //if (yas < 0 | yas > 100)
            //{
            //    Console.WriteLine("Yas 0'dan az veya 100'den fazla olamaz!");
            //}
            //else if (yas < 18)
            //{
            //    Console.WriteLine("Resit olmadiginiz icin kayit olamazsiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Kayit olabilirsiniz.");
            //}

            #endregion

            #region  Mod Islemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. Sayiyi Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayiyi Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. Sayinin 2. Sayiyia bolumunden kalan: " + result);

            //int number;

            //Console.Write("Bir sayi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi Cifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Tektir.");
            //}
            #endregion

            #region Char Degiskenler ile karar yapilari
            //char team;
            //Console.Write("Takim Sembolu Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}
            //else if(team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Besiktas");
            //}
            //else
            //{
            //    Console.WriteLine("Hatali Giris Yaptiniz!");
            //}
            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("****** C# Egitim Kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Corbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- Icecekler");
            //Console.WriteLine("5- Tatlilar");
            //Console.WriteLine("-----------------");

            //string menuItem;
            //string selected;

            //Console.Write("Lutfen Detayini gormek istediginiz menu secimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");

            //    Console.Write("Sectiginiz Ana yemek Nedir --> ");
            //    selected = Console.ReadLine();

            //    if(selected == "1")
            //    {
            //        Console.WriteLine("Sectiginiz yemek Kori Soslu Tavuk");
            //    }
            //    else if(selected == "2")
            //    {
            //        Console.WriteLine("Kizartma Tabagi");
            //    }
            //    else if (selected == "3")
            //    {
            //        Console.WriteLine("Fasulye Pilav");
            //    }
            //    else if (selected == "4")
            //    {
            //        Console.WriteLine("Firinda Somon");
            //    }
            //    else if (selected == "5")
            //    {
            //        Console.WriteLine("Patlıcan Musakka");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatali Giris yaptiniz!");
            //    }
            //}
            //else if(menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Corbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Ezogelin Corbasi");
            //    Console.WriteLine("3-Anali Kizli Corbasi");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Corbalar-----------");

            //    Console.Write("Sectiginiz Corba Nedir --> ");
            //    selected = Console.ReadLine();

            //    if (selected == "1")
            //    {
            //        Console.WriteLine("Sectiginiz Corba Mercimek Corbasi");
            //    }
            //    else if(selected == "2")
            //    {
            //        Console.WriteLine("Sectiginiz Corba Ezogelin Corbasi");
            //    }
            //    else if (selected == "3")
            //    {
            //        Console.WriteLine("Sectiginiz Corba Anali Kizli Corbasi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatali Giris yaptiniz!");
            //    }

            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sucuklu Pizza");
            //    Console.WriteLine("2-Kasari Pizza");
            //    Console.WriteLine("3-Veggy Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");

            //    Console.Write("Sectiginiz Pizza --> ");
            //    selected = Console.ReadLine();

            //    if (selected == "1")
            //    {
            //        Console.WriteLine("Sucuklu Pizza");
            //    }
            //    else if (selected == "2")
            //    {
            //        Console.WriteLine("Kasari Pizza");
            //    }
            //    else if (selected == "3")
            //    {
            //        Console.WriteLine("Veggy Pizza");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatali Giris yaptiniz!");
            //    }

            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Icecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Coca Cola");
            //    Console.WriteLine("2-Cay");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Icecekler-----------");

            //    Console.Write("Sectiginiz Icecek --> ");
            //    selected = Console.ReadLine();

            //    if (selected == "1")
            //    {
            //        Console.WriteLine("Coca Cola");
            //    }
            //    else if (selected == "2")
            //    {
            //        Console.WriteLine("Cay");
            //    }
            //    else if (selected == "3")
            //    {
            //        Console.WriteLine("Ayran");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatali Giris Yaptiniz!");
            //    }

            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlilar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kunefe");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Tiramisu");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlilar-----------");

            //    Console.Write("Sectiginiz Tatli --> ");
            //    selected = Console.ReadLine();

            //    if (selected == "1")
            //    {
            //        Console.WriteLine("Kunefe");
            //    }
            //    else if (selected == "2")
            //    {
            //        Console.WriteLine("Baklava");
            //    }
            //    else if (selected == "3")
            //    {
            //        Console.WriteLine("Tiramisu");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatali Giris Yaptiniz!!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hatali Giris Yaptiniz!!!");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak");
            //        break;
            //    case 2: Console.Write("Subat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayis");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Agustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylul");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasim");
            //        break;
            //    case 12:
            //        Console.Write("Aralik");
            //        break;
            //    default: Console.Write("Hatali Veri Girisi");
            //        break;
            //}

            #endregion

            #region Hesap Makinesi

            //double sayi1, sayi2, sonuc;

            //Console.Write("Ilk sayiyi giriniz: ");
            //sayi1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ikinci sayiyi giriniz: ");
            //sayi2 = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("***** 4 Islem Merkezi *****");
            //Console.WriteLine("1- Toplama");
            //Console.WriteLine("2- Cikarma");
            //Console.WriteLine("3- Bolme");
            //Console.WriteLine("4- Kalan");
            //Console.WriteLine("5- Carpma");
            //Console.WriteLine();

            //int secim;

            //Console.Write("Yapmak Istediginiz Islemi Tuslayiniz: ");
            //secim = int.Parse(Console.ReadLine());

            //switch(secim)
            //{
            //    case 1: sonuc = (sayi1 + sayi2);
            //        Console.WriteLine();
            //        Console.Write(sayi1 + " Ile " + sayi2 + " Toplami " + " = " + sonuc);
            //        break;
            //    case 2:
            //        sonuc = (sayi1 - sayi2);
            //        Console.WriteLine();
            //        Console.Write(sayi1 + " Ile " + sayi2 + " Farki " + " = " + sonuc);
            //        break;
            //    case 3:
            //        sonuc = (sayi1 / sayi2);
            //        Console.WriteLine();
            //        Console.Write(sayi1 + " Ile " + sayi2 + " Bolumu " + " = " + sonuc);
            //        break;
            //    case 4:
            //        sonuc = (sayi1 % sayi2);
            //        Console.WriteLine();
            //        Console.Write(sayi1 + " Ile " + sayi2 + " Bolumunden Kalan " + " = " + sonuc);
            //        break;
            //    case 5:
            //        sonuc = (sayi1 * sayi2);
            //        Console.WriteLine();
            //        Console.Write(sayi1 + " Ile " + sayi2 + " Carpimi " + " = " + sonuc);
            //        break;
            //    default: Console.WriteLine("Hatali Giris Yaptiniz!!!");
            //        break;
            //}


            #endregion
            Console.ReadLine();
        }
    }
}
