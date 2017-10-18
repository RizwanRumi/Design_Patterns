using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            IShape objShape;

            if (shapeType.Equals("CIRCLE"))
            {
                objShape = new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                objShape = new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                objShape = new Square();
            }
            else
            {
                objShape = null;
            }

            return objShape;
        }
    
    }
}
