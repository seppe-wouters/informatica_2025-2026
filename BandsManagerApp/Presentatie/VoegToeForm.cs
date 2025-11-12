using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentatie
{
    public partial class VoegToeForm : Form
    {
        public VoegToeForm()
        {
            //init
            InitializeComponent();
            cbGenre.DataSource = null;
            cbGenre.DataSource = Enum.GetValues(typeof(Genres));
        }

        //het werkelijke toevoegen aan lijst en db
        private void BtnVoegToe_Click(object sender, EventArgs e)
        {
            DataAccess.VoegToe(new Band(txtNaam.Text, (Genres)cbGenre.SelectedItem, txtLand.Text, Convert.ToInt32(numPopulariteit.Value)));
            Close();
        }
    }
}
