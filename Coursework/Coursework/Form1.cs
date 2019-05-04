using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{
    public partial class Form1 : Form
    {
        Student student;
        Study[] study;
        Input_study input = new Input_study();       
        
        public Form1()
        {
            student = new Student();
            study = new Study[5];
            for (int i = 0; i < 5; i++)
            {
                study[i] = new Study();
            }
            InitializeComponent();

            //*********Example**********//
            textBox_name.Text = "Vasyl Ivanov";
            textBox_record.Text = "10";
            textBox_faculty.Text = "ICS";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            student.Name = textBox_name.Text;
            student.Record_number = textBox_record.Text;
            student.Name_faculty = textBox_faculty.Text;
            student.Course = Convert.ToString(numeric_course.Value);           
            for (int i = 0; i < 5; i++)
            {
               input.ShowDialog();
            }            
        }
        
        private void button_grid_Click(object sender, EventArgs e)
        {
            richText.Text = "";
            dataGridView.Rows.Add(textBox_name.Text, textBox_record.Text, textBox_faculty.Text, numeric_course.Value,
               input.study[0].Subject, input.study[0].Name_teacher, input.study[0].Mark,
               input.study[1].Subject, input.study[1].Name_teacher, input.study[1].Mark,
               input.study[2].Subject, input.study[2].Name_teacher, input.study[2].Mark,
               input.study[3].Subject, input.study[3].Name_teacher, input.study[3].Mark,
               input.study[4].Subject, input.study[4].Name_teacher, input.study[4].Mark);            
            richText.Text += "Your data add in the table, for view to came DataGrid\n";            
        }

        private void button_password_Click(object sender, EventArgs e)
        {           
        }
        private void button_password_Click_1(object sender, EventArgs e)
        {
            int pin;
            Random rand = new Random();
            pin = rand.Next(9999);
            textBox_password.Text = Convert.ToString(pin);           
        }

        private void button_thebest_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "The best Students:\n";
            int N = dataGridView.Rows.Count;
            double[] average_mark = new double[N];
            int k = 6;
            for (int i = 0; i < N; i++)
            {
                k = 6;
                for (int j = 0; j < 5; j++)
                {
                    average_mark[i] += Convert.ToDouble(dataGridView.Rows[i].Cells[k].Value.ToString());
                    k += 3;
                }
                average_mark[i] /= 5;
                if (average_mark[i] >= 4)
                    richTextInformation.Text += dataGridView.Rows[i].Cells[0].Value.ToString() + "\n";
                else
                    richTextBox_search.Text = "Not found, such students\n";
            }
        }

        private void button_dupes_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "Students dupes:\n";
            int N = dataGridView.Rows.Count;
            double[] average_mark = new double[N];
            int k = 6;
            for (int i = 0; i < N; i++)
            {
                k = 6;
                for (int j = 0; j < 5; j++)
                {
                    average_mark[i] += Convert.ToDouble(dataGridView.Rows[i].Cells[k].Value.ToString());
                    k += 3;
                }
                average_mark[i] /= 5;
                if (average_mark[i] < 3)
                    richTextInformation.Text += dataGridView.Rows[i].Cells[0].Value.ToString() + "\n";
                else
                    richTextBox_search.Text = "Not found, such students\n";
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (textBox_search.Text == dataGridView.Rows[i].Cells[1].Value.ToString())
                {
                    richTextBox_search.Text = "Name: " + dataGridView.Rows[i].Cells[0].Value.ToString() +
                        "\nRecord Number: " + dataGridView.Rows[i].Cells[1].Value.ToString() +
                        "\nName Faculty: " + dataGridView.Rows[i].Cells[2].Value.ToString() +
                        "\nCourse: " + dataGridView.Rows[i].Cells[3].Value.ToString();
                    count++;
                    break;
                }               
            }
            if(count == 0)                 
                richTextBox_search.Text = "Not found, such student\n";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (reader.PeekChar() != -1)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        dataGridView.Rows[i].Cells[j].Value = reader.ReadString();
                    }
                    dataGridView.Rows.Add();
                }
                else
                {
                    reader.Close();
                    break;
                }
            }
            MessageBox.Show("File opened");
            richText.Text = "\nYou was opening data from file";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {                    
                    writer.Write(dataGridView.Rows[i].Cells[j].Value.ToString());                    
                }
            }
            writer.Close();
            MessageBox.Show("File saved");
            richText.Text = "\nYou was adding data to the DataGrid";
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа представляет собой Базу данных студентов.\n" +
                "О разработчике:\nСтудент: Андрей Бутескул\nФакультет: ИКС\nГруппа: АТ-182\n");
        }
    }
}
