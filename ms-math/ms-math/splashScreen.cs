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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
            // Create a new instance of the Form2 class
            Form1 main = new Form1();
            
            // Show the settings form
            main.Show();

            timer1.Start();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
           
           progressBar1.Increment(5);
            if (progressBar1.Value == 70)
            {
                timer2.Start();
            }
                if (progressBar1.Value == progressBar1.Maximum)
            {
                // Stop the timer.
                timer1.Stop();
               
                this.Close();
               Form.ActiveForm.Opacity = 100;
            }
          
                
        }

        private void splashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            List<Form> forms = new List<Form>();

            // All opened myForm instances
            foreach (Form f in Application.OpenForms)
                if (f.Name == "Form1")
                    forms.Add(f);

            // Now let's close opened myForm instances
            foreach (Form f in forms)
                f.Close();
            System.Windows.Forms.Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState=(FormWindowState.Minimized);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(5);
        }
    }
}
