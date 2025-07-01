//1-n

Console.WriteLine("1 den kaça kadar sayıları toplamak istiyorsunuz");
int kacaKadar=int.Parse(Console.ReadLine());
int orjKacaKadar=kacaKadar;
int toplam = 0;
while (kacaKadar > 0)
{
    toplam += kacaKadar;
    kacaKadar--;

}
Console.WriteLine("1-{0} arası sayıların toplamı {1}",orjKacaKadar,toplam);