using System;

namespace HazirMetotlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "CSharp dersine hoşgeldiniz!";
            string degisken1 = "merhaba ";
            string degisken2 = "hoşgeldiniz!";
            Console.WriteLine("");
            Console.WriteLine("Degisken ifademiz  : {0}",degisken);
            Console.WriteLine("Degisken1 ifademiz : {0}",degisken1);
            Console.WriteLine("Degisken2 ifademiz : {0}",degisken2);
            Console.WriteLine("******************************");
            Console.WriteLine("");
            Console.WriteLine("Değişkenin uzunluğu                        : {0}",degisken.Length); 
            Console.WriteLine("Büyük harfler ile                          : {0}",degisken.ToUpper()); 
            Console.WriteLine("Küçük harfler ile                          : {0}",degisken.ToLower());
            Console.WriteLine("İki Değişken birleştirme                   : {0}",string.Concat(degisken1,degisken));  
            // CompareTo iki ifadenin eşit olup olmadığına bakar Dönen değerler aşağıdaki gibidir.
            Console.WriteLine("CompareTo Metodu ile....");
            Console.WriteLine("------------------------");
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",degisken2.CompareTo(degisken2)); //0
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",degisken2.CompareTo(degisken)); //1
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",degisken.CompareTo(degisken2)); //-1
            //compare metodu CompareTo ile aynıdır fakat syntax ı farklıdır.
            Console.WriteLine("Compare Metodu ile....");
             Console.WriteLine("---------------------");
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",string.Compare(degisken2,degisken2)); //0
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",string.Compare(degisken2,degisken)); //1
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",string.Compare(degisken,degisken2)); //-1
            Console.WriteLine("İki Değişken karşılaştırma                 : {0}",string.Compare(degisken,degisken2));
            Console.WriteLine("Degisken2 değerini içeriyor mu?            : {0}",degisken.Contains(degisken2)); //true ya da false döner.
            Console.WriteLine("Degisken2 değeriyle mi bitiyor?            : {0}",degisken.EndsWith(degisken2)); //true ya da false döner.
            Console.WriteLine("Degisken2 değeriyle mi başlıyor?           : {0}",degisken.StartsWith(degisken2)); //true ya da false döner.
            Console.WriteLine("Degisken de e kaçıncı indexde?             : {0}", degisken.IndexOf("e")); //soldan bulduğu ilk indexi verecektir.
            Console.WriteLine("Degisken de e kaçıncı indexde?             : {0}", degisken.LastIndexOf("e"));//Sağdan bulduğu ilk indexi verecektir.
            Console.WriteLine("Degiskene insert ile merhaba ekleme        : {0}", degisken.Insert(0, "Merhaba, "));
            Console.WriteLine("Degisken2'yi soldan 30 karaktere tamamlama : {0}", degisken + degisken2.PadLeft(30));
            Console.WriteLine("Degisken2'yi sağdan 30 karaktere tamamlama : {0}", degisken2.PadRight(30,'*') + degisken);
            Console.WriteLine("Degisken ifadesininden karakter silme      : {0}",degisken.Remove(0,5)); //0. karakterden başla ve 5 karakter sil.
            Console.WriteLine("Degisken ifadesininden karakter silme      : {0}",degisken.Remove(5)); //5.karakterden itibaren hepsini sil.
            Console.WriteLine("Degisken ifadesininden karakter silme      : {0}",degisken.Remove(5,3)); //5.karakterden itibaren 3 karakter sil.
            Console.WriteLine("Degisken ifadesinin karakterini değiştirme : {0}",degisken.Replace("CSharp","C#")); //CSharp ı C# olarak değiştirir.
            Console.WriteLine("Degisken ifadesinin karakterini değiştirme : {0}",degisken.Replace(" ","-")); // boşlukları - yapar.
            Console.WriteLine("Degisken ifadesini bölme ve diziye atama   : {0}",degisken.Split(' ')[0]);
            Console.WriteLine("Degisken ifadesininden karakter seçme      : {0}",degisken.Substring(4,6)); //4. indexden itibaren 6 karakter getirir.






        }
    }
}