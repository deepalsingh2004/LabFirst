namespace LabFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person
            {
                personId = 1,
                firstName = "Ian",
                lastName = "Brooks",
                favoriteColour = "Red",
                age = 30,
                isWorking = true
            };

            Person person2 = new Person
            {
                personId = 2,
                firstName = "Gina",
                lastName = "James",
                favoriteColour = "Green",
                age = 18,
                isWorking = false
            };

            Person person3 = new Person
            {
                personId = 3,
                firstName = "Mike",
                lastName = "Briscoe",
                favoriteColour = "Blue",
                age = 45,
                isWorking = true
            };

            Person person4 = new Person
            {
                personId = 4,
                firstName = "Mary",
                lastName = "Beals",
                favoriteColour = "Yellow",
                age = 28,
                isWorking = true
            };

            
            Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}'s favorite colour is {person2.favoriteColour}");

            
            Console.WriteLine(person3);

            
            person1.ChangeFavoriteColour();
            Console.WriteLine($"{person1.personId}: {person1.firstName} {person1.lastName}'s favorite colour is: {person1.favoriteColour}");

            
            Console.WriteLine($"{person4.firstName} {person4.lastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            
            Relation relation1 = new Relation { Relationship = Relation.RelationshipType.Sisterhood };
            Relation relation2 = new Relation { Relationship = Relation.RelationshipType.Brotherhood };

            
            relation1.ShowRelationShip(person2, person4); 
            relation2.ShowRelationShip(person1, person3); 



            
            List<Person> peopleList = new List<Person>
                {
                   person1, person2, person3, person4
                };

            
            double averageAge = peopleList.Average(person => person.age);
            Console.WriteLine($"Average age is: {averageAge}");

            
            var youngestPerson = peopleList.OrderBy(person => person.age).First();
            var oldestPerson = peopleList.OrderByDescending(person => person.age).First();

            

            Console.WriteLine($"The youngest person is: {youngestPerson.firstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.firstName}");

            Console.WriteLine(person3);
            Console.WriteLine(person4);
            Console.WriteLine(person3);



            
        }
    }
}
    


    


