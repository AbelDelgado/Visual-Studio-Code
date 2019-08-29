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
    public partial class finalForm : Form
    {

        public string textFromMainForm;
        Data_Enter originalForm;

        public finalForm(Data_Enter incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
            label1.Text = originalForm.text;
           
        }

    }
}
