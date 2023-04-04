namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //list<T> class
            //system.cllections.generic
            //t object türündendir aslında bir generictir bu bir nesne alabilir listenin içerisindeki tipini beliirtiyor.

            List<int> SayiListesi = new List<int>();
            SayiListesi.Add(25);
            SayiListesi.Add(10);
            SayiListesi.Add(3);
            SayiListesi.Add(5);
            SayiListesi.Add(92);
            SayiListesi.Add(34);

            List<string> RenkListesi = new List<string>();
            RenkListesi.Add("kırmızı");
            RenkListesi.Add("yeşil");
            RenkListesi.Add("mavi");
            RenkListesi.Add("mor");
            
            //count
            
            Console.WriteLine(RenkListesi.Count);
            Console.WriteLine(SayiListesi.Count);

            foreach (var Sayi in SayiListesi)
                Console.WriteLine(Sayi);
            

            foreach (var Renk in RenkListesi)
                Console.WriteLine(Renk);
            
            SayiListesi.ForEach(Sayi=> Console.WriteLine(Sayi));
            RenkListesi.ForEach(Renk=>Console.WriteLine(Renk));
            
            //listeneden eleman çıkarma 

            SayiListesi.Remove(3);
            RenkListesi.Remove("yeşil");
            
            SayiListesi.RemoveAt(0);
            RenkListesi.RemoveAt(1);
            
            SayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            RenkListesi.ForEach(renk=>Console.WriteLine(renk));
            
            //liste içerisinde arama 
            if (SayiListesi.Contains(10))
                Console.WriteLine("10 liste iççersinde");
            
            //eleman ile index'e erişme 
            RenkListesi.BinarySearch("sarı");
            Console.WriteLine(RenkListesi.BinarySearch("kırmızı"));
            
            //diziyi list'e çevirme 
            string[] hayvanlar = {'kedi', 'köpek', 'fare'};
            List<string> hayvanlistesi = new List<string>(hayvanlar);
            
            //listeyi nasıl temizleriz 
            hayvanlistesi.Clear();
            
            //List içerisinde nesne tutmak.
            List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayse";
            kullanıcı1.Soyisim = "hakan";
            kullanıcı1.Yas = 13;
            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "hakan0";
            kullanıcı2.Soyisim = "hakkı";
            kullanıcı2.Yas = 50;
            
            kullanıcılarListesi.Add(kullanıcı1);
            kullanıcılarListesi.Add(kullanıcı2);
            
            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>();
            yeniliste.Add(new Kullanıcılar()
            {
                Isim = "hakan",
                Soyisim = "arda",
                Yas = 25
            });

            foreach (var Kullanici  in kullanıcılarListesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+Kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı:" + Kullanici.Soyisim);
                Console.WriteLine("Yaş:"+Kullanici.Yas);
            }
                yeniliste.Clear();



        }
    }
    public class Kullanıcılar
    {
         private string isim;
         private string soyisim;
         private int yas;
         
         public  string Isim
         {
             get => isim;
             set => isim = value;
         }

         public string Soyisim
         {
             get => soyisim;
             set => soyisim = value;
         }

         public int Yas
         {
             get => yas;
             set => yas = value;

         }
         
    }
}