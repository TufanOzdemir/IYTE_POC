namespace IYTE_POC.Model;
internal class Dog : Animal
{
	public bool isDangerous;

	public Dog(string name, bool isDangerous) : base(name)
	{
		this.isDangerous = isDangerous;
	}

	public void MakeNoise()
	{
		if (isAlive)
		{
			Console.WriteLine($"{name} hav dedi");
		}
		else
		{
			Console.WriteLine($"{name} sesi çıkmıyor.");
		}
	}
}
