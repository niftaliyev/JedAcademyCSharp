namespace ClassAndMethods
{
    public static class Program
    {
        public static void Main()
        {
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(2);
            values.Add(3);
            values.Remove(2);
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
            //MyList myList = new MyList();
            //Console.WriteLine(myList.getLength());
            //foreach (var item in myList.getArray())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Car.Model);
            //Car.Model = "BMW";
            //Console.WriteLine(Car.Model);
            //Car.Model = "Opel";
            //Console.WriteLine(Car.Model);


            //Person person = null;
            //Console.WriteLine(person.Name);
            //Console.WriteLine("Test in Program.cs");
            //Person person = new Person();
            //person.PrintTest();
            //Person[] people = new Person[2];
            //Person person1 = new Person();
            //person1.InitializeName("Cemile");
            //person1.InitializeSurname("Mirzayeva");
            //person1.InitializeAge(18);

            //people[0] = person1;
            ////Console.WriteLine($"Name: {person1.Name} Surname: {person1.Surname} Age: {person1.Age}");

            //Person person2 = new Person();
            //person2.InitializeName("MirCafar");
            //person2.InitializeSurname("Rzayev");
            //person2.InitializeAge(17);

            //people[1] = person2;

            //Person person3 = new Person();
            //person3.InitializeName("Fizuli");
            //person3.InitializeSurname("Nermanli");
            //person3.InitializeAge(33);

            //Person[] tempegerPeopleList = new Person[5];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    tempegerPeopleList[i] = people[i];
            //}
            //people = tempegerPeopleList;

            //people[2] = person3;
            ////Console.WriteLine($"Name: {person2.Name} Surname: {person2.Surname} Age: {person2.Age}");

            ////foreach (var person in people)
            ////{
            ////    Console.WriteLine($"Name: {person.Name} Surname: {person.Surname} Age: {person.Age}");

            ////}
            //for (int i = 0; i < people.Length; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine($"Name: {people[i].Name} Surname: {people[i].Surname} Age: {people[i].Age}");

            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }

            //}
        }
    }

}
