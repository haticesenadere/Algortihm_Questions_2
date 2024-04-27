using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algortihm_HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Girilen sayının tek mi çift mi olduğunu bulan program.  ");
            Console.WriteLine("2 - Girilen sayı hem 2 hem de 3 ile tam bölünebiliyorsa “TAMAM”, aksi halde “HATA” mesajı veren program");
            Console.WriteLine("3-Girilen 3 sayıdan en az biri 50’den büyükse “Yeterli”, aksi halde “Yetersiz” mesajı veren program ");
            Console.WriteLine("4-Kullanıcı ders notunu girsin. Notu 50'den küçükse kaldınız, büyükse geçtiniz yazan program");
            Console.WriteLine("5-Girilen sayının pozitif mi negatif mi olduğunu yazan program");
            Console.WriteLine("6-Girilen sayının mükemmel sayı olup olmadığını bulan program(Bir sayının kendisi hariç bölenlerinin toplamının kendisine eşit olması. 6 -> 1 - 2 - 3 - 6 | 1+2+3 = 6)");
            Console.WriteLine("7-1 ve 200 arasında çift sayıların toplamını bulan program");
            Console.WriteLine("8-Klavyeden girilecek X değerinden N değerine kadar tüm doğal sayıları listeleyen program");
            Console.WriteLine("9-Klavyeden girilen bir sayının tüm tam bölenlerini bulup ekrana yazan program");
            Console.WriteLine("10-1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan program");
            Console.WriteLine("11-Kullanıcıdan alınan iki sayı arasındaki asal sayıları bulan program");
            Console.WriteLine("12-Klavyeden girilen sayının 2′ye bölümünü bulan programı yapınız. (Not: Bölme / operatörünü kullanmadan yapılacak)");
            Console.WriteLine("13-Kullanıcıdan bir sayı girmesi istenecek ve kullanıcı \"Başka bir sayı girmek istiyor musunuz?\" sorusuna hayır cevabını verene kadar sayı girmeye devam edecek. Kullanıcının girdiği sayıların ortalamasını bulan program.(Kullanıcı ilk sayıyı girerken Başka bir sayı girmek istiyor musunuz? sorusu sorulmamalı)");
            Console.WriteLine("14-Klavyeden 0 girilene kadar girilmiş olan sayıların toplamını ekrana yazan program");
            Console.WriteLine("15-Bir sayının palindrom olup olmadığını bulan program (Palindrom sayı : Soldan sağa veya sağdan sola doğru yazıldığında aynı olan sayılara ise palindrom sayılar denir. 2002 gibi)");
            Console.WriteLine("16-Girilen pozitif sayının kaç basamaklı olduğunu bulan program");
            Console.WriteLine("17-Bir sayı belirleyin. Kullanıcıdan bu sayıyı tahmin etmesini isteyin. Kullanıcı sayıyı bulana kadar sormaya devam edin");
            Console.WriteLine("18-Herhangi bir sayının herhangi bir dereceden kuvvetini bulan program");
            Console.WriteLine("19-1-100 arasındaki asal sayıları bulup ekrana asal sayıları yazan ve kaç adet asal sayı olduğunu bulan program");
            Console.WriteLine("20-Girilen bir sayının basamaklarında ki en büyük sayıyı bulan program(485 -> 8)");
            Console.WriteLine("21-Girilen 3 basamaklı bir sayının her bir basamağındaki sayının küplerinin toplamının sayının kendisine eşit olup olmadığını bulan program.");
            Console.WriteLine("22-Kullanıcıdan bir dikdörtgenin kısa ve uzun kenar ölçüleri alınacak ve dikdörtgenin alan ve çevresi hesaplanacak. Kullanıcı herhangi bir değere 0 ve sıfırdan küçük değer girmediği müddetçe kullanıcıdan ölçü alınıp işlem yapılmaya devam edilecek.");
            Console.WriteLine("23-Kullanıcının girdiği kelimenin yarısından sonrasını altsatıra bastıran program");
            Console.WriteLine("24-0 ile 100 arasında 7'ye bölümünden kalanı 3 olan kaç tane sayı olduğunu bulan program");
            Console.WriteLine("25-Kullanıcının girdiği sayıların toplamı 30'u geçtiği an işlemi durdurup sayıları ve kaç adet sayı girildiğini ekrana bastıran program");
            Console.WriteLine("26-Kullanıcının girdiği 10 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulan program");
            Console.WriteLine("27-Kullanıcıdan 2 adet sayı alın ve çıkarma işlemi yapın. İşlemin sonucu sıfırdan büyük ve çift ise 'Başarılı' yazsın.");
            Console.WriteLine("28-Klavyeden ardı ardına sayı girişi isteyen ve bu sayı 10 ile 15 arasında olmadığı sürece bu işleme devam eden program");
            Console.WriteLine("29-Klavyeden bir not girilmesini isteyen ve bu not 0-49 arasındaysa “Başarısız”, 50-64 arasındaysa “Orta”, 65-84 arasındaysa “İyi”, 85-100 arasındaysa “Çok iyi “ Yazan program");
            Console.WriteLine("30-Kullanıcıdan parola girmesini isteyin. Parolanın geçerli olabilmesi için ya 10 karakterden fazla olması ya da 8 karakterden fazla ve ilk karakterinin büyük bir harf olması gerekmektedir.Parola geçerli ise 'Parola kabul edildi' değilse 'Parola kabul edilmedi' yazan program.");
            Console.WriteLine("31-Kullanıcıdan hava durumu bilgisini (yağmurlu, güneşli, karlı vb.) alın. Eğer hava durumu yağmurlu ise veya karlı ise, \"Şemsiyenizi veya kar botlarınızı almayı unutmayın!\" mesajını verin.");
            Console.WriteLine("32-Bir işyerinde çalışanın aylık satışını alın. Eğer aylık satış 5000 TL'den fazla ise veya çalışanın toplam satışı 20000 TL'den fazla ise, çalışana bonus verilmesi gerektiğini belirtin.");
        








            Console.WriteLine("Soru numaranızı Giriniz. ");
            int qNum = Convert.ToInt32(Console.ReadLine());


            if (qNum == 1)
            {
                Console.WriteLine("1-Girilen sayının tek mi çift mi olduğunu bulan program.  ");

                int result;
                Console.WriteLine("Bir sayı Giriniz. ");
                int number = Convert.ToInt32(Console.ReadLine());
                result = number % 2;

                if (result == 0)
                {
                    Console.WriteLine("Girdiğiniz sayı çift sayidir. ");


                }
                else
                {

                    Console.WriteLine("Giridiğiniz sayı tek sayidir. ");
                }
            }
            if (qNum == 2)
            {
                Console.WriteLine("2-Girilen sayı hem 2 hem de 3 ile tam bölünebiliyorsa “TAMAM”, aksi halde “HATA” mesajı veren program");

                Console.WriteLine("Bir sayı Giriniz. ");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number % 2 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("okey. Lets goo");
                }
                else
                {
                    Console.WriteLine("Error. try again");

                }
            }
            if (qNum == 3)
            {
                Console.WriteLine("3-Girilen 3 sayıdan en az biri 50’den büyükse “Yeterli”, aksi halde “Yetersiz” mesajı veren program ");

                int[] number = new int[3];
                int i;

                for (i = 0; i < number.Length; i++)
                {
                    Console.WriteLine("Bir sayı Giriniz. ");
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }

                if (number[0] >= 50 || number[1] >= 50 || number[2] >= 50) // burayı for döngüsü ve if ile de kontrol edebilirdim. Ama problemdeki sayi adedim azdı.
                {
                    Console.WriteLine("YETERLİ");

                }
                else
                {
                    Console.WriteLine("YETERSİZ");
                }
            }
            if (qNum == 4)
            {
                Console.WriteLine(" 4-Kullanıcı ders notunu girsin. Notu 50'den küçükse kaldınız, büyükse geçtiniz yazan program");

                Console.WriteLine("Bir sayı Giriniz. ");
                int point = Convert.ToInt32(Console.ReadLine());

                if (point > 50)
                {
                    Console.WriteLine("Dersten Gçetiniz. ");

                }
                else
                {
                    Console.WriteLine("Dersten Kaldınız.");
                }
            }

            if (qNum == 5)
            {
                Console.WriteLine("5-Girilen sayının pozitif mi negatif mi olduğunu yazan program");

                Console.WriteLine("Bir sayı Giriniz. ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("Girilen sayi Pozitifdir.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Girilen sayi negatiftir.");
                }
                else
                {
                    Console.WriteLine("0 sayısını girdiniz");
                }

            }
            if (qNum == 6)
            {
                Console.WriteLine("6-Girilen sayının mükemmel sayı olup olmadığını bulan program(Bir sayının kendisi hariç bölenlerinin toplamının kendisine eşit olması. 6 -> 1 - 2 - 3 - 6 | 1+2+3 = 6)");


                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                Console.WriteLine($"{sayi} sayısının bölenleri:");

                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        Console.WriteLine(i);
                        result += i;
                    }




                }
                Console.WriteLine($"{result} Kalanların toplam sonucu.");

                if (result == sayi)
                {
                    Console.WriteLine("Bu sayi mükemmel sayi'dir");
                }
                else { Console.WriteLine("Mükemmel sayi değildir."); }

            }

            if (qNum == 7)
            {
                Console.WriteLine("7-1 ve 200 arasında çift sayıların toplamını bulan program");

                int toplam = 0;

                for (int i = 2; i < 200; i += 2)
                {
                    toplam += i;
                }
                Console.WriteLine(toplam);




            }

            if (qNum == 8)
            {
                Console.WriteLine("-Klavyeden girilecek X değerinden N değerine kadar tüm doğal sayıları listeleyen program");

                Console.WriteLine("Başlangıç sayısını giriniz ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bitiş sayısını Giriniz. ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (x <= n)
                {


                    for (int i = x; i < n + 1; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("sayılarınızı giriniz lütfen");
                }
            }
            if (qNum == 9)
            {

                Console.WriteLine("9-Klavyeden girilen bir sayının tüm tam bölenlerini bulup ekrana yazan program");


                Console.WriteLine("Bir sayi giriniz. ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
            if (qNum == 10)
            {
                Console.WriteLine("10-1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan program");
                for (int i = 0; i <= 40; i += 5)
                {

                    Console.WriteLine(i);

                }

                //for (int i = 1; i <= 40; i++)
                //{
                //    if (i % 5 == 0)
                //    {
                //        Console.WriteLine(i);
                //    }



                //}

            }
            if (qNum == 11)
            {

                Console.WriteLine("11-Kullanıcıdan alınan iki sayı arasındaki asal sayıları bulan program");

                Console.WriteLine("Başlangıç sayısını giriniz ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bitiş sayısını Giriniz. ");
                int n = Convert.ToInt32(Console.ReadLine());


                int sayac = 0;

                for (int i = x; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 2)
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", n);
                }
                else
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", n);
                }

            }

            if (qNum == 12)
            {
                Console.WriteLine("12-Klavyeden girilen sayının 2′ye bölümünü bulan programı yapınız. (Not: Bölme / operatörünü kullanmadan yapılacak)");

                Console.WriteLine("Bir sayı giriniz ");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number % 2 == 0)
                {
                    Console.WriteLine("Bu sayi 2'ye tam bölünebilir.");
                }
                else
                {
                    Console.WriteLine("bu sayiya tam bölünemez");
                }
            }
            if (qNum == 13)
            {

                Console.WriteLine("13-Kullanıcıdan bir sayı girmesi istenecek ve kullanıcı \"Başka bir sayı girmek istiyor musunuz?\" sorusuna hayır cevabını verene kadar sayı girmeye devam edecek. Kullanıcının girdiği sayıların ortalamasını bulan program.(Kullanıcı ilk sayıyı girerken Başka bir sayı girmek istiyor musunuz? sorusu sorulmamalı)");

                int[] numberList = new int[100];
                int toplam = 0;
                double ortalam;
                int count = 0;

                for (int i = 0; i < numberList.Length; i++)
                {
                    Console.WriteLine("Bir sayı giriniz ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    numberList[count] = number;
                    count++;

                    Console.WriteLine("Başka bir sayı girmek istiyor musunuz? (0/1) ");
                    int numanswer = Convert.ToInt32(Console.ReadLine());
                    bool answer = (numanswer == 0);

                    if (!answer || count >= numberList.Length)
                    {
                        break;

                    }

                }

                for (int i = 0; i < count; i++)
                {
                    toplam += numberList[i];
                }

                ortalam = (double)toplam / count;

                Console.WriteLine("sayıların ortalaması" + ortalam);
            }


            if (qNum == 14)
            {

                Console.WriteLine("14-Klavyeden 0 girilene kadar girilmiş olan sayıların toplamını ekrana yazan program");

                int[] numberList = new int[100];

                int count = 0;
                int toplam = 0;

                Console.WriteLine("Bir sayı giriniz ");
                int number = Convert.ToInt32(Console.ReadLine());
                numberList[count] = number;
                count++;
                while (number != 0)
                {

                    Console.WriteLine("Bir sayı giriniz ");
                    number = Convert.ToInt32(Console.ReadLine());
                    numberList[count] = number;
                    count++;

                }

                for (int i = 0; i < count; i++)
                {
                    toplam += numberList[i];
                }

                Console.WriteLine(toplam);
            }
            if (qNum == 15)
            {

                Console.WriteLine("15-Bir sayının palindrom olup olmadığını bulan program (Palindrom sayı : Soldan sağa veya sağdan sola doğru yazıldığında aynı olan sayılara ise palindrom sayılar denir. 2002 gibi)");

                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int tersSayi = 0;
                int gecici = sayi;

                // Sayının tersini hesapla
                while (gecici != 0)
                {
                    int basamak = gecici % 10;
                    tersSayi = tersSayi * 10 + basamak;
                    gecici /= 10;
                }

                // Sayının palindrom olup olmadığını kontrol et
                if (sayi == tersSayi)
                {
                    Console.WriteLine("Girilen sayı bir palindrom sayıdır.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı bir palindrom sayı değildir.");
                }
            }



            if (qNum == 16)
            {
                Console.WriteLine("16-Girilen pozitif sayının kaç basamaklı olduğunu bulan program");

                Console.WriteLine("Bir sayı giriniz ");
                int number = Convert.ToInt32(Console.ReadLine());

                int sayac = 0;

                while (number != 0)
                {
                    number /= 10;
                    sayac++;
                }

                Console.WriteLine("Girilen sayı " + sayac + " basamaklı.");
            }

            if (qNum == 17)
            {
                Console.WriteLine("17-Bir sayı belirleyin. Kullanıcıdan bu sayıyı tahmin etmesini isteyin. Kullanıcı sayıyı bulana kadar sormaya devam edin");


                int correctNumber = 8;
                int sayac = 0;

                Console.WriteLine("Bir sayı giriniz ");
                int number = Convert.ToInt32(Console.ReadLine());

                while (correctNumber != number)
                {
                    Console.WriteLine("Bir sayı giriniz ");
                    number = Convert.ToInt32(Console.ReadLine());
                    sayac++;


                }

                Console.WriteLine("Doğru sayiyi buldunuz " + correctNumber);

            }
            if (qNum == 18)
            {

                Console.WriteLine("18-Herhangi bir sayının herhangi bir dereceden kuvvetini bulan program");

                Console.WriteLine("Bir sayı giriniz ");
                int taban = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bir sayı giriniz ");
                int us = Convert.ToInt32(Console.ReadLine());

                int result = 1;
                for (int i = 0; i < us; i++)

                {

                    result *= taban;
                }

                Console.WriteLine($"{taban} üzeri {us} = {result}");




            }
            if (qNum == 19)
            {
                Console.WriteLine("19-1-100 arasındaki asal sayıları bulup ekrana asal sayıları yazan ve kaç adet asal sayı olduğunu bulan program");

            }

            if (qNum == 20)
            {
                Console.WriteLine("20-Girilen bir sayının basamaklarında ki en büyük sayıyı bulan program(485 -> 8)");

                Console.WriteLine("Bir sayı giriniz ");
                int num = Convert.ToInt32(Console.ReadLine());


                int enBuyukBasamak = 0;


                while (num != 0)
                {

                    int basamak = num % 10;


                    if (basamak > enBuyukBasamak)
                    {
                        enBuyukBasamak = basamak;
                    }


                    num /= 10;
                }

                Console.WriteLine("Girilen sayının en büyük basamağı: " + enBuyukBasamak);
            }


            if (qNum == 21)
            {
                Console.WriteLine("21-Girilen 3 basamaklı bir sayının her bir basamağındaki sayının küplerinin toplamının sayının kendisine eşit olup olmadığını bulan program.");

                Console.WriteLine("Bir sayı giriniz ");
                int num = Convert.ToInt32(Console.ReadLine());

                int yuzler = num / 100;

                int onlar = (num % 100) / 10;

                int birler = num % 10;

                Console.WriteLine("Birler basamağı: " + birler);
                Console.WriteLine("Onlar basamağı: " + onlar);
                Console.WriteLine("Yüzler basamağı: " + yuzler);

                int yuzlerKup = yuzler * yuzler * yuzler;
                int onlarKup = onlar * onlar * onlar;
                int birlerKup = birler * birler * birler;

                int sonuc = yuzlerKup + onlarKup + birlerKup;

                if (sonuc == num)
                {
                    Console.WriteLine($"Girdiğiniz {num} sayısı ile basamakların küpünün toplamı olan {sonuc} sayısına eşittir.");
                }
                else
                {
                    Console.WriteLine("Maalesef eşit değildir.");
                }


            }
            if (qNum == 22)
            {
                Console.WriteLine("22-Kullanıcıdan bir dikdörtgenin kısa ve uzun kenar ölçüleri alınacak ve dikdörtgenin alan ve çevresi hesaplanacak. Kullanıcı herhangi bir değere 0 ve sıfırdan küçük değer girmediği müddetçe kullanıcıdan ölçü alınıp işlem yapılmaya devam edilecek.");

                while (true)
                {



                    Console.WriteLine("Diktörtgenin kısa tarafını giriniz ");
                    int shortSide = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Diktörtgenin uzun tarafını girini ");
                    int longSide = Convert.ToInt32(Console.ReadLine());



                    if (shortSide == 0 || shortSide < 0 || longSide == 0 || longSide < 0)
                    {
                        Console.WriteLine("Maalesef 0 girdiniz.");
                        return;
                    }
                    else
                    {
                        int cevre = (shortSide + longSide) * 2;

                        int alan = (shortSide * longSide);

                        Console.WriteLine($" Diktörtgenizin çevresi : {cevre}");
                        Console.WriteLine($" Diktörtgenizin alanı : {alan}");
                    }

                }
            }
            if (qNum == 23)
            {

                Console.WriteLine("23-Kullanıcının girdiği kelimenin yarısından sonrasını altsatıra bastıran program");

                Console.WriteLine("Bir kelime giriniz ");
                string word = Console.ReadLine();

                int word2 = word.Length / 2;


                for (int i = 0; i < word2; i++)
                {
                    Console.Write(word[i]);

                }
                Console.Write("-----");
                for (int i = word2; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                }


            }
            if (qNum == 24)
            {
                Console.WriteLine("24-0 ile 100 arasında 7'ye bölümünden kalanı 3 olan kaç tane sayı olduğunu bulan program");

                int[] ints = new int[50];
                int count = 0;

                for (int i = 0; i < 101; i++)
                {
                    if (i % 7 == 3)
                    {

                        Console.WriteLine(i);
                        ints[count] = i;
                        count++;

                    }


                }
                Console.Write(ints);


            }
            if (qNum == 25)
            {
                Console.WriteLine("25-Kullanıcının girdiği sayıların toplamı 30'u geçtiği an işlemi durdurup sayıları ve kaç adet sayı girildiğini ekrana bastıran program");

                int total = 0;
                int count = 0;

                while (total <= 30)
                {
                    Console.WriteLine("Bir sayı giriniz ");
                    int num = Convert.ToInt32(Console.ReadLine());


                    total += num;
                    count++;

                    if (total == 30)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Toplam girdi sayısı: {count}");
                Console.WriteLine($"Toplam: {total}");
            }

            if (qNum == 26)
            {
                Console.WriteLine("26-Kullanıcının girdiği 10 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulan program");

                int[] cift = new int[10];
                int[] tek = new int[10];

                int ciftToplam = 0;
                int tekToplam = 0;

                int ciftcount = 0;
                int tekCount = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Bir sayı giriniz ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        cift[ciftcount] = i;
                        ciftcount++;
                        ciftToplam += num;
                    }
                    else if (num % 3 == 0)
                    {
                        tek[tekCount] = i;
                        tekCount++;
                        tekToplam += num;
                    }



                }

                if (tekToplam != 0) // Tek sayıların toplamı sıfırdan farklı ise oranı hesapla
                {
                    double oran = (double)ciftToplam / tekToplam;
                    Console.WriteLine("Çift sayıların tek sayılara oranı: " + oran);
                }
                else
                {
                    Console.WriteLine("Tek sayıların toplamı sıfır olduğu için oran hesaplanamıyor.");
                }
                //for (int i = 0; i < ciftcount; i++) // Çift sayıları ekrana yazdır
                //{
                //    Console.WriteLine(cift[i]);
                //}

                //for (int i = 0; i < tekCount; i++) // Tek sayıları ekrana yazdır
                //{
                //    Console.WriteLine(tek[i]);
                //}

            }
            if (qNum == 27)
            {
                Console.WriteLine("27-Kullanıcıdan 2 adet sayı alın ve çıkarma işlemi yapın. İşlemin sonucu sıfırdan büyük ve çift ise 'Başarılı' yazsın.");

                Console.WriteLine("Büyük sayı giriniz ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Küçük sayı giriniz ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num - num2;

                if (result > 0 && result % 2 == 0)
                {
                    Console.WriteLine("Başarılı bir işlem.");
                }
                else
                {
                    Console.WriteLine("Maalesef başarısız.");
                }


            }
            if (qNum == 28)
            {

                Console.WriteLine("28-Klavyeden ardı ardına sayı girişi isteyen ve bu sayı 10 ile 15 arasında olmadığı sürece bu işleme devam eden program");

                while (true)
                {
                    Console.WriteLine("sayı giriniz ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num >= 10 && num <= 15)
                    {
                        Console.WriteLine("Girilen sayı 10 ile 15 arasında. Program sonlandırılıyor.");
                        break;
                    }
                }

            }
            if (qNum == 29)
            {

                Console.WriteLine("29-Klavyeden bir not girilmesini isteyen ve bu not 0-49 arasındaysa “Başarısız”, 50-64 arasındaysa “Orta”, 65-84 arasındaysa “İyi”, 85-100 arasındaysa “Çok iyi “ Yazan program");

                Console.WriteLine("Sınav Puan sayınızı giriniz ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= 49)
                {
                    Console.WriteLine("Başarısız");
                }
                else if (num <= 64)
                {
                    Console.WriteLine("orta");
                }
                else if (num <= 84)
                {

                    Console.WriteLine("iyi");

                }
                else if (num <= 100)
                {
                    Console.WriteLine("Çok iyi");
                }
                else { Console.WriteLine("Geçersiz giriş"); }






            }
            if (qNum == 30)
            {
                Console.WriteLine("30-Kullanıcıdan parola girmesini isteyin. Parolanın geçerli olabilmesi için ya 10 karakterden fazla olması ya da 8 karakterden fazla ve ilk karakterinin büyük bir harf olması gerekmektedir.Parola geçerli ise 'Parola kabul edildi' değilse 'Parola kabul edilmedi' yazan program.");

                Console.WriteLine("Parolanzı giriniz ");
                string password = Console.ReadLine();

                bool correct = false;


                if (password.Length > 10 || password.Length > 8 && char.IsUpper(password[0]))
                {
                    correct = true;
                }


                if (correct)
                {
                    Console.WriteLine("Parola girişi başarılı");
                }
                else
                {
                    Console.WriteLine("Giriş başarısız oldu");
                }

            }
            if (qNum == 31)
            {
                Console.WriteLine("31-Kullanıcıdan hava durumu bilgisini (yağmurlu, güneşli, karlı vb.) alın. Eğer hava durumu yağmurlu ise veya karlı ise, \"Şemsiyenizi veya kar botlarınızı almayı unutmayın!\" mesajını verin.");

                Console.WriteLine("Hava Durumunu Giriniz. ");
                string weather = Console.ReadLine();

                if (weather.ToUpper() == "YAĞMURLU" || weather.ToUpper() == "KARLI")
                {
                    Console.WriteLine("Şemsiyenizi veya kar botlarınızı almayı unutmayın!");
                }
                else
                {
                    Console.WriteLine("İyi Günler");
                }



            }
            if (qNum == 32)
            {

                Console.WriteLine("32-Bir işyerinde çalışanın aylık satışını alın. Eğer aylık satış 5000 TL'den fazla ise veya çalışanın toplam satışı 20000 TL'den fazla ise, çalışana bonus verilmesi gerektiğini belirtin.");

                Console.WriteLine("Aylık satış tutarını Giriniz. ");
                int monthSale = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Toplam satış tutarını Giriniz. ");
                int totalSale = Convert.ToInt32(Console.ReadLine());

                if (monthSale > 5000 || totalSale > 20000)
                {
                    Console.WriteLine("Bravo bu seferki çalışmalarınızdan dolayı bonus kazandınız.");
                }
                else
                {
                    Console.WriteLine("Bir dahaki aya umarım. ");
                }




            }


        }
    }
}
    
