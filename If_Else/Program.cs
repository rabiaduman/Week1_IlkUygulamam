
Console.Write("Lütfen bir sayi giriniz: ");

int sayi = Convert.ToInt32(Console.ReadLine()); //Girilen metinsel ifade  tam sayıya cevriliyor.

if (sayi == 10)
{
    Console.WriteLine("Girilen sayi 10'a esittir.");
    
}
else if (sayi < 10)
{
    Console.WriteLine("Girilen sayi 10'dan kücüktür.");

}
else
{
    Console.WriteLine("Girilen sayi 10'dan büyüktür.");
}

if (sayi % 2 == 0) //Tek mi cift mi anlamak için sayinin 2 ile bolumunden kalanin 0 a esit olma durumuna bakiliyor. 
{
    Console.WriteLine("Girilen sayi cifttir.");
}
else
{
    Console.WriteLine("Girilen sayi tektir.");
}
