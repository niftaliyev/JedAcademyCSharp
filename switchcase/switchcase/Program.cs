
//Random random = new Random();
//int randomValue = random.Next(5, 100);
//Console.WriteLine(randomValue);
//int secondRandomValue =  random.Next(100, 500);
//Console.WriteLine(secondRandomValue);


// Switch case
int number1 = 20;
int number2 = 0;
char character = '/';

switch (character)
{
    case '+':
        Console.WriteLine(number1+number2);
        break;
    case '-':
        Console.WriteLine(number1 - number2);
        break;
    case '/':
        if(number2 != 0) 
        { 
            Console.WriteLine(number1 / number2);
        }
        else
        {
            Console.WriteLine("Divided By zero");
        }
        break;
    case '*':
        Console.WriteLine(number1 * number2);
        break;
    default:
        break;
}