using CircusTrein.Classes;

namespace CircusTrein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.SetDetails(1, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal2 = new Animal();
            animal2.SetDetails(2, CircusTrein.Classes.Type.Carnivore, Size.Small);
            Animal animal3 = new Animal();
            animal3.SetDetails(3, CircusTrein.Classes.Type.Carnivore, Size.Medium);
            Animal animal4 = new Animal();
            animal4.SetDetails(4, CircusTrein.Classes.Type.Carnivore, Size.Large);
            Animal animal5 = new Animal();
            animal5.SetDetails(5, CircusTrein.Classes.Type.Herbivore, Size.Small);
            Animal animal6 = new Animal();
            animal6.SetDetails(6, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal7 = new Animal();
            animal7.SetDetails(7, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal8 = new Animal();
            animal8.SetDetails(8, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal9 = new Animal();
            animal9.SetDetails(9, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal10 = new Animal();
            animal10.SetDetails(10, CircusTrein.Classes.Type.Herbivore, Size.Medium);
            Animal animal11 = new Animal();
            animal11.SetDetails(11, CircusTrein.Classes.Type.Herbivore, Size.Large);

            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);
            animals.Add(animal6);
            animals.Add(animal7);
            animals.Add(animal8);
            animals.Add(animal9);
            animals.Add(animal10);
            animals.Add(animal11);

            Logic logic = new Logic();
            Train train = logic.LogicTrain(animals);
            Console.WriteLine($"Train has {train.Wagons.Count} wagons!");
            int a = 1;
            foreach (Wagon wagon in train.Wagons)
            {
                Console.WriteLine($"Wagon {a} has {wagon.Points} points with the following animals inside:");
                a++;
                foreach(Animal animal in wagon.Animals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }

        }
    }
}