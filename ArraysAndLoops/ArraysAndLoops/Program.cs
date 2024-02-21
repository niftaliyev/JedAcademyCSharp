////1.10 həqiqi ədəddən ibarət massiv daxil edin. massiv elementinin nrçəsinin kəsr hissəsi olmadığını müəyyən edin.   

//double[] numbers = { 1.5, 2.7, 3.1, 4.0, 5.8, 6.2, 7.0, 8.4, 9.0, 10.1 };
//int count = 0;
//foreach (double num in numbers)
//{
//    if (num == Math.Floor(num))
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Number of integers in the array: {count}");



////2   1-dən 200-ə qədər 20 təsadüfi ədəddən ibarət massiv yaradın. Birrəqəmli ədədlərin sayını təyin edin.1 rəqəmlin 2 rəqəmli 3 rəqəmli - ədədlərin faizlə nisbətini tapın

//int[] numbers = new int[20];
//int oneDigitCount = 0, twoDigitCount = 0, threeDigitCount = 0;
//Random rand = new Random();
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = rand.Next(1, 201);
//    if (numbers[i] >= 1 && numbers[i] <= 9)
//    {
//        oneDigitCount++;
//    }
//    else if (numbers[i] >= 10 && numbers[i] <= 99)
//    {
//        twoDigitCount++;
//    }
//    else if (numbers[i] >= 100 && numbers[i] <= 200)
//    {
//        threeDigitCount++;
//    }
//}
//Console.WriteLine($"One-digit: {(float)oneDigitCount / numbers.Length * 100}%");
//Console.WriteLine($"Two-digit: {(float)twoDigitCount / numbers.Length * 100}%");
//Console.WriteLine($"Three-digit: {(float)threeDigitCount / numbers.Length * 100}%");



////3  2 ilə 100 aralığında 20 təsadüfi tam ədəddən ibarət massiv yaradın. Tam ədədlərin sayını qeyd edin , və göstərin

//int[] numbers = new int[20];
//Random rand = new Random();
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = rand.Next(2, 101);
//}

//foreach (int num in numbers)
//{
//    bool isPrime = true;
//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.WriteLine(num);
//    }
//}


//// 4   10 təsadüfi tam ədəddən ibarət massiv yaradın. Massiv elementlərinin sırasını əkdinə dəyişdirin (0-cu element 9-cu ilə, 1-ci element 8-ci ilə dəyişir və s.).

//int[] numbers = new int[10];
//Random rand = new Random();
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = rand.Next();
//}

//Array.Reverse(numbers);
//Console.WriteLine("Reversed array:");
//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}


////5  10 təsadüfi tam ədəddən ibarət massiv yaradın. Qonşu massiv elementlərini dəyişdirin (0-cu element 1 - ci elementlə dəyişir, 3 lə 2 , və s.

//int[] numbers = new int[10];
//Random rand = new Random();
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = rand.Next();
//}

//for (int i = 0; i < numbers.Length - 1; i += 2)
//{
//    int temp = numbers[i];
//    numbers[i] = numbers[i + 1];
//    numbers[i + 1] = temp;
//}
//Console.WriteLine("Swapped array:");
//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}


