// See https://aka.ms/new-console-template for more information

int heroHealth = 10;
int monsterHealth = 10;

Random atck = new Random();

bool bothAreAlive = true;
bool monsterTurn = false;

while (bothAreAlive) {
    
    int attack = atck.Next(1, 10);

    if (monsterTurn) {
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
        monsterTurn = false;
    }
    else {
        monsterHealth -= attack;
        Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
        monsterTurn = true;
    }

    if (monsterHealth <= 0 || heroHealth <= 0) {
        bothAreAlive = false;
        if (monsterHealth < heroHealth) {
            Console.WriteLine("Hero wins!");
        }
        else {
            Console.WriteLine("Monster wins!");
        }
    }
}