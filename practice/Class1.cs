using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    public interface ICDPlayer
    {
        void Play();
        void Stop();
        void PreviousTrack();
        void NextTrack();
        int CurrentTrack
        {
            get;
        }
    }
    public class CDPlayer : ICDPlayer
    {
        private int currentTrack = 0;
        public void Play()
        {
            Console.WriteLine("启动CD...");
        }
        public void Stop()
        {
            Console.WriteLine("停止CD...");
        }
        public void PreviousTrack()
        {
            Console.WriteLine("前一个音轨...");
            if (currentTrack >= 1) currentTrack--;
        }
        public void NextTrack()
        {
            Console.WriteLine("后一个音轨...");
            currentTrack++;
        }
        public int CurrentTrack
        {
            get
            {
                return currentTrack;
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            /*CDPlayer myCD = new CDPlayer();
            myCD.Play();
            Console.WriteLine("myCD.CurrentTrack={0}",myCD.CurrentTrack);
            myCD.NextTrack();
            myCD.NextTrack();
            Console.WriteLine("myCD.CurrentTrack={0}", myCD.CurrentTrack);
            ICDPlayer myICD = (ICDPlayer)myCD;
            myICD.PreviousTrack();
            Console.WriteLine("myCD.CurrentTrack={0}", myCD.CurrentTrack);
            myICD.Stop();
            Console.ReadKey();*/
            int[] myArray = new int[10];
            int index = 0;

            Console.WriteLine("请输入要插入的值："); 
            
            int value = int.Parse(Console.ReadLine());

            myArray[index] = value; index++;

            Console.WriteLine("值已插入数组中。");

        }

    }
}
