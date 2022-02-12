using System.Windows.Forms;

namespace PassMan;

public partial class FMain : Form
{
    private readonly DataBaseManager _dataBaseManager;
    
    public FMain(DataBaseManager dataBaseManager)
    {
        InitializeComponent();
        _dataBaseManager = dataBaseManager;
    }
}