using System;
namespace Draft_Diamond_BD.Workers
{
    public  class Worker
    {
        internal Guid Id { get; set; } //для работы с бд
        internal string Login {  get; set; }
        internal string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Jobs Job { get; set; }
        public Worker() // для инициализации в бд
        {
            Id = Guid.NewGuid(); 
        }
        public Worker(Guid id,string login,string password,string name,string surname,Jobs job) 
        { 
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Job = job;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} - {Job}";
        }


    }
}
