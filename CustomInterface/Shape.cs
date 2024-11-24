﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        protected Shape(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }
        // Единственный виртуальный метод,
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}
