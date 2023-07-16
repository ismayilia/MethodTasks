//ShowDatas();

//static void ShowDatas()
//{
//    Welcome();
//    string fullName = "Kubra Memmedova";
//    string email = "kubra@code.edu.az";
//    string fullData = $"{fullName} - {email}";

//    ShowAge();

//    Console.WriteLine(fullData);

//}

//static void ShowAge()
//{

//    Welcome();
//    int age = 25;
//    Console.WriteLine(age);

//}

//static void Welcome()
//{
//    Console.WriteLine("Welcome Kubra");
//}
//                           --------------------------Arrayin elementlerinin hesablanmasi
//static void SumItemsOfArray()
//{
//    int sum = 0;
//    int[] arr = { 1, 2, 3, 4, 5 };
//    foreach (var item in arr)
//    {
//        sum += item;
//    }
//    Console.WriteLine(sum);
//}

//SumItemsOfArray();  

//                                              --------------   Adina gore search
//static void SearchByName()
//{
//    string[] people = { "Sheref", "Pervin", "Cahangir", "Huseyn" };
//    string searchText = "Pervinn";

//    foreach (string person in people)
//    {
//        if (person == searchText)
//        {
//            Console.WriteLine(person);
//            break;
//        }
//        if (person == "Cahangir")
//        {
//            Console.WriteLine(person);
//            return;
//        }
//    }

//    Console.WriteLine("Our search method is working");



//SearchByName(); 


//static void Sum(int number1, int number2)
//{
//    int sum = number1 + number2;
//    Console.WriteLine(sum);

//}

//Sum(5, 9);


//bool isMarried = true;
//static void ShowText(string text, int num)
//{
//    Console.WriteLine(text+ "-" +num);
//}

//if (isMarried)
//{
//    Console.WriteLine("Evlidir");
//}

//string str = "Hello P139";
//int number = 55;

//ShowText(str, number);


//static void Login(string username, string password)
//{
//	if (username == "samir555" && password == "Samir123_")
//	{
//        Console.WriteLine("Login successed");
//    }
//    else
//    {
//        Console.WriteLine("Username or password is wrong");
//    }
//}

//Console.WriteLine("Add your username");
//string username= Console.ReadLine();

//Console.WriteLine("Add your password");
//string password= Console.ReadLine();

//Login(username, password);  




//Console.WriteLine("Add first number:");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Add second number:");
//int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("----------------------");

//static void SumNumber(int a, int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//SumNumber(number1, number2);

//                                          ---------------Return Typi olan

////static string ShowName()
////{

////    return "Samir";
////}

////var text = "nese";
////string result = ShowName();
////Console.WriteLine(result);




//static void Sum(int a, int b)
//{
//        Console.WriteLine(a+b);
//}
//Sum(5, 6);



//--------------------2 Reqem gelir toplayib geri qaytaran metod yaz

//static int Sum(int a, int b)
//{
//    return a + b;
//}

//int num1 = 5;
//int num2 = 100;

//int result = Sum(num1, num2);
//Console.WriteLine(result);


//                              ---------Metod parametr olaraq array qebul edir. O arrayin icindeki elementlerin cemini qaytaran metod yazin

//static int GetSumOfNumbersFromArray(int[] numbers)
//{
//    int sum = 0;
//    foreach (int item in numbers)
//    {
//        sum += item;
//    }
//    return sum;
//}

//int[] arr = { 1, 2, 3 };

//int result = GetSumOfNumbersFromArray(arr);

//Console.WriteLine(result);


//string weekDay = "Monday";

//switch (weekDay)
//{
//    case "Saturday":
//        Console.WriteLine("This day is Saturday");
//        break;
//    case "Monday":
//        Console.WriteLine("This day is Monday");
//        break;
//    case "Tuesday":
//        Console.WriteLine("This day is Tuesday");
//        break;
//    case "Sunday":
//        Console.WriteLine("This day is Sunday");
//        break;
//    default:
//        Console.WriteLine("Not found week day");
//        break;





//                                 -------------Heftenin bazar gunu olub-olmamagin yoxlasin

//static bool CheckWeekDayIfSunday(string weekDay)
//{
//    bool isSunday = false;

//    switch (weekDay)
//    {
//        case "Saturday":
//            isSunday = false;
//            break;
//        case "Monday":
//            isSunday = false;
//            break;
//        case "Tuesday":
//            isSunday = false;
//            break;
//        case "Sunday":
//            isSunday = true;
//            break;
//        case "Thrusday":
//            isSunday = false;
//            break;
//        case "Friday":
//            isSunday = false;
//            break;
//        case "Wednesday":
//            isSunday = false;
//            break;

//    }
//    return isSunday;
//}

//bool result = CheckWeekDayIfSunday("Sunday");


//ShowWeekDay(result);

//static void ShowWeekDay(bool isSunday)
//{
//    if (isSunday)
//    {
//        Console.WriteLine("yes, Today is Sunday");
//    }
//    else
//    {
//        Console.WriteLine("no, Today is  not  Sunday");
//    }
//}