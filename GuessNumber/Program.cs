
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


// Console.Write("vvedite vash vozrast: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "sovershennoletniy" : "nesovershennoletniy";
// Console.WriteLine($"you {ageGroup}");
// Console.Write("\nVvedite temperaturu za oknom (C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "teplo" : (temp >= 0 ? "prohladno" : "moroz");
// Console.WriteLine($"za oknom {weather}");

// Console.Write("\nVvedite chislo: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "chet" : "nechet";
// Console.WriteLine($"chislo {n} - {parity}");


// Console.WriteLine("menu");
// Console.WriteLine("1. posmotret raspisanie");
// Console.WriteLine("2. posmotret otsenki");
// Console.WriteLine("3. svyaz s prepodavatelem");
// Console.WriteLine("4. vyiti");
// Console.Write("vyberi punkt (1-4): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1":
//         Console.WriteLine("raspisanie: ISP-242, kab. 1-36, 13:40");
//         break;
//     case "2":
//         Console.WriteLine("vashi otsenki: ISRPO - 34, RPM - 51");
//         break;
//     case "3":
//         Console.WriteLine("Email: prepod@gmail.com");
//         break;
//     case "4":
//         Console.WriteLine("do svidaniya");
//         break;
//     default:
//         Console.WriteLine($"oshibka: punkt {choice} ne sushestvuet. vvedi chislo ot 1 do 4");
//         break;
// }

// Console.Write("\nVvedite nomer dnya nedeli (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("rabochiy den");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("vihodnoy");
//         break;
//     default:
//         Console.WriteLine("takogo dnya net!");
//         break;
// }

// Console.Write("\nVvedi nomer mesyatsa cifroy (1-12): ");
// int monNumber = int.Parse(Console.ReadLine());
// switch (monNumber)
// {
//     case 1:
//     case 2:
//     case 12:
//         Console.WriteLine("zima");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("vesna");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("leto");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("osen");
//         break;
//     default:
//         Console.WriteLine("takogo mesyatsa net!");
//         break;
// }

using System.Reflection.Metadata;

Random random = new Random();
int secret = random.Next(1, 101);
int attempts = 0;
bool guessed = false;
Console.WriteLine("ugaday chislo (1-100)");
Console.WriteLine("ya zagadal chislo, poprobuy ugadat");
string result = attempts <= 7 
    ? $"otlichno! vsego {attempts} popytok" 
    : $"chislo naydeno za {attempts} popytok. mozhno lucshe";
Console.WriteLine($"pravilno! zagadannoe chislo: {secret}");
Console.WriteLine($"{result}");

string GetHint(int difference)
{
    switch (difference)
    {
        case <= 3:
            return "goryacho";
        case <= 10:
            return "teplo";
        case <= 25:
            return "prohladno";
        default:
            return "holodno";
    }
}

while (!guessed)
{
    Console.Write($"popytka {attempts + 1}. tvoy variant: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("!!! vvedi tseloe chislo a ne text");
        continue;
    }
    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("!!! chislo dolzhno byt ot 1 do 100");
        continue;
    }
    attempts++;
    if (guess < secret)
    {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"bolshe! {hint}\n");
    } else if (guess > secret) {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"menshe! {hint}\n");
    } else
    {
        guessed = true;
    }
}