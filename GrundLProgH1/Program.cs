Person p = new("Niels", "Olesen", new DateTime(1971, 2, 23));
Console.WriteLine(p.GetFullName());
Console.WriteLine(p.BirthDateInDanishFormat);
Console.WriteLine(p.Age);
Console.WriteLine(p.TimeSpanInTotalDays);

Person p2 = new();
Console.WriteLine(p2.GetFullName());
