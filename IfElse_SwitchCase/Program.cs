
using System.ComponentModel.Design;

Console.WriteLine("Rüya manavına hoş geldiniz!\nElma = 2 TL\nArmut = 3 TL\nÇilek = 2 TL\nMuz = 3 TL\nDiğer bütün meyveler = 4 TL\n");

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

string fruit = Console.ReadLine().ToLower(); //ToLower ile girilen metnin karakterleri kucuk harfe cevrildi

//BU PROBLEMİ SWITCH CASE İLE ÇÖZMEK DAHA MANTIKLI ÇÜNKÜ FRUIT DEĞİŞKENİ ELMA/ARMUT GİBİ SABİT BİR DEĞERE SAHİP,DEĞİŞKEN İLE  HERHANGİ BİR İŞLEM( < , > , != ) YAPILMIYOR, GİRİLEN DEĞERİN EŞİTLİĞİNE BAKILIYOR. AYRICA KOD DAHA TEMİZ GÖZÜKÜYOR.


//------------------------------Switch Case İle Çözüm--------------------------------------------------------    

switch (fruit)
{
    case "elma":

        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;

    case "armut":

        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;

    case "çilek":

        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;

    case "muz":

        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;

    case "diğer":

        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;

    default:

        Console.WriteLine("Geçersiz seçim!");
        break;
}


//-------------------------------If Else İle Çözüm-----------------------------------------------------------

//if (fruit == "elma")

//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");

//else if (fruit == "armut")

//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");

//else if (fruit == "çilek")

//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");

//else if (fruit == "muz")

//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");

//else if (fruit == "diğer")

//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");

//else Console.WriteLine("Geçersiz seçim!");


