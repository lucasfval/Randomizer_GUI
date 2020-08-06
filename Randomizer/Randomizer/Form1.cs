using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Randomizer
{
    public partial class Form1 : Form
    {

        List<string> listFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            saveButton.Enabled = false;
            discardButton.Enabled = false;
            randomButton.Enabled = false;
        }


        string[] line = { };
        List<string> lines = new List<string>();
        string path;
        string path2;
        string actual;
        public void deleteString(string path, string actual, List<string> lines)
        {
            File.Delete(path);// Deleting the file
            using (StreamWriter sw = File.AppendText(path))

            {
                foreach (string line in lines)
                {
                    if (line.IndexOf(actual) >= 0)
                    {
                        //Skip the line
                        continue;
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            lines.Remove(actual);
        }

        public int countFile(string path)
        {
            string[] count = File.ReadAllLines(path);
            return count.Length;
        }

        public string randomizeLink(List<string> lines)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, lines.Count);
            return lines[num];
        }

        public void writeNewFile(string path, string actual, List<string> lines)
        {
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(actual);
            }
           
        }

        public void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            actual = randomizeLink(lines);
            OpenUrl(actual);
            saveButton.Enabled = true;
            discardButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            writeNewFile(destinyBox.Text, actual,lines);
            saveButton.Enabled = false;
            discardButton.Enabled = false;
            randomButton.Enabled = true;
            countOut.Text = countFile(destinyBox.Text).ToString();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            deleteString(originBox.Text, actual, lines);
            saveButton.Enabled = false;
            discardButton.Enabled = false;
            randomButton.Enabled = true;
            countIn.Text = countFile(originBox.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originBox.Text = openFileDialog1.FileName;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            path = originBox.Text;
            path2 = destinyBox.Text;
            randomButton.Enabled = true;
            line = File.ReadAllLines(path);
            lines = line.ToList<string>();
            countIn.Text = countFile(originBox.Text).ToString();
            countOut.Text = countFile(destinyBox.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                destinyBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
