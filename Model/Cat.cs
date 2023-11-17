namespace IYTE_POC.Model;
internal class Cat : Animal
{
	public static int CatCount;

	public Cat(string name) : base(name)
	{
		CatCount++;
	}

	public override string GetNoise()
	{
		return "miyavladı!";
	}
}
