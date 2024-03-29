﻿using System;

namespace Section9_Composition_Exercicse.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return string.Format($"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}");
        }
    }
}
