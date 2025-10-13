using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Enum.Material;
using Business;

namespace Presentatie
{
    public partial class DetailsForm : MaterialForm
    {
        public DetailsForm(Pompoen pompeon)
        {
            InitializeComponent();
            txtSoort.Text = pompeon.Soort;
            txtGewicht.Text = pompeon.GewichtKg.ToString();
            txtPrijsPerKg.Text = pompeon.PrijsPerKg.ToString("C");
            txtTotPrijs.Text = pompeon.TotaalPrijs().ToString("C");
        }
    }
}
