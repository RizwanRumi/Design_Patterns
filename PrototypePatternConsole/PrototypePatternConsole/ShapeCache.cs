using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternConsole
{
    public class ShapeCache
    {
        private static Hashtable shapeMap = new Hashtable();

        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = (Shape) shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        // for each shape run database query and create shape
        // shapeMap.Add(shapeKey, shape);
        // for example, we are adding three shapes

        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            Square square = new Square();
            square.setId("2");
            shapeMap.Add(square.getId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}
