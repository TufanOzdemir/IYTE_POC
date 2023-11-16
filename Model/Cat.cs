namespace IYTE_POC.Model;
internal class Cat : Animal
{
	public static int CatCount;

	public Cat(string name) : base(name)
	{
		CatCount++;
	}

	public void MakeNoise()
	{
		if (isAlive)
		{
			Console.WriteLine($"{name} miyav dedi");
		}
		else
		{
			Console.WriteLine($"{name} sesi çıkmıyor.");
		}
	}
}
