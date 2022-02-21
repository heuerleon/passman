using System;
using System.Windows.Forms;
using PassMan.Models;

namespace PassMan.Forms;

public partial class FNewPassword : Form
{
    private readonly DataBaseManager _dataBaseManager;
    
    public FNewPassword(DataBaseManager dataBaseManager)
    {
        InitializeComponent();
        _dataBaseManager = dataBaseManager;
    }

    private void BSave_Click(object sender, EventArgs e)
    {
        var entry = new PasswordEntry(1, TBWebsite.Text, TBUsername.Text, TBPassword.Text);
        _dataBaseManager.AddPassword(entry);
    }
}