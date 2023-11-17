using IYTE_POC.Abstraction;
using IYTE_POC.Model;

// Veterinerler için bir uygulama olsun
// Kedi
// Köpek
// Kuş

List<Animal> animals = new List<Animal>();

Cat c1 = new Cat("Ponçik");
c1.Age = 1;
//c1.MakeNoise();

Cat c2 = new Cat("Tekircan");
c2.Age = 2;
//c2.MakeNoise();

Cat c3 = new Cat("Sarı");
c3.Age = 3;
//c3.MakeNoise();
//Console.WriteLine($"{Cat.CatCount} kedi var.");

Dog d1 = new Dog("Karabaş", false);

Bird b1 = Bird.BirdWithName("Maviş");

//c1.MakeNoise();
//d1.MakeNoise();
//b1.MakeNoise();

var a = new object();

// boxing
Animal animal = new Dog("Akbaş", true);
Animal animal2 = new Cat("taso");
Animal animal3 = Bird.BirdWithName("Sarış");

animals.Add(animal);
animals.Add(animal2);
animals.Add(animal3);
animals.Add(c1);
animals.Add(c2);
animals.Add(c3);
animals.Add(d1);
animals.Add(b1);

FlyBirds(animals);

// --------------------------

static void FlyBirds(List<Animal> animals)
{
	foreach (var item in animals)
	{
		//if (item is IFlightable)
		//{
		//	var flightableObject = (IFlightable)item;
		//	flightableObject.Fly();
		//}
		item.MakeNoise();
	}
}