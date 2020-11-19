using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin_Empleado : Form
    {
        public frmLogin_Empleado()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();

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
    }
}
