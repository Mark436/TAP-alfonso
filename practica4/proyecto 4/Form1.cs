using System;
using System.Threading;
using System.Windows.Forms;

namespace proyecto_4
{
    public partial class Form1: Form
    {
        private Thread[] hilos=new Thread[4];
        private ManualResetEvent[] estadoSetters=new ManualResetEvent[4];
        private bool[] corriendoEstado=new bool[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHilo1_Click(object sender, EventArgs e)
        {
            if (hilos[0] == null)
            {
                corriendoEstado[0] = true;
                EstadoHilo1.Text = "Corriendo";
                estadoSetters[0] = new ManualResetEvent(false);
                hilos[0] =new Thread(() =>
                {
                    long y=0;

                    for (long x = 1; x <= 30000000; x++)
                    {
                    estadoSetters[0].WaitOne();
                        y = y + x;
                    }
                    this.Invoke(new Action(() => EstadoHilo1.Text = $"Resultado: {y}"));
                    this.Invoke(new Action(() => hilos[0] = null));

                });
                hilos[0].Start();
                EstadoHilo1.Text = "Pausado";
                corriendoEstado[0] = false;
                estadoSetters[0].Reset();
                return;
            }
            if (!corriendoEstado[0])
            {
                estadoSetters[0].Set();
                EstadoHilo1.Text = "Corriendo";
                corriendoEstado[0] = true;
                return;
            }
            //corriendoEstado[0] = false;
            //EstadoHilo1.Text = "Pausado";
            //estadoSetters[0].Reset();

        }

        private void BtnHilo2_Click(object sender, EventArgs e)
        {

            if(EstadoHilo1.Text.IndexOf("Resultado")==-1)
            {
                MessageBox.Show("Primero debe recibir el resultado del hilo 1 para reiniciarlo");
                return;
            }
            hilos[1] = new Thread(() => {
                this.Invoke(new Action(() => EstadoHilo2.Text = "Dormido"));
                Thread.Sleep(3000);
                this.Invoke(new Action(() => EstadoHilo2.Text = "Espera"));
                this.Invoke(new Action(() => MessageBox.Show("Reiniciando el hilo 1")));
                corriendoEstado[0] = true;
                this.Invoke(new Action(() => EstadoHilo1.Text = "Corriendo"));

                estadoSetters[0] = new ManualResetEvent(true);
                hilos[0] = new Thread(() =>
                {
                    long y = 0;

                    for (long x = 1; x <= 30000000; x++)
                    {
                        estadoSetters[0].WaitOne();
                        y = y + x;
                    }
                    this.Invoke(new Action(() => EstadoHilo1.Text = $"Resultado: {y}"));
                    this.Invoke(new Action(() => hilos[0] = null));

                });
                hilos[0].Start();
            });
            hilos[1].Start();

        }

        private void BtnHilo3_Click(object sender, EventArgs e)
        {
            if (hilos[2] == null)
            {
                estadoSetters[2] = new ManualResetEvent(false);
                hilos[2] = new Thread(() => {
                    this.Invoke(new Action(() => MessageBox.Show("Iniciando el hilo 3")));
                    this.Invoke(new Action(() => EstadoHilo3.Text = "Suspendido"));
                    estadoSetters[2].WaitOne();
                    this.Invoke(new Action(() => EstadoHilo3.Text = "Corriendo"));
                    Thread.Sleep(5000);
                    Application.Exit();
                });
                hilos[2].Start();
            }
           
        }

        private void BtnHilo4_Click(object sender, EventArgs e)
        {
            if (hilos[3] == null && hilos[2]!=null)
            {
                hilos[3] = new Thread(() =>
                {
                    this.Invoke(new Action(() => EstadoHilo4.Text = "Dormido"));
                    Thread.Sleep(5000);
                    this.Invoke(new Action(() => EstadoHilo4.Text = "Corriendo"));
                    this.Invoke(new Action(() => MessageBox.Show("Reanudando el hilo 3")));
                    this.Invoke(new Action(() => EstadoHilo3.Text = "Corriendo"));
                    estadoSetters[2].Set();
                });
                hilos[3].Start();
            }
        }
    }
}
