﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    interface IPrintable
    {
        void Print();
        void Draw(); // <-- Здесь возможен конфликт имен!
    }

}
