using IYTE_POC.Model;

// Veterinerler için bir uygulama olsun
// Kedi
// Köpek
// Kuş

Cat c1 = new Cat("Ponçik");
c1.age = 1;
//c1.MakeNoise();

Cat c2 = new Cat("Tekircan");
c2.age = 2;
//c2.MakeNoise();

Cat c3 = new Cat("Sarı")
{
	age = 3
};
//c3.MakeNoise();
//Console.WriteLine($"{Cat.CatCount} kedi var.");

Dog d1 = new Dog("Karabaş", false)
{
	age = 4
};

Bird b1 = new Bird("Maviş")
{
	age = 4
};

//c1.MakeNoise();
//d1.MakeNoise();
//b1.MakeNoise();

var a = new object();

// boxing
Animal animal = new Dog("Akbaş", true);
Animal animal2 = new Cat("taso");
Animal animal3 = new Bird("Sarış");

// unboxing
if (animal2 is Dog)
{
	var dog = (Dog)animal;
	dog.isDangerous = true;
}