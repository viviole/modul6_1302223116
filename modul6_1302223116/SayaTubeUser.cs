using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223116
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(String user)
        {
            Debug.Assert(user != null);
            Debug.Assert(user.Length <= 10000);
            Random random = new Random();
            this.Username = user;
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
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
            Debug.Assert(videoBaru != null);
            Debug.Assert(videoBaru.GetPlayCount() < int.MaxValue);
            uploadedVideos.Add(videoBaru);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 1; i < uploadedVideos.Count || i < 8; i++)
            {
                Console.WriteLine($"Video {i} judul: {uploadedVideos[i].title} {uploadedVideos[i].GetPlayCount()}");
            }            
            Console.WriteLine();
        }
    }   
}
