using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using CapaDatos;
namespace CapaPresentacion
{

    public partial class CONEXION_MANUAL : Form

    {
        private CapaDatos.AES aes = new CapaDatos.AES();
        public CONEXION_MANUAL()
        {
            InitializeComponent();
        }
        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        string dbcnString;
        public void ReadfromXML()
        {

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtCnString.Text = (aes.Decrypt(dbcnString, CapaDatos.Desencryptacion.appPwdUnique, int.Parse("256")));

            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {


            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavetoXML(aes.Encrypt(txtCnString.Text, CapaDatos.Desencryptacion.appPwdUnique, int.Parse("256")));
            mostrar();

        }
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CapaDatos.Conexion.Conectar;
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);




                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                MessageBox.Show("Coneccion realizada correctamente", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sin conexion a la Base de datos", "Conexion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            //CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);

        }
        private void CONEXION_MANUAL_Load(object sender, EventArgs e)
        {
            ReadfromXML();
        }
    }
}
