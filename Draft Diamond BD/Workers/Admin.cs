using Draft_Diamond_BD.HashPassword;
using System;

namespace Draft_Diamond_BD.Workers
{
    public class Admin: Worker
    {
        public Admin (Guid id, string login, string password, string name, string surname)
             : base(id, login, password, name, surname, Jobs.Storekeeper)
        {
            Id = id;
            Login = login;
            Password = SimpleHash.HashSHA256(password); 
            Name = Name;
            Surname = surname;
            Job = Jobs.Administrator;
        }
    }
}
