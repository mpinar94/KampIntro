// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
////for (int i = 1; i <=10; i++)
////{
//    //Console.WriteLine(i);  
////}
//string kurs1 = "Yazılım geliştirici kursu";
//string kurs2 = "Java";
//string kurs3 = "Programlamaya başlangıç kursu";

string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Java", "Programlamaya başlangıç kursu","Python" };
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);   
}
Console.WriteLine("Sayfa sonu");

Console.ReadLine();    