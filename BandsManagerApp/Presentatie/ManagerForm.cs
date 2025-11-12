using Business;
using Data;

namespace Presentatie
{
    public partial class ManagerForm : Form
    {
        private AlleBands _Manager;
        public ManagerForm()
        {
            InitializeComponent();
            _Manager = new AlleBands();
            cbFilterGenre.DataSource = null;
            cbFilterGenre.DataSource = Enum.GetValues(typeof(Genres));
            RefreshListBox();
        }

        //refresh methode
        public void RefreshListBox()
        {
            _Manager.Bands = DataAccess.HaalOp();
            lbBands.DataSource = null;
            lbBands.DataSource = _Manager.Bands;
        }

        //toevoegen aan lijst en db
        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            VoegToeForm form = new VoegToeForm();
            form.ShowDialog();
            RefreshListBox();
        }

        //verwijderen uit lijst en db
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            DataAccess.Verwijder((Band)lbBands.SelectedItem);
            RefreshListBox();
        }

        //filteren op basis van naam
        private void btnFilterOpNaam_Click(object sender, EventArgs e)
        {
            List<Band> filterList = _Manager.Bands.Where(b => b.Naam == txtFilter.Text).ToList();
            lbBands.DataSource = null;
            lbBands.DataSource = filterList;
        }

        //filteren op basis van genre
        private void btnFilterOpGenre_Click(object sender, EventArgs e)
        {
            List<Band> filterList = _Manager.Bands.Where(b => b.Genre == (Genres)cbFilterGenre.SelectedItem).ToList();
            lbBands.DataSource = null;
            lbBands.DataSource = filterList;
        }

        //geen filter
        private void btnGeenFilter_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }
    }
}
