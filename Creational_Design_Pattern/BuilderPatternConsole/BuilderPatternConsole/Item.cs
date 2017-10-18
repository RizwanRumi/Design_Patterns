using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public interface Item
    {
        string Name();
        Packing Packing();
        double Price();
    }
}
