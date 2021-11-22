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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        IObjectContainer db = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("ADBTeamSH_FlightManager.yap");
            loadData();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var plane = new Plane()
            {
                Model = txtModel.Text,
                Year = txtYear.Text,
                ID = txtID.Text,
                Capacity = txtCapacity.Text,
                Weight = int.Parse(txtWeight.Text)
            };
            db.Store(plane);

            loadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
            txtModel.Text = "";
            txtYear.Text = "";
            txtID.Text = "";
            txtCapacity.Text = "";
            txtWeight.Text = "";
        }

        private void loadData()
        {
            var template = new Plane();
            var result = db.QueryByExample(template);
            dgvPlane.DataSource = result;
        }
        private void dgvPlane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModel.Text = dgvPlane.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtYear.Text = dgvPlane.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtID.Text = dgvPlane.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCapacity.Text = dgvPlane.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtWeight.Text = dgvPlane.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        
    }

    
}
