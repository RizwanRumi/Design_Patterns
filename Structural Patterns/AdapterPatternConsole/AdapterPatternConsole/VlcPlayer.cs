using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternConsole
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
           // throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}
