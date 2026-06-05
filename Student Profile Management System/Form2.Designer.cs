namespace Student_Profile_Management_System
{
    partial class Form2
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
            label1 = new Label();
            NameTxt = new TextBox();
            AgeNum = new NumericUpDown();
            label2 = new Label();
            GenderTxt = new TextBox();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)AgeNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(34, 62);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Name :";
            // 
            // NameTxt
            // 
            NameTxt.Anchor = AnchorStyles.None;
            NameTxt.Location = new Point(197, 64);
            NameTxt.MaxLength = 32766;
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(340, 23);
            NameTxt.TabIndex = 1;
            // 
            // AgeNum
            // 
            AgeNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeNum.Location = new Point(197, 116);
            AgeNum.Name = "AgeNum";
            AgeNum.Size = new Size(120, 29);
            AgeNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(34, 115);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Age : ";
            // 
            // GenderTxt
            // 
            GenderTxt.Anchor = AnchorStyles.None;
            GenderTxt.Location = new Point(197, 172);
            GenderTxt.MaxLength = 32766;
            GenderTxt.Name = "GenderTxt";
            GenderTxt.Size = new Size(340, 23);
            GenderTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(34, 170);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Gender :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(490, 256);
            button1.Name = "button1";
            button1.Size = new Size(129, 32);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 319);
            Controls.Add(button1);
            Controls.Add(GenderTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AgeNum);
            Controls.Add(NameTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)AgeNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTxt;
        private NumericUpDown AgeNum;
        private Label label2;
        private TextBox GenderTxt;
        private Label label3;
        private Button button1;
    }
}