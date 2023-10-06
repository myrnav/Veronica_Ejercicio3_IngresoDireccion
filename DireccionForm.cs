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


    }
}