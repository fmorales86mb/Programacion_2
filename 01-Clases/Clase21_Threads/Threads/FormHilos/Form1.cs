using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHilos
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        int[] numeros;

        public Form1()
        {
            InitializeComponent();
            t1 = new Thread(new ParameterizedThreadStart(Incrementar));
            t2 = new Thread(new ParameterizedThreadStart(Incrementar)); 
            t3 = new Thread(new ParameterizedThreadStart(Incrementar)); 
            t4 = new Thread(new ParameterizedThreadStart(Incrementar));
            this.numeros = new int[] { 0, 0, 0, 0 };
            t1.Start(0);
            t2.Start(1);
            t3.Start(2);
            t4.Start(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Incrementar (object o)
        {
            int posicion = (int)o;

            while (numeros[posicion] < 1000)
            {
                numeros[posicion]++;                                
                Thread.Sleep(100);
                Mostrar(posicion, numeros[posicion]);
            }            
        }

        private void Mostrar(int posicion, int val)
        {
            switch(posicion)
            {
                case 0:
                    if(this.textBox1.InvokeRequired)
                    {
                        this.textBox1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox1.Text = val.ToString(); 
                        }
                        );
                    }
                    else
                    {
                        this.textBox1.Text = val.ToString();
                    }
                    break;
                case 1:
                    if (this.textBox2.InvokeRequired)
                    {
                        this.textBox2.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox2.Text = val.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox2.Text = val.ToString();
                    }
                    break;
                case 2:
                    if (this.textBox3.InvokeRequired)
                    {
                        this.textBox3.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox3.Text = val.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox3.Text = val.ToString();
                    }
                    break;
                case 3:
                    if (this.textBox4.InvokeRequired)
                    {
                        this.textBox4.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.textBox4.Text = val.ToString();
                        }
                        );
                    }
                    else
                    {
                        this.textBox4.Text = val.ToString();
                    }
                    break;
            }
        }

        private void MatarHilo(Thread t)
        {
            if (t.IsAlive)
                t.Abort();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatarHilo(t1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatarHilo(t2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MatarHilo(t3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MatarHilo(t4);
        }
    }
}
