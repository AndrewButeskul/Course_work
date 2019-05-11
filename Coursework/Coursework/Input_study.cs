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
    public partial class Input_study : Form
    {
        int count = 0;
        internal Study[] study;
        public Input_study()
        {
            study = new Study[5];
            for (int i = 0; i < 5; i++)
            {
                study[i] = new Study();
            }
            InitializeComponent();
            textBox_subject1.Text = "Math";
            textBox_teacher1.Text = "Vladimir Sidorov";
        }
        private void button_add_progress_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 5; i++)
            //{
            if (count >= 5)
                count = 0;
                study[count].Subject = textBox_subject1.Text;
                study[count].Name_teacher = textBox_teacher1.Text;
                study[count].Mark = Convert.ToDouble(numeric_mark1.Value);
                count++;
            //}            
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Check_input_text(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            if(e.KeyChar.Equals(' ')) return;
            var tb = (TextBox)sender;
            if (e.KeyChar.Equals('-'))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text[tb.SelectionStart - 1].Equals('-');
                if (!e.Handled)
                {
                    return;
                }
            }
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void textBox_subject1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void textBox_teacher1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }
    }
}
