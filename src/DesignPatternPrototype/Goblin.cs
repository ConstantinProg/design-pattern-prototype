namespace DesignPatternPrototype;

public class Goblin : Monster
{
    public string Weapon { get; set; }

    public Goblin(string name, int health, string weapon)
        : base(name, health)
    {
        Weapon = weapon;
    }

    public override Goblin MyClone()
        => new Goblin(this.Name, this.Health, this.Weapon);

    public override string ToString()
        => $"{Name}, Health: {Health}, Weapon: {Weapon}";
}
