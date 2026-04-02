using Draft_Diamond_BD.HashPassword;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace Draft_Diamond_BD.Workers
{
    public  class Worker
    {
        public Guid Id { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Jobs Job { get; set; }
        public Worker() 
        {
            Id = Guid.NewGuid(); 
        }
        public Worker(string login,string password,string name,string surname,Jobs job) 
        { 
            Id = Guid.NewGuid();
            Login = login;
            Password = SimpleHash.HashSHA256(password);
            Name = name;
            Surname = surname;
            Job = job;
        }
        /// <summary>
        /// Метод для выведения информации о рабочем 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Surname} - {Job}";
        }


    }
}
