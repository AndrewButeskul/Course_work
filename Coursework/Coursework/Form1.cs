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
        int index_search = 0;
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
            Menu.TabPages.Remove(tabPageEdit);
            button_check_password.Enabled = false;
            button_Delete.Enabled = false;
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
            int N = dataGridView.RowCount;
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
            int N = dataGridView.RowCount;
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
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (textBox_search.Text == dataGridView.Rows[i].Cells[1].Value.ToString())
                {
                    richTextBox_search.Text = "Name: " + dataGridView.Rows[i].Cells[0].Value.ToString() +
                        "\nRecord Number: " + dataGridView.Rows[i].Cells[1].Value.ToString() +
                        "\nName Faculty: " + dataGridView.Rows[i].Cells[2].Value.ToString() +
                        "\nCourse: " + dataGridView.Rows[i].Cells[3].Value.ToString();
                    index_search = i;
                    count++;
                    button_check_password.Enabled = true;
                    button_Delete.Enabled = true;

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
            dataGridView.Rows.RemoveAt(dataGridView.RowCount - 1);
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

        private void button_discipline_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "Discipline on which the greatest number of students received twos\n";
            int[] count = new int[5];
            int temp = 0;
            int max = count[0], k = 4;
            bool check = true;
            //int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value) == 2)
                    count[0]++;
                else if (Convert.ToInt32(dataGridView.Rows[i].Cells[9].Value) == 2)
                    count[1]++;
                else if (Convert.ToInt32(dataGridView.Rows[i].Cells[12].Value) == 2)
                    count[2]++;
                else if (Convert.ToInt32(dataGridView.Rows[i].Cells[15].Value) == 2)
                    count[3]++;
                else if (Convert.ToInt32(dataGridView.Rows[i].Cells[18].Value) == 2)
                    count[4]++;
                else;
            }
            if (count[0] + count[1] + count[2] + count[3] + count[4] != 0)
            {
                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] > max)
                    {
                        max = count[i];
                        temp = i;
                    }
                }

                for (int j = 0; j < count.Length; j++)
                {
                    if (temp == j)
                    {
                        richTextInformation.Text += dataGridView.Rows[temp].Cells[k].Value.ToString();
                    }
                    k += 3;
                }

            }
            else
                richTextInformation.Text = "Not found!";
        }

        private void button_check_password_Click(object sender, EventArgs e)
        {
            if (textBox_check_password.Text == textBox_password.Text)
            {
                Menu.TabPages.Insert(3, tabPageEdit);
                Menu.SelectedTab = Menu.TabPages[3];
            }           
            else
                MessageBox.Show("Wrong Password!\nLook your password on the page Create and repid please");

            edit_name.Text = dataGridView.Rows[index_search].Cells[0].Value.ToString();
            edit_record.Text = dataGridView.Rows[index_search].Cells[1].Value.ToString();
            edit_faculty.Text = dataGridView.Rows[index_search].Cells[2].Value.ToString();
            edit_course.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[3].Value);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(index_search);
            MessageBox.Show("All data about student, deleted successfully");
        }

        private void button_choose_subject_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(choose_subject.Value);
            switch (selection)
            {
                case 1:
                    edit_subject.Text = dataGridView.Rows[index_search].Cells[4].Value.ToString();
                    edit_teacher.Text = dataGridView.Rows[index_search].Cells[5].Value.ToString();
                    edit_mark.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[6].Value);
                    break;
                case 2:
                    edit_subject.Text = dataGridView.Rows[index_search].Cells[7].Value.ToString();
                    edit_teacher.Text = dataGridView.Rows[index_search].Cells[8].Value.ToString();
                    edit_mark.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[9].Value);
                    break;
                case 3:
                    edit_subject.Text = dataGridView.Rows[index_search].Cells[10].Value.ToString();
                    edit_teacher.Text = dataGridView.Rows[index_search].Cells[11].Value.ToString();
                    edit_mark.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[12].Value);
                    break;
                case 4:
                    edit_subject.Text = dataGridView.Rows[index_search].Cells[13].Value.ToString();
                    edit_teacher.Text = dataGridView.Rows[index_search].Cells[14].Value.ToString();
                    edit_mark.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[15].Value);
                    break;
                case 5:
                    edit_subject.Text = dataGridView.Rows[index_search].Cells[16].Value.ToString();
                    edit_teacher.Text = dataGridView.Rows[index_search].Cells[17].Value.ToString();
                    edit_mark.Value = Convert.ToDecimal(dataGridView.Rows[index_search].Cells[18].Value);
                    break;
                default:
                    break;
            }
        }

        private void button_change_data_Click(object sender, EventArgs e)
        {
            dataGridView.Rows[index_search].Cells[0].Value = edit_name.Text;
            dataGridView.Rows[index_search].Cells[1].Value = edit_record.Text;
            dataGridView.Rows[index_search].Cells[2].Value = edit_faculty.Text;
            dataGridView.Rows[index_search].Cells[3].Value = edit_course.Value;
            dataGridView.Refresh();
        }

        private void button_change_progress_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(choose_subject.Value);
            switch (selection)
            {
                case 1:
                    dataGridView.Rows[index_search].Cells[4].Value = edit_subject.Text;
                    dataGridView.Rows[index_search].Cells[5].Value = edit_teacher.Text;
                    dataGridView.Rows[index_search].Cells[6].Value = edit_mark.Value;
                    break;
                case 2:
                    dataGridView.Rows[index_search].Cells[7].Value = edit_subject.Text;
                    dataGridView.Rows[index_search].Cells[8].Value = edit_teacher.Text;
                    dataGridView.Rows[index_search].Cells[9].Value = edit_mark.Value;
                    break;
                case 3:
                    dataGridView.Rows[index_search].Cells[10].Value = edit_subject.Text;
                    dataGridView.Rows[index_search].Cells[11].Value = edit_teacher.Text;
                    dataGridView.Rows[index_search].Cells[12].Value = edit_mark.Value;
                    break;
                case 4:
                    dataGridView.Rows[index_search].Cells[13].Value = edit_subject.Text;
                    dataGridView.Rows[index_search].Cells[14].Value = edit_teacher.Text;
                    dataGridView.Rows[index_search].Cells[15].Value = edit_mark.Value;
                    break;
                case 5:
                    dataGridView.Rows[index_search].Cells[16].Value = edit_subject.Text;
                    dataGridView.Rows[index_search].Cells[17].Value = edit_teacher.Text;
                    dataGridView.Rows[index_search].Cells[18].Value = edit_mark.Value;
                    break;
                default:
                    break;
            }
        }

        //private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar >= 'А') & (e.KeyChar <= 'я')) e.Handled = true;
        //}
    }
}
