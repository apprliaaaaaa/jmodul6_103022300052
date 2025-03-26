using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmodul6_103022300052
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideo;
        String username;

        public SayaTubeUser(String username)
        {
            Debug.Assert(username.Length <= 100 && username.Length != null, "Username terlalu panjang");
            this.username = username;
            uploadVideo = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadVideo.Count; i++)
            {
                total += uploadVideo[i].getPlayCount();
            }
            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "inputan video harus memiliki isi");
            Debug.Assert(video.getPlayCount() < int.MaxValue, "Play count melebihi batas");
            uploadVideo.Add(video);
        }

        public void printAllVideoPlayCount()
        {
            for (int i = 0; i < Math.Min(10, uploadVideo.Count); i++)
            {
                Console.WriteLine(uploadVideo[i].getTitle() + " : " + uploadVideo[i].getPlayCount());

            }
        }
    
    }
}
