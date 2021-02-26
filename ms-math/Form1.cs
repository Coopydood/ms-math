using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ms_math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Timer timer1)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value == progressBar1.Maximum)
                timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            //this.Opacity = (progressBar2.Value/100);
        }
    }
}
