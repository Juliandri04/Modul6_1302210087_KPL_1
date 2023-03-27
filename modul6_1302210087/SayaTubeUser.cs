using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;


namespace modul6_1302210087
{
     class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            this.uploadedVideos= new List<SayaTubeVideo>();
            this.id = new Random().Next(10000, 99999);
        }

        public int DetailsVideoPlayCount()
        {
            int jum = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                jum += uploadedVideos[i].getplaycount();
            }
            return jum;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void printallvideoplaycount()
        {
            Console.WriteLine("User : " + this.username);
            for (int i = 0; i < this.uploadedVideos.Count; i++)
            { 
                Console.WriteLine("Video " + (i+1) + " judul: " + this.uploadedVideos[i].gettittle());
            }
        }
    }
}
