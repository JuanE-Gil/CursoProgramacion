namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // En esta parte creamos una variable para obtener la edad
            string textoEdad = txtEdad.Text;

            // Convertimos el texto a un numero
            int edad = Int32.Parse(textoEdad);
            bool esMayorDeEdad = edad >= 18;

            if (esMayorDeEdad)
            {
                lblResultado.Text = "El usuario es mayor de edad";
            }
            else
            {
                lblResultado.Text = "El usuario es menor de edad";
            }
        }
    }
}