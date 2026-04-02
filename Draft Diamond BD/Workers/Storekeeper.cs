using System;
using Draft_Diamond_BD.HashPassword;
namespace Draft_Diamond_BD.Workers
{
    public class Storekeeper : Worker
    {
        public Storekeeper(string login, string password, string name, string surname)
             : base(login, password, name, surname, Jobs.Storekeeper) 
        {
            Login = login;
            Password = SimpleHash.HashSHA256(password);
            Name = Name;
            Surname = surname;
            Job = Jobs.Storekeeper;
        }
    }
}
