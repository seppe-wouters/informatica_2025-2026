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
    public partial class ReisForm : Form
    {
        private JaarboekReizen reis2025;
        private Reis eenReis;
        private Reis tweeReis;
        public ReisForm()
        {
            InitializeComponent();
            reis2025 = new JaarboekReizen(2025);
            eenReis = new Reis("Zimbabwe", 6, 2843.20m);
            tweeReis = new Reis("Nederland", 2, 150);

            reis2025.VoegReisToe(eenReis);
            reis2025.VoegReisToe(tweeReis);
            reis2025.TotaleKostprijs();

            reis2025.WisReizenLand("Nederland");
        }
    }
}
