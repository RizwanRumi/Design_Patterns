using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternConsole
{
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer adVancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                adVancedMusicPlayer = new VlcPlayer();
            }
            else if(audioType.Equals("mp4"))
            {
                adVancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                adVancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                adVancedMusicPlayer.PlayMP4(fileName);
            }
        }
    }
}
