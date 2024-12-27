namespace DesignPatternPrototype;

public class Wolf : Monster
{
    public int Speed { get; set; }

    public Wolf(string name, int health, int speed) : base(name, health)
    {
        Speed = speed;
    }

    public override Wolf MyClone()
        => new Wolf(this.Name, this.Health, this.Speed);

    public override string ToString()
        => $"{Name}, Health: {Health}, Speed: {Speed}";
}
