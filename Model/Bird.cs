using IYTE_POC.Abstraction;

namespace IYTE_POC.Model;
internal class Bird : Animal, IFlightable
{
	private Bird(string name) : base(name)
	{

	}

	private Bird() : base() { }

	public static Bird BirdWithName(string name)
	{
		return new Bird(name);
	}

	public void Fly()
	{
		Console.WriteLine($"{Name} uçuyor!");
	}

	public override string GetNoise()
	{
		return "cikledi.";
	}
}
