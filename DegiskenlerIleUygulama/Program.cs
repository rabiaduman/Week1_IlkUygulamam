
string name, surname;
int age, cost1, cost2, total; 
Int64 idNumber, telNumber; // int degiskeninin max degeri 2147483647 'dir. Tc ve telefon numarasi int'e sigmaz.Bu yuzden max degeri 9223372036854775807 olan int64 degiskenini kullandim.
double point; // Urunlerin toplaminin %10'u ondalikli sayi olabilir bu yuzden double degiskenini kullandım.


Console.Write("Lutfen asagidaki bilgileri giriniz:\nT.C Kimlik Numarasi: ");

idNumber = Convert.ToInt64(Console.ReadLine()); //Girilen metinsel ifadenin int64 degiskenine atanabilmesi için tam sayiya donusturulmesi

Console.Write("Adi: ");
name = Console.ReadLine();

Console.Write("Soyadi: ");
surname = Console.ReadLine();

Console.Write("Telefon Numarasi: ");
telNumber = Convert.ToInt64(Console.ReadLine());

Console.Write("Yas: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Ilk Aldigi Urunun Fiyati: ");
cost1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikinci Aldigi Urunun Fiyati: ");
cost2 = Convert.ToInt32(Console.ReadLine());

total = cost1 + cost2; // Iki sayinin toplami
point = total * 0.1; // Toplanan sayilarin %10'u 

Console.WriteLine("-----------------------------------------");

Console.Write(idNumber + " Tc numarali " + name + " " + surname + " isimli kisi icin kayit olusturulmustur.\n" + telNumber + " telefon numarasina bildirim mesaji gonderilmistir.\n" + total + " toplam harcama karsiligi kazanilan %10 patika puan miktari -> " + point.ToString("F2") + " TL' dir.");
