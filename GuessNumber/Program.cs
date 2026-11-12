
// Console.Write("vvedite chislo: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     Console.WriteLine("chislo polozhitelnoe");
// }
// else if (number < 0)
// {
//     Console.WriteLine("chislo otritsatelnoe");
// }
// else
// {
//     Console.WriteLine(" chislo 0");
// }

// Console.Write("vvedite ball (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91)
// {
//     Console.WriteLine("otlichno (5)");
// }
// else if (score >= 71)
// {
//     Console.WriteLine("horoshist(4)");
// }
// else if (score >= 51)
// {
//     Console.WriteLine("udovlet. (3)");
// }
// else
// {
//     Console.WriteLine("neud.");
// }

// Console.Write("vvedi kol-vo posesheniy (iz 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("vvedi sredniy ball po praktike: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendance && goodGrades)
// {
//     Console.WriteLine("+ dopusk k examenu");
// }
// else if (!goodAttendance && goodGrades)
// {
//     Console.WriteLine("- nado otrabotat propuski");
// }
// else if (goodAttendance && !goodGrades)
// {
//     Console.WriteLine("- nizkiy ball, nado peresdat");
// }
// else
// {
//     Console.WriteLine("- problemy vezde, srochno k prepodavatelyu");
// }


Console.Write("vvedite vash vozrast: ");
int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "sovershennoletniy" : "nesovershennoletniy";
Console.WriteLine($"you {ageGroup}");
Console.Write("\nVvedite temperaturu za oknom (C): ");
double temp = double.Parse(Console.ReadLine());
string weather = temp >= 20 ? "teplo" : (temp >= 0 ? "prohladno" : "moroz");
Console.WriteLine($"za oknom {weather}");

Console.Write("\nVvedite chislo: ");
int n = int.Parse(Console.ReadLine());
string parity = n % 2 == 0 ? "chet" : "nechet";
Console.WriteLine($"chislo {n} - {parity}");