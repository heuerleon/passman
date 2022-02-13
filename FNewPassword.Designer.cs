using System.ComponentModel;

namespace PassMan;

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
        this.TBPassword.Location = new System.Drawing.Point(220, 93);
        this.TBPassword.Margin = new System.Windows.Forms.Padding(4);
        this.TBPassword.Name = "TBPassword";
        this.TBPassword.Size = new System.Drawing.Size(237, 32);
        this.TBPassword.TabIndex = 13;
        // 
        // LPassword
        // 
        this.LPassword.AutoSize = true;
        this.LPassword.Location = new System.Drawing.Point(13, 96);
        this.LPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LPassword.Name = "LPassword";
        this.LPassword.Size = new System.Drawing.Size(114, 26);
        this.LPassword.TabIndex = 12;
        this.LPassword.Text = "Password:";
        // 
        // TBUsername
        // 
        this.TBUsername.Location = new System.Drawing.Point(220, 53);
        this.TBUsername.Margin = new System.Windows.Forms.Padding(4);
        this.TBUsername.Name = "TBUsername";
        this.TBUsername.Size = new System.Drawing.Size(237, 32);
        this.TBUsername.TabIndex = 11;
        // 
        // LUsername
        // 
        this.LUsername.AutoSize = true;
        this.LUsername.Location = new System.Drawing.Point(13, 56);
        this.LUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LUsername.Name = "LUsername";
        this.LUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.LUsername.Size = new System.Drawing.Size(181, 26);
        this.LUsername.TabIndex = 10;
        this.LUsername.Text = "Username/Email:";
        // 
        // BSave
        // 
        this.BSave.AutoSize = true;
        this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BSave.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.BSave.Location = new System.Drawing.Point(385, 187);
        this.BSave.Margin = new System.Windows.Forms.Padding(4);
        this.BSave.Name = "BSave";
        this.BSave.Size = new System.Drawing.Size(72, 36);
        this.BSave.TabIndex = 9;
        this.BSave.Text = "Save";
        this.BSave.UseVisualStyleBackColor = true;
        this.BSave.Click += new System.EventHandler(this.BSave_Click);
        // 
        // TBWebsite
        // 
        this.TBWebsite.Location = new System.Drawing.Point(220, 13);
        this.TBWebsite.Margin = new System.Windows.Forms.Padding(4);
        this.TBWebsite.Name = "TBWebsite";
        this.TBWebsite.Size = new System.Drawing.Size(237, 32);
        this.TBWebsite.TabIndex = 8;
        // 
        // LWebsite
        // 
        this.LWebsite.AutoSize = true;
        this.LWebsite.Location = new System.Drawing.Point(13, 16);
        this.LWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.LWebsite.Name = "LWebsite";
        this.LWebsite.Size = new System.Drawing.Size(97, 26);
        this.LWebsite.TabIndex = 7;
        this.LWebsite.Text = "Website:";
        // 
        // BCancel
        // 
        this.BCancel.AutoSize = true;
        this.BCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.BCancel.Location = new System.Drawing.Point(13, 187);
        this.BCancel.Margin = new System.Windows.Forms.Padding(4);
        this.BCancel.Name = "BCancel";
        this.BCancel.Size = new System.Drawing.Size(90, 36);
        this.BCancel.TabIndex = 14;
        this.BCancel.Text = "Cancel";
        this.BCancel.UseVisualStyleBackColor = true;
        // 
        // FNewPassword
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(470, 236);
        this.Controls.Add(this.BCancel);
        this.Controls.Add(this.TBPassword);
        this.Controls.Add(this.LPassword);
        this.Controls.Add(this.TBUsername);
        this.Controls.Add(this.LUsername);
        this.Controls.Add(this.BSave);
        this.Controls.Add(this.TBWebsite);
        this.Controls.Add(this.LWebsite);
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.Margin = new System.Windows.Forms.Padding(4);
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