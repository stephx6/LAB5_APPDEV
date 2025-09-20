using System.ComponentModel;

namespace Lab5_LauzCarlStephen;

partial class Product {
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
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        showBtn = new System.Windows.Forms.Button();
        hidePrd = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(65, 58);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(217, 32);
        label1.TabIndex = 0;
        label1.Text = "PRODUCT CATALOG";
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]{ columnHeader1, columnHeader2 });
        listView1.Location = new System.Drawing.Point(65, 93);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(520, 213);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Prd_id";
        columnHeader1.Width = 67;
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "prd_name";
        columnHeader2.Width = 84;
        // 
        // showBtn
        // 
        showBtn.Location = new System.Drawing.Point(608, 123);
        showBtn.Name = "showBtn";
        showBtn.Size = new System.Drawing.Size(111, 30);
        showBtn.TabIndex = 2;
        showBtn.Text = "Show Products";
        showBtn.UseVisualStyleBackColor = true;
        showBtn.Click += showBtn_Click;
        // 
        // hidePrd
        // 
        hidePrd.Location = new System.Drawing.Point(608, 169);
        hidePrd.Name = "hidePrd";
        hidePrd.Size = new System.Drawing.Size(111, 30);
        hidePrd.TabIndex = 3;
        hidePrd.Text = "Hide Products";
        hidePrd.UseVisualStyleBackColor = true;
        hidePrd.Click += hidePrd_Click;
        // 
        // Product
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.InactiveCaption;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(hidePrd);
        Controls.Add(showBtn);
        Controls.Add(listView1);
        Controls.Add(label1);
        Text = "Product";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;

    private System.Windows.Forms.Button showBtn;
    private System.Windows.Forms.Button hidePrd;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.Label label1;

    #endregion
}