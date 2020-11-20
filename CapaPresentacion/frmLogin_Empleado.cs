using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class frmLogin_Empleado : Form
    {
        public frmLogin_Empleado()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
            PanelRestaurarCuenta.Visible = false;


        }

        private void frmLogin_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable datos = CapaNegocio.NEmpleados.Login(this.txtUsuario.Text, this.txtContraseña.Text);
            //si existe el usuario
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No Tiene Acceso Al Sistema De Ventas", "Sistema De Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FRMSisVentas PRINCIPAL = new FRMSisVentas();
                PRINCIPAL.idEmpleado = datos.Rows[0][0].ToString();
                PRINCIPAL.Emp_Nombre = datos.Rows[0][1].ToString();
                PRINCIPAL.Emp_Apellido = datos.Rows[0][2].ToString();
                PRINCIPAL.Emp_Acceso = datos.Rows[0][3].ToString();

                PRINCIPAL.Show();
                this.Hide();

            }
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EMPLEADOS registro = new EMPLEADOS();
            registro.TableroControl();
            registro.ShowDialog();
        }
        public void  CBCorreos()
        {
            DataTable DtMostrar = new DataTable("Empleados");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Conectar;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "cargarCorreos";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(DtMostrar);
                cbCorreos.ValueMember = "Emp_Correo";
                cbCorreos.DisplayMember = "Emp_Correo";
                cbCorreos.DataSource = DtMostrar;


            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                DtMostrar = null;
            }


        }
        private void RecupCon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRestaurarCuenta.Visible = true;
            CBCorreos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanelRestaurarCuenta.Visible = false;
        }

        private void cbCorreos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
