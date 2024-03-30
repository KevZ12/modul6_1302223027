using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title.Length < 200);
            Debug.Assert(!string.IsNullOrEmpty(title));

            Random random = new Random();
            this.Title = title;
            this.playCount = 0;
            this.id = random.Next(10000, 100000);
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount>0 && playCount <= 25_000_000);

            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            } catch (Exception ex) 
            {
                
                Console.WriteLine(ex.Message);
            }

           

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
