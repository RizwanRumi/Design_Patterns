using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternConsole
{
    class Program
    {
        /// <summary>
        /// Structural Design Patterns
        /// </summary>
        /// <param name="args">Adapter Pattern</param>

        /*
         * Adapter pattern works as a bridge between two incompatible interfaces.
         * This pattern involves a single class which is responsible to join functionalities of independent or incompatible interfaces.
         * Card reader is a adapter between Memory card and Laptop.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern:\n");

            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");

            Console.ReadLine();
        }
    }
}
