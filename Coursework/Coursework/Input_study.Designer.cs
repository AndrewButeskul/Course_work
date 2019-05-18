namespace Coursework
{
    partial class Input_study
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
            this.button_add_progress = new System.Windows.Forms.Button();
            this.numeric_mark1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_teacher1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_subject1 = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_progress
            // 
            this.button_add_progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_progress.Location = new System.Drawing.Point(36, 146);
            this.button_add_progress.Name = "button_add_progress";
            this.button_add_progress.Size = new System.Drawing.Size(131, 44);
            this.button_add_progress.TabIndex = 37;
            this.button_add_progress.Text = "Add Subject";
            this.button_add_progress.UseVisualStyleBackColor = true;
            this.button_add_progress.Click += new System.EventHandler(this.button_add_progress_Click);
            // 
            // numeric_mark1
            // 
            this.numeric_mark1.Location = new System.Drawing.Point(194, 101);
            this.numeric_mark1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_mark1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_mark1.Name = "numeric_mark1";
            this.numeric_mark1.Size = new System.Drawing.Size(193, 22);
            this.numeric_mark1.TabIndex = 36;
            this.numeric_mark1.ThousandsSeparator = true;
            this.numeric_mark1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Average marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Teachers";
            // 
            // textBox_teacher1
            // 
            this.textBox_teacher1.Location = new System.Drawing.Point(194, 61);
            this.textBox_teacher1.Name = "textBox_teacher1";
            this.textBox_teacher1.Size = new System.Drawing.Size(193, 22);
            this.textBox_teacher1.TabIndex = 33;
            this.textBox_teacher1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_teacher1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Subjects";
            // 
            // textBox_subject1
            // 
            this.textBox_subject1.Location = new System.Drawing.Point(194, 23);
            this.textBox_subject1.Name = "textBox_subject1";
            this.textBox_subject1.Size = new System.Drawing.Size(193, 22);
            this.textBox_subject1.TabIndex = 31;
            this.textBox_subject1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_subject1_KeyPress);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(226, 146);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(126, 44);
            this.button_Cancel.TabIndex = 38;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Input_study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 202);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_add_progress);
            this.Controls.Add(this.numeric_mark1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_teacher1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_subject1);
            this.Name = "Input_study";
            this.Text = "Input_study";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_progress;
        private System.Windows.Forms.NumericUpDown numeric_mark1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_teacher1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_subject1;
        private System.Windows.Forms.Button button_Cancel;
    }
}