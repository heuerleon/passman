using System;
using System.Windows.Forms;

namespace PassMan;

public partial class FMain : Form
{
    private readonly DataBaseManager _dataBaseManager;
    private FLogin? _login;
    private long _selectedPasswordId = -1;
    public bool ReallyQuit { get; private set; }

    public FMain()
    {
        InitializeComponent();
        _dataBaseManager = new DataBaseManager();
    }

    private void UpdatePasswords()
    {
        DGVPasswords.Rows.Clear();
        var passwords = _dataBaseManager.GetPasswords();
        if (passwords == null || passwords.Count == 0)
        {
            return;
        }

        foreach (var entry in passwords)
        {
            DGVPasswords.Rows.Add(entry.Id, entry.Website, entry.Username);
        }
    }

    private string GeneratePassword()
    {
        return PasswordGenerator.Generate(
            CBLowercase.Checked,
            CBUppercase.Checked,
            CBNumbers.Checked,
            CBSymbols.Checked,
            CBAmbiguous.Checked,
            (int) NUDLength.Value);
    }

    private void UpdateSelectedEntry()
    {
        var rows = DGVPasswords.SelectedRows;
        if (rows.Count == 0 || rows[0].Cells.Count == 0)
        {
            _selectedPasswordId = -1;
            return;
        }

        Console.WriteLine((long) rows[0].Cells[0].Value);
        try
        {
            _selectedPasswordId = (long) rows[0].Cells[0].Value;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + ex.StackTrace);
            _selectedPasswordId = -1;
        }

        if (_selectedPasswordId > -1)
        {
            var entry = _dataBaseManager.GetPassword(_selectedPasswordId);
            if (entry != null)
            {
                BSave.Enabled = true;
                TBWebsite.Enabled = true;
                TBUsername.Enabled = true;
                TBPassword.Enabled = true;
                TBWebsite.Text = entry.Website;
                TBUsername.Text = entry.Username;
                TBPassword.Text = entry.Password;
                return;
            }
        }
        BSave.Enabled = false;
        TBWebsite.Enabled = false;
        TBUsername.Enabled = false;
        TBPassword.Enabled = false;
    }

    private void BNew_Click(object sender, EventArgs e)
    {
        var newPassword = new FNewPassword(_dataBaseManager);
        if (newPassword.ShowDialog() == DialogResult.OK)
        {
            UpdatePasswords();
        }
    }

    private void FMain_Load(object sender, EventArgs e)
    {
        UpdatePasswords();
        TBGenerated.Text = GeneratePassword();
        UpdateSelectedEntry();
    }

    private void UpdateGeneratedPassword(object sender, EventArgs e)
    {
        TBGenerated.Text = GeneratePassword();
    }

    private void BCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(TBGenerated.Text);
    }

    private void BSave_Click(object sender, EventArgs e)
    {
        if (_selectedPasswordId < 0)
        {
            return;
        }

        var entry = _dataBaseManager.GetPassword(_selectedPasswordId);
        if (entry == null)
        {
            return;
        }
        
        entry.Website = TBWebsite.Text;
        entry.Username = TBUsername.Text;
        entry.Password = TBPassword.Text;
        _dataBaseManager.EditPassword(entry);
        UpdatePasswords();
    }

    private void DGVPasswords_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        UpdateSelectedEntry();
    }

    private void TSMILogin_Click(object sender, EventArgs e)
    {
        _login = new FLogin(_dataBaseManager);
        _login.ShowDialog();
    }

    private void TSMIQuit_Click(object sender, EventArgs e)
    {
        ReallyQuit = true;
        NITray.Visible = false;
        Close();
    }

    private void TSMIShow_Click(object sender, EventArgs e)
    {
        Show();
        Focus();
    }

    private void TSMIGenerate_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(GeneratePassword());
    }
}