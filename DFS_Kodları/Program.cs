using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Kodları
{
    internal class Program
    {
        //BFS C# KODLARI


        public class BFS
        {
            public static void GenişlikÖncelikliArama(Dictionary<int, List<int>> grafik, int başlangıç)
            {
                // Ziyaret edilen düğümleri takip etmek için bir dizi oluşturuyoruz
                bool[] ziyaretEdildi = new bool[grafik.Count];

                // Bir kuyruk oluşturarak başlangıç düğümünü ekliyoruz
                Queue<int> kuyruk = new Queue<int>();
                ziyaretEdildi[başlangıç] = true;
                kuyruk.Enqueue(başlangıç);

                while (kuyruk.Count > 0)
                {
                    // Kuyruktan bir düğüm çıkarıyoruz ve ziyaret ediyoruz
                    int düğüm = kuyruk.Dequeue();
                    Console.WriteLine("Ziyaret edilen düğüm: " + düğüm);

                    // Bu düğümün komşularını ziyaret ediyoruz
                    foreach (int komşu in grafik[düğüm])
                    {
                        // Komşu düğüm daha önce ziyaret edilmediyse kuyruğa ekliyoruz
                        if (!ziyaretEdildi[komşu])
                        {
                            ziyaretEdildi[komşu] = true;
                            kuyruk.Enqueue(komşu);
                        }
                    }
                }
            }

            public static void Main(string[] args)
            {
                Dictionary<int, List<int>> grafik = new Dictionary<int, List<int>>()
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 5, 4 } },
            { 2, new List<int> { 0, 7, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 3 } },
            { 6, new List<int> { 2 } }

        };

                GenişlikÖncelikliArama(grafik, 0);

                Console.Read();
            }
        }
    }
}

