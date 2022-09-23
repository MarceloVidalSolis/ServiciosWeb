using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.AreasCalc
{
    public partial class Áreas : Form
    {
        public decimal Lado = 0;
        public decimal Base = 0;
        public decimal Altura = 0;
        public decimal Radio = 0;
        public decimal Diametro = 0;
        
        public Áreas()
        {
            InitializeComponent();
            Radio_radioButton.Checked = true;
            Radio_textBox.Enabled = true;
            Diametro_textbox.Enabled = false;
        }

        private void Cuadrado_button_Click(object sender, EventArgs e)
        {
            CalculadoraServiceReference.AreasWebServiceSoapClient ws = new CalculadoraServiceReference.AreasWebServiceSoapClient();
            try 
            {
            Lado = Decimal.Parse(Lado_textBox.Text);
            AreaCuadrado_textBox.Text = ws.AreaCuadrado(Lado).ToString();
            }
            catch (FormatException) { }
        }

        private void Circulo_button_Click(object sender, EventArgs e)
        {
            CalculadoraServiceReference.AreasWebServiceSoapClient ws = new CalculadoraServiceReference.AreasWebServiceSoapClient();
            if (Radio_radioButton.Checked == true)
            {
                try
                {
                    Radio = Decimal.Parse(Radio_textBox.Text);
                    Diametro = 0;
                    AreaCirculo_textBox.Text = ws.AreaCirculo(Radio).ToString();
                }
                catch (FormatException) { }
            }
            else if (Diametro_radioButton.Checked == true) 
            {
                try
                {
                Diametro = Decimal.Parse(Diametro_textbox.Text);
                Radio = 0;
                AreaCirculo_textBox.Text = ws.AreaCirculo2(Diametro).ToString();
                }
                catch (FormatException) { }
            }
        }

        private void Triangulo_button_Click(object sender, EventArgs e)
        {
            CalculadoraServiceReference.AreasWebServiceSoapClient ws = new CalculadoraServiceReference.AreasWebServiceSoapClient();
            try
            {
                decimal Base = Decimal.Parse(Base_textBox.Text);
                decimal Altura = Decimal.Parse(Altura_textBox.Text);
                AreaTriangulo_textBox.Text = ws.AreaTriangulo(Base, Altura).ToString();
            }
            catch (FormatException) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AreaCirculo_textBox.TextAlign = HorizontalAlignment.Right;
        }

        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Lado_textBox.Text = "";
            Radio_textBox.Text = "";
            Base_textBox.Text = "";
            Altura_textBox.Text = "";
            Diametro_textbox.Text = "";

            AreaCirculo_textBox.Text = "";
            AreaCuadrado_textBox.Text = "";
            AreaTriangulo_textBox.Text = "";

            Lado = 0;
            Base = 0;
            Altura = 0;
            Radio = 0;
            Diametro = 0;

            Radio_radioButton.Checked = true;

        }

        private void Radio_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_radioButton.Checked == true) 
            {
                Radio_textBox.Enabled = true;
                Diametro_textbox.Enabled = false;
                Diametro_textbox.Text = "";
                Diametro = 0;
                Radio_pictureBox.Visible = true;
                Diametro_pictureBox.Visible = false;
            }
            else if (Radio_radioButton.Checked == false) 
            {
                Diametro_textbox.Enabled = true;
                Radio_textBox.Enabled = false;
                Radio_textBox.Text = "";
                Radio = 0;
                Radio_pictureBox.Visible = false;
                Diametro_pictureBox.Visible = true;
            }                
        }

        private void Diametro_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Diametro_radioButton.Checked == true)
            {
                Radio_textBox.Enabled = false;
                Diametro_textbox.Enabled = true;
                Radio_textBox.Text = "";
                Radio = 0;
                AreaCirculo_textBox.Text = "";
                Radio_pictureBox.Visible = false;
                Diametro_pictureBox.Visible = true;
            }
            else if (Diametro_radioButton.Checked == false)
            {
                Diametro_textbox.Enabled = false;
                Radio_textBox.Enabled = true;
                Diametro_textbox.Text = "";
                Diametro = 0;
                AreaCirculo_textBox.Text = "";
                Radio_pictureBox.Visible = true;
                Diametro_pictureBox.Visible = false;
            }
        }
    }
}
