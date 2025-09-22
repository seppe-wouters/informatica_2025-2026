using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentatie
{
    public partial class DobbelsteenForm : Form
    {
        Dobbelsteen _dobbelsteen;
        public DobbelsteenForm()
        {
            InitializeComponent();

            _dobbelsteen = new Dobbelsteen(6);
        }

        private void btnWerp_Click(object sender, EventArgs e)
        {
            txtUitkomst.Text = _dobbelsteen.Werp().ToString();
        }
    }
}
