using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpDeWeegschaal
{
    public partial class BMIForm : Form
    {
        WeightWatcher _BmiBereken;
        public BMIForm()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            _BmiBereken = new WeightWatcher(Convert.ToInt32(txtKg.Text), Convert.ToInt32(txtLengte.Text));

            txtBMI.Text = _BmiBereken.BerekenBMI().ToString();
            txtStatus.Text = _BmiBereken.GeefStatus();

            txtLengte.Text = "";
            txtKg.Text = "";
        }
    }
}
