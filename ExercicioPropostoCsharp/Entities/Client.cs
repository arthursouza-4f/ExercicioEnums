using System;

namespace ExercicioPropostoCsharp.Entities
{
    class Client
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return "Client: "
                + Name
                + " "
                + birthDate
                + " - "
                + Email;
        }


    }

}
