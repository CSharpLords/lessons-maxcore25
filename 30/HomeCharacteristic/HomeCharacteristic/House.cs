using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeCharacteristic
{
    class House
    {
        Floor eachFloor = new Floor();
        public int amountOfFloors = 5;
        public int[] floors = {1, 2, 3, 4, 5};
        
        
        public void NumberOfFloor()
        {
            for (int i = 0; i < floors.Length; i++)
            {
                Console.WriteLine("Number of the floor: " + floors[i]);
            }
        }
        public void AllFlats()
        {
            Console.WriteLine("There are: " + (amountOfFloors * eachFloor.amountOfFlats) + " flats");
        }
        FlatMaster flatmaster = new FlatMaster();
        public void FlatOwners()
        {
            Console.WriteLine("There are: " + (amountOfFloors * eachFloor.amountOfFlats * flatmaster.amountOfLivers) + " flat owners");
            flatmaster.BoozerSay();
        }
    }
}
