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

        }
    }
    
}