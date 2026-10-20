

Sword Suki = new Sword("Cherry", 3);
Suki.Kill();
Bow Blue = new Bow("Melon", 4);
Blue.Kill();
public abstract class Weapon
{
    public string Smith { get; set; }
    public int Weight { get; set; }
    public Weapon(string _smith, int _weight)
    {
        Smith = _smith;
        Weight = _weight;
    }
    public abstract void Kill();    // abstract methodun govdesi olmaz
    // sadece (); yazilir birakilir
}
public class Sword : Weapon
{
    public Sword(string _smith, int _weight) : base(_smith, _weight) { }
    public override void Kill()
    {
        Console.WriteLine($"You have been killed by a sword crafted by  {this.Smith}");
    }
}
public class Bow : Weapon
{
    public Bow(string _smith, int _weight) : base(_smith, _weight) { } // constructor
    public override void Kill()
    {
        Console.WriteLine($"You have been killed by a bow that weights only {this.Weight} kg");
    }
}