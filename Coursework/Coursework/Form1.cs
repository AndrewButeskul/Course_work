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
        bool dup = false;
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
            richText.Text += "History of operation:\n";
            dataGridView.Rows.Add(textBox_name.Text, textBox_record.Text, textBox_faculty.Text, numeric_course.Value,
               input.study[0].Subject, input.study[0].Name_teacher, input.study[0].Mark,
               input.study[1].Subject, input.study[1].Name_teacher, input.study[1].Mark,
               input.study[2].Subject, input.study[2].Name_teacher, input.study[2].Mark,
               input.study[3].Subject, input.study[3].Name_teacher, input.study[3].Mark,
               input.study[4].Subject, input.study[4].Name_teacher, input.study[4].Mark);            
            richText.Text += "Student added to database\n";            
        }

        private void button_password_Click_1(object sender, EventArgs e)
        {
            int pin;
            Random rand = new Random();
            pin = rand.Next(9999);
            textBox_password.Text = Convert.ToString(pin);
            richText.Text += "Password was generated: " + textBox_password.Text + "\n";
        }

        private void button_thebest_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "The best Students:\n";
            int N = dataGridView.RowCount;
            double[] average_mark = new double[N];
            int k = 6, count = 0;
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
                    count++;
            }
            if(count == N)
                richTextInformation.Text += "Not found, such students\n";
            richText.Text += "The best students were input\n";
        }

        private void button_dupes_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "Students dupes:\n";
            int N = dataGridView.RowCount;
            double[] average_mark = new double[N];
            int k = 6, count = 0;
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
                    count++;
            }
            if (count == N)
                richTextBox_search.Text = "Not found, such students\n";
            richText.Text += "The losers were input\n";
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
            richText.Text += dataGridView.Rows[index_search].Cells[0].Value.ToString() + "was found\n";
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
            richText.Text = "Your data from File were opened\n";
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
            richText.Text = "\nYour data were saved to File";
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа представляет собой Базу данных студентов.\n" +
                "О разработчике:\nСтудент: Андрей Бутескул\nФакультет: ИКС\nГруппа: АТ-182\n");
        }

        private void button_discipline_Click(object sender, EventArgs e)
        {
            richTextInformation.Text = "Discipline on which the greatest number of students received twos\n";
            int k = 0, p = 0, n, s = 0, check_on_check = 0, Count = 0;
            n = dataGridView.RowCount * 5;
            string[] dicipline = new string[n];
            int[] count = new int[n];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                k = 6;
                p = 4;
                for (int j = 0; j < 5; j++)
                {
                    if (Convert.ToInt32(dataGridView.Rows[i].Cells[k].Value) == 2)
                    {
                        Count++;
                        check_on_check = 0;
                        if (s == 0)
                        {
                            dicipline[s] = dataGridView.Rows[i].Cells[p].Value.ToString();
                            count[s]++;
                            k += 3;
                            p += 3;
                            s++;
                            continue;
                        }
                        for (int l = 0; l < s; l++)
                        {
                            if (dataGridView.Rows[i].Cells[p].Value.ToString() == dicipline[l])
                            {
                                count[l]++;
                                check_on_check++;
                                break;
                            }
                        }
                        if (check_on_check == 0)
                        {
                            dicipline[s] = dataGridView.Rows[i].Cells[p].Value.ToString();
                            count[s]++;
                            s++;
                        }
                    }
                    k += 3;
                    p += 3;
                }
            }
            int max = count[0];
            for (int i = 0; i < s; i++)
            {
                if (count[i] >= max)
                {
                    max = count[i];
                    p = i;
                }
            }
            if (Count == 0)
                richTextInformation.Text = "Not found, each diciplines";
            else
                richTextInformation.Text += dicipline[p];
            richText.Text += "The subject was found, on which more twos\n";

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
            richText.Text += "The student " + dataGridView.Rows[index_search].Cells[0].Value.ToString() + 
                " was deleted from database\n";
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

        private void save_changes_Click(object sender, EventArgs e)
        {
            dataGridView.Refresh();
            MessageBox.Show("Entered data saved");
            richText.Text += "Database was edited";
        }
        
        private void remove_losers_Click(object sender, EventArgs e)
        {
            int k = 0, count = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                k = 6;
                for (int j = 0; j < 5; j++)
                {
                    if (Convert.ToInt32(dataGridView.Rows[i].Cells[k].Value) == 2)
                    {
                        dataGridView.Rows.RemoveAt(i);
                        break;
                    }
                    k += 3;
                }
            }
            dataGridView.Refresh();
            MessageBox.Show("Data removed");
            richText.Text += "Data on students who have had deuces removed";
        }

        //-------------------------------Checks----------------------------------------
        void Check_input_text(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            if (e.KeyChar.Equals(' ')) return;

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
        void Check_input_digit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            e.Handled = !char.IsDigit(e.KeyChar);
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }
        private void textBox_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void edit_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void edit_teacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void edit_subject_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void textBox_faculty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void edit_faculty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_text(sender, e);
        }

        private void edit_record_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_digit(sender, e);
        }

        private void textBox_record_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_input_digit(sender, e);
        }

        
        private void Form1_HelpRequested_1(object sender, HelpEventArgs hlpevent)
        {
            //Help.ShowHelp(this, "help.chm");
            MessageBox.Show("jn");
        }

    }
}
