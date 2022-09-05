// See https://aka.ms/new-console-template for more information

using SchoolBag.Repos;

var repo = new SchoolBagsRepo();

repo.SchoolBags.ForEach(Console.WriteLine);