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
        public string title;
        private int playCount;

        public SayaTubeVideo(String tube)
        {
            Debug.Assert(tube.Length < 200);
            Debug.Assert(tube != null);
            Random random = new Random();
            this.title = tube;
            this.id = random.Next(10000,99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert (count <= 25000000);
            Debug.Assert(count > 0);
            try
            {
                checked 
                { 
                    this.playCount += playCount; 
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
                
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
