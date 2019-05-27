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
        public Show()
        {
            InitializeComponent();            
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Verdana", 40, FontStyle.Regular);
        }


    }
}
