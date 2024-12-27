namespace DesignPatternPrototype;

public class GoblinArcher : Goblin
{
    public int ArcherySkill { get; set; }

    public GoblinArcher(string name, int health, string weapon, int archerySkill)
        : base(name, health, weapon)
    {
        ArcherySkill = archerySkill;
    }

    public override GoblinArcher MyClone()
        => new GoblinArcher(this.Name, this.Health, this.Weapon, this.ArcherySkill);

    public override string ToString()
        => $"{Name}, Health: {Health}, Weapon: {Weapon}, Archery Skill: {ArcherySkill}";
}
