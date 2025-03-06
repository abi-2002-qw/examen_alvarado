using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_alvarado
{



    public partial class form : Form
    {
        //lista que almacena los alumnos 
        List<string[]> alumnos = new List<string[]>();
        

        public form()
        {
            InitializeComponent();
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            // Verifica si el DNI ya existe
            bool flag = false;
            string DNI = dniBox.Text;
            string apellido = apellidoBox.Text;
            string nombre = nombreBox.Text;

            // Intenta convertir la nota a double
            if (!double.TryParse(notaBox.Text, out double nota) || nota < 0 || nota > 10)
            {
                MessageBox.Show("Error: La nota debe ser un número válido entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el DNI ya existe en la lista de alumnos
            foreach (var datos in alumnos)
            {
                if (datos != null && datos.Length > 0 && datos[0] == DNI)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Error: El DNI ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Crea un nuevo arreglo para el alumno
                string[] datosAlumno = new string[5];

                // Llena el arreglo con los datos del alumno
                datosAlumno[0] = DNI;
                datosAlumno[1] = apellido;
                datosAlumno[2] = nombre;
                datosAlumno[3] = nota.ToString("0.00"); // Formatea la nota con dos decimales

                // Calcula la calificación basada en la nota
                if (nota < 5)
                {
                    datosAlumno[4] = "SS";
                }
                else if (nota >= 5 && nota < 7)
                {
                    datosAlumno[4] = "AP";
                }
                else if (nota >= 7 && nota < 9)
                {
                    datosAlumno[4] = "NT";
                }
                else
                {
                    datosAlumno[4] = "SB";
                }

                // Agrega el arreglo a la lista de alumnos
                alumnos.Add(datosAlumno);

                // Actualiza el ListBox
                ActualizarListBox();
            }
        }

        private void ActualizarListBox()
        {
            // Limpia el ListBox y agrega cada alumno de la lista
            listBox1.Items.Clear();
            foreach (var datos in alumnos)
            {
                if (datos != null && datos.Length >= 5)
                {
                    listBox1.Items.Add($"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})");
                }
            }
        }

        private void apellidoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calificacionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void todosButton_Click(object sender, EventArgs e)
        {
            //limpio y cargo todos los alumnos en la lista al listbx haciendo un recorrido
            listBox1.Items.Clear ();
            foreach (var datos in alumnos)
            {
                string datosAlumno = $"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})";
                listBox1.Items.Add(datosAlumno);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            //obtengo el dni del box
            String dni = dniBox.Text;
            Boolean flag = false;
            //exploro todos los vectores de la lista pero solo en la posicion 0 que pertenece al DNI
            for (int i = 0; i < alumnos.Count; i++) {
                if (alumnos[i][0] == dni) { 
                    // elimino el vector perteneciente a ese dni, el i es la posicion en la lista
                    alumnos.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

            //mensajes de advertencia que se envian segun el estado de la bandera
            if(flag)
            {
                MessageBox.Show("Alumno eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Alumno no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            string dni = dniBox.Text;
            bool flag = false;

            // Limpia el ListBox antes de mostrar nuevos datos
            listBox1.Items.Clear();

            // Recorre la lista de alumnos
            for (int i = 0; i < alumnos.Count; i++)
            {
                // Verifica si el DNI coincide
                if (alumnos[i][0] == dni)
                {
                    // Muestra los datos del alumno en el ListBox
                    listBox1.Items.Add($"DNI: {alumnos[i][0]}");
                    listBox1.Items.Add($"Apellido: {alumnos[i][1]}");
                    listBox1.Items.Add($"Nombre: {alumnos[i][2]}");
                    listBox1.Items.Add($"Nota: {alumnos[i][3]}");
                    listBox1.Items.Add($"Calificación: {alumnos[i][4]}");

                    flag = true; // Marca que se encontró el alumno
                    break;
                }
            }

            // Si no se encontró el alumno, muestra un mensaje de advertencia
            if (!flag)
            {
                MessageBox.Show("Alumno no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void suspensosButton_Click(object sender, EventArgs e)
        {
         
            listBox1.Items.Clear();
            //exploro la lista 
            foreach (var datos in alumnos) {
                //busco el alumno de interes
                if (datos[4] == "SS")
                {
                    
                    string datosAlumno = $"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})";
                    listBox1.Items.Add(datosAlumno);
                }
            }

            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Alumnos no encontrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void aprobadosButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var datos in alumnos)
            {
                if (datos[4] == "AP" || datos[4] == "NT" || datos[4] == "SB")
                {
                    string datosAlumno = $"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})";
                    listBox1.Items.Add(datosAlumno);
                }
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Alumnos no encontrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void mhButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var datos in alumnos)
            {
                if (datos[3] == "10")
                {
                    string datosAlumno = $"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})";
                    listBox1.Items.Add(datosAlumno);
                }
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Alumnos no encontrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void modinotaButton_Click(object sender, EventArgs e)
        {
            String dni = dniBox.Text;
            Double nota = Convert.ToDouble(notaBox.Text);
            Boolean flag = false;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i][0] == dni)
                {
                    alumnos[i][3] = notaBox.Text;
                    if (nota < 5)
                    {
                        alumnos[i][4] = "SS";
                    }
                    else
                    if (nota >= 5 && nota < 7)
                    {
                        alumnos[i][4] = "AP";
                    }
                    else
                    if (nota >= 7 && nota < 9)
                    {
                        alumnos[i][4] = "NT";
                    }
                    else
                    if (nota >= 9)
                    {
                        alumnos[i][4] = "SB";
                    }
                    flag = true;
                    listBox1.Items.Clear();
                    MessageBox.Show("Nota Modificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Alumno no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
