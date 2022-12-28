using RecordType;

var yakup = new PersonRecord("Yakup", new DateOnly(2000, 1, 1));
var yakup2 = new PersonRecord("Yakup", new DateOnly(2000, 1, 1));

var yakupOlder = yakup with { DateOfBirth = new DateOnly(1999, 1, 1) };

var (name, dateOfBirth) = yakup;
Console.WriteLine($"{name} {dateOfBirth}");

Console.WriteLine(yakup);
Console.WriteLine(yakupOlder);

Console.WriteLine(yakup == yakup2);

var yakupClass = new PersonClass()
{
    FullName = "Yakup",
    DateOfBirth = new DateOnly(2000, 1, 1)
};

var yakupClass2 = new PersonClass()
{
    FullName = "Yakup",
    DateOfBirth = new DateOnly(2000, 1, 1)
};

Console.WriteLine(yakupClass == yakupClass2);