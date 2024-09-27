using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class RegristroDeEdades : Form
    {
        public RegristroDeEdades()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text;
        }
        private void agregar()
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            int fechaNacimiento = dateTimePicker1.Value.Year;
            string ciudad = comboBox1.Text;

            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.FechaNacimiento = dateTimePicker1.Value;
            persona.Ciudad = ciudad;
            Registro registro = new Registro();
            registro.AgregarPersona(persona);
            listBox11.Items.Add($"{persona.Nombre}{Persona.Apellido}{persona.FechaNacimiento}{persona.Ciudad}")
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Trim();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value;
        }
    }
}
