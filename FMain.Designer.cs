using System.ComponentModel;

namespace PassMan;

partial class FMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.TCMain = new System.Windows.Forms.TabControl();
        this.TPPasswords = new System.Windows.Forms.TabPage();
        this.DGVPasswords = new System.Windows.Forms.DataGridView();
        this.BNew = new System.Windows.Forms.Button();
        this.TBPassword = new System.Windows.Forms.TextBox();
        this.LPassword = new System.Windows.Forms.Label();
        this.TBUsername = new System.Windows.Forms.TextBox();
        this.LUsername = new System.Windows.Forms.Label();
        this.BSave = new System.Windows.Forms.Button();
        this.TBWebsite = new System.Windows.Forms.TextBox();
        this.LWebsite = new System.Windows.Forms.Label();
        this.TPGenerator = new System.Windows.Forms.TabPage();
        this.CWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.CPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.TCMain.SuspendLayout();
        this.TPPasswords.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) (this.DGVPasswords)).BeginInit();
        this.SuspendLayout();
        // 
        // TCMain
        // 
        this.TCMain.Controls.Add(this.TPPasswords);
        this.TCMain.Controls.Add(this.TPGenerator);
        this.TCMain.Location = new System.Drawing.Point(12, 12);
        this.TCMain.Name = "TCMain";
        this.TCMain.SelectedIndex = 0;
        this.TCMain.Size = new System.Drawing.Size(861, 484);
        this.TCMain.TabIndex = 0;
        // 
        // TPPasswords
        // 
        this.TPPasswords.Controls.Add(this.DGVPasswords);
        this.TPPasswords.Controls.Add(this.BNew);
        this.TPPasswords.Controls.Add(this.TBPassword);
        this.TPPasswords.Controls.Add(this.LPassword);
        this.TPPasswords.Controls.Add(this.TBUsername);
        this.TPPasswords.Controls.Add(this.LUsername);
        this.TPPasswords.Controls.Add(this.BSave);
        this.TPPasswords.Controls.Add(this.TBWebsite);
        this.TPPasswords.Controls.Add(this.LWebsite);
        this.TPPasswords.Location = new System.Drawing.Point(4, 35);
        this.TPPasswords.Name = "TPPasswords";
        this.TPPasswords.Padding = new System.Windows.Forms.Padding(3);
        this.TPPasswords.Size = new System.Drawing.Size(853, 445);
        this.TPPasswords.TabIndex = 0;
        this.TPPasswords.Text = "Passwords";
        this.TPPasswords.UseVisualStyleBackColor = true;
        // 
        // DGVPasswords
        // 
        this.DGVPasswords.AllowUserToAddRows = false;
        this.DGVPasswords.AllowUserToDeleteRows = false;
        this.DGVPasswords.AllowUserToOrderColumns = true;
        this.DGVPasswords.AllowUserToResizeColumns = false;
        this.DGVPasswords.AllowUserToResizeRows = false;
        this.DGVPasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.DGVPasswords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.DGVPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.DGVPasswords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.CWebsite, this.CPassword});
        this.DGVPasswords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        this.DGVPasswords.Location = new System.Drawing.Point(6, 6);
        this.DGVPasswords.MultiSelect = false;
        this.DGVPasswords.Name = "DGVPasswords";
        this.DGVPasswords.ReadOnly = true;
        this.DGVPasswords.RowHeadersVisible = false;
        this.DGVPasswords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        this.DGVPasswords.RowTemplate.Height = 28;
        this.DGVPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.DGVPasswords.ShowEditingIcon = false;
        this.DGVPasswords.Size = new System.Drawing.Size(254, 391);
        this.DGVPasswords.TabIndex = 8;
        // 
        // BNew
        // 
        this.BNew.AutoSize = true;
        this.BNew.Location = new System.Drawing.Point(3, 403);
        this.BNew.Name = "BNew";
        this.BNew.Size = new System.Drawing.Size(257, 36);
        this.BNew.TabIndex = 7;
        this.BNew.Text = "New entry";
        this.BNew.UseVisualStyleBackColor = true;
        this.BNew.Click += new System.EventHandler(this.BNew_Click);
        // 
        // TBPassword
        // 
        this.TBPassword.Location = new System.Drawing.Point(467, 103);
        this.TBPassword.Name = "TBPassword";
        this.TBPassword.Size = new System.Drawing.Size(160, 32);
        this.TBPassword.TabIndex = 6;
        // 
        // LPassword
        // 
        this.LPassword.AutoSize = true;
        this.LPassword.Location = new System.Drawing.Point(269, 106);
        this.LPassword.Name = "LPassword";
        this.LPassword.Size = new System.Drawing.Size(114, 26);
        this.LPassword.TabIndex = 5;
        this.LPassword.Text = "Password:";
        // 
        // TBUsername
        // 
        this.TBUsername.Location = new System.Drawing.Point(467, 57);
        this.TBUsername.Name = "TBUsername";
        this.TBUsername.Size = new System.Drawing.Size(160, 32);
        this.TBUsername.TabIndex = 4;
        // 
        // LUsername
        // 
        this.LUsername.AutoSize = true;
        this.LUsername.Location = new System.Drawing.Point(269, 60);
        this.LUsername.Name = "LUsername";
        this.LUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.LUsername.Size = new System.Drawing.Size(181, 26);
        this.LUsername.TabIndex = 3;
        this.LUsername.Text = "Username/Email:";
        // 
        // BSave
        // 
        this.BSave.AutoSize = true;
        this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BSave.Location = new System.Drawing.Point(467, 169);
        this.BSave.Name = "BSave";
        this.BSave.Size = new System.Drawing.Size(72, 36);
        this.BSave.TabIndex = 2;
        this.BSave.Text = "Save";
        this.BSave.UseVisualStyleBackColor = true;
        // 
        // TBWebsite
        // 
        this.TBWebsite.Location = new System.Drawing.Point(467, 13);
        this.TBWebsite.Name = "TBWebsite";
        this.TBWebsite.Size = new System.Drawing.Size(160, 32);
        this.TBWebsite.TabIndex = 1;
        // 
        // LWebsite
        // 
        this.LWebsite.AutoSize = true;
        this.LWebsite.Location = new System.Drawing.Point(269, 16);
        this.LWebsite.Name = "LWebsite";
        this.LWebsite.Size = new System.Drawing.Size(97, 26);
        this.LWebsite.TabIndex = 0;
        this.LWebsite.Text = "Website:";
        // 
        // TPGenerator
        // 
        this.TPGenerator.Location = new System.Drawing.Point(4, 35);
        this.TPGenerator.Name = "TPGenerator";
        this.TPGenerator.Padding = new System.Windows.Forms.Padding(3);
        this.TPGenerator.Size = new System.Drawing.Size(853, 445);
        this.TPGenerator.TabIndex = 1;
        this.TPGenerator.Text = "Generator";
        this.TPGenerator.UseVisualStyleBackColor = true;
        // 
        // CWebsite
        // 
        this.CWebsite.Frozen = true;
        this.CWebsite.HeaderText = "Website";
        this.CWebsite.Name = "CWebsite";
        this.CWebsite.ReadOnly = true;
        this.CWebsite.Width = 116;
        // 
        // CPassword
        // 
        this.CPassword.Frozen = true;
        this.CPassword.HeaderText = "Password";
        this.CPassword.Name = "CPassword";
        this.CPassword.ReadOnly = true;
        this.CPassword.Width = 133;
        // 
        // FMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.ClientSize = new System.Drawing.Size(885, 508);
        this.Controls.Add(this.TCMain);
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.MaximizeBox = false;
        this.Name = "FMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Main";
        this.TCMain.ResumeLayout(false);
        this.TPPasswords.ResumeLayout(false);
        this.TPPasswords.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) (this.DGVPasswords)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn CWebsite;
    private System.Windows.Forms.DataGridViewTextBoxColumn CPassword;

    private System.Windows.Forms.DataGridView DGVPasswords;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button BNew;

    private System.Windows.Forms.TextBox TBWebsite;

    private System.Windows.Forms.Label LWebsite;
    private System.Windows.Forms.TextBox TBPassword;
    private System.Windows.Forms.Label LPassword;

    private System.Windows.Forms.Label LUsername;
    private System.Windows.Forms.TextBox TBUsername;
    private System.Windows.Forms.Button BSave;

    private System.Windows.Forms.TabControl TCMain;
    private System.Windows.Forms.TabPage TPPasswords;
    private System.Windows.Forms.TabPage TPGenerator;

    #endregion
}