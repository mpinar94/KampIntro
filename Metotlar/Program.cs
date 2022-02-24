// See https://aka.ms/new-console-template for more information
using Metotlar;


string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya elması";

Urun urun1 = new Urun();
urun1.Adı = "Elma";
urun1.Fiyatı = 15;
urun1.Aciklama = "Amasya Elması";
urun1.StokAdedi = 20;

Urun urun2 = new Urun();
urun2.Adı = "Karpuz";
urun2.Fiyatı= 80;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 14;

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (var item in urunler)
{
    Console.WriteLine(item.Adı);
    Console.WriteLine(item.Fiyatı);
    Console.WriteLine(item.Aciklama);
    Console.WriteLine("********");
}
Console.WriteLine("-----Metotlar------");
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
sepetManager.Ekle2("Elma", "Yeşil elma", 15,20);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80,14);

Console.ReadLine();