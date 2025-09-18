using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasics_T101
{
    public partial class CountChar : Form
    {
        public CountChar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txProcessText.Text = "Work Started.";
            // 1. Simple way
            txProcessText.Text = "Char count :" + CountCharMethod().ToString();
        }

        public int CountCharMethod()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\db\x.txt"))
            {
                string content = reader.ReadToEnd();
                count += content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // 2. Simple way using Async
            txProcessText.Text = "Work Started.";
            Task<int> myTask = new Task<int>(CountCharMethod);
            myTask.Start();
            int chrs = await myTask;
            txProcessText.Text = "Char count :" + chrs.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3. Using Thread but it blocks the main thread
            txProcessText.Text = "Work Started.";
            int chrs = 0;
            Thread th = new Thread( () => {
                chrs = CountCharMethod(); 
            });
            th.Start();

            th.Join();
            txProcessText.Text = "Char count :" + chrs.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4. Using Thread with no blocks to main thread
            txProcessText.Text = "Work Started.";
            int chrs = 0;
            Thread th = new Thread(() => {
                chrs = CountCharMethod();
                Action action = () =>
                {
                    txProcessText.Text = "Char count :" + chrs.ToString();
                };
                // UI related changes must done by UI thread only
                this.BeginInvoke(action);
            });
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5. Using Thread with no blocks to main thread and function in main thread
            txProcessText.Text = "Work Started.";
            Thread th = new Thread(() => {
                noOfChar = CountCharMethod();
                Action action = new Action(SetText);
                // UI related changes must done by UI thread only
                this.BeginInvoke(action);
            });
            th.Start();
        }

        public int noOfChar { get; set; }
        private void SetText()
        {
            txProcessText.Text = "Char count :" + noOfChar.ToString();
        }
    }
}
