using Business;
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
    public partial class DetailsForm : Form
    {
        public DetailsForm(Auto auto)
        {
            InitializeComponent();

            txtMerk.Text = auto.Merk;
            txtType.Text = auto.Type;
        }
    }
}
