using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFirst
{
    class Relation
    {
        public enum RelationshipType { Sisterhood, Brotherhood, Motherhood, Fatherhood }

        public RelationshipType Relationship;

        public void ShowRelationShip(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {Relationship}");
        }
    }

    

}
