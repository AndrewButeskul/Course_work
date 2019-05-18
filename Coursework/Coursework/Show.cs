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

            //DialogResult result = MessageBox.Show("Do you want to show students?", "Cancle", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    for (int i = 0; i < form.count_stud; i++)
            //    {
            //        dataGridViewShow.Rows.Add();
            //        for (int j = 0; j < 4; j++)
            //        {
            //            dataGridViewShow.Rows[i].Cells[j].Value = form.dataGridView.Rows[i].Cells[j].Value;
            //        }
            //        dataGridViewShow.Rows[i].Cells[4].Value = form.marks[i];
            //    }
            //    dataGridViewShow.Refresh();
            //}
            //else
            //    Close();

        }


    }
}
