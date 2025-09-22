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
        public DobbelsteenForm(int aantalZijde)
        {
            InitializeComponent();
            _dobbelsteen = new Dobbelsteen(aantalZijde);
            txtUitkomst.Text = _dobbelsteen.AantalZijden.ToString();
        }

        private void btnWerp_Click(object sender, EventArgs e)
        {
            txtUitkomst.Text = _dobbelsteen.Werp().ToString();
        }
    }
}
