using System.ComponentModel;

namespace Lab5_LauzCarlStephen;

partial class ContactManager {
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
        contactTable = new System.Windows.Forms.ListView();
        Name = new System.Windows.Forms.ColumnHeader();
        ContactNumber = new System.Windows.Forms.ColumnHeader();
        Email = new System.Windows.Forms.ColumnHeader();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        nameInput = new System.Windows.Forms.TextBox();
        numberInput = new System.Windows.Forms.TextBox();
        emailInput = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        deleteBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // contactTable
        // 
        contactTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
        contactTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]{ Name, ContactNumber, Email });
        contactTable.Location = new System.Drawing.Point(47, 97);
        contactTable.Name = "contactTable";
        contactTable.Size = new System.Drawing.Size(489, 236);
        contactTable.TabIndex = 0;
        contactTable.UseCompatibleStateImageBehavior = false;
        contactTable.View = System.Windows.Forms.View.Details;
        // 
        // Name
        // 
        Name.Name = "Name";
        Name.Text = "Name";
        Name.Width = 76;
        // 
        // ContactNumber
        // 
        ContactNumber.Name = "ContactNumber";
        ContactNumber.Text = "ContactNumber";
        ContactNumber.Width = 97;
        // 
        // Email
        // 
        Email.Name = "Email";
        Email.Text = "Email";
        Email.Width = 61;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(32, 52);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(236, 34);
        label1.TabIndex = 1;
        label1.Text = "CONTACT MANAGER";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.OldLace;
        button1.Location = new System.Drawing.Point(551, 266);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(118, 31);
        button1.TabIndex = 2;
        button1.Text = "SAVE CONTACT";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // nameInput
        // 
        nameInput.Location = new System.Drawing.Point(551, 124);
        nameInput.Name = "nameInput";
        nameInput.Size = new System.Drawing.Size(173, 23);
        nameInput.TabIndex = 3;
        // 
        // numberInput
        // 
        numberInput.Location = new System.Drawing.Point(551, 179);
        numberInput.Name = "numberInput";
        numberInput.Size = new System.Drawing.Size(173, 23);
        numberInput.TabIndex = 4;
        // 
        // emailInput
        // 
        emailInput.BackColor = System.Drawing.SystemColors.Window;
        emailInput.Location = new System.Drawing.Point(551, 237);
        emailInput.Name = "emailInput";
        emailInput.Size = new System.Drawing.Size(173, 23);
        emailInput.TabIndex = 5;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(554, 97);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(83, 27);
        label2.TabIndex = 6;
        label2.Text = "Name";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(551, 159);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(99, 17);
        label3.TabIndex = 7;
        label3.Text = "Contact Number";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(551, 217);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(99, 17);
        label4.TabIndex = 8;
        label4.Text = "Email";
        // 
        // deleteBtn
        // 
        deleteBtn.BackColor = System.Drawing.Color.BurlyWood;
        deleteBtn.Location = new System.Drawing.Point(675, 266);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new System.Drawing.Size(118, 31);
        deleteBtn.TabIndex = 9;
        deleteBtn.Text = "DELETE CONTACT";
        deleteBtn.UseVisualStyleBackColor = false;
        deleteBtn.Click += deleteBtn_Click;
        // 
        // ContactManager
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightGray;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(deleteBtn);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(emailInput);
        Controls.Add(numberInput);
        Controls.Add(nameInput);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(contactTable);
        Text = "ContactManager";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button deleteBtn;

    private System.Windows.Forms.ColumnHeader Name;
    private System.Windows.Forms.ColumnHeader ContactNumber;
    private System.Windows.Forms.ColumnHeader Email;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox numberInput;
    private System.Windows.Forms.TextBox emailInput;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox nameInput;

    private System.Windows.Forms.ListView contactTable;
    private System.Windows.Forms.Label label1;

    #endregion
}