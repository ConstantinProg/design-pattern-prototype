using DesignPatternPrototype;

// In this example, the “var” keyword is not used for transparency.

Goblin goblin1 = new Goblin("Goblin Warrior", 50, "Axe");
Goblin goblin2 = goblin1.MyClone();
object goblin3 = goblin1.Clone();

Console.WriteLine("Original Goblin: " + goblin1);
Console.WriteLine("Cloned Goblin (IMyClonable)): " + goblin2);
Console.WriteLine("Cloned Goblin (IClonable)): " + goblin3);

Wolf wolf1 = new Wolf("Dire Wolf", 100, 80);
Wolf wolf2 = wolf1.MyClone();
object wolf3 = wolf1.Clone();

Console.WriteLine("Original Wolf: " + wolf1);
Console.WriteLine("Cloned Wolf (IMyClonable): " + wolf2);
Console.WriteLine("Cloned Wolf (IClonable): " + wolf3);

GoblinWizard wizard1 = new GoblinWizard("Goblin Wizard", 40, "Staff", 120);
GoblinWizard wizard2 = wizard1.MyClone();
object wizard3 = wizard1.Clone();

Console.WriteLine("Original Goblin Wizard: " + wizard1);
Console.WriteLine("Cloned Goblin Wizard (IMyClonable): " + wizard2);
Console.WriteLine("Cloned Goblin Wizard (IClonable): " + wizard3);

GoblinArcher archer1 = new GoblinArcher("Goblin Archer", 45, "Bow", 90);
GoblinArcher archer2 = archer1.MyClone();
object archer3 = archer1.Clone();

Console.WriteLine("Original Goblin Archer: " + archer1);
Console.WriteLine("Cloned Goblin Archer (IMyClonable): " + archer2);
Console.WriteLine("Cloned Goblin Archer (IClonable): " + archer3);
