namespace Database_2
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
            StudentBox = new ListBox();
            SubjectBox = new ListBox();
            saveStudentButton = new Button();
            deletebutton = new Button();
            Searchbutton = new Button();
            studenttextBox = new TextBox();
            updatebutton = new Button();
            UpdateBox = new TextBox();
            updatelabel = new Label();
            searchlabel = new Label();
            searchBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // StudentBox
            // 
            StudentBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentBox.FormattingEnabled = true;
            StudentBox.ItemHeight = 28;
            StudentBox.Location = new Point(130, 101);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(407, 340);
            StudentBox.TabIndex = 0;
            StudentBox.SelectedIndexChanged += studentBox_SelectedIndexChanged;
            // 
            // SubjectBox
            // 
            SubjectBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectBox.FormattingEnabled = true;
            SubjectBox.ItemHeight = 28;
            SubjectBox.Location = new Point(692, 101);
            SubjectBox.Name = "SubjectBox";
            SubjectBox.Size = new Size(294, 340);
            SubjectBox.TabIndex = 1;
            // 
            // saveStudentButton
            // 
            saveStudentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveStudentButton.Location = new Point(239, 536);
            saveStudentButton.Name = "saveStudentButton";
            saveStudentButton.Size = new Size(112, 44);
            saveStudentButton.TabIndex = 2;
            saveStudentButton.Text = "Save";
            saveStudentButton.UseVisualStyleBackColor = true;
            saveStudentButton.Click += saveStudentButton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebutton.Location = new Point(1197, 536);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(112, 44);
            deletebutton.TabIndex = 3;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // Searchbutton
            // 
            Searchbutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Searchbutton.Location = new Point(1191, 168);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(118, 42);
            Searchbutton.TabIndex = 4;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = true;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // studenttextBox
            // 
            studenttextBox.Location = new Point(187, 485);
            studenttextBox.Name = "studenttextBox";
            studenttextBox.Size = new Size(236, 31);
            studenttextBox.TabIndex = 6;
            // 
            // updatebutton
            // 
            updatebutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebutton.Location = new Point(1197, 371);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(112, 41);
            updatebutton.TabIndex = 7;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // UpdateBox
            // 
            UpdateBox.Location = new Point(1110, 303);
            UpdateBox.Name = "UpdateBox";
            UpdateBox.Size = new Size(276, 31);
            UpdateBox.TabIndex = 8;
            // 
            // updatelabel
            // 
            updatelabel.AutoSize = true;
            updatelabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatelabel.Location = new Point(1159, 252);
            updatelabel.Name = "updatelabel";
            updatelabel.Size = new Size(163, 28);
            updatelabel.TabIndex = 9;
            updatelabel.Text = "UpdateLastname:";
            // 
            // searchlabel
            // 
            searchlabel.AutoSize = true;
            searchlabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchlabel.Location = new Point(1159, 51);
            searchlabel.Name = "searchlabel";
            searchlabel.Size = new Size(175, 28);
            searchlabel.TabIndex = 10;
            searchlabel.Text = "Search for student:";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(1110, 112);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(263, 31);
            searchBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(473, 18);
            label1.Name = "label1";
            label1.Size = new Size(283, 48);
            label1.TabIndex = 12;
            label1.Text = "School Database";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1436, 621);
            Controls.Add(label1);
            Controls.Add(searchBox);
            Controls.Add(searchlabel);
            Controls.Add(updatelabel);
            Controls.Add(UpdateBox);
            Controls.Add(updatebutton);
            Controls.Add(studenttextBox);
            Controls.Add(Searchbutton);
            Controls.Add(deletebutton);
            Controls.Add(saveStudentButton);
            Controls.Add(SubjectBox);
            Controls.Add(StudentBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox StudentBox;
        private ListBox SubjectBox;
        private Button saveStudentButton;
        private Button deletebutton;
        private Button Searchbutton;
        private TextBox studenttextBox;
        private Button updatebutton;
        private TextBox UpdateBox;
        private Label updatelabel;
        private Label searchlabel;
        private TextBox searchBox;
        private Label label1;
    }
}
