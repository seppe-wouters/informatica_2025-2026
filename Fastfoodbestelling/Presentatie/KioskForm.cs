using Business;

namespace Presentatie
{
    public partial class KioskForm : Form
    {
        private Bestelling _bestelling;
        private List<MenuItem> _menu = new List<MenuItem>(); 
        public KioskForm()
        {
            InitializeComponent();
            _bestelling = new Bestelling();
            _menu.Add(new MenuItem("Burger", 5.99m, 300));
            _menu.Add(new MenuItem("Friete", 2.99m, 200));
            _menu.Add(new MenuItem("Cola", 1.99m, 150));
            lbMenu.DataSource = null;
            lbMenu.DataSource = _menu;
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = lbMenu.SelectedItem as MenuItem;
            if (menuItem != null)
            {
                _bestelling.voegtoeItemToe(menuItem);
                lbBestelling.DataSource = null;
                lbBestelling.DataSource = _bestelling.Items;
            }
        }
            
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = lbBestelling.SelectedItem as MenuItem;
            if (menuItem != null)
            {
                _bestelling.verwijderItem(menuItem);
                lbBestelling.DataSource = null;
                lbBestelling.DataSource = _bestelling.Items;
            }
        }
        private void btnTotaal_Click(object sender, EventArgs e)
        {    
            lblTotprijs.Text = $"Totale Prijs: {_bestelling.TotaalPrijs():0.00} EUR";
        }

    }
}
