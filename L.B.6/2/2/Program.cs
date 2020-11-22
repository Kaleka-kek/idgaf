using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using _2;

namespace _2
{
    interface IMedia
    {
        void Play();
        void Pause();
        void Stop();

    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class PlayerItem
    {
        public void Scan()
        {
            Console.WriteLine("Введите путь");
            var path = Console.ReadLine();
            int i = 0;
            int pos;
            List<String> mp3 = new List<string>();
            foreach (var file in (Directory.EnumerateFiles(path,"*.mp3")))
            {
                FileInfo name = new FileInfo(file);
                mp3.Add(name.Name);
                Console.WriteLine(mp3[i]);
                i++;
            }
            List<String> mkv = new List<string>();
            foreach (string file in (Directory.EnumerateFiles(path, "*.mkv")))
            {
                FileInfo name = new FileInfo(file);
                mkv.Add(name.Name);
                Console.WriteLine(mkv[i]);
                i++;
            }
            List<String> wav = new List<string>();
            foreach (string file in (Directory.EnumerateFiles(path, "*.wav")))
            {
                FileInfo name = new FileInfo(file);
                wav.Add(name.Name);
                Console.WriteLine(wav[i]);
                i++;
            }
            Console.WriteLine("Выберите формат файла(mp3,mkv,wav):");
            string Pname = Console.ReadLine();
            if (Pname == "mp3")
            {
                PMp3 pMp3 = new PMp3();
                Console.WriteLine("Выберите файл(номер)");
                pos = Int32.Parse(Console.ReadLine());
                pos -= 1;
                Console.WriteLine("Выбран файл"+mp3[pos]);
                Console.WriteLine("Record,Pause or Stop");
                string Action = Console.ReadLine();
                if (Action == "Record")
                {
                    pMp3.Record();
                }
                if (Action == "Pause")
                {
                    pMp3.Pause();
                }
                if (Action == "Stop")
                {
                    pMp3.Stop();
                }
            }
            if (Pname == "mkv")
            {
                PMkv pMkv = new PMkv();
                Console.WriteLine("Выберите файл(номер)");
                pos = Int32.Parse(Console.ReadLine());
                pos -= 1;
                Console.WriteLine("Выбран файл" + mkv[pos]);
                Console.WriteLine("Record,Pause or Stop");
                string Action = Console.ReadLine();
                if (Action == "Record")
                {
                    pMkv.Play();
                }
                if (Action == "Pause")
                {
                    pMkv.Pause();
                }
                if (Action == "Stop")
                {
                    pMkv.Stop();
                }
            }
            if (Pname == "wav")
            {
                PWav pWav = new PWav();
                Console.WriteLine("Выберите файл(номер)");
                pos = Int32.Parse(Console.ReadLine());
                pos -= 1;
                Console.WriteLine("Выбран файл" + wav[pos]);
                Console.WriteLine("Record,Pause or Stop");
                string Action = Console.ReadLine();
                if (Action == "Record")
                {
                    pWav.Play();
                }
                if (Action == "Pause")
                {
                    pWav.Pause();
                }
                if (Action == "Stop")
                {
                    pWav.Stop();
                }
            }
        }
    }
    class PMp3 : IRecordable
    {
        public void Record()
        {
            Console.WriteLine("Recording...");
        }

        public void Pause()
        {
            Console.WriteLine("Pause...");
        }
        public void Stop()
        {
            Console.WriteLine("Stop...");
        }
    }
    class PMkv: IPlayable

    {
    public void Play()
    {
        Console.WriteLine("Play...");
    }

    public void Pause()
    {
        Console.WriteLine("Pause...");
    }

    public void Stop()
    {
        Console.WriteLine("Stop...");
    }
    }
}
class PWav: IMedia
{
        public void Play()
        {
            Console.WriteLine("Play...");
        }
        public void Pause()
        {
            Console.WriteLine("Pause...");
        }
        public void Stop()
        {
            Console.WriteLine("Stop...");
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            
            PlayerItem playerItem = new PlayerItem();
            playerItem.Scan();
            Console.ReadKey();
        }
    }

