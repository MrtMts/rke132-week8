string folderPath = @"C:\Users\\Laptop\\Documents\\Programmeerimine";
string heroeFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroeFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] weapon = { "tokk", "tolline laud", "klaviatuur", "lendav kaabu", "bumerang" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrength = heroHP;
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
int villainHp = GetCharacterHP(villain);
int villainStrikeStrength = villainHp;
Console.WriteLine($"Today {villain} ({villainHp} HP) with {villainWeapon} tries to take over the world!");

while(heroHP > 0 && villainHp > 0)
{
    heroHP = heroHP - Hit(villain, villainStrikeStrength);
    villainHp = villainHp - Hit(hero, heroStrikeStrength);
}

Console.WriteLine($"Hero {hero} HP: {hero}");
Console.WriteLine($"Villain {villain} HP: {villainHp}");

if(heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villainHp > 0)
{
    Console.WriteLine($"Dark side wins!");
}
else
{
    Console.WriteLine("Draw!");
}

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if(characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");
    }
    else if(strike == characterHP - 1)
    {
        Console.WriteLine($"{characterName} madde a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }
    return strike;
}






