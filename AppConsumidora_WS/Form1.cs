using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppConsumidora_WS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (

Convert.ToString(this.comboBox1.SelectedItem) != ""
&& Convert.ToString(this.textBox1.Text) != ""
&& Convert.ToString(this.textBox2.Text) != ""

)
            {
                WSOperacionesMatematicas.Operaciones_Matematicas ObjOperacionesMatematicas = new WSOperacionesMatematicas.Operaciones_Matematicas();

                Int32 resultado = 0;
                this.textBox3.Text = string.Empty;

                switch (Convert.ToString(this.comboBox1.SelectedItem))
                {
                    case "Add":
                        resultado = ObjOperacionesMatematicas.Add(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.textBox2.Text));
                        break;

                    case "Substract":
                        resultado = ObjOperacionesMatematicas.Substract(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.textBox2.Text));
                        break;

                    case "Multiply":
                        resultado = ObjOperacionesMatematicas.Multiply(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.textBox2.Text));
                        break;

                    case "Divide":
                        resultado = ObjOperacionesMatematicas.Divide(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.textBox2.Text));
                        break;

                }

                this.textBox3.Text = resultado.ToString();
            }
        }
    }
}
