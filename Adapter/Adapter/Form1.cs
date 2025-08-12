using System.Windows.Forms;
using Interfaces;

  
namespace Adapter
{
    public partial class Form1 : Form
    {
        public IGrilla _grilla;
        public ICompra _compraLogic;
        public Form1( IGrilla grilla, ICompra compra)
        {
            _grilla = grilla;
            _compraLogic = compra;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
