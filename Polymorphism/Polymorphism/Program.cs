using Polymorphism;

List<Animal> animals = new List<Animal>();


Animal dog = new Dog("Toplan");
Animal cat = new Cat("Mestan");
Animal leon = new Leon("Symba");

Person person = new Person("MirCefer");

Animal animal1 = cat;

//Console.WriteLine(leon.Info());

animals.Add(dog);
animals.Add(cat);
animals.Add(leon);
//animals.Add(person);
foreach (var animal in animals)
{
    animal.Say();
}

//foreach (var animal in animals)
//{
//    Console.WriteLine(animal.Info());
//    //if (animal is Cat)
//    //{
//    //    ((Cat)animal).Jump();
//    //}
//    var newCat = animal as Cat;
//    if (newCat != null)
//    {
//        newCat.Jump();
//    }
//}



