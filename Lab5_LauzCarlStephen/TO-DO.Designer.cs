using System.ComponentModel;

namespace Lab5_LauzCarlStephen;

partial class TO_DO {
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
        label1 = new System.Windows.Forms.Label();
        listView1 = new System.Windows.Forms.ListView();
        taskNumber = new System.Windows.Forms.ColumnHeader();
        task = new System.Windows.Forms.ColumnHeader();
        addtaskbtn = new System.Windows.Forms.Button();
        taskInput = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(60, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(144, 39);
        label1.TabIndex = 0;
        label1.Text = "TO-DO LIST";
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.SystemColors.Info;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]{ taskNumber, task });
        listView1.Location = new System.Drawing.Point(60, 62);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(486, 222);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // taskNumber
        // 
        taskNumber.Name = "taskNumber";
        taskNumber.Text = "Task_ID";
        taskNumber.Width = 67;
        // 
        // task
        // 
        task.Name = "task";
        task.Text = "Task";
        task.Width = 76;
        // 
        // addtaskbtn
        // 
        addtaskbtn.Cursor = System.Windows.Forms.Cursors.Hand;
        addtaskbtn.Location = new System.Drawing.Point(605, 138);
        addtaskbtn.Name = "addtaskbtn";
        addtaskbtn.Size = new System.Drawing.Size(103, 29);
        addtaskbtn.TabIndex = 2;
        addtaskbtn.Text = "ADD TASK";
        addtaskbtn.UseVisualStyleBackColor = true;
        addtaskbtn.Click += addtaskbtn_Click;
        // 
        // taskInput
        // 
        taskInput.Location = new System.Drawing.Point(562, 109);
        taskInput.Name = "taskInput";
        taskInput.Size = new System.Drawing.Size(195, 23);
        taskInput.TabIndex = 3;
        // 
        // TO_DO
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ActiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(taskInput);
        Controls.Add(addtaskbtn);
        Controls.Add(listView1);
        Controls.Add(label1);
        Text = "TO_DO";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ColumnHeader task;

    private System.Windows.Forms.ColumnHeader taskNumber;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button addtaskbtn;
    private System.Windows.Forms.TextBox taskInput;

    #endregion
}