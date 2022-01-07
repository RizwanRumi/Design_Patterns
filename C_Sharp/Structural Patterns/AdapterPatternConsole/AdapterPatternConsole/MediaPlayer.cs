using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternConsole
{
    public interface MediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
