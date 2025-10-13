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
    public partial class ShopForm : Form
    {
        private Kledingwinkel _winkel;
        public ShopForm()
        {
            InitializeComponent();
            _winkel = new Kledingwinkel();

            UpdateForm();
        }

        private void rbNaam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaam.Checked == true)
            {
                rbPrijs.Checked = false;
                _winkel.SorteerOpNaam();
                UpdateForm();
            }
        }

        private void rbPrijs_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrijs.Checked == true)
            {
                rbNaam.Checked = false;
                _winkel.SorteerOpPrijs();
                UpdateForm();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnBroek_Click(object sender, EventArgs e)
        {
            _winkel.FilterOpCategorie("Broek");
            UpdateForm();
        }

        private void btnTshirt_Click(object sender, EventArgs e)
        {
            _winkel.FilterOpCategorie("Tshirt");
            UpdateForm();
        }

        private void btnTrui_Click(object sender, EventArgs e)
        {
            _winkel.FilterOpCategorie("Trui");
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbKleding.DataSource = null;
            lbKleding.DataSource = _winkel.Gefiltert;
        }
    }
}
