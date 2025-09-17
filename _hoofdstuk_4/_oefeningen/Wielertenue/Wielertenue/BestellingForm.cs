using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {
        private BestellingWielertenue _bestelling;

        public BestellingForm()
        {
            InitializeComponent();
            _bestelling = new BestellingWielertenue(1, false, false, false);
            numAantal.Value = _bestelling._aantal;
            cbWaterdichtZakje.Checked = _bestelling._waterdichtZakje;
            cbBroek.Checked = _bestelling._broek;
            cbSuperzeem.Checked = _bestelling._superZeem;
        }

        public void UpdateForm()
        {
            _bestelling._aantal = Convert.ToInt32(numAantal.Value);
            _bestelling._waterdichtZakje = cbWaterdichtZakje.Checked;
            _bestelling._broek = cbBroek.Checked;
            _bestelling._superZeem = cbSuperzeem.Checked;
            txtPrijs.Text = _bestelling.berekenPrijs().ToString("C");
        }

        private void numAantal_ValueChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cbWaterdichtZakje_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cbBroek_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cbSuperzeem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
