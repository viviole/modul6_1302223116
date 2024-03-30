using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223116
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(String user)
        {

        }

        public int GetTotalVideoPlayCount()
        {
            int i = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                i += video.GetPlayCount();
            }
            return i;
        }

        public void AddVideo(SayaTubeVideo videoBaru)
        {
            uploadedVideos.Add(videoBaru);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {Username}");
            Console.WriteLine($"Video 1 judul: {uploadedVideos}");
            Console.WriteLine($"Video 2 judul: {uploadedVideos}");
            Console.WriteLine();
        }
    }   
}
