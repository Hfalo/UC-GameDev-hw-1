string hero = "Link";
int health = 100;

int Damaged_health = health - 20;
int Boosted_health = health - 10;

Console.WriteLine("Damaged health : " + Damaged_health);
Console.WriteLine("Boosted health : " + Boosted_health);

Console.WriteLine(Damaged_health + " is less than " + Boosted_health);