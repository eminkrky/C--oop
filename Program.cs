
// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;

//bir class tan nesne oluşturma
//ClassIsmi nesneAdi = new ClassIsmi();
insan i = new insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = false;

//uyu metodunu çağırdık
i.uyu();

car tofas = new car();
tofas.brand = "Tofaş";
tofas.model = "Şahin";
tofas.year = 1999;
tofas.startEngine();

car bmw = new car();
bmw.brand = "Bmw";
bmw.model = "X5";
bmw.year = 2023;
bmw.startEngine();

