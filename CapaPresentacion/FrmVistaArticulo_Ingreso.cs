using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVistaArticulo_Ingreso : Form
    {
        public FrmVistaArticulo_Ingreso()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dgArticulos.Columns[0].Visible = false;
            this.dgArticulos.Columns[1].Visible = false;
            this.dgArticulos.Columns[5].Visible = false;
        }

        private void mostrar()
        {
            this.dgArticulos.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            lblTotalArticulos.Text = "Total de registros: " + Convert.ToString(dgArticulos.Rows.Count);
        }

        private void BuscarArticulo()
        {
            this.dgArticulos.DataSource = NArticulo.BuscarArticulo(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotalArticulos.Text = "Total de registros: " + Convert.ToString(dgArticulos.Rows.Count);
        }
        private void FrmVistaArticulo_Ingreso_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarArticulo();
        }

        private void dgArticulos_DoubleClick(object sender, EventArgs e)
        {
            FRMIngreso frmIngreso = FRMIngreso.GetInsancia();
            string idArticulo, articulo;
            idArticulo = Convert.ToString(this.dgArticulos.CurrentRow.Cells["Art_id"].Value);
            articulo = Convert.ToString(this.dgArticulos.CurrentRow.Cells["NOMBRE"].Value);
            frmIngreso.setArticulo(idArticulo, articulo);
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
