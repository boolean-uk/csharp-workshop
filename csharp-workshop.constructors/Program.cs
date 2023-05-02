using csharp_workshop.constructors.Car;
using csharp_workshop.constructors.Person;

/*
Person person1 = new Person("Nigel");
Person person2 = new Person("Keith");
Person person3 = new Person();
person3.Name = "Bridget";
*/


//uses the engine constructor
Engine engine = new Engine("Automatic Gearbox Engine");
Car beetle = new Car(engine);

//uses the string constructor on car
Car mini = new Car("Manual Gearbox Engine");
Console.WriteLine(mini.Engine.EngineType);

Console.ReadLine();



