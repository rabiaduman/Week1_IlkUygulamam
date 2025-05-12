
Console.WriteLine("*******Kim Milyoner Olmak İster ? Yarışmasına Hoşgeldiniz*******\n\n");

Console.WriteLine("1. Kızınca tüküren hayvan hangisidir ?\na) Lama b) Deve");

string ansver1 = Console.ReadLine().ToLower();

int sayac = 0;

switch (ansver1)
{
    case "a":
        Console.WriteLine("*Doğru Cevap*\n");
        sayac++;
        break;

    default:
        Console.WriteLine("Yanlış Cevap!\n");
        break;

}


Console.WriteLine("2. Dünya'ya en yakın gezegen hangisidir ?\na) Venüs b) Mars");

string ansver2 = Console.ReadLine().ToLower();

switch (ansver2)
{
    case "a":
        Console.WriteLine("*Doğru Cevap*\n");
        sayac++;
        break;

    default:
        Console.WriteLine("Yanlış Cevap!\n");
        break;

}


 if (sayac == 2 || sayac == 1)
{
    Console.WriteLine("3. 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?\na) 7 b) 12");
    string ansver3 = Console.ReadLine().ToLower();

    switch (ansver3)
    {
        case "b":
            Console.WriteLine("*Doğru Cevap*\n");
            sayac++;
            break;

        default:
            Console.WriteLine("Yanlış Cevap!\n");
            break;
    }
    
        
     if (sayac == 2|| sayac == 3) 
        Console.WriteLine("+*+*+Yarışmayı kazandınız+*+*+");
     else
        Console.WriteLine("Yarışmadan elendiniz...");
}

else
     Console.WriteLine("Yarışmadan elendiniz...");
      







