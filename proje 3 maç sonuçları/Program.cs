using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_3_maç_sonuçları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
           
            Random rastgele = new Random();
            a1 = rastgele.Next(0, 6);
            a2 = rastgele.Next(0, 6);
            a3 = rastgele.Next(0, 6);
            b1 = rastgele.Next(0, 6);
            b2 = rastgele.Next(0, 6);
            b3 = rastgele.Next(0, 6);
            c1 = rastgele.Next(0, 6);
            c2 = rastgele.Next(0, 6);
            c3 = rastgele.Next(0, 6);
            d1 = rastgele.Next(0, 6);
            d2 = rastgele.Next(0, 6);
            d3 = rastgele.Next(0, 6);
            int pg = 0, pb = 0, pt = 0, pf = 0;
            int sayaç = 1;
            if (sayaç == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*******1.HAFTA********");
                Console.WriteLine("Galatasaray" + "" + a1 + "-" + b1 + "" + "Beşiktaş");
                if(a1 < b1)
                {
                    pb += 3;
                }
                if (a1 > b1)
                {
                    pg += 3;
                }
                if (a1 == b1)
                {
                    pb++;
                    pg++;
                }
                Console.WriteLine("Trabzonspor" + "" + c1 + "-" + d1 + "" + "Fenerbahçe");
                if (c1 < d1)
                {
                    pf += 3;
                }
                if (c1 > d1)
                {
                    pt += 3;
                }
                if (c1 == d1)
                {
                    pf++;
                    pt++;
                }

                sayaç++;
                
               
            }
            if (sayaç == 2)
            {
               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*******2.HAFTA********");
                Console.WriteLine("Galatasaray" + "" + a2 + "-" + d2 + "" + "Fenerbahçe");
                if (a2 < d2)
                {
                    pf += 3;
                }
                if (a2 > d2)
                {
                    pg += 3;
                }
                if (a2 == d2)
                {
                    pf++;
                    pg++;
                }
                Console.WriteLine("Trabzonspor" + "" + c2 + "-" + b2 + "" + "Beşiktaş");
                if (c2 < b2)
                {
                    pb += 3;
                }
                if (c2 > b2)
                {
                    pt += 3;
                }
                if (c2 == b2)
                {
                    pb++;
                    pt++;
                }
                sayaç++;
               
            }
            if (sayaç == 3)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*******3.HAFTA********");
                Console.WriteLine("Galatasaray" + "" + a3 + "-" + c3 + "" + "Trabzonspor");
                if (a3 < c3)
                {
                    pt += 3;
                }
                else if (a3 > c3)
                {
                    pg += 3;
                }
                else if (a3 == c3)
                {
                    pt++;
                    pg++;
                }
                Console.WriteLine("Fenerbahçe" + "" + d3 + "-" + b3 + "" + "Beşiktaş");
                if (d3 < b3)
                {
                    pb += 3;
                }
                else if (d3 > b3)
                {
                    pf += 3;
                }
                else if (d3 == b3)
                {
                    pb++;
                    pf++;
                }
                sayaç++;
             
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("maçlar tamamlandı sonucu görmek için entera basınız.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" ////puan tablosu////:");
            Console.WriteLine("Galatsarayın puan durumu:" + pg);
            Console.WriteLine("Beşiktaşın puan durumu:" + pb);
            Console.WriteLine("Fenerbahçenin puan durumu:" + pf);
            Console.WriteLine("Trabzonsporun puan durumu:" + pt);

            int[] puanlar = { pg, pb, pf, pt };
            string[] takımlar = { "Galatasaray", "Beşiktaş", "Fenerbahçe", "Trabzonspor" };

            int enBuyuk = puanlar[0];
            int kazananIndex = 0;

            for (int i = 1; i < puanlar.Length; i++)
            {
                if (puanlar[i] > enBuyuk)
                {
                    enBuyuk = puanlar[i];
                    kazananIndex = i;
                }
            }

            Console.WriteLine("\nKazanan Takım: " + takımlar[kazananIndex] + " | Skor: " + enBuyuk);
            Console.WriteLine("Tebrikler!");

            Console.Read();

        }
    }
}
