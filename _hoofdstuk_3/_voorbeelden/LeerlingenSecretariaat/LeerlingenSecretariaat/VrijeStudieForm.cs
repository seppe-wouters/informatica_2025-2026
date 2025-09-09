using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerlingenSecretariaat
{
    public partial class VrijeStudieForm : Form
    {
        private VrijeStudie _vrijeStudie;

        public VrijeStudieForm()
        {
            InitializeComponent();
            _vrijeStudie = new VrijeStudie("Poly C", 40, 20);

            UpdateForm();
        }

        public void UpdateForm()
        {
            lokaalTextBox.Text = _vrijeStudie.Lokaal;
            capaciteitTextBox.Text = _vrijeStudie.Capaciteit.ToString();
            bezetTextBox.Text = _vrijeStudie.AantalBezettePlaatsen.ToString();
            txtAantalLaptops.Text = _vrijeStudie.AantalLaptops.ToString();
            txtAantalgereserveerd.Text = _vrijeStudie.AantalLaptopsGereserveerd.ToString();
        }

        private void inschrijvenButton_Click(object sender, EventArgs e)
        {
            try
            {
                _vrijeStudie.Inschrijven(Convert.ToInt32(aantalInschrijvenTextBox.Text), Convert.ToInt32(txtLaptopsTeReserveren.Text));
                boodschapTextBox.BackColor = Color.White;
                boodschapTextBox.Text = "Succesvol ingeschreven";
                aantalInschrijvenTextBox.Text = "";
                txtLaptopsTeReserveren.Text = "";
                UpdateForm();
            }
            catch (Exception)
            {
                boodschapTextBox.BackColor = Color.Red;
                boodschapTextBox.Text = "Geen plaats meer of te weinig laptops";
                UpdateForm();
            }
        }
    }
}
