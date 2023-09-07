//generator trzech losowych liczb - gra

Random dice2 = new Random();

int roll4 = dice2.Next(1,7);
int roll5 = dice2.Next(1,7);
int roll6 = dice2.Next(1,7);

int total = roll4 + roll5 + roll6;

Console.WriteLine($"Dice roll: {roll4} + {roll5} + {roll6} = {total}");

//"Jeśli jakiekolwiek dwie kostki przerzucisz wynik w tej samej wartości, otrzymasz dwa punkty bonusowe dla rolki podwójnej"
if ((roll4 == roll5) || (roll5 == roll6) || (roll4 == roll6))
{
    //"Jeśli wszystkie trzy kostki rzutują wynik w tej samej wartości, otrzymasz sześć dodatkowych punktów za kroczenie potrójne"
    if ((roll4 == roll5) && (roll5 == roll6))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
//"przyznawanie nagród za konkretny wynik"

if (total == 18)
{
    Console.WriteLine("You win a new car!");
}
else if (total == 16)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 17)
{
    Console.WriteLine("You win a trip for two!");
}
else if (total < 15)
{
    Console.WriteLine("You win a kitten!");
}

//"wygrywa suma oczek 15 lub wyżej"
if (total >= 15)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry, You lose.");
}



