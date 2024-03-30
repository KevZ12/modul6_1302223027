using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223027
{
    public class SayaTubeVideo
    {
        private int id;
        private string Title;
        private int playCount;



        public SayaTubeVideo(string title)
        {
           
            Random random = new Random();
            this.Title = title;
            this.playCount = 0;
            this.id = random.Next(10000, 100000);
        }
        public void IncreasePlayCount(int playCount)
        {

         

                    this.playCount += playCount;

        }
        public void PrintVideoDetail()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public String getTitle()
        {
            return this.Title;
        }

        public int getPlayCount() {
            return this.playCount;  
        }
    }
}
