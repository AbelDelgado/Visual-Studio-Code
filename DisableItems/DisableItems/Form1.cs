using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisableItems
{
    public partial class Form1 : Form        
    {
  

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {         
            DisableControls();
        }

        private void DisableControls()
        {                    
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
                TextBox d = c as TextBox;
                if (d != null)
                {
                    d.Enabled = false;
                }

                CheckBox e = c as CheckBox;
                if (e != null)
                {
                    e.Enabled = false;
                }


            }

            



        }
    }
}

