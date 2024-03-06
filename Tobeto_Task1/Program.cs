static void Example1()
{
    Console.Write("Sipariş edilecek ürün numarasını giriniz:");

    int productNumber = Convert.ToInt32(Console.ReadLine());

    string product = "";

    switch (productNumber)
    {

        case 1:
            product = "Casper Excalibur Series";
            break;
        case 2:
            product = "MSI KATANA 15 B12VGK-087XTR";
            break;
        case 3:
            product = "HP Victus 16-R0001NT";
            break;
        case 4:
            product = "Apple MacBook Air M1";
            break;
        case 5:
            product = "Lenovo Thinkpad T14 Gen 4";
            break;
        default:
            Console.WriteLine("Bu siparis numarasina ait bir urun bulunmamaktadir");
            break;
    }

    Console.WriteLine("Siparis etmekte oldugunuz urun: " + product);
}

static void Example2()
{
    Console.Write("Lutfen kac adet urun almak istediginizi belirtiniz: ");

    int amount = Convert.ToInt32(Console.ReadLine());

    double total = 0;

    for (int i = 0; i < amount; i++)
    {
        Console.Write("Almak istediginiz urunun fiyatini giriniz:");

        double price = Convert.ToDouble(Console.ReadLine());

        total += price;

    }

    Console.WriteLine("Toplam alisveriz tutariniz: " + total + " turk lirasidir");

}

static void Example3_1()
{
    Console.Write("Baslangic sayisini giriniz: ");

    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Bitis sayisini giriniz: ");

    int lastNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > lastNumber)
    {
        Console.WriteLine("Başlangıç sayısı bitiş sayısından büyük olamaz. Lütfen tekrar deneyiniz. ");

    }


    int temp = firstNumber + 1;//firstNumber gosterimde kullanilacagi icin temp degiskeni ile islem yapiyorum ve iki deger arasini hesaplayacagim icin +1 ekliyorum

    int total = 0;

    while (temp < lastNumber)
    {
        total += Convert.ToInt32(temp);
        temp++;
    }


    Console.WriteLine(firstNumber + " ile " + lastNumber + " arasindaki sayilarin toplami : " + total + " olmaktadir ");
}

static void Example3_2()
{
    int number;
start:
    do
    {
        Console.Write("Bir sayı girin: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))//burada herhangi bir deger girilmeden entera basilirsa kullaniciyi uyariyorum
        {
            Console.WriteLine("Bu alan bos birakilamaz tekrar deneyiniz. ");
            goto start;//yukarida start etiketini tanimliyoruz ve kod buraya dusar ise start etiketini tanimladigimiz yere tekrardan gidiyor
        }


        number = Convert.ToInt32(input);



        if (number % 2 == 0)
        {
            Console.WriteLine(number + " çift bir sayıdır.");
        }
        else
        {
            Console.WriteLine(number + " tek bir sayıdır.");
        }

        Console.Write("Başka bir sayı girmek istiyor musunuz? (evet/hayır): ");

    } while (Console.ReadLine().ToLower() == "evet");//evet disinda verilen herhangi bir girdi icin program sonalanacaktir
}

static void Example4()
{

    Console.WriteLine("sistemin belirledigi rastgele sayiyi tahmin edin");
start:
    Random random = new Random();

    int randomNumber = random.Next(1, 11);



    while (true)
    {
        Console.Write("Sayiyi giriniz: ");

        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Bu alan boş geçilemez lütfen geçerli bir sayı girişi yapın. ");
            goto start;
        }



        int guessedNumber = Convert.ToInt32(input);


        if (guessedNumber == randomNumber)
        {
            Console.Write("Tahmininiz Dogru! Tekrar Denemek Ister misiniz ? (evet/hayir) : ");
            string restartGame = Console.ReadLine();
            if (restartGame == "evet")
            {
                goto start;
            }
            else
            {
                break;
            }

        }
        else if (guessedNumber > 10 || guessedNumber < 1)
        {
            Console.Write("Lütfen tahminizi 1 ve 10 dahil olacak şekilde bu aralıkta yapınız!");
            goto start;
        }
        else
        {
            Console.WriteLine("Tahmininiz yanlis lutfen tekrar deneyiniz");

        }
    }
}


static void Example5()
{
    Console.WriteLine("Girdiginzi sayinin mukemmel sayi olup olmadigini kontrol edelim.");

    Console.Write("Bir sayı giriniz: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }

    if (sum == number)
    {
        Console.WriteLine(number + " bir mükemmel  sayıdır.");
    }
    else
    {
        Console.WriteLine(number + " bir mükemmel  sayı değildir.");
    }
}

static void Example6()
{
    string input = "   Hello Tobeto!   ";

    string upperCase = input.ToUpper();
    string lowerCase = input.ToLower();
    bool contains = input.Contains("Tobeto");
    string substring = input.Substring(3, 5);//Ilk parametre olarak verilen indexten baslayip ikinci parametre olarak verilen kadar bir kismini alir
    string replacedInput = input.Replace("Hello", "Merhaba");
    string trimmedInput = input.Trim();

    Console.WriteLine("Uppercase methodu sonucu: " + upperCase);
    Console.WriteLine("lowerCase methodu sonucu: " + lowerCase);
    Console.WriteLine("Contains methodu sonucu: " + contains);
    Console.WriteLine("Substring methodu sonucu: " + replacedInput);
    Console.WriteLine("Replace methodu sonucu: " + substring);
    Console.WriteLine("Substring methodu sonucu: " + substring);
    Console.WriteLine("Trim methodu sonucu: " + trimmedInput);
}


static void Example7()
{
    Console.Write("Öğrenci sayısını giriniz: ");


    int studentCount = Convert.ToInt32(Console.ReadLine());

    double totalAverageGrade = 0;

    for (int i = 1; i <= studentCount; i++)
    {
        Console.WriteLine(i + ". Oğrencinin bilgilerini giriniz.");

        Console.Write("Öğrenci adı: ");
        string studentName = Console.ReadLine();

        Console.Write("Öğrenci soyadı: ");
        string studentSurname = Console.ReadLine();

        Console.Write("1. Sınav notu: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Sınav notu: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3. Sınav notu: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        // Not ortalamasını hesapla
        double averageGrade = (grade1 + grade2 + grade3) / 3;

        totalAverageGrade += averageGrade;

        // Öğrenci bilgilerini ekrana yazdır
        Console.WriteLine("Öğrenci Adı: " + studentName);
        Console.WriteLine("Öğrenci Soyadı: " + studentSurname);
        Console.WriteLine("1. Sınav Notu: " + grade1);
        Console.WriteLine("2. Sınav Notu: " + grade2);
        Console.WriteLine("3. Sınav Notu: " + grade3);
        Console.WriteLine("Not Ortalaması: " + averageGrade);
        Console.WriteLine("---------------------");
    }
    double classAverage = totalAverageGrade / studentCount;
    Console.WriteLine("Tüm sınıfın ortalaması ise: " + classAverage);
}
