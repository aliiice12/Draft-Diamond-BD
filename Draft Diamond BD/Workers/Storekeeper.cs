using System;

namespace Draft_Diamond_BD.Workers
{
    public class Storekeeper : Worker
    {

        public Storekeeper(Guid id,string login, string password, string name, string surname)
             : base(id,login, password, name, surname, Jobs.Кладовщик) 
        { 
            Id = Guid.NewGuid();
        }
       
        public override string ToString()
        {
            return $"login - {Login}, password - {Password}, name - {Name}, surname - {Surname}, job - Кладовщик";
        }

    }
}
