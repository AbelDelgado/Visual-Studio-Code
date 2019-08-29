using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class PopupForm : Form
    {
        public string textFromMainForm;
        MainForm originalForm;
        public PopupForm(MainForm incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
            NameLabel.Text = originalForm.text;
            this.Text = originalForm.text;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
       
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
