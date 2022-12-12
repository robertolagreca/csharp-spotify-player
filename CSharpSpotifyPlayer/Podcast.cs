using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpotifyPlayer
{
    internal class Podcast : IContenutoRiproducibile
    {
        private string podTitle;

        public Podcast(string podTitle)
        {
            this.podTitle = podTitle;
        }

        public string GetPodcast() { return this.podTitle; }

        public void Play()
        {
            Console.WriteLine("Playing now " + podTitle);
        }

        public void Pause()
        {
            Console.WriteLine("Pause " + podTitle);
        }

        public void Stop()
        {
            Console.WriteLine("Stop " + podTitle);
        }

    }
}
