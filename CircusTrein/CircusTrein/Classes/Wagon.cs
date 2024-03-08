using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Wagon
    {
        public List<Animal> Animals { get; private set; }
        public int Points { get; private set; }
        public Wagon() 
        {
            Points = 0;
            Animals = new List<Animal> { };
        }
        public bool TryAddingAnimal(Animal animal)
        {
            bool test1 = IsThereSpace(Points, animal.GetPoints());
            bool test2 = animal.SafetyCheck(Animals);
            if(test1 && test2)
            {
                Animals.Add(animal);
                Points = Points + animal.GetPoints();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsThereSpace(int wagonPoints, int animalPoints)
        {
            return wagonPoints + animalPoints <= 10;
        }
    }
}
