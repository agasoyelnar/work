//25
//Console.Write("eded daxil edin: ");
//int num =Convert.ToInt32(Console.ReadLine());

//if (num <= 100 && num >= 1) {
//    Console.WriteLine((num*num*num));
//}
//else {
//    Console.WriteLine("reqem uygun deyil");
//}


//26
//Console.Write("adinizi axil edin: ");
//string name = Console.ReadLine();
//Console.Write("soyadinizi axil edin: ");
//string surname = Console.ReadLine();
//Console.WriteLine("welcome " +name+" "+surname);

//27
//string soz = Console.ReadLine();
//int uzun = soz.Length;
//Console.WriteLine(uzun);


//28
//string soz = "alma";
//int sans = 3;
//Console.WriteLine("3 sansiniz var!");
//Console.WriteLine("bu meyvedir");
//while (sans > 0)
//{
//    Console.Write("texminizi daxil edin: ");
//    string cavab = Console.ReadLine();

//    if (cavab.ToLower() == soz)
//    {
//        Console.WriteLine(" sozu tapdiniz.");
//        break;
//    }
//    else
//    {
//        sans--;
//        Console.WriteLine("Sehvdir Qalan sans: " + sans);
//    }
//}

//29
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 10 == 7 || i%7==0)
//    {
//        Console.Write("duz ");
//    }
//    else
//        Console.Write(i + " ");
//}

// // 30
// int[] num = {10,12,22,10,32,22,16,32,22,10,11,23,32,10,10,23,23,15};
// int say = 0;
// for (int i = 0; i < num.Length; i++)
//     {
//         bool tekrar = false;
//         for (int j = 0; j < i; j++)
//         {
//             if (num[i] == num[j])
//             {
//                 tekrar = true;
//                 break;
//             }
//             }
//             if (!tekrar)
//             {
//                 say++;
//             }
//         }
// System.Console.WriteLine(say);
