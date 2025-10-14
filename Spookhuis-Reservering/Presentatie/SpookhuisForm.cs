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
    public partial class SpookhuisForm : MaterialForm
    {
        private SpookHuis _huis;
        public SpookhuisForm()
        {
            InitializeComponent();
            _huis = new SpookHuis();
        }

        private void btnEerste_Click(object sender, EventArgs e)
        {
            _huis.VerwerkEerste();
            updateForm();
        }

        private void btnVoorang_Click(object sender, EventArgs e)
        {
            _huis.VerwerkMetVoorang((Reservering)lbWachtrij.SelectedItem);
            updateForm();
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNaam.Text != null && NumAantalPersonen.Value != 0)
                {
                    _huis.VoegReserveringToe(new Reservering(txtNaam.Text, dtTijdslot.Value, (int)NumAantalPersonen.Value));

                    txtNaam.Text = "";
                    NumAantalPersonen.Value = 0;
                    dtTijdslot.Value = DateTime.Now;
                    
                    updateForm();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ongeldige invoer");
            }
        }

        private void updateForm()
        {
            lbWachtrij.DataSource = null;
            lbWachtrij.DataSource = _huis.Wachtrij;
            txtAantalVerwerkt.Text = _huis.AantalVerwerkt.ToString();
        }

  
    }
}
