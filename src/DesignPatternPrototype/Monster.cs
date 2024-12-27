namespace DesignPatternPrototype;

public class Monster : IMyCloneable<Monster>, ICloneable
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Monster(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual Monster MyClone()
        => new Monster(this.Name, this.Health);

    public virtual object Clone()
        => this.MyClone();

    public override string ToString()
        => $"{Name}, Health: {Health}";
}
