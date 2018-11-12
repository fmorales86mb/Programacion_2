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

namespace FormularioImagen
{
    public partial class Form1 : Form
    {
        Thread tLocationX;
        Thread tLocationY;
        Thread tTime;

        public Form1()
        {
            InitializeComponent();
            tLocationX = new Thread(new ParameterizedThreadStart(RandomPosition));
            tLocationY = new Thread(new ParameterizedThreadStart(RandomPosition));
            tLocationX.Start(true);
            tLocationY.Start(false);
        }

        private void RandomPosition (object o)
        {
            Random rd = new Random();
            int val;
            bool x = (bool)o; 

            while (true)
            {
                if (x)
                    val = rd.Next(this.Location.X+1);
                else
                    val = rd.Next(this.Location.Y+1);
                Thread.Sleep(150);
                MoverImagen(x, val);
            }            
        }

        private void MoverImagen(bool isX, int val)
        {
            if(this.pictureBox1.InvokeRequired)
            {
                this.pictureBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    if (isX)
                    {                        
                        this.pictureBox1.Left = val;
                    }
                    else
                    {
                        this.pictureBox1.Top = val;
                    }
                }
                );
            } 
            else
            {
                if (isX)
                {
                    this.pictureBox1.Left = val;
                }
                else
                {
                    this.pictureBox1.Top = val;
                }
            }
        }

    }
}
