namespace Coursework
{
    partial class Show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_number_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_mark_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewShow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_,
            this.Group_number_,
            this.Faculty_,
            this.Course_,
            this.Average_mark_});
            this.dataGridViewShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShow.Location = new System.Drawing.Point(3, 66);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersVisible = false;
            this.dataGridViewShow.RowHeadersWidth = 51;
            this.dataGridViewShow.RowTemplate.Height = 24;
            this.dataGridViewShow.Size = new System.Drawing.Size(668, 381);
            this.dataGridViewShow.TabIndex = 0;
            // 
            // Name_
            // 
            this.Name_.Frozen = true;
            this.Name_.HeaderText = "Name";
            this.Name_.MinimumWidth = 6;
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.Width = 125;
            // 
            // Group_number_
            // 
            this.Group_number_.Frozen = true;
            this.Group_number_.HeaderText = "Group number";
            this.Group_number_.MinimumWidth = 6;
            this.Group_number_.Name = "Group_number_";
            this.Group_number_.ReadOnly = true;
            this.Group_number_.Width = 125;
            // 
            // Faculty_
            // 
            this.Faculty_.Frozen = true;
            this.Faculty_.HeaderText = "Faculty";
            this.Faculty_.MinimumWidth = 6;
            this.Faculty_.Name = "Faculty_";
            this.Faculty_.ReadOnly = true;
            this.Faculty_.Width = 125;
            // 
            // Course_
            // 
            this.Course_.Frozen = true;
            this.Course_.HeaderText = "Course";
            this.Course_.MinimumWidth = 6;
            this.Course_.Name = "Course_";
            this.Course_.ReadOnly = true;
            this.Course_.Width = 125;
            // 
            // Average_mark_
            // 
            this.Average_mark_.Frozen = true;
            this.Average_mark_.HeaderText = "Average mark";
            this.Average_mark_.MinimumWidth = 6;
            this.Average_mark_.Name = "Average_mark_";
            this.Average_mark_.ReadOnly = true;
            this.Average_mark_.Width = 125;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(668, 57);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(692, 497);
            this.MinimumSize = new System.Drawing.Size(692, 497);
            this.Name = "Show";
            this.Text = "Show";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_number_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_mark_;
        public System.Windows.Forms.DataGridView dataGridViewShow;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}