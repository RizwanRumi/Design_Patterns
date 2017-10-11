using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternConsole
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void draw();

        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public object Clone()
        {
            Object clone = null;

            try
            {
                clone = this.MemberwiseClone();

            }
            catch (Exception e)
            {
                return e.Message;
            }

            return clone;
        }
    }
}
