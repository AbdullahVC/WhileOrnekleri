//Bu pratik uygulama 5 aşamadan oluşuyor.
//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdır.
int tekrar = 0;
while (tekrar < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    tekrar++;
}
Console.WriteLine(" ");// Boşluk bırakma için
//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int number = 1;
while (number <= 20)
{
    Console.WriteLine(number);
    number++;
}
Console.WriteLine(" ");
//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int num = 1;
while (num <= 20)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}
Console.WriteLine(" ");
//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int sayi = 50;
int toplam = 0;
while (sayi <= 150)
{
    toplam += sayi;
    sayi++;
}
Console.WriteLine($"Toplam: {toplam}");
Console.WriteLine(" ");
//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int sayilar = 1;
int tekSayilar = 0;
int çiftSayilar = 0;
while (sayilar <= 120)
{
    if (sayilar % 2 == 0)
    {
        çiftSayilar += sayilar;
    }
    else
    {
        tekSayilar += sayilar;
    }
    sayilar++;
}
Console.WriteLine("Tek sayıların toplamı: " + tekSayilar);
Console.WriteLine("Çift sayıların toplamı: " + çiftSayilar);