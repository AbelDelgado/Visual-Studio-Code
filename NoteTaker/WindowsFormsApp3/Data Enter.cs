using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Data_Enter : Form
    {
        public string text;

        public Data_Enter()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 tf = new Form2();
            tf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            text = richTextBox2.Text;
            finalForm tf = new finalForm(this); //This allows you to access varialbes from form1 ONTO form 2
            tf.Show();
        }
    }
}
