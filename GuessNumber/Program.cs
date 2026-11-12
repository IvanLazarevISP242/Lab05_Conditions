
Console.Write("vvedite chislo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("chislo polozhitelnoe");
}
else if (number < 0)
{
    Console.WriteLine("chislo otritsatelnoe");
}
else
{
    Console.WriteLine(" chislo 0");
}

Console.Write("vvedite ball (0-100): ");
int score = int.Parse(Console.ReadLine());
if (score >= 91)
{
    Console.WriteLine("otlichno (5)");
}
else if (score >= 71)
{
    Console.WriteLine("horoshist(4)");
}
else if (score >= 51)
{
    Console.WriteLine("udovlet. (3)");
}
else
{
    Console.WriteLine("neud.");
}

Console.Write("vvedi kol-vo posesheniy (iz 19): ");
int attendance = int.Parse(Console.ReadLine());
Console.Write("vvedi sredniy ball po praktike: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14;
bool goodGrades = practiceGpa >= 3.0;
if (goodAttendance && goodGrades)
{
    Console.WriteLine("+ dopusk k examenu");
}
else if (!goodAttendance && goodGrades)
{
    Console.WriteLine("- nado otrabotat propuski");
}
else if (goodAttendance && !goodGrades)
{
    Console.WriteLine("- nizkiy ball, nado peresdat");
}
else
{
    Console.WriteLine("- problemy vezde, srochno k prepodavatelyu");
}
