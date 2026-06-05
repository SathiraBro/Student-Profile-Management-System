namespace Student_Profile_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddBtn = new Button();
            StudentsGridView = new DataGridView();
            label1 = new Label();
            RemoveBtn = new Button();
            UpdataBtn = new Button();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsGridView).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(37, 446);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(157, 31);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // StudentsGridView
            // 
            StudentsGridView.AllowUserToResizeColumns = false;
            StudentsGridView.AllowUserToResizeRows = false;
            StudentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGridView.Location = new Point(37, 130);
            StudentsGridView.Name = "StudentsGridView";
            StudentsGridView.ReadOnly = true;
            StudentsGridView.Size = new Size(744, 310);
            StudentsGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 26);
            label1.Name = "label1";
            label1.Size = new Size(465, 40);
            label1.TabIndex = 2;
            label1.Text = "Student Profile Managment System";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveBtn.Location = new Point(224, 446);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(157, 31);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // UpdataBtn
            // 
            UpdataBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdataBtn.Location = new Point(413, 446);
            UpdataBtn.Name = "UpdataBtn";
            UpdataBtn.Size = new Size(157, 31);
            UpdataBtn.TabIndex = 4;
            UpdataBtn.Text = "Update";
            UpdataBtn.UseVisualStyleBackColor = true;
            UpdataBtn.Click += UpdataBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(37, 93);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(606, 23);
            SearchBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(649, 92);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(132, 26);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 489);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(UpdataBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(label1);
            Controls.Add(StudentsGridView);
            Controls.Add(AddBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private DataGridView StudentsGridView;
        private Label label1;
        private Button RemoveBtn;
        private Button UpdataBtn;
        private TextBox SearchBox;
        private Button SearchBtn;
    }
}
