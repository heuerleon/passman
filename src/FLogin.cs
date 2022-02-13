using System;
using System.Windows.Forms;

namespace PassMan
{
    public partial class FLogin : Form
    {
        private readonly DataBaseManager _dataBaseManager;

        public FLogin(DataBaseManager dataBaseManager)
        {
            InitializeComponent();
            _dataBaseManager = dataBaseManager;
        }
    }
}