using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Presentatie
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            
        }

        private void btnKlassiek_Click(object sender, EventArgs e)
        {
            DobbelsteenForm formKlassiek = new DobbelsteenForm(6);
            formKlassiek.Show();
        }

        private void btn12Zijdig_Click(object sender, EventArgs e)
        {
            DobbelsteenForm form12Zijdig = new DobbelsteenForm(12);
            form12Zijdig.Show();
        }

        private void btnXZijde_Click(object sender, EventArgs e)
        {
            DobbelsteenForm XzijdeForm = new DobbelsteenForm(Convert.ToInt32(numAantalzijde.Value));
            XzijdeForm.Show();
        }
    }
}
