using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTeamSH_DB4O
{
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }

        IObjectContainer db = null;

        private void AddCity_Load(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("ADBTeamSH_FlightManager.yap");
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var city = new City()
            {
                CityID = txtCityID.Text,
                CityName = txtName.Text,
                CityCountry = txtCityID.Text
            };
            db.Store(city);
            loadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
            txtCityID.Text = "";
            txtName.Text = "";
            txtCountry.Text = "";
        }

        private void loadData()
        {
            var template = new City();
            var result = db.QueryByExample(template);
            dgvCity.DataSource = result;
        }

        private void dgvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCityID.Text = dgvCity.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvCity.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCountry.Text = dgvCity.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        
    }
}
