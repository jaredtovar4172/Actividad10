using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej10_NumerosRomanos
{
    public partial class Form1 : Form
    {
        Romano mRomano;
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mRomano = new Romano();
            int arab = int.Parse(textBox1.Text.ToString());
            string roman = mRomano.ConvertArabicToRoman(arab);
            label3.Text = roman;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            label3.Text = "......";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
