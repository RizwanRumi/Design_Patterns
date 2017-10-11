using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            IColor objColor;

            if (colorType.Equals("RED"))
            {
                objColor = new Red();

            }
            else if (colorType.Equals("GREEN"))
            {
                objColor = new Green();

            }
            else if (colorType.Equals("BLUE"))
            {
                objColor = new Blue();
            }
            else
            {
                objColor = null;
            }

            return objColor;
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
