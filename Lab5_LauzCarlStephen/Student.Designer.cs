using System.ComponentModel;

namespace Lab5_LauzCarlStephen;

partial class Student {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        studentTable = new System.Windows.Forms.ListView();
        ID = new System.Windows.Forms.ColumnHeader();
        Name = new System.Windows.Forms.ColumnHeader();
        Course = new System.Windows.Forms.ColumnHeader();
        label1 = new System.Windows.Forms.Label();
        courseInput = new System.Windows.Forms.ComboBox();
        idInput = new System.Windows.Forms.TextBox();
        addBtn = new System.Windows.Forms.Button();
        nameInput = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // studentTable
        // 
        studentTable.BackColor = System.Drawing.SystemColors.ScrollBar;
        studentTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]{ ID, Name, Course });
        studentTable.Location = new System.Drawing.Point(26, 99);
        studentTable.Name = "studentTable";
        studentTable.Size = new System.Drawing.Size(512, 245);
        studentTable.TabIndex = 0;
        studentTable.UseCompatibleStateImageBehavior = false;
        studentTable.View = System.Windows.Forms.View.Details;
        // 
        // ID
        // 
        ID.Name = "ID";
        ID.Text = "ID";
        ID.Width = 46;
        // 
        // Name
        // 
        Name.Name = "Name";
        Name.Text = "Name";
        // 
        // Course
        // 
        Course.Name = "Course";
        Course.Text = "Course";
        Course.Width = 102;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(36, 52);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(239, 34);
        label1.TabIndex = 1;
        label1.Text = "STUDENT DIRECTORY";
        // 
        // courseInput
        // 
        courseInput.FormattingEnabled = true;
        courseInput.Items.AddRange(new object[]{ "BSIT", "BSCE", "BSECE" });
        courseInput.Location = new System.Drawing.Point(570, 236);
        courseInput.Name = "courseInput";
        courseInput.Size = new System.Drawing.Size(141, 23);
        courseInput.TabIndex = 2;
        // 
        // idInput
        // 
        idInput.Location = new System.Drawing.Point(566, 127);
        idInput.Name = "idInput";
        idInput.Size = new System.Drawing.Size(153, 23);
        idInput.TabIndex = 3;
        // 
        // addBtn
        // 
        addBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
        addBtn.Location = new System.Drawing.Point(568, 283);
        addBtn.Name = "addBtn";
        addBtn.Size = new System.Drawing.Size(151, 31);
        addBtn.TabIndex = 4;
        addBtn.Text = "ADD STUDENT";
        addBtn.UseVisualStyleBackColor = false;
        addBtn.Click += addBtn_Click;
        // 
        // nameInput
        // 
        nameInput.Location = new System.Drawing.Point(566, 184);
        nameInput.Name = "nameInput";
        nameInput.Size = new System.Drawing.Size(153, 23);
        nameInput.TabIndex = 5;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(566, 101);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 6;
        label2.Text = "STUDENT-ID";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(566, 158);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 7;
        label3.Text = "Student Name";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(566, 210);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 8;
        label4.Text = "Student Course";
        // 
        // Student
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.InactiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(nameInput);
        Controls.Add(addBtn);
        Controls.Add(idInput);
        Controls.Add(courseInput);
        Controls.Add(label1);
        Controls.Add(studentTable);
        Text = "Student";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ColumnHeader ID;
    private System.Windows.Forms.ColumnHeader Name;
    private System.Windows.Forms.ColumnHeader Course;

    private System.Windows.Forms.ComboBox courseInput;
    private System.Windows.Forms.TextBox idInput;
    private System.Windows.Forms.Button addBtn;
    private System.Windows.Forms.TextBox nameInput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ListView studentTable;
    private System.Windows.Forms.Label label1;

    #endregion
}