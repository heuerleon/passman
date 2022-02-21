using System.ComponentModel;

namespace PassMan.Forms;

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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
        this.TCMain = new System.Windows.Forms.TabControl();
        this.TPPasswords = new System.Windows.Forms.TabPage();
        this.DGVPasswords = new System.Windows.Forms.DataGridView();
        this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.CWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.CUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.BNew = new System.Windows.Forms.Button();
        this.TBPassword = new System.Windows.Forms.TextBox();
        this.LPassword = new System.Windows.Forms.Label();
        this.TBUsername = new System.Windows.Forms.TextBox();
        this.LUsername = new System.Windows.Forms.Label();
        this.BSave = new System.Windows.Forms.Button();
        this.TBWebsite = new System.Windows.Forms.TextBox();
        this.LWebsite = new System.Windows.Forms.Label();
        this.TPGenerator = new System.Windows.Forms.TabPage();
        this.BCopy = new System.Windows.Forms.Button();
        this.BGenerate = new System.Windows.Forms.Button();
        this.LLength = new System.Windows.Forms.Label();
        this.NUDLength = new System.Windows.Forms.NumericUpDown();
        this.TBGenerated = new System.Windows.Forms.TextBox();
        this.CBAmbiguous = new System.Windows.Forms.CheckBox();
        this.LSettings = new System.Windows.Forms.Label();
        this.CBSymbols = new System.Windows.Forms.CheckBox();
        this.CBNumbers = new System.Windows.Forms.CheckBox();
        this.CBLowercase = new System.Windows.Forms.CheckBox();
        this.CBUppercase = new System.Windows.Forms.CheckBox();
        this.MSMain = new System.Windows.Forms.MenuStrip();
        this.TSMIAccount = new System.Windows.Forms.ToolStripMenuItem();
        this.TSMILogin = new System.Windows.Forms.ToolStripMenuItem();
        this.TSMILogout = new System.Windows.Forms.ToolStripMenuItem();
        this.NITray = new System.Windows.Forms.NotifyIcon(this.components);
        this.CMSTray = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.TSMIGenerate = new System.Windows.Forms.ToolStripMenuItem();
        this.TSS1 = new System.Windows.Forms.ToolStripSeparator();
        this.TSMIShow = new System.Windows.Forms.ToolStripMenuItem();
        this.TSMIQuit = new System.Windows.Forms.ToolStripMenuItem();
        this.TCMain.SuspendLayout();
        this.TPPasswords.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) (this.DGVPasswords)).BeginInit();
        this.TPGenerator.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) (this.NUDLength)).BeginInit();
        this.MSMain.SuspendLayout();
        this.CMSTray.SuspendLayout();
        this.SuspendLayout();
        // 
        // TCMain
        // 
        this.TCMain.Controls.Add(this.TPPasswords);
        this.TCMain.Controls.Add(this.TPGenerator);
        this.TCMain.Location = new System.Drawing.Point(12, 36);
        this.TCMain.Name = "TCMain";
        this.TCMain.SelectedIndex = 0;
        this.TCMain.Size = new System.Drawing.Size(890, 833);
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
        this.TPPasswords.Location = new System.Drawing.Point(4, 39);
        this.TPPasswords.Name = "TPPasswords";
        this.TPPasswords.Padding = new System.Windows.Forms.Padding(3);
        this.TPPasswords.Size = new System.Drawing.Size(882, 790);
        this.TPPasswords.TabIndex = 0;
        this.TPPasswords.Text = "Passwords";
        this.TPPasswords.UseVisualStyleBackColor = true;
        // 
        // DGVPasswords
        // 
        this.DGVPasswords.AllowUserToAddRows = false;
        this.DGVPasswords.AllowUserToDeleteRows = false;
        this.DGVPasswords.AllowUserToOrderColumns = true;
        this.DGVPasswords.AllowUserToResizeRows = false;
        this.DGVPasswords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.DGVPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.DGVPasswords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.CID, this.CWebsite, this.CUsername});
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
        this.DGVPasswords.Size = new System.Drawing.Size(403, 709);
        this.DGVPasswords.TabIndex = 6;
        this.DGVPasswords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPasswords_CellContentClick);
        // 
        // CID
        // 
        this.CID.Frozen = true;
        this.CID.HeaderText = "ID";
        this.CID.Name = "CID";
        this.CID.ReadOnly = true;
        this.CID.Visible = false;
        this.CID.Width = 59;
        // 
        // CWebsite
        // 
        this.CWebsite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.CWebsite.HeaderText = "Website";
        this.CWebsite.Name = "CWebsite";
        this.CWebsite.ReadOnly = true;
        // 
        // CUsername
        // 
        this.CUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.CUsername.HeaderText = "Username";
        this.CUsername.Name = "CUsername";
        this.CUsername.ReadOnly = true;
        // 
        // BNew
        // 
        this.BNew.AutoSize = true;
        this.BNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.BNew.Location = new System.Drawing.Point(6, 721);
        this.BNew.Name = "BNew";
        this.BNew.Size = new System.Drawing.Size(403, 67);
        this.BNew.TabIndex = 5;
        this.BNew.Text = "New entry";
        this.BNew.UseVisualStyleBackColor = true;
        this.BNew.Click += new System.EventHandler(this.BNew_Click);
        // 
        // TBPassword
        // 
        this.TBPassword.Enabled = false;
        this.TBPassword.Location = new System.Drawing.Point(628, 106);
        this.TBPassword.Name = "TBPassword";
        this.TBPassword.Size = new System.Drawing.Size(238, 37);
        this.TBPassword.TabIndex = 3;
        // 
        // LPassword
        // 
        this.LPassword.AutoSize = true;
        this.LPassword.Location = new System.Drawing.Point(430, 109);
        this.LPassword.Name = "LPassword";
        this.LPassword.Size = new System.Drawing.Size(108, 30);
        this.LPassword.TabIndex = 5;
        this.LPassword.Text = "Password:";
        // 
        // TBUsername
        // 
        this.TBUsername.Enabled = false;
        this.TBUsername.Location = new System.Drawing.Point(628, 60);
        this.TBUsername.Name = "TBUsername";
        this.TBUsername.Size = new System.Drawing.Size(238, 37);
        this.TBUsername.TabIndex = 2;
        // 
        // LUsername
        // 
        this.LUsername.AutoSize = true;
        this.LUsername.Location = new System.Drawing.Point(430, 63);
        this.LUsername.Name = "LUsername";
        this.LUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.LUsername.Size = new System.Drawing.Size(176, 30);
        this.LUsername.TabIndex = 3;
        this.LUsername.Text = "Username/Email:";
        // 
        // BSave
        // 
        this.BSave.AutoSize = true;
        this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BSave.Enabled = false;
        this.BSave.Location = new System.Drawing.Point(628, 172);
        this.BSave.Name = "BSave";
        this.BSave.Size = new System.Drawing.Size(154, 40);
        this.BSave.TabIndex = 4;
        this.BSave.Text = "Save changes";
        this.BSave.UseVisualStyleBackColor = true;
        this.BSave.Click += new System.EventHandler(this.BSave_Click);
        // 
        // TBWebsite
        // 
        this.TBWebsite.Enabled = false;
        this.TBWebsite.Location = new System.Drawing.Point(628, 16);
        this.TBWebsite.Name = "TBWebsite";
        this.TBWebsite.Size = new System.Drawing.Size(238, 37);
        this.TBWebsite.TabIndex = 1;
        // 
        // LWebsite
        // 
        this.LWebsite.AutoSize = true;
        this.LWebsite.Location = new System.Drawing.Point(430, 19);
        this.LWebsite.Name = "LWebsite";
        this.LWebsite.Size = new System.Drawing.Size(96, 30);
        this.LWebsite.TabIndex = 0;
        this.LWebsite.Text = "Website:";
        // 
        // TPGenerator
        // 
        this.TPGenerator.Controls.Add(this.BCopy);
        this.TPGenerator.Controls.Add(this.BGenerate);
        this.TPGenerator.Controls.Add(this.LLength);
        this.TPGenerator.Controls.Add(this.NUDLength);
        this.TPGenerator.Controls.Add(this.TBGenerated);
        this.TPGenerator.Controls.Add(this.CBAmbiguous);
        this.TPGenerator.Controls.Add(this.LSettings);
        this.TPGenerator.Controls.Add(this.CBSymbols);
        this.TPGenerator.Controls.Add(this.CBNumbers);
        this.TPGenerator.Controls.Add(this.CBLowercase);
        this.TPGenerator.Controls.Add(this.CBUppercase);
        this.TPGenerator.Location = new System.Drawing.Point(4, 39);
        this.TPGenerator.Name = "TPGenerator";
        this.TPGenerator.Padding = new System.Windows.Forms.Padding(3);
        this.TPGenerator.Size = new System.Drawing.Size(882, 790);
        this.TPGenerator.TabIndex = 1;
        this.TPGenerator.Text = "Generator";
        this.TPGenerator.UseVisualStyleBackColor = true;
        // 
        // BCopy
        // 
        this.BCopy.AutoSize = true;
        this.BCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BCopy.Location = new System.Drawing.Point(704, 316);
        this.BCopy.Name = "BCopy";
        this.BCopy.Size = new System.Drawing.Size(172, 40);
        this.BCopy.TabIndex = 9;
        this.BCopy.Text = "Copy password";
        this.BCopy.UseVisualStyleBackColor = true;
        this.BCopy.Click += new System.EventHandler(this.BCopy_Click);
        // 
        // BGenerate
        // 
        this.BGenerate.AutoSize = true;
        this.BGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BGenerate.Location = new System.Drawing.Point(586, 316);
        this.BGenerate.Name = "BGenerate";
        this.BGenerate.Size = new System.Drawing.Size(112, 40);
        this.BGenerate.TabIndex = 8;
        this.BGenerate.Text = "Generate";
        this.BGenerate.UseVisualStyleBackColor = true;
        this.BGenerate.Click += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // LLength
        // 
        this.LLength.AutoSize = true;
        this.LLength.Location = new System.Drawing.Point(12, 69);
        this.LLength.Name = "LLength";
        this.LLength.Size = new System.Drawing.Size(79, 30);
        this.LLength.TabIndex = 8;
        this.LLength.Text = "Length";
        // 
        // NUDLength
        // 
        this.NUDLength.Location = new System.Drawing.Point(103, 67);
        this.NUDLength.Maximum = new decimal(new int[] {128, 0, 0, 0});
        this.NUDLength.Minimum = new decimal(new int[] {8, 0, 0, 0});
        this.NUDLength.Name = "NUDLength";
        this.NUDLength.Size = new System.Drawing.Size(74, 37);
        this.NUDLength.TabIndex = 1;
        this.NUDLength.Value = new decimal(new int[] {16, 0, 0, 0});
        this.NUDLength.ValueChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // TBGenerated
        // 
        this.TBGenerated.Location = new System.Drawing.Point(12, 319);
        this.TBGenerated.Name = "TBGenerated";
        this.TBGenerated.ReadOnly = true;
        this.TBGenerated.Size = new System.Drawing.Size(568, 37);
        this.TBGenerated.TabIndex = 7;
        // 
        // CBAmbiguous
        // 
        this.CBAmbiguous.AutoSize = true;
        this.CBAmbiguous.Location = new System.Drawing.Point(27, 260);
        this.CBAmbiguous.Name = "CBAmbiguous";
        this.CBAmbiguous.Size = new System.Drawing.Size(316, 34);
        this.CBAmbiguous.TabIndex = 6;
        this.CBAmbiguous.Text = "Ambiguous characters (\\ § #)";
        this.CBAmbiguous.UseVisualStyleBackColor = true;
        this.CBAmbiguous.CheckedChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // LSettings
        // 
        this.LSettings.AutoSize = true;
        this.LSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.LSettings.Location = new System.Drawing.Point(12, 16);
        this.LSettings.Name = "LSettings";
        this.LSettings.Size = new System.Drawing.Size(127, 32);
        this.LSettings.TabIndex = 4;
        this.LSettings.Text = "Settings";
        // 
        // CBSymbols
        // 
        this.CBSymbols.AutoSize = true;
        this.CBSymbols.Checked = true;
        this.CBSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
        this.CBSymbols.Location = new System.Drawing.Point(27, 224);
        this.CBSymbols.Name = "CBSymbols";
        this.CBSymbols.Size = new System.Drawing.Size(195, 34);
        this.CBSymbols.TabIndex = 5;
        this.CBSymbols.Text = "Symbols (? $ @)";
        this.CBSymbols.UseVisualStyleBackColor = true;
        this.CBSymbols.CheckedChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // CBNumbers
        // 
        this.CBNumbers.AutoSize = true;
        this.CBNumbers.Checked = true;
        this.CBNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
        this.CBNumbers.Location = new System.Drawing.Point(27, 188);
        this.CBNumbers.Name = "CBNumbers";
        this.CBNumbers.Size = new System.Drawing.Size(196, 34);
        this.CBNumbers.TabIndex = 4;
        this.CBNumbers.Text = "Numbers (1 2 3)";
        this.CBNumbers.UseVisualStyleBackColor = true;
        this.CBNumbers.CheckedChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // CBLowercase
        // 
        this.CBLowercase.AutoSize = true;
        this.CBLowercase.Checked = true;
        this.CBLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
        this.CBLowercase.Location = new System.Drawing.Point(27, 152);
        this.CBLowercase.Name = "CBLowercase";
        this.CBLowercase.Size = new System.Drawing.Size(272, 34);
        this.CBLowercase.TabIndex = 3;
        this.CBLowercase.Text = "Lowercase letters (a b c)";
        this.CBLowercase.UseVisualStyleBackColor = true;
        this.CBLowercase.CheckedChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // CBUppercase
        // 
        this.CBUppercase.AutoSize = true;
        this.CBUppercase.Checked = true;
        this.CBUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
        this.CBUppercase.Location = new System.Drawing.Point(27, 116);
        this.CBUppercase.Name = "CBUppercase";
        this.CBUppercase.Size = new System.Drawing.Size(281, 34);
        this.CBUppercase.TabIndex = 2;
        this.CBUppercase.Text = "Uppercase letters (A B C)";
        this.CBUppercase.UseVisualStyleBackColor = true;
        this.CBUppercase.CheckedChanged += new System.EventHandler(this.UpdateGeneratedPassword);
        // 
        // MSMain
        // 
        this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.TSMIAccount});
        this.MSMain.Location = new System.Drawing.Point(0, 0);
        this.MSMain.Name = "MSMain";
        this.MSMain.Size = new System.Drawing.Size(914, 33);
        this.MSMain.TabIndex = 1;
        this.MSMain.Text = "Menu";
        // 
        // TSMIAccount
        // 
        this.TSMIAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.TSMILogin, this.TSMILogout});
        this.TSMIAccount.Name = "TSMIAccount";
        this.TSMIAccount.Size = new System.Drawing.Size(89, 29);
        this.TSMIAccount.Text = "Account";
        // 
        // TSMILogin
        // 
        this.TSMILogin.Name = "TSMILogin";
        this.TSMILogin.Size = new System.Drawing.Size(152, 30);
        this.TSMILogin.Text = "Login";
        this.TSMILogin.Click += new System.EventHandler(this.TSMILogin_Click);
        // 
        // TSMILogout
        // 
        this.TSMILogout.Name = "TSMILogout";
        this.TSMILogout.Size = new System.Drawing.Size(152, 30);
        this.TSMILogout.Text = "Logout";
        // 
        // NITray
        // 
        this.NITray.ContextMenuStrip = this.CMSTray;
        this.NITray.Icon = ((System.Drawing.Icon) (resources.GetObject("NITray.Icon")));
        this.NITray.Text = "PassMan";
        this.NITray.Visible = true;
        // 
        // CMSTray
        // 
        this.CMSTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.TSMIGenerate, this.TSS1, this.TSMIShow, this.TSMIQuit});
        this.CMSTray.Name = "CMSTray";
        this.CMSTray.Size = new System.Drawing.Size(277, 122);
        // 
        // TSMIGenerate
        // 
        this.TSMIGenerate.Name = "TSMIGenerate";
        this.TSMIGenerate.Size = new System.Drawing.Size(276, 30);
        this.TSMIGenerate.Text = "Copy random password";
        this.TSMIGenerate.Click += new System.EventHandler(this.TSMIGenerate_Click);
        // 
        // TSS1
        // 
        this.TSS1.Name = "TSS1";
        this.TSS1.Size = new System.Drawing.Size(273, 6);
        // 
        // TSMIShow
        // 
        this.TSMIShow.Name = "TSMIShow";
        this.TSMIShow.Size = new System.Drawing.Size(276, 30);
        this.TSMIShow.Text = "Show app";
        this.TSMIShow.Click += new System.EventHandler(this.TSMIShow_Click);
        // 
        // TSMIQuit
        // 
        this.TSMIQuit.Name = "TSMIQuit";
        this.TSMIQuit.Size = new System.Drawing.Size(276, 30);
        this.TSMIQuit.Text = "Quit";
        this.TSMIQuit.Click += new System.EventHandler(this.TSMIQuit_Click);
        // 
        // FMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.ClientSize = new System.Drawing.Size(914, 881);
        this.Controls.Add(this.TCMain);
        this.Controls.Add(this.MSMain);
        this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.MainMenuStrip = this.MSMain;
        this.MaximizeBox = false;
        this.Name = "FMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "PassMan";
        this.Load += new System.EventHandler(this.FMain_Load);
        this.TCMain.ResumeLayout(false);
        this.TPPasswords.ResumeLayout(false);
        this.TPPasswords.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) (this.DGVPasswords)).EndInit();
        this.TPGenerator.ResumeLayout(false);
        this.TPGenerator.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) (this.NUDLength)).EndInit();
        this.MSMain.ResumeLayout(false);
        this.MSMain.PerformLayout();
        this.CMSTray.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem TSMIGenerate;
    private System.Windows.Forms.ToolStripMenuItem TSMIShow;
    private System.Windows.Forms.ToolStripMenuItem TSMIQuit;

    private System.Windows.Forms.ToolStripSeparator TSS1;

    private System.Windows.Forms.ContextMenuStrip CMSTray;

    private System.Windows.Forms.ToolStripMenuItem TSMILogin;

    private System.Windows.Forms.NotifyIcon NITray;

    private System.Windows.Forms.ToolStripMenuItem TSMILogout;

    private System.Windows.Forms.MenuStrip MSMain;
    private System.Windows.Forms.ToolStripMenuItem TSMIAccount;

    private System.Windows.Forms.DataGridViewTextBoxColumn CUsername;

    private System.Windows.Forms.DataGridViewTextBoxColumn CID;

    private System.Windows.Forms.Button BCopy;

    private System.Windows.Forms.Button BGenerate;

    private System.Windows.Forms.TextBox TBGenerated;
    private System.Windows.Forms.NumericUpDown NUDLength;
    private System.Windows.Forms.Label LLength;

    private System.Windows.Forms.CheckBox CBAmbiguous;

    private System.Windows.Forms.CheckBox CBNumbers;

    private System.Windows.Forms.Label LSettings;

    private System.Windows.Forms.CheckBox CBLowercase;
    private System.Windows.Forms.CheckBox CBSymbols;

    private System.Windows.Forms.CheckBox CBUppercase;

    private System.Windows.Forms.DataGridViewTextBoxColumn CWebsite;

    private System.Windows.Forms.DataGridView DGVPasswords;

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