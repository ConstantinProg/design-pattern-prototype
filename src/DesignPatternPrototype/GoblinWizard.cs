namespace DesignPatternPrototype;

public class GoblinWizard : Goblin
{
    public int Mana { get; set; }

    public GoblinWizard(string name, int health, string weapon, int mana)
        : base(name, health, weapon)
    {
        Mana = mana;
    }

    public override GoblinWizard MyClone()
        => new GoblinWizard(this.Name, this.Health, this.Weapon, this.Mana);

    public override string ToString()
        => $"{Name}, Health: {Health}, Weapon: {Weapon}, Mana: {Mana}";
}
