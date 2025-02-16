using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public PointDescription description = new PointDescription();

        public Point (int x, int y, string PetName) {  X = x; Y = y; description.PetName = PetName; }
        public Point (int x, int y) {  X = x; Y = y; }
        public Point() { }

        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {description.PetName}; ID = {description.PointId}";
        }

        public object Clone() 
        {
            Point newPoint = (Point)this.MemberwiseClone();

            PointDescription currentDescription = new PointDescription();

            currentDescription.PetName = this.description.PetName;

            newPoint.description = currentDescription;

            return newPoint;
        
        }
    }
}
