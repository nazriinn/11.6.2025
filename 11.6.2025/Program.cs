




////Task1
//using System.ComponentModel.Design;

//Console.WriteLine("Enter a number:");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0) 
//Console.WriteLine($"{num} Number is even");
//else
//Console.WriteLine($"{num} Number is odd");


////Task2
//Console.WriteLine("Enter first number:");
//int num1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2)
//    Console.WriteLine($"{num1}>{num2}");
//else if (num2 > num1)
//    Console.WriteLine($"{num2}>{num1}");
//else
//    Console.WriteLine("These numbers are equal");




////Task3
//Console.WriteLine("Enter a number:");
//int num=Convert.ToInt32(Console.ReadLine());
//if (num > 0)
//    Console.WriteLine("Musbet");
//else if (num < 0)
//    Console.WriteLine("Menfi");
//else
//    Console.WriteLine("Sifir");

//////Task4
////Console.WriteLine("Enter a number:");
////int n = Convert.ToInt32(Console.ReadLine());
////for(int i=1; i<n; i++)
////{
////    Console.WriteLine(i);
//}


//Task5
//Console.WriteLine("Enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for(int i=0; i<n; i++)
//{
//    sum += i;

//}
//Console.WriteLine(sum);



//Task6

//int num = Convert.ToInt32(Console.ReadLine());
//for(int i=1;i<=10;i++)
//{
//     Console.WriteLine($"{i} x {num} = {i * num}");
////    i++;
////}


////Task7
//Console.WriteLine("Enter a number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while( num!=0)
//{
//    num /= 10;
//    count++;
//}
//Console.WriteLine(count);


//Task8
//int num = Convert.ToInt32(Console.ReadLine());
//int rev = 0;
//while(num!=0)
//{
//    int digit = num % 10;
//    rev = rev * 10 + digit;
//    num /= 10;
//}
//Console.WriteLine(rev);

////Task9
//Console.WriteLine("Enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 1;
//for (int i=1;i<n; i++)
//{
//    a *= i;
//}
//Console.WriteLine(a);

////Task10
//int evenSum = 0, oddSum = 0;

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//        evenSum += i;
//    else
//        oddSum += i;
//}

//Console.WriteLine("Cut ededlerin cemi: " + evenSum);
//Console.WriteLine("Tek ededlerin cemi: " + oddSum);


//Task11
//Console.WriteLine("Enter a numbers:");
//int num = Convert.ToInt32(Console.ReadLine());
//int rev = 0;
//while (num != 0)
//{
//    int digit = num % 10;
//    rev = rev * 10 + digit;
//    num /= 10;
//}
//Console.WriteLine(rev);
//if(rev==num)
//{
//    Console.WriteLine("Palindrom ededdir");
//}
//else
//{
//    Console.WriteLine("Polindrom eded deyil");
//}

//Task12



////Task13
//Console.WriteLine("Enter a number:");
//int n=Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//        //3 e ve 5 e bolunen eded onsuz da 15 e bolunen oldugu ucun,--if(n%15==0) da yazmaq olar
//        Console.WriteLine(i);
//}


//Task14


//Task15
//string parol;
//while (parol != "Secret123")
//{
//    Console.WriteLine("Enter password");
//        parol=Console.ReadLine();
//    if (parol != "Secret123")
//    {
//        Console.WriteLine("Girise icaze verildi.");



//    }
//    else
//        Console.WriteLine("Yanlis parol");

//}


//Task16
////Task16
//        Random random = new Random(); // Təsadüfi ədəd generatoru
//        int sirliEded = random.Next(1, 21); // 1–20 arası təsadüfi ədəd
//        int texmin; // istifadəçinin təxmin etdiyi ədəd

//        Console.WriteLine("1–20 arası bir ədəd tapmağa çalış!");

//        do
//        {
//            Console.Write("Ədəd daxil et: ");
//            texmin = int.Parse(Console.ReadLine());

//            if (texmin > sirliEded)
//                Console.WriteLine("Çox böyükdür!");
//            else if (texmin < sirliEded)
//                Console.WriteLine("Çox kiçikdir!");
//            else
//                Console.WriteLine("Təbriklər! Düz tapdın!");
//        }
//        while (texmin != sirliEded); // düzgün ədəd tapılmayınca dövr davam edir

//Task17
//Console.Write("Ədəd daxil et: ");
//int n = int.Parse(Console.ReadLine());

//bool sade = true; // əvvəlcədən fərz edirik ki, ədəd sadədir

//if (n <= 1)
//{
//    sade = false; // 1 və mənfi ədədlər sadə deyil
//}
//else
//{
//    for (int i = 2; i <= Math.Sqrt(n); i++) // 2-dən √n-ə qədər yoxlayırıq
//    {
//        if (n % i == 0) // əgər tam bölünürsə, sadə deyil
//        {
//            sade = false;
//            break;
//        }
//    }
//}

//if (sade)
//    Console.WriteLine($"{n} sadə ədəddir.");
//else
//    Console.WriteLine($"{n} sadə ədəd deyil.");

//Task18
//Console.Write("Ədəd daxil et: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}













