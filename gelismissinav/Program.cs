using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gelismissinav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sorular = new ArrayList()
        {
            new soru("Hangi renk sembolik olarak huzur anlamına gelir?", new string[]{"A) Kırmızı", "B) Mavi", "C) Yeşil", "D) Sarı"}, 'C'),
            new soru("Hangisi Türkiye'nin başkentidir?", new string[]{"A) Ankara", "B) İstanbul", "C) İzmir", "D) Bursa"}, 'A'),
            new soru("Hangi gezegen güneş sisteminde üçüncü sıradadır?", new string[]{"A) Mars", "B) Jüpiter", "C) Dünya", "D) Uranüs"}, 'C'),
            new soru("Hangisi bir memelidir?", new string[]{"A) Ton balığı", "B) Yılan", "C) Köpek", "D) Turna"}, 'C'),
            new soru("Hangi yıl Türkiye Cumhuriyeti kurulmuştur?", new string[]{"A) 1920", "B) 1922", "C) 1923", "D) 1924"}, 'C'),
            new soru("Hangisi bir programlama dilidir?", new string[]{"A) Java", "B) Kitap", "C) Çivi", "D) Kedi"}, 'A'),
            new soru("Hangisi bir meyve değildir?", new string[]{"A) Elma", "B) Muz", "C) Domates", "D) Armut"}, 'C'),
            new soru("Hangisi bir hayvanat bahçesi hayvanıdır?", new string[]{"A) Fil", "B) At", "C) Aslan", "D) Kartal"}, 'A'),
            new soru("Hangisi bir müzik türüdür?", new string[]{"A) Futbol", "B) Rock", "C) Yüzme", "D) Tarih"}, 'B'),
            new soru("Hangisi bir içecek türüdür?", new string[]{"A) Otobüs", "B) Su", "C) Ayakkabı", "D) Koltuk"}, 'B'),
        };

            int puan = 0;

            for (int i = 0; i < sorular.Count; i++)
            {
                soru soru = (soru)sorular[i];
                Console.WriteLine(soru.SoruMetni);
                for (int j = 0; j < soru.Secenekler.Length; j++)
                {
                    Console.WriteLine(soru.Secenekler[j]);
                }

                Console.Write("Cevabınızı girin (A, B, C, D): ");
                string cevap = Console.ReadLine().ToUpper();

                int secilenSecenek = -1;

                switch (cevap)
                {
                    case "A":
                        secilenSecenek = 0;
                        break;
                    case "B":
                        secilenSecenek = 1;
                        break;
                    case "C":
                        secilenSecenek = 2;
                        break;
                    case "D":
                        secilenSecenek = 3;
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçenek girdiniz");
                        break;
                }

                
            }


        }
    }
}

