using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;

namespace HilosProy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread hilo1, hilo2, hilo3, hilo4;
        bool hilo1Ini = false;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (hilo2 == null || !hilo2.IsAlive) 
            {
                hilo2 = new Thread(() =>
                {
                    Thread.Sleep(3000); 
                    Invoke((MethodInvoker)(() => label2.Text = "Hilo 2"));
                    if (hilo1 != null && hilo1.ThreadState == ThreadState.Stopped)
                    {
                        hilo1 = null;
                        Invoke((MethodInvoker)(() => label1.Text = ""));
                    }
                    else if (hilo1 != null && hilo1.ThreadState == ThreadState.Suspended)
                    {
                        hilo1.Resume(); 
                        hilo1 = null;   
                        Invoke((MethodInvoker)(() => label1.Text = ""));
                    }
                });

                hilo2.Start();
            }
            else
            {
                
                MessageBox.Show("Hilo 2 ya está en ejecución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (hilo3 == null)
            {
                hilo3 = new Thread(() =>
                {
                    Thread.CurrentThread.Suspend();

                    label3.Text = "Hilo 3";

                    Thread.Sleep(5000);
                    Application.Exit();
                });

                hilo3.Start();
            }
            else
            {

                MessageBox.Show("Hilo 3 ya está en ejecución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {if(hilo3 == null)
            {
                MessageBox.Show("Inicie el Hilo 3", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hilo4 == null )
            {
                hilo4 = new Thread(() =>
                {
                    Thread.Sleep(5000);
                    label4.Text = "Hilo 4";

                    if (hilo3 != null && hilo3.ThreadState == ThreadState.Suspended)
                    {
                        hilo3.Resume();
                    }
                });

                hilo4.Start();
            }
            else
            {

                MessageBox.Show("Hilo 4 ya está en ejecución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (hilo1 == null)
            {
                hilo1 = new Thread(() =>
                {
                    
                        Int64 x, y = 0;
                        for (x = 1; x <= 300000; x++)
                        {
                            y += x;

                            if (x == 1)
                            {
                                Thread.CurrentThread.Suspend(); // Suspender después de la primera iteración
                            }
                        }
                        Invoke((MethodInvoker)(() => label1.Text = y.ToString()));
                    
                    
                });

                hilo1.Start();
            }
            else if (hilo1.ThreadState == ThreadState.Suspended)
            {
                hilo1.Resume(); // Reanuda si está suspendido
            }
            else
            {

                MessageBox.Show("Hilo 1 ya está en ejecución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((hilo1 != null && hilo1.IsAlive && hilo1.ThreadState == ThreadState.Suspended) ||
                (hilo2 != null && hilo2.IsAlive && hilo2.ThreadState == ThreadState.Suspended) ||
                (hilo3 != null && hilo3.IsAlive && hilo3.ThreadState == ThreadState.Suspended) ||
                (hilo4 != null && hilo4.IsAlive && hilo4.ThreadState == ThreadState.Suspended))
            {
                MessageBox.Show("Hay un hilo suspendido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
