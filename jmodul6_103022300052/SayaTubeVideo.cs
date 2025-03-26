using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace jmodul6_103022300052
{
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Debug.Assert(title.Length <= 200 && title.Length != null, "Judul terlalu panjang");
            Random rdm = new Random();
            this.id = rdm.Next(1000, 9999);
            this.title = title;
            this.playCount = 0;
        }

        //public void IncreasePlayCount(int playCount)
        //{
        //    if (playCount < 0 || playCount > 25000000)
        //    {
        //        throw new ArgumentOutOfRangeException("Play count harus lebih dari 0 dan tidak boleh lebih dari 25 juta!");
        //    }
        //    checked
        //    {
        //        this.playCount += playCount;
        //    }
        //}

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0, "Penambahan play count harus lebih dari 0!");
            Debug.Assert(count <= 10000000, "Penambahan play count tida boleh lebih dari 25 juta!");

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas integer.");
            }
        }


        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
