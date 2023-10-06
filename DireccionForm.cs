using System.Reflection;

namespace Veronica_Ejercicio3_IngresoDireccion
{
    public partial class DireccionForm : Form
    {

        //declaro variables
        DireccionModel modelo_direccion;

        public DireccionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelo_direccion = new();
        }

        private void buttonOK_GroupBoxdireccion_Click(object sender, EventArgs e)
        {
            modelo_direccion.direccion_calle = textBoxCalle.Text;
            modelo_direccion.direccion_numero = textBoxNumero.Text;
            modelo_direccion.direccion_piso = textBoxPiso.Text;
            modelo_direccion.direccion_depto = textBoxDepartamento.Text;
            string mensaje = modelo_direccion.ValidarDatosdeDireccion();
            MessageBox.Show(mensaje);
        }
    }
}