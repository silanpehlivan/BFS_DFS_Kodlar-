using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS_Kodları
{
    internal class Program
    {
        //DFS C# KODLARI


        public class DFS
        {
            public static void DerinlikÖncelikliArama(Dictionary<int, List<int>> grafik, int düğüm, bool[] ziyaretEdildi)
            {
                // Bu düğümü ziyaret edildi olarak işaretliyoruz
                ziyaretEdildi[düğüm] = true;
                Console.WriteLine("Ziyaret edilen düğüm: " + düğüm);

                // Bu düğümün komşularını ziyaret ediyoruz
                foreach (int komşu in grafik[düğüm])
                {
                    // Komşu düğüm daha önce ziyaret edilmediyse, onu da ziyaret ediyoruz
                    if (!ziyaretEdildi[komşu])
                    {
                        DerinlikÖncelikliArama(grafik, komşu, ziyaretEdildi);
                    }
                }
            }

            public static void Main(string[] args)
            {
                Dictionary<int, List<int>> grafik = new Dictionary<int, List<int>>()
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 2 } },
            { 6, new List<int> { 2 } }
        };

                bool[] ziyaretEdildi = new bool[grafik.Count];
                DerinlikÖncelikliArama(grafik, 0, ziyaretEdildi);



                Console.Read();
            }

            
        }

    }
}
