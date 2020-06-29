using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;

namespace SerializationJSON
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender PersonGender { get; set; }

        public string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    
}
