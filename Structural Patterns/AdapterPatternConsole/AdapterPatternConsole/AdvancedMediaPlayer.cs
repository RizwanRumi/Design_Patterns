using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternConsole
{
    public interface AdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMP4(string fileName);
    }
}
