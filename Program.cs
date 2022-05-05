
using LanguagesDuel03JavaVsCsharpStreamsLinqCsharpCode;

/*
 * Z podanej kolekcji osób wyznacz imiona tych, 
 * które posiadają wiek w określonym przedziale.
 */

List<Person>? people = new()
{
    new Person("ADAM", 34),
    new Person("IZA", 21),
    new Person("JAN", 39),
    new Person { Name = "KAMIL", Age = 32 },
    new Person(Name: "EWA", Age: 18)
};

// LINQ - Method Syntax
var names1 = people
    .Where(p => p.HasAgeBetween(30, 39))
    .Select(p => p.Name)
    .Aggregate((n1, n2) => $"{n1}, {n2}");

Console.WriteLine(names1);

// LINQ - Query Syntax
var names = from p in people
            where p.HasAgeBetween(30, 39)
            select p.Name;

var names2 = String.Join(", ", names);
Console.WriteLine(names2);

// LINQ - Mixed Syntax

var names3 = (
    from p in people
    where p.HasAgeBetween(30, 39)
    select p.Name)
    .Aggregate((n1, n2) => $"{n1}, {n2}");

Console.WriteLine(names3);