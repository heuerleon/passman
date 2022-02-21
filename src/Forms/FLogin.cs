using System.Windows.Forms;

namespace PassMan.Forms
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