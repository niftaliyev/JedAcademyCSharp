//int[] arr = null;
//int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine(arr[4]);
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//int[] arr = new int[5];
//int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//object obj  = null;
//obj = 5;
//Console.WriteLine(obj);
//obj = null;
//Console.WriteLine(obj);
//obj = 88;
//if (obj != null)
//{
//    Console.WriteLine("obj is not null");
//}


//int[] arr = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//DateTime date = DateTime.Now;
//Console.WriteLine(date.Day);
//Random random = new Random();
//int randomNumber = random.Next(3, 10);
//Console.WriteLine("random Number: " + randomNumber);

//int[,] numbers = new int[5,5];
//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//	for (int j = 0; j < numbers.GetLength(1); j++)
//	{
//        Console.WriteLine("\t");
//    }
//} 
//int forExampleLengthInYDirection = 0;
//for (int y = 0; y < numbers.GetLength(0); y++)  
//{
//    for (int x = 0; x < numbers.GetLength(x); x++)
//    {
//        //Console.Write(numbers[y,x] + "\t");
//        forExampleLengthInYDirection++;
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("length y direction = " + forExampleLengthInYDirection);
//const int length = 99;
//int[] arr = new int[] { 11, 20, 31, 40, 50,80 };
//int[] evenCounterArray = new int[length];
//int counter = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 2; j <= arr[i]; j++)
//    {
//        if (arr[j] % 2 == 0)
//        {
//            counter++;
//        }
//    }
//    evenCounterArray[i] = counter;
//    counter = 0;
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"{arr[i]} \t {evenCounterArray[i]}");
//}

//int[] arr = { 1, 2, 3, 4, 5 };
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//int[,] arr7 = new int[5, 5];



//int[,] arr = 
//{ 
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 },
//    { 10, 11, 12 }
//};

////foreach (var item in arr)
////{
////    Console.WriteLine(item);
////}

//Console.WriteLine(arr.Length);
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write($"{arr[i, j]}\t");
//    }
//    Console.WriteLine();
//}

// while , foreach , jagged array's,buble sort,function

// 6,15,8,3,4,2
// 2,3,4,5,6,8,15

//int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9 };

//foreach (int myItem in numbers)
//{
//    if (myItem % 2 == 0)
//    {
//        Console.WriteLine(myItem);
//    }
//}

//int[][] arr =
//{
//    new int [] { 1, 2, 3 },
//    new int [] { 4, 5 },
//    new int [] { 6, 7, 8, 9 },
//    numbers
//};

//foreach (var subArray in arr)
//{
//    foreach (var myItemInSubArray in subArray)
//    {
//        Console.Write($"{myItemInSubArray}\t");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        Console.Write($"{arr[i][j]}\t");
//    }
//    Console.WriteLine();
//}




//int[] arr = { 7, 5, 1, 9, 2,3 };
//Array.Sort(arr);
//Array.Reverse(arr);
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}




using LoopsAndArrays2;

//int[] result = MyFunctions.myFunction();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//string name = MyFunctions.returnStringTest("Kamran");
//Console.WriteLine(name);

int[] arr1 = { 7, 5, 1, 9, 2, 3 };
int[] arr2 = MyFunctions.returnArrayForTest();
int[] newSortArray = MyFunctions.SortAlgorithm(arr2);
//for (int i = 0; i < newSortArray.Length; i++)
//{
//    if (i != 4)
//    {
//        Console.WriteLine(newSortArray[i]);

//    }
//}
//int x = 0;
//foreach (var item in newSortArray)
//{
//    if (item == 7 && x == 0)
//    {
//        Console.WriteLine(item);
//        x++;
//    }

//    else if (item != 7)
//    {
//        Console.WriteLine(item);
//    }
//}





bool turn = true;
int x = 0;

while (turn)
{
    x++;
    Console.WriteLine(x);
    Console.Write("input: ");
    string inputUser = Console.ReadLine();
    if (!checkTurn(inputUser))
    {
        turn = false;
        break;
    }
    //Console.Clear();
}

bool checkTurn(string inputUser)
{
    switch (inputUser)
    {
        case "a":
            return true;
    }
    return false;
}



