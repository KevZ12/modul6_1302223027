using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223027
{
    public class SayaTubeUser
    {
        private int id;
        private List <SayaTubeVideo> uploadedVideos;
        private string userName;
       public  SayaTubeUser(string userName)
        {
            Debug.Assert(userName.Length < 100);
            Debug.Assert(!string.IsNullOrEmpty(userName));
            this.userName = userName;  
            uploadedVideos = new List<SayaTubeVideo>();
            Random random = new Random();
            this.id = random.Next(10000, 100000);

        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += this.uploadedVideos[i].getPlayCount();
            }

            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null);
            Debug.Assert(video.getPlayCount()<int.MaxValue);
            uploadedVideos.Add(video); 
        }

        public void printAllVideoPlayCount()
            
        {
            Console.WriteLine("user name: " + this.userName);
            for (int i = 0; i < uploadedVideos.Count ; i++)
            {

                Console.WriteLine("video "+(i+1)+" "+this.uploadedVideos[i].getTitle());
                Console.WriteLine("play count: " + this.uploadedVideos[i].getPlayCount());
                Debug.Assert(i < 7,"lebih dari 8");
            }
        }
    }
}
