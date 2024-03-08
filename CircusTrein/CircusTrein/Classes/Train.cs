using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();
        public Train()
        {
            Wagons.Add(new Wagon());
        }
        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            Wagons.Add(wagon);
        }
    }
}
