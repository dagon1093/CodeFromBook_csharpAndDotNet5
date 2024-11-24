using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // Поведение "наличия вершин" в виде свойства только для чтения,
    public interface IPointy
    {
        // Неявно public и abstract.
        // byte GetNumberOfPoints();
        // Свойство, поддерживающее чтение и запись,
        // в интерфейсе может выглядеть так:
        // string PropName { get; set; }
        // Тогда как свойство только для записи - так:
        byte Points { get; }
    }

}
