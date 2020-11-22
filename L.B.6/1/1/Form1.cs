using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    
    public partial class Form1 : Form
    {
        public string FileName;
        public string Dir;
        AbstractHandler instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            MessageBox.Show(instance.CreateFile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            textBox1.Text = instance.OpenFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileName = textBox3.Text;
            Dir = textBox2.Text;

            if (FileName.EndsWith(".txt"))
                instance = new TXT(FileName, Dir);
            else if (FileName.EndsWith(".doc"))
                instance = new DOC(FileName, Dir);

            MessageBox.Show(instance.EditFile(textBox1.Text));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
    abstract class AbstractHandler
    {
        public string FileName;
        public string Dir;

        public AbstractHandler(string filename, string dir)
        {
            FileName = filename;
            Dir = dir;
        }
        public abstract string OpenFile();
        public abstract string CreateFile();
        public abstract string EditFile(string text);
    }
    class DOC : AbstractHandler
    {
        public DOC(string filename, string dir) : base(filename, dir)
        {
            FileName = filename;
            Dir = dir;
        }
        public override string CreateFile()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Dir);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream filestream = new FileStream($"{Dir}/{FileName}", FileMode.OpenOrCreate))
            {
                return "Файл успешно создан";
            }
        }

        public override string OpenFile()
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.OpenRead($"{Dir}/{FileName}"))
                {
                    byte[] array = new byte[filestream.Length];
                    filestream.Read(array, 0, array.Length);
                    string text = System.Text.Encoding.Default.GetString(array);
                    return text;
                }
            }
            else
                return "Файл не существует, сначала создайте файл";
        }

        public override string EditFile(string text)
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.Create($"{Dir}/{FileName}"))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    filestream.Write(array, 0, array.Length);
                    return "Файл успешно записан";
                }
            }
            else
                return "Файл не существует, сначала создайте файл";

        }
    }
    class TXT : AbstractHandler
    {
        public TXT(string filename, string dir) : base(filename, dir)
        {
            FileName = filename;
            Dir = dir;
        }
        public override string CreateFile()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Dir);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream filestream = new FileStream($"{Dir}/{FileName}", FileMode.OpenOrCreate))
            {
                return "Файл успешно создан";
            }
        }

        public override string OpenFile()
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.OpenRead($"{Dir}/{FileName}"))
                {
                    byte[] array = new byte[filestream.Length];
                    filestream.Read(array, 0, array.Length);
                    string text = System.Text.Encoding.Default.GetString(array);
                    return text;
                }
            }
            else
                return "Файл не существует, сначала создайте файл";
        }

        public override string EditFile(string text)
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.Create($"{Dir}/{FileName}"))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    filestream.Write(array, 0, array.Length);
                    return "Файл успешно записан";
                }
            }
            else
                return "Файл не существует, сначала создайте файл";

        }
    }
}