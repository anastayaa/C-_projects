using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace ex6TP3
{
    public partial class Form1 : Form
    {

        List<Thread> threads = new List<Thread>();

        int nbThreadNbPremier=0, nbThreadAnimation=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercice1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Tp3.Program p = new Tp3.Program();
            Process myProcess = new Process();
            try
            {
                //myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = p.returnPath() + "\\Tp3.exe";
                myProcess.StartInfo.CreateNoWindow = true;

                myProcess.Start();

                ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;
                foreach (ProcessThread thread in currentThreads)
                {
                    threadsListListBox.Items.Add(thread.Id);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         */
            if (nbThreadNbPremier < 5)
            {
                Thread t = new Thread(runEx3);
                t.Start();
                threads.Add(t);
                threadsListListBox.Items.Add("Nombre premier: " + (++nbThreadNbPremier));

            }
            else
            {
                MessageBox.Show("impossible");
            }
        }

        private void exercice2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nbThreadAnimation < 5)
            {
                Thread t = new Thread(runEx5);
                t.Start();
                threads.Add(t);
                threadsListListBox.Items.Add("Animation: " + (++nbThreadAnimation));
            }
            else
            {
                MessageBox.Show("impossible");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        public void runEx3()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ex3TP3.Form1());
            //new ex3TP3.Form1().Show();
        }
        public void runEx5()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ex5TP3.Form1());
            //new ex3TP3.Form1().Show();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Thread th in threads)
            {
                if (th.IsAlive)
                {
                    //Monitor.Enter(runEx5);
                    //th.Suspend();
                }
            }
        }

        private void tousLesThreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Thread th in threads)
            {
                if (th.IsAlive)
                {
                    //Monitor.Enter(runEx5);
                    th.Abort();
                }
            }
            threads.Clear();
            threadsListListBox.Items.Clear();
        }

        private void threadSelectioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //threadsListListBox.GetItemText(threadsListListBox.SelectedItem);
            if (threadsListListBox.SelectedItem != null)
            {
                /**
                * Supprimer le thread de la liste box
                **/
                threadsListListBox.Items.Remove(threadsListListBox.SelectedItem);
                /**
                * Supprimer le thread de la liste des threads
                **/
                threads.Remove(threads[threadsListListBox.SelectedIndex-1]);
                /**
                 * Supprimer le thread de l'OS
                 **/
                threads[threadsListListBox.SelectedIndex - 1].Abort();
            }
                

        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.ExitThread();
        }

        //les mutex
        private void reprendreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Thread th in threads)
            {
                if (!th.IsAlive)
                {
                    //th. Resume();
                    //Monitor.Exit(runEx3);
                    //th.Start();
                }
            }
        }
    }
}
