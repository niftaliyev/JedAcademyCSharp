using ClassLibrary;
using Inheritance2;

public class Program
{
    public static void Main()
    {

        object cat = new Cat("Mestan", 2, 9);
        Cat cat2 = new Cat("Barsik", 5, 9);


        Dog dog = new Dog(age: 5, weight: 20, name: "Toplan");


        ((Animal)cat).Info();
        dog.Info();
        cat2.Info();



        TestData testData = new TestData();
        testData.Name = "Anur";
        testData.Age = 18;

        Console.WriteLine(testData.ToString());
        //Console.WriteLine(testData.GetHashCode());

        //TestData testData2 = new TestData();
        //testData2.Name = "Anur";
        //testData2.Age = 18;

        //Console.WriteLine(testData2.ToString());
        //Console.WriteLine(testData2.GetHashCode());
        //Console.WriteLine(testData.Equals(testData2));


    }
}