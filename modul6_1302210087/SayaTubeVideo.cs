using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210087
{
     class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;


        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount= 0;
            this.id = new Random().Next(10000, 99999);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Details Video");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Video: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }

        public int getplaycount() { return this.playCount; }
        public string gettittle() { return this.title; }

    }
}
