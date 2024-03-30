using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223116
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String tube)
        {        
            Random random = new Random();
            this.title = tube;
            this.id = random.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += playCount;
                
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Jumlah Pemutaran: {playCount}");
            Console.WriteLine();
        }
    }  
}
