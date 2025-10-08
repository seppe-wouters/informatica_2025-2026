using Business;

namespace Presentatie
{
    public partial class AutoForm : Form
    {
        private Verhuur _verhuur;
        public AutoForm()
        {
            InitializeComponent();
            _verhuur = new Verhuur();
            _verhuur.Beschikbaar.Add(new Auto("Toyota", "Corolla", 50));
            _verhuur.Beschikbaar.Add(new Auto("Honda", "Civic", 55));
            _verhuur.Beschikbaar.Add(new Auto("Ford", "Focus", 45));
            UpdateLijsten();
        }

        private void UpdateLijsten()
        {
            lbGehuurd.DataSource = null;
            lbGehuurd.DataSource = _verhuur.Gehuurd;
            lbBeschikbaar.DataSource = null;
            lbBeschikbaar.DataSource = _verhuur.Beschikbaar;
        }

        private void btnHuur_Click(object sender, EventArgs e)
        {
            if (lbBeschikbaar.SelectedItem is Auto geselecteerdeAuto)
            {
                try
                {
                    _verhuur.HuurAuto(geselecteerdeAuto);
                    UpdateLijsten();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnBrengTerug_Click(object sender, EventArgs e)
        {
            if (lbGehuurd.SelectedItem is Auto geselecteerdeAuto)
            {
                try
                {
                    _verhuur.BrengTerug(geselecteerdeAuto);
                    UpdateLijsten();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Auto geselecteerdeAuto = lbBeschikbaar.SelectedItem as Auto ?? lbGehuurd.SelectedItem as Auto;
            if (geselecteerdeAuto != null)
            {
                DetailsForm detailsForm = new DetailsForm(geselecteerdeAuto);
                detailsForm.Show();
            }
        }
    }
}
