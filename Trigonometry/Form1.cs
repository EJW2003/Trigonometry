using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Force, Angle; 
            //input values for Force and Angles from textboxes

            try
            {
                Force = double.Parse(textBox1.Text);

            }
            catch
            { MessageBox.Show("Nope");
                Force = 0.0;

            }

        }
    }
}
