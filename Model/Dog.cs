namespace IYTE_POC.Model;
internal class Dog : Animal
{
	public bool isDangerous;

	public Dog(string name, bool isDangerous) : base(name)
	{
		this.isDangerous = isDangerous;
	}

	public override string GetNoise()
	{
		return "havladı!";
	}
}
