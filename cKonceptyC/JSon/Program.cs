using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSon
{
    class Program
    {
        static void Main(string[] args)
        {
            var someObject = new JSONExample
            {
                UserName = "Dariusz Wroniak",
                SomeStrings = new List<string> { "a", "b", "c", "d" },
                Value = 5,
            };

            var json = JsonConvert.SerializeObject(someObject);

            Console.WriteLine(json);

            var someOtherObject = JsonConvert.DeserializeObject<JSONExample>(json);
        }
    }
}
