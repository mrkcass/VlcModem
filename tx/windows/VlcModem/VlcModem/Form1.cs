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

namespace VlcModem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Thread initTableThread = new Thread(modulate);
            initTableThread.Name = "Init Tables";
            initTableThread.Start();
        }

        private void modulate()
        {
            while (true)
            {
                signalLeft.BackColor = System.Drawing.Color.FromArgb(128, 0, 0);
                signalRight.BackColor = System.Drawing.Color.FromArgb(132, 0, 0);
                Thread.Sleep(16);
                signalLeft.BackColor = System.Drawing.Color.FromArgb(132, 0, 0);
                signalRight.BackColor = System.Drawing.Color.FromArgb(128, 0, 0);
                Thread.Sleep(16);
            }
        }
    }
}
