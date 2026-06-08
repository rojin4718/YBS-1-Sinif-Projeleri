using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kurulum Aşaması
            string[] ürünler = new string[3];
            int[] stoklar = new int[3];
            double[] fiyatlar = new double[3];
            int ToplamSatışAdeti = 0;
            double ToplamCiro = 0;
            Console.WriteLine("___ İŞLETME ENVANTER GİRİŞİ ___");
            //Ürün girişi

            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + ". Ürün Adı:");
                ürünler[i] = Console.ReadLine();
                Console.Write("Stok Miktarı: ");
                stoklar[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Fiyat: ");
                fiyatlar[i] = double.Parse(Console.ReadLine());
                // Yönetim Paneli
            }
            int seçim;

            Console.WriteLine("___ İŞLEM MENÜSÜ ___");

            do
            {
                Console.WriteLine("\n1-Envanteri Listele");
                Console.WriteLine("2-Satış Yap ");
                Console.WriteLine("3- Raporu Göster ve Çıkış Yap");
                Console.Write("Seçiminiz: ");
                seçim=int.Parse(Console.ReadLine());

                if (seçim == 1)

                {

                    for (int i = 0; i < 3; i++)
                    {

                        Console.WriteLine($"{i + 1}-{ürünler[i]}\t| Stok: {stoklar[i]}\t| Fiyat: {fiyatlar[i]}TL");
                    }
                }
                else if (seçim == 2)
                {
                    Console.Write("Ürün seçiniz (1-2-3): ");
                    int seç = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Adet:");
                    int adet = Convert.ToInt32(Console.ReadLine());

                    if (seç >= 0 && seç <= 2)
                    {
                        if (adet > 0 && adet <= stoklar[seç])
                        {
                            stoklar[seç] -= adet;
                            double kazanç = adet * fiyatlar[seç];
                            ToplamCiro += kazanç;
                            ToplamSatışAdeti += adet;

                            Console.WriteLine($"Satış Başarılı! Tutar:{kazanç} TL ");
                        }
                        else
                        {
                            Console.WriteLine("Stok Yetersiz!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz Seçim!");

                    }
                    
                }

            }
            while (seçim != 3);
           

            Console.WriteLine("___ RAPOR ___");
            Console.WriteLine($"Toplam Satış:   {ToplamSatışAdeti}");
            Console.WriteLine($"Toplam Elde Edilen Kazanç: {ToplamCiro} TL");
            Console.WriteLine();
            Console.WriteLine("\nÇıkmak için Enter...");
            Console.ReadLine();
       
           

        }
        
       
       
    

        }
  
}


