using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aftelklok
{
    public partial class AftelklokForm : Form
    {
        private Aftelklok _klok;
        public AftelklokForm()
        {
            InitializeComponent();
            txtTijd.SelectionAlignment = HorizontalAlignment.Center;
            _klok = new Aftelklok(1, 30);
            UpdateTijd();
        }

        private void UpdateTijd()
        {
            txtTijd.Text = _klok.ResterendeTijd();
        }

        private void tAfteklok_Tick(object sender, EventArgs e)
        {
            _klok.Aftellen();
            UpdateTijd();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _klok.TijdInstellen(1,30);
            UpdateTijd();
        }
    }
}
