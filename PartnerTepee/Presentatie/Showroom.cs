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
    public partial class Showroom : Form
    {
        private PartnerTepee _tepee;
        public Showroom()
        {
            InitializeComponent();
            _tepee = new PartnerTepee(false, false);
            UpdateForm();
        }

        private void cbAirco_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cbRadio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        public void UpdateForm()
        {
            _tepee.AutoRadio = cbRadio.Checked;
            _tepee.Airco = cbAirco.Checked;
            txtPrijs.Text = _tepee.GeefPrijs().ToString("C");
        }
    }
}
