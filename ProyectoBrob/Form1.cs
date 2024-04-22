using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBrob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Carrera";
            dataGridView1.Columns[3].Name = "Edad";
            dataGridView1.Columns[4].Name = "Fecha de Ejecución";

            ToolTip toolTipNombre = new ToolTip();
            toolTipNombre.SetToolTip(txtNombre, "Ingrese su nombre aquí");

            ToolTip toolTipApellido = new ToolTip();
            toolTipApellido.SetToolTip(txtApellido, "Ingrese su apellido aquí");

            ToolTip toolTipCarrera = new ToolTip();
            toolTipCarrera.SetToolTip(txtCarrera, "Ingrese su carrera aquí");

            ToolTip toolTipEdad = new ToolTip();
            toolTipEdad.SetToolTip(txtEdad, "Ingrese su edad aquí");

            
            ToolTip toolTipAceptar = new ToolTip();
            toolTipAceptar.SetToolTip(btnAceptar, "Aceptar");

            ToolTip toolTipSiguiente = new ToolTip();
            toolTipSiguiente.SetToolTip(btnSuiguiente, "Siguiente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))
            {
             
                MessageBox.Show("Debe llenar todos los campos requeridos para continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            if (!int.TryParse(txtEdad.Text, out _))
            {
                
                MessageBox.Show("La edad debe ser un número válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string carrera = txtCarrera.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            DateTime fechaEjecucion = dtEjecucion.Value;
            dataGridView1.Rows.Add(nombre, apellido, carrera, edad, fechaEjecucion);

            
            MessageBox.Show("Sus datos se han ingresado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuiguiente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCarrera.Text.Trim() == "" || txtEdad.Text.Trim() == "")
            {

                MessageBox.Show("Si desea avanzar debe llenar todos los datos de registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Form2 form2 = new Form2();


                form2.Show();
            }
        }
    }
    
}
