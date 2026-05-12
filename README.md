# 🧠 BFS ve DFS Algoritmaları C# Implementasyonu

Bu proje, Bilgisayar Bilimleri ve Veri Yapıları derslerinde sıkça kullanılan iki temel grafik arama algoritması olan **Genişlik Öncelikli Arama (BFS)** ve **Derinlik Öncelikli Arama (DFS)** algoritmalarının C# dilinde implementasyonlarını içermektedir.

---

## 🎯 Projenin Amacı

Bu projenin temel amacı, grafik veri yapıları üzerinde arama algoritmalarının çalışma mantığını uygulamalı olarak göstermektir.

Bu kapsamda:

- 🔹 BFS ve DFS algoritmalarının mantığının anlaşılması  
- 🔹 Grafik veri yapısının (adjacency list) kullanımı  
- 🔹 C# ile algoritmik düşünme becerisinin geliştirilmesi  
- 🔹 Veri yapıları dersine pratik katkı sağlanması  

---

## 📚 Özellikler

### 🌐 Genişlik Öncelikli Arama (BFS)

- Grafikte seviyeli (katman katman) gezinti yapar  
- Kuyruk (Queue) veri yapısını kullanır  
- En kısa yol mantığını anlamak için idealdir  

---

### 🌲 Derinlik Öncelikli Arama (DFS)

- Grafikte mümkün olduğunca derine iner  
- Stack veya recursive yapı kullanır  
- Geri dönüş (backtracking) mantığını öğretir  

---

### 📊 Grafik Temsili

Grafikler şu yapı ile temsil edilmiştir:

```csharp
Dictionary<int, List<int>>
```

Bu yapı adjacency list (komşuluk listesi) mantığına dayanır.

---

## ⚙️ Teknik Detaylar

| Özellik | Açıklama |
|----------|----------|
| Dil | C# |
| Yapı | Konsol Uygulaması |
| Veri Yapısı | Dictionary (Adjacency List) |
| Konu | BFS & DFS Graph Traversal |
| Paradigma | Algoritmik Programlama |

---

## 💻 BFS (Genişlik Öncelikli Arama)

```csharp
public static void BFS(Dictionary<int, List<int>> grafik, int baslangic)
{
    Queue<int> queue = new Queue<int>();
    HashSet<int> ziyaretEdildi = new HashSet<int>();

    queue.Enqueue(baslangic);
    ziyaretEdildi.Add(baslangic);

    while (queue.Count > 0)
    {
        int node = queue.Dequeue();
        Console.WriteLine(node);

        foreach (var komsu in grafik[node])
        {
            if (!ziyaretEdildi.Contains(komsu))
            {
                ziyaretEdildi.Add(komsu);
                queue.Enqueue(komsu);
            }
        }
    }
}
```

---

## 🌲 DFS (Derinlik Öncelikli Arama)

```csharp
public static void DFS(Dictionary<int, List<int>> grafik, int dugum, bool[] ziyaretEdildi)
{
    ziyaretEdildi[dugum] = true;
    Console.WriteLine(dugum);

    foreach (var komsu in grafik[dugum])
    {
        if (!ziyaretEdildi[komsu])
        {
            DFS(grafik, komsu, ziyaretEdildi);
        }
    }
}
```

---

## 🚀 Kurulum ve Çalıştırma

1. Projeyi indir veya klonla  
2. Visual Studio ile `.sln` dosyasını aç  
3. Projeyi build et (Build Solution)  
4. F5 ile çalıştır  

---

## 📂 Proje Yapısı

```
BFS_DFS_Kodlar/
├── Program.cs
├── BFS.cs
├── DFS.cs
├── BFS_DFS_Kodları.sln
└── Properties/
```

---

## 📜 Lisans

Bu proje **MIT License** ile lisanslanmıştır. Detaylı bilgi için `LICENSE` dosyasını inceleyebilirsiniz.

## 👩‍💻 Geliştirici

Şilan Pehlivan
