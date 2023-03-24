namespace String_Hazir_Methodlar.String_Hazir_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "CSharp";
            // Length
            Console.WriteLine(degisken.Length);

            // ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());  // Bütün harfleri büyük yazdırmak için kullanılır.
            Console.WriteLine(degisken.ToLower());  // Bütün harfleri küçük yazdırmak için kullanılır.

            // Concat
            Console.WriteLine(string.Concat(degisken," Merhaba"));

            // Compare, CompareTo
            Console.WriteLine(string.Compare(degisken,degisken2,true));  // 1.degiskenimiz = degisken, 2.degiskenimiz = degisken2 yani karşılaştırmayı ona göre yaptı. degiskenin karakter sayısı degisken2' nin karakter sayısından fazla ise 1, az ise -1, eğer ki birbirine eşit ise 0 yazdırır.
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            // Contains

            Console.WriteLine(degisken.Contains(degisken2));
            
            // EndsWith
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));  // tanımlı degisken 'Hoşgeldiniz' ile bitiyor mu diye sorgulatıyorum.

            // StartWith
            Console.WriteLine(degisken.StartsWith("Dersimiz"));  //tanımlı degisken 'Dersimiz' ile başlıyor mu
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("H"));  // tanımlı degiskendeki 'H' harfi kaçıncı indexte başlıyor.
            Console.WriteLine(degisken.IndexOf("CSharp")); // tanımlı degiskendeki 'CSharp' kaçıncı indexten başlıyor

            // Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));  // tanımlı degiskendeki 0. indeksten başlayarak 'Merhaba!' yazdır.

            // LastIndexOf

            Console.WriteLine(degisken.LastIndexOf("i"));  // tanımlı degiskendeki birden çok tekrar eden bir harfi ve kelimeyi sorgulatmak istediğimiz ifadenin en son hangi index numarasında yer aldığını gösterir

            // PadLeft , PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

            // Remove

            Console.WriteLine(degisken.Remove(10));  //tanımlı degiskendeki 10 indeksten başlayarak son indekse kadar

            Console.WriteLine(degisken.Remove(3,10));  //tanımlı degiskendeki 3. indeksten başlarak 3.indeks dahil değil 10 tane karakter sil


            // Replace

            Console.WriteLine(degisken.Replace("CSharp","C#"));  // tanımlı degiskendeki 'CSharp'ı' 'C#' ile değiştir.
            Console.WriteLine(degisken.Replace(" ","*"));  // tanımlı degiskendeki ' ' boşluk karakterleri yerine '*' koy.

            // Split

            Console.WriteLine(degisken.Split(' ')[1]); // tanımlı degiskendeki ifadeyi ' ' boşluklardan ayırarak bir dizi haline getir ve bana 1.indeksteyi elemanı göster.

            // Substring

            Console.WriteLine(degisken.Substring(4));  // tanımlı degiskendeki 4.indeksten başlayarak sona kadar git ve hepsini bana göster.4.indeksten sona kadar olan kısmı

            Console.WriteLine(degisken.Substring(4,5));  // tanımlı degiskendeki 4.indekste dahil başlayarak 5 karakteri bana getir.

        }
    }
}