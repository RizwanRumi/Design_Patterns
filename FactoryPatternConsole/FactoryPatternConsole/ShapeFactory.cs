using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternConsole
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            IShape objShape = null; 

            if (shapeType.Equals("CIRCLE"))
            {
                objShape =  new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                objShape = new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                objShape =  new Square();
            }

            return objShape;
            
        }
    }
}
