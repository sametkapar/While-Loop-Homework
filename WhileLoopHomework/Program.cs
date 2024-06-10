using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 0-1000 arası kaç sayı vardır? toplamı nedir?
            //int sayac = 0;
            //double toplam = 0;
            //int adet = 0;

            //while (sayac <= 1000)
            //{
            //    if (sayac % 4 == 0)
            //    {

            //        toplam = Convert.ToDouble(toplam);
            //        adet++;
            //        toplam = toplam + sayac;

            //    }
            //    sayac++;
            //}
            //Console.WriteLine("0-1000 arasında 4'e bölünebilen " + adet + " adet sayı vardır. \nToplamı = " + toplam);
            #endregion

            #region Konsoldan alınan 5 sayının ortalamasını hesaplayınız

            //Console.WriteLine("5 adet sayı giriniz: ");
            //int loop = 0;
            //double sayi = 0;
            //while (loop < 5) 
            //{

            //    sayi = sayi + Convert.ToDouble(Console.ReadLine());

            //    loop++;
            //}
            //double ort = sayi / 5;

            //Console.WriteLine("Girilen sayıların ortalaması= " + ort);
            #endregion

            #region Kullanıcı Giriş Validation - Ödev 2

            //kullanıcı adı admin Şifre 1234 ise hoşgeldin
            //Kullanıcı adı boş olmaz
            //şifre boş bolmaz


            //Console.Write("Kullanıcı Adı: ");
            //string username = Console.ReadLine();

            //while (username != "")
            //{
            //    if (username == "admin")
            //    {
            //        Console.Write("Şifre: ");
            //        string password = Console.ReadLine();
            //        if (password == "1234")
            //        {
            //            Console.WriteLine("Giriş başarılı");
            //        }

            //        else if (password == "")
            //        {

            //            Console.WriteLine("Şifre boş olamaz");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Şifre hatalı");
            //        }
            //        break;
            //    }

            //    else if(username =="")
            //    {
            //        Console.WriteLine("Kullanıcı Adı boş olamaz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalı");
            //    }
            ////    break;
            //}




            #endregion

            #region  Kullanıcı Giriş Validation - Ödev 2

            //string name = "";
            //string pass = "";

            //while (name == "")
            //{
            //    Console.Write("KULLANICI ADI: ");
            //    name = Console.ReadLine();
            //    Console.Clear();
            //}
            //if (name == "admin")
            //{

            //    while (pass == "")
            //    {
            //        Console.Write("ŞİFRE: ");
            //        pass = Console.ReadLine();
            //        Console.Clear();
            //    }
            //    if (pass == "1234")
            //    {
            //        Console.WriteLine("Giriş Başarılı ");
            //    }
            //    else
            //    {
            //        while (pass != "1234")
            //        {
            //            Console.Write("Girilen Şifre Hatalı\nŞİFRE: ");
            //            pass = Console.ReadLine();
            //            Console.Clear();
            //        }
            //        Console.WriteLine("Giriş Başarılı");
            //    }
            //}
            //else
            //{
            //    while (name != "admin")
            //    {
            //        Console.Write("Kullanıcı ADI HATALI\nKULLANICI ADI: ");
            //        name = Console.ReadLine();
            //        Console.Clear();
            //    }
            //    if (name == "admin")
            //    {

            //        while (pass == "")
            //        {
            //            Console.Write("ŞİFRE: ");
            //            pass = Console.ReadLine();
            //            Console.Clear();
            //        }
            //        if (pass == "1234")
            //        {
            //            Console.WriteLine("Giriş Başarılı ");
            //        }
            //        else
            //        {
            //            while (pass != "1234")
            //            {
            //                Console.Write("Girilen Şifre Hatalı\nŞİFRE: ");
            //                pass = Console.ReadLine();
            //                Console.Clear();
            //            }
            //            Console.WriteLine("Giriş Başarılı");
            //        }
            //    }


            }
            #endregion

        }
    }
}
