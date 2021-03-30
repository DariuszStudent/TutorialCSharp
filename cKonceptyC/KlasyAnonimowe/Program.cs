using System;
using System.Collections.Generic;
using System.Linq;

namespace KlasyAnonimowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var a = new                          // tak tworzymy klase anonimową
            {
                VaueOfSomething = 5,
                ValueOfSomething = "dsadsa"
            };*/

            var listOfInts = new List<int> { 2, 4, 5, 1, 10, 15 };
            var listOfStrings = new List<string> { "cos", "tam", "jest", "fajnego" };

            var listOfUsers = new List<User>
            {
                new User
                {
                    Name = "Darek",
                    Age = 34,
                    Email = "dfkjd@kfjd.com"
                },
                new User
                {
                    Name = "Marek",
                    Age = 21,
                    Email = "dsdsdsdfkjd@kfjd.com"
                },
                new User
                {
                    Name = "Wiesiek",
                    Age = 15,
                    Email = "aaaaaaa@kfjd.com"
                },
            };

            var someInts = listOfInts.Where(x => x > 5).ToList();

            someInts.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(listOfInts.Where(x => x > 5).Average());

            Console.WriteLine(listOfUsers.Average(x => x.Age));

            Console.WriteLine(listOfInts.FirstOrDefault(x => x > 5));   // pierwszy element, jeśli nie ma, to złapie da nam null, przy int 0 First jeśli nie ma, wywali nam błąd

            Console.WriteLine(listOfInts.Where(x => x > 5).Skip(1).FirstOrDefault());

            var someStrings = listOfStrings.Skip(1).Take(2).ToList();
            someStrings.ForEach(x => Console.WriteLine(x));

            var intsConverterToStrings = listOfInts.Select(x => x.ToString()).ToList();

            var strings = listOfStrings.Select(x => x + " : costam").ToList();

            strings.ForEach(x => Console.WriteLine(x));

            var viewModels = listOfUsers
                .Select(x => new
                {
                    UserData = x,
                    Title = GetUserTitle(x.Age),
                })
                .Select(x => new UserViewModel
                {
                    Age = x.UserData.Age,
                    Email = x.UserData.Email,
                    Name = x.UserData.Name,
                    Title = x.Title,
                }).ToList();
        }

        private static string GetUserTitle(int userAge)
            => userAge > 22 ? "Jeśli tak: Title1" : "Jeśli nie: NoTitle";
    }
}
