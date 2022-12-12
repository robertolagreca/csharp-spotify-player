using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpotifyPlayer
{
    internal class Brano : IContenutoRiproducibile
    {
        private string song;

        
        public Brano(string song)
        {
            this.song = song;
        }

        public string GetSong() { return this.song; }

        public void Play()
        {
            Console.WriteLine("Playing now " + song);
        }

        public void Pause()
        {
            Console.WriteLine("Pause " + song);
        }

        public void Stop() 
        {
            Console.WriteLine("Stop " + song);
        }

    }
}
