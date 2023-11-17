namespace IYTE_POC.Model;
internal abstract class Animal
{
	public string Name { get; set; }
	public bool IsAlive { get; set; }

	private int age;

	public int Age { 
		get 
		{ 
			return this.age; 
		} 
		set 
		{
			if (value > 0 && value < 100)
			{
				this.age = value;
			}
		} 
	}

	public Animal(string name)
	{
		this.Name = name;
		this.IsAlive = true;
	}

	public Animal()
	{
		this.IsAlive = true;
		this.Name = new Random().Next(0, 100).ToString() + " numaralı";
	}

	public virtual void MakeNoise()
	{
		if (IsAlive)
		{
			Console.WriteLine($"{Name} {GetNoise()}");
		}
		else
		{
			Console.WriteLine($"{Name} sesi çıkmıyor.");
		}
	}

	public abstract string GetNoise();

	public void Dead(string message = null)
	{
		IsAlive = false;
		if(!string.IsNullOrEmpty(message))
		{
			Console.WriteLine($"{this.Name} {message}");
		}
	}
}
