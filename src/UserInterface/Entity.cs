using System.Collections.Generic;

namespace Ayende.NHibernateQueryAnalyzer.UserInterface
{
    public class Entity
    {
        public Entity()
        {
            Properties = new SortedList<string, string>();
        }
        public Entity(string name)
            : this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public SortedList<string, string> Properties { get; set; }
    }
}