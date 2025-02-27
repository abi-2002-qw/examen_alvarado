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
            Boolean flag = false;
            String[] datosAlumno = new string[5];
            String DNI = dniBox.Text;
            String apellido = apellidoBox.Text;
            String nombre = nombreBox.Text;
            Double nota = Convert.ToDouble(notaBox.Text);


            foreach (var datos in alumnos)
            {
                if (datos.Length > 0 && datos[0] == DNI)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Dato repetido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                datosAlumno[0] = DNI;
                datosAlumno[1] = apellido;
                datosAlumno[2] = nombre;
                datosAlumno[3] = Convert.ToString(nota);

                if(nota < 5)
                {
                    datosAlumno[4] = "SS";
                }else
                if (nota >= 5 && nota < 7)
                {
                    datosAlumno[4] = "AP";
                }else 
                if(nota >= 7 && nota < 9)
                {
                    datosAlumno[4] = "NT";
                }else 
                if (nota >= 9)
                {
                    datosAlumno[4] = "SB";
                }
                
                alumnos.Add(datosAlumno);

            }

            listBox1.Items.Clear();
            foreach (var datos in alumnos)
            {
                listBox1.Items.Add($"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})");
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
            listBox1.Items.Clear ();
            foreach (var datos in alumnos)
            {
                string datosAlumno = $"{datos[0]} - {datos[1]} {datos[2]} - Nota: {datos[3]} ({datos[4]})";
                listBox1.Items.Add(datosAlumno);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            String dni = dniBox.Text;
            Boolean flag = false;
            for (int i = 0; i < alumnos.Count; i++) {
                if (alumnos[i][0] == dni) { 
                    alumnos.RemoveAt(i);
                    flag = true;
                    break;
                }
            }

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
            String dni = dniBox.Text;
            Boolean flag = false;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i][0] == dni)
                {
                    notaBox.Text = alumnos[i][3];
                    calificacionBox.Text = alumnos[i][4];
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Alumno no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void suspensosButton_Click(object sender, EventArgs e)
        {
         
            listBox1.Items.Clear();
            foreach (var datos in alumnos) {
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
    }
}
