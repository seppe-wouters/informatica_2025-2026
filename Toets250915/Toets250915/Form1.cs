using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets250915
{
    public partial class Form1 : Form
    {
        private Tankbeurt _tank;
        double _prijsPerLiter = 1.56;
        public Form1()
        {
            InitializeComponent();
            updateForm();
            
        }

       //methodes voor knoppen
        private void btnBereken_Click(object sender, EventArgs e)
        {
            try
            {
                _tank = new Tankbeurt(Convert.ToInt32(txtAantalLiter.Text), Convert.ToInt32(txtHuidigeKmStand.Text), Convert.ToInt32(txtVorigeKmStand.Text), _prijsPerLiter);

                lblTotPrijs.Text = Math.Round(_tank.BerekenTotPrijs(),2).ToString("C");
                lblVerbruikPer100km.Text = $"{_tank.BerekenVerbruik().ToString("0.0")} L";
            }
            catch (Exception)
            {
                MessageBox.Show("foute invoer");
            }
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            txtAantalLiter.Text = "";
            txtHuidigeKmStand.Text = "";
            txtVorigeKmStand.Text = "";
            lblTotPrijs.Text = "";
            lblVerbruikPer100km.Text = "";
        }

        //Extra methodes
        public void updateForm()
        {
            txtPrijsPerLiter.Text = _prijsPerLiter.ToString("C");
        }
    }
}
