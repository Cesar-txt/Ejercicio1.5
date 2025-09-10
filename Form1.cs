using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO1._5
{
    public partial class Form1 : Form
    {
        private Recursividad recursivo;
        public Form1()
        {
            InitializeComponent();
            recursivo = new Recursividad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);

                if (numero < 0)
                    throw new ArgumentException("⚠️ No se permiten números negativos.");

                label2.Text = recursivo.SumaSecuencia(numero);
            }
            catch (FormatException)
            {
                MessageBox.Show("⚠️ Ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);

                if (numero < 0)
                    throw new ArgumentException("⚠️ No se permiten números negativos.");

                label2.Text = recursivo.FactorialSecuencia(numero);
            }
            catch (FormatException)
            {
                MessageBox.Show("⚠️ Ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);

                if (numero < 0)
                    throw new ArgumentException("⚠️ No se permiten números negativos.");

                label2.Text = recursivo.FibonacciSecuencia(numero);
            }
            catch (FormatException)
            {
                MessageBox.Show("⚠️ Ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
    }
}
