using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Show : Form
    {
        private Form1 form;
        public Show(Form1 form1)
        {
            this.form = form1;            
            InitializeComponent();            
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }


    }
}
