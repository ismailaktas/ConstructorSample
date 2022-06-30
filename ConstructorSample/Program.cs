using System;

namespace ConstructorSample
{

    class user
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public user(string defaultName) // Yapıcı metot(Constructor) 1 
        {
            name = defaultName;
            Console.Write("Gonderilen Parametre: " + name);
        }

        public user(string defaultName, string defaultSurname) // Yapıcı metot(Constructor) 2
        {
            name = defaultName;
            surname = defaultSurname;
            Console.Write("Gonderilen Parametre: " + name + " " + surname);
        }

        public user(string defaultName, string defaultSurname, int defaultAge) // Yapıcı metot(Constructor) 3
        {
            name = defaultName;
            surname = defaultSurname;
            age = defaultAge;
            Console.Write("Gonderilen Parametre: " + name + " " + surname + " Yaş: " + age.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            user usr = new user("İsmail", "Aktaş", 40); //Sınıf örneği oluşturulduğunda default değerler gönderilerek Constructor işletilebilir
        }
    }

}
