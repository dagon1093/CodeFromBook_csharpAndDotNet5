using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    internal class Car : IComparable
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int CarID { get; set; }
        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            CarID = id;
            PetName = name;
        }
        int IComparable.CompareTo(object? obj)
        {
            if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            throw new ArgumentException("Parameter is not a car");
        }
    }
}
