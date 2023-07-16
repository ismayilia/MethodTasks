
//                   2) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//static void Result(int n)
//{
//    if (n%3 == 0 && n%7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }
//}
//int result = 21;

//Result(result);


//static void Result(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }
//}
//Console.WriteLine("Add number");
//int number = Convert.ToInt32(Console.ReadLine());

//Result(number);

//static bool Nums(int b)
//{
//    if (b % 3 == 0 && b % 7 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//int a = 21;

//if (Nums(a))
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}


//3)  n və m ədədləri verilir. 

//    Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//static void Sum(int n,int m)
//{

//    int sum = 0;
//    if (n%2==0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }  
//}

//Console.WriteLine("add number");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("add number");
//int b = Convert.ToInt32(Console.ReadLine());
//Sum(a, b);




// 4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//static int SingleNumbers()
//{
//    int n = 10;
//    int m = 20;
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}
//Console.WriteLine(SingleNumbers());

//static int SingleNumbers(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//int a = 10;
//int b = 20;
//int result = SingleNumbers(a, b);

//Console.WriteLine(result);



//5) Verilmish arrayin icindeki tek ededlerin cemini tapin.

//static int GetSumOfSingleNumbers(int[] numbers)
//{
//    int sum = 0;
//    foreach (int item in numbers)
//    { 
//        if (item%2==1)
//        sum += item;
//    }
//    return sum;
//}

//int[] nums = { 1, 6, 3,8, 7 };

//int result = GetSumOfSingleNumbers(nums);

//Console.WriteLine(result);



//static int GetSumOfSingleNumbers(int[] numbers)
//{
//    int sum = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] %2==1)
//        {
//            sum += numbers[i];
//        }

//    }
//    return sum;
//}

//int[] nums = { 1, 6, 3, 8, 7 };

//int result = GetSumOfSingleNumbers(nums);

//Console.WriteLine(result);



//6) Verilmish arrayin icindeki cut ededlerin sayini tapin.

//static void GetCountOfNumbers() 
//{
//    int count = 0;
//    int[] arr= { 1, 2, 3,4,6};
//    foreach (var item in arr)
//    {
//        if (item%2==0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}
//GetCountOfNumbers();


//static int GetCount(int[] arr) 
//{ int count = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//		if (arr[i]%2==1)
//		{
//			count++;
//		}
//	}
//	return count;
//}

//int[] num = { 1, 3, 5, 6 };

//int result= GetNum(num);

//Console.WriteLine(result);



//                7) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//static void GetSingleNumbers(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i%2==1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}
//GetSingleNumbers(5,15);

// 8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//static int GetSumOfDoubleNumbers(int n, int m)
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum += i;
//		}
//	}
//	return sum;

//}

//int a = 5;
//int b = 10;

//int result = GetSumOfDoubleNumbers(a, b);
//Console.WriteLine(result);


//9) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//static int GetCountOfDoubleNumbers(int n, int m)
//{

//	int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}
//	return count;
//}
//int a = 5;
//int b = 15;
//int result = GetCountOfDoubleNumbers(a, b);

//Console.WriteLine(result);

//    10) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//static void FindSimpleOrComplexNumbers(int n)
//{


//    int count = 0;

//    if (n <= 0)
//    {
//        Console.WriteLine("Duzgun eded daxil edin");

//    }
//    else if (n == 1)
//    {
//        Console.WriteLine("Ne sadedir nede murekkeb");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }
//        if (count > 2)
//        {
//            Console.WriteLine("Murekkebdir");
//        }
//        else
//        {
//            Console.WriteLine("Sadedir");
//        }

//    }

//}
//Console.WriteLine("Add number");
//int a = Convert.ToInt32(Console.ReadLine());

//FindSimpleOrComplexNumbers(a);

//11)  n ededinin faktorialini hesablamaq.



//static void FindNumberOfFactorial(int n)
//{
	
//	int factorial = 1;
//	for (int i = 1; i <=n; i++)
//	{
//		factorial *= i;
//	}
//    Console.WriteLine(factorial);
	
//}

//Console.Write("Add number: ");
//int a=Convert.ToInt32(Console.ReadLine());

//FindNumberOfFactorial(a);




//static int FindNumberOfFactorial(int n)
//{
//    int factorial = 1;
//        for (int i = 1; i <= n; i++)
//    {
//        factorial *= i;
//    }
//    return factorial;
//}

//int result= FindNumberOfFactorial(5);
//Console.WriteLine(result);






