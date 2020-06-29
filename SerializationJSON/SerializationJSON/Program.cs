using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;


namespace SerializationJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person()
            {
                Name = "John",
                Age = 83,
                BirthDate = new DateTime(1937, 6, 21),
                PersonGender = Gender.Male
            };

            var tempJSON = john.Serialize();
            Console.WriteLine(tempJSON);

            Person john2 = JsonSerializer.Deserialize<Person>(tempJSON);
            Console.WriteLine($"John2 name: {john2.Name}; John2 age: {john2.Age} John2 gender: {john2.PersonGender}...");

        }

    }
}
