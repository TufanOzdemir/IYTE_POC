namespace IYTE_POC.Model;
internal class Animal
{
	public string name;
	public int age;
	public bool isAlive;

	public Animal(string name)
	{
		this.name = name;
		this.isAlive = true;
	}

	public void MakeNoise()
	{
		if (isAlive)
		{
			Console.WriteLine($"{name} ses çıkardı.");
		}
		else
		{
			Console.WriteLine($"{name} sesi çıkmıyor.");
		}
	}
}
