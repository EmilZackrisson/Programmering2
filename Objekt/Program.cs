// See https://aka.ms/new-console-template for more information
using Objekt;

Console.WriteLine("Hello, World!");

Person nyAnvändare = new Person();
nyAnvändare.förnamn = "Kalle";
nyAnvändare.efternamn = "Svensson";
nyAnvändare.telefon = "2323545";

Person user2 = new Person() { förnamn = "Kalle", efternamn = "Svensson", telefon = "234234" };
