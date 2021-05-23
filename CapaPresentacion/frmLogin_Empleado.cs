using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
using System.Net.Mail;
using System.Net;

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
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {



                    if (datos.Rows.Count == 0)
                    {
                        //MessageBox.Show("No Tiene Acceso Al Sistema De Ventas", "Sistema De Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        msgError("USUARIO O CONTRASEÑA INCORRECTO");                    
                    }
                    else
                    {
                        FRMSisVentas PRINCIPAL = new FRMSisVentas();
                        PRINCIPAL.idEmpleado = datos.Rows[0][0].ToString();
                        PRINCIPAL.Emp_Nombre = datos.Rows[0][1].ToString();
                        PRINCIPAL.Emp_Apellido = datos.Rows[0][2].ToString();
                        PRINCIPAL.Emp_Acceso = datos.Rows[0][3].ToString();
                        MessageBox.Show("BIENVENIDO " + PRINCIPAL.Emp_Nombre);
                        PRINCIPAL.Show();
                        this.Hide();

                    }
                }
                else msgError("INGRESE CONTRASEÑA");
            }
            else msgError("INGRESE USUARIO");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }


        public void CBCorreos()
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
                cbCorreos.ValueMember = "Emp_correo";
                cbCorreos.DisplayMember = "Emp_correo";
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
            CBCorreos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
        }

        private void cbCorreos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Mostrar_Empleados()
        {
            DataTable DtMostrar = new DataTable("Empleados");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                string resultado;
                sqlcon.ConnectionString = Conexion.Conectar;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "BuscarContraseña";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(DtMostrar);
                sqlData.SelectCommand.Parameters.AddWithValue("@correo", cbCorreos.Text);
                sqlcon.Open();


            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                DtMostrar = null;
            }


        }
        internal void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add((destinatario));
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                MessageBox.Show("Contraseña Enviada, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Mostrar_Empleados();
            richTextBox1.Text = richTextBox1.Text.Replace("@pass", lblResultadoContraseña.Text);
            enviarCorreo("dj.jhonsi12@gmail.com", "***************", richTextBox1.Text, "Solicitud de Contraseña", cbCorreos.Text, "");


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        //mover formulario
        int posY = 0;
        int posX = 0;

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;

            }
        }
        private void msgError(string msg)
        {
            lblErrorMensaje.Text = " " + msg;
            lblErrorMensaje.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
