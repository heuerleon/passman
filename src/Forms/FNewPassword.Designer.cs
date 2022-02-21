using System.ComponentModel;

namespace PassMan.Forms;

partial class FNewPassword
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNewPassword));
        this.TBPassword = new System.Windows.Forms.TextBox();
        this.LPassword = new System.Windows.Forms.Label();
        this.TBUsername = new System.Windows.Forms.TextBox();
        this.LUsername = new System.Windows.Forms.Label();
        this.BSave = new System.Windows.Forms.Button();
        this.TBWebsite = new System.Windows.Forms.TextBox();
        this.LWebsite = new System.Windows.Forms.Label();
        this.BCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // TBPassword
        // 
        this.TBPassword.Location = new System.Drawing.Point(203, 107);
        this.TBPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.TBPassword.Name = "TBPassword";
        this.TBPassword.Size = new System.Drawing.Size(219, 37);
        this.TBPassword.TabIndex = 3;
        // 
        // LPassword
        // 
        this.LPassword.AutoSize = true;
        this.LPassword.Location = new System.Drawing.Point(12, 111);
        this.LPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LPassword.Name = "LPassword";
        this.LPassword.Size = new System.Drawing.Size(108, 30);
        this.LPassword.TabIndex = 12;
        this.LPassword.Text = "Password:";
        // 
        // TBUsername
        // 
        this.TBUsername.Location = new System.Drawing.Point(203, 61);
        this.TBUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.TBUsername.Name = "TBUsername";
        this.TBUsername.Size = new System.Drawing.Size(219, 37);
        this.TBUsername.TabIndex = 2;
        // 
        // LUsername
        // 
        this.LUsername.AutoSize = true;
        this.LUsername.Location = new System.Drawing.Point(12, 65);
        this.LUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LUsername.Name = "LUsername";
        this.LUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.LUsername.Size = new System.Drawing.Size(176, 30);
        this.LUsername.TabIndex = 10;
        this.LUsername.Text = "Username/Email:";
        // 
        // BSave
        // 
        this.BSave.AutoSize = true;
        this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BSave.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.BSave.Location = new System.Drawing.Point(355, 216);
        this.BSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.BSave.Name = "BSave";
        this.BSave.Size = new System.Drawing.Size(69, 40);
        this.BSave.TabIndex = 4;
        this.BSave.Text = "Save";
        this.BSave.UseVisualStyleBackColor = true;
        this.BSave.Click += new System.EventHandler(this.BSave_Click);
        // 
        // TBWebsite
        // 
        this.TBWebsite.Location = new System.Drawing.Point(203, 15);
        this.TBWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.TBWebsite.Name = "TBWebsite";
        this.TBWebsite.Size = new System.Drawing.Size(219, 37);
        this.TBWebsite.TabIndex = 1;
        // 
        // LWebsite
        // 
        this.LWebsite.AutoSize = true;
        this.LWebsite.Location = new System.Drawing.Point(12, 18);
        this.LWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LWebsite.Name = "LWebsite";
        this.LWebsite.Size = new System.Drawing.Size(96, 30);
        this.LWebsite.TabIndex = 7;
        this.LWebsite.Text = "Website:";
        // 
        // BCancel
        // 
        this.BCancel.AutoSize = true;
        this.BCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.BCancel.Location = new System.Drawing.Point(12, 216);
        this.BCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.BCancel.Name = "BCancel";
        this.BCancel.Size = new System.Drawing.Size(87, 40);
        this.BCancel.TabIndex = 5;
        this.BCancel.Text = "Cancel";
        this.BCancel.UseVisualStyleBackColor = true;
        // 
        // FNewPassword
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(434, 272);
        this.Controls.Add(this.BCancel);
        this.Controls.Add(this.TBPassword);
        this.Controls.Add(this.LPassword);
        this.Controls.Add(this.TBUsername);
        this.Controls.Add(this.LUsername);
        this.Controls.Add(this.BSave);
        this.Controls.Add(this.TBWebsite);
        this.Controls.Add(this.LWebsite);
        this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.Name = "FNewPassword";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "New Password";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button BCancel;

    private System.Windows.Forms.TextBox TBPassword;
    private System.Windows.Forms.Label LPassword;
    private System.Windows.Forms.TextBox TBUsername;
    private System.Windows.Forms.Label LUsername;
    private System.Windows.Forms.Button BSave;
    private System.Windows.Forms.TextBox TBWebsite;
    private System.Windows.Forms.Label LWebsite;

    #endregion
}