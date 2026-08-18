using Core;

Creature c = new Creature("some", 10, 5, 6);

Console.WriteLine(c.ID);
Console.WriteLine(c.Name);
c.TakeDamage(8);
Console.WriteLine(c.Health);
c.TakeDamage(11);
Console.WriteLine(c.Health);