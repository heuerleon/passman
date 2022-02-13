namespace PassMan
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.LUsername = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Location = new System.Drawing.Point(12, 15);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(116, 30);
            this.LUsername.TabIndex = 0;
            this.LUsername.Text = "Username:";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(12, 59);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(108, 30);
            this.LPassword.TabIndex = 1;
            this.LPassword.Text = "Password:";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(137, 12);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(306, 37);
            this.TBUsername.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(137, 56);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(306, 37);
            this.TBPassword.TabIndex = 2;
            // 
            // BLogin
            // 
            this.BLogin.AutoSize = true;
            this.BLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BLogin.Location = new System.Drawing.Point(367, 213);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(76, 40);
            this.BLogin.TabIndex = 3;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.AutoSize = true;
            this.BCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(12, 213);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(87, 40);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(455, 265);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BCancel;

        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BLogin;

        private System.Windows.Forms.Label LUsername;

        #endregion
    }
}