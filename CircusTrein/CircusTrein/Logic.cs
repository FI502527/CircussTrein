using CircusTrein.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Logic
    {
        public Train LogicTrain(List<Animal> animalList)
        {
            Train train = new Train();
            foreach (Animal animal in animalList)
            {
                for (int i = 0; i < train.Wagons.Count; i++)
                {
                    if (train.Wagons[i].TryAddingAnimal(animal))
                    {
                        break;
                    }
                    else
                    {
                        if (i + 1 == train.Wagons.Count)
                        {
                            train.AddWagon();
                            train.Wagons[i + 1].TryAddingAnimal(animal);
                            break;
                        }
                    }
                }
            }
            return train;
        }
    }
}
