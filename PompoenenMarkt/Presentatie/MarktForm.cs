using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using ReaLTaiizor;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Enum.Material;
using Business;
using System.Drawing.Text;

namespace Presentatie
{
    public partial class MarktForm : MaterialForm
    {
        private Markt markt;
        public MarktForm()
        {
            InitializeComponent();
            markt = new Markt();
            markt.VoegToe(new Pompoen("Hokkaido", 10, 2.0m));
            markt.VoegToe(new Pompoen("Butternut", 20, 3.02m));
            markt.VoegToe(new Pompoen("Halloween", 15, 6.1m));
            markt.GeenFilter();
            UpdateForm();
        }

        private void btnHokkaido_Click(object sender, EventArgs e)
        {
            markt.Gefiltererd = markt.FilterOpSoort("Hokkaido");
            UpdateForm();
        }

        private void btnButternut_Click(object sender, EventArgs e)
        {
            markt.Gefiltererd = markt.FilterOpSoort("Butternut");
            UpdateForm();
        }

        private void BtnHalloween_Click(object sender, EventArgs e)
        {
            markt.Gefiltererd = markt.FilterOpSoort("Halloween");
            UpdateForm();
        }

        public void UpdateForm()
        {
            lbCatalogus.DataSource = null;
            lbCatalogus.DataSource = markt.Gefiltererd;
        }

        private void btnGeenFilter_Click(object sender, EventArgs e)
        {
            markt.GeenFilter();
            UpdateForm();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DetailsForm form = new DetailsForm((Pompoen)lbCatalogus.SelectedItem);
            form.Show();
        }
    }
}
