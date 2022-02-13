using System;
using System.Windows.Forms;

namespace PassMan;

public partial class FMain : Form
{
    private readonly DataBaseManager _dataBaseManager;
    
    public FMain(DataBaseManager dataBaseManager)
    {
        InitializeComponent();
        _dataBaseManager = dataBaseManager;
        //UpdatePasswords();
        //_dataBaseManager.AddPassword(new PasswordEntry(1, "heuer.ovh", "leon", "1234"));
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
            DGVPasswords.Rows.Add(entry.Website, entry.Password);
        }
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
    }
}