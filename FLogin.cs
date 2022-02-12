using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class FLogin : Form
    {
        private readonly DataBaseManager _dataBaseManager;
        
        public FLogin()
        {
            InitializeComponent();
            _dataBaseManager = new DataBaseManager();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var main = new FMain(_dataBaseManager);
            main.Show();
            main.Focus();
            main.FormClosed += (_, _) =>
            {
                Show();
                Focus();
            };
        }
    }
}