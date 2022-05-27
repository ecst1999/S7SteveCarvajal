using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7SteveCarvajal.Models;

namespace S7SteveCarvajal
{
    public partial class Form1 : Form
    {
        DbModel con = new DbModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Conectar();

            string consulta = "INSERT INTO tutores VALUES (NULL, '" + txtNombreTutor.Text + "', 1 );";

            con.EjecutarSql(consulta);

            txtNombreTutor.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 's7_tutoriasDataSet.estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.s7_tutoriasDataSet.estudiantes);
            // TODO: esta línea de código carga datos en la tabla 's7_tutoriasDataSet.tutores' Puede moverla o quitarla según sea necesario.
            this.tutoresTableAdapter.Fill(this.s7_tutoriasDataSet.tutores);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Conectar();

            string consulta = "INSERT INTO tutores_estudiantes VALUES (" + cmbTutor.SelectedValue + "," + cmbEstudiante.SelectedValue + " );";

            con.EjecutarSql(consulta);
        }
    }
}
