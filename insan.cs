namespace ConsoleApp1.Classes
{
    public class insan
    {  //başlangıç scope
       //bir değişkeni tanımlarken
       //access modifiers(public,private,protected) dataType değişkenAdi
       //string tipindeki değişkenler alfanümerik değerleri saklamamızı sağlar
       //PROPERTIES DEĞİŞKENLER 
        public string adi = "35";
        public string soyadi;
        //tam sayısal verileri saklamımızı sağlar
        public int yas = 35;
        //kesirli küsuratlı verileri saklamamızı sağlar
        public double maas = 0.0;
        //true yada false şeklinde verileri saklamamızı sağlar
        public bool cinsiyet = false;

        //METODLAR 2 YE AYRILIRLAR
        //geriye değer döndüren ve geriye değer döndürmeyen
        //access modifiers dönüştipi metodAdi()  {   }
        //geriye değer döndüryemen adı uyu olan ve paramerre almayan bir metod
        public void uyu()
        {
            Console.WriteLine("uyuyor...");
        }
    } //bitiş scope
}