using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            listBox1.Items.Clear();
            int Num, tabla, resultado;
            tabla = int.Parse(textBox1.Text);


            for(Num=1;Num<=12;Num++)
            {
                resultado = Num * tabla;
                listBox1.Items.Add(tabla+"x" + Num + "=" + resultado);
            }

            if (Convert.ToInt32(this.textBox1.Text) > Convert.ToInt32("12"))
            {
                textBox1.Clear();
                listBox1.Items.Clear();
                textBox1.Focus();
                MessageBox.Show("El limite es solo de la tabla del 1 hasta a la del 12");
            }
            else
                if(Convert.ToInt32(this.textBox1.Text) < Convert.ToInt32("1"))
            {
                textBox1.Clear();
                listBox1.Items.Clear();
                textBox1.Focus();
                MessageBox.Show("El limite es solo de la tabla del 1 hasta a la del 12");
            }
            else
                if (textBox1.Text == ("abcdefghijklmnñopqrstuwxyz"))
            {
                MessageBox.Show("Solo acepta caracteres numericos");
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Variable = new Form2();
            Variable.Show();
        }
    }
}
