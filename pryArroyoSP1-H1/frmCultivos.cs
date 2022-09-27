using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Globalization;

namespace pryArroyoSP1_H1
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            bool Bandera = false;

            StreamReader srNumeroCultivos = new StreamReader("./Cultivos.txt", true); //abro y leo el archivo

            while (!srNumeroCultivos.EndOfStream) // mientra sea diferente a fin de archivo 
            {
                string auxCodigo = srNumeroCultivos.ReadLine(); //cargo la variable con lo que se encuentra en el archivo

                if (mtbNumeroCultivo.Text == auxCodigo.Substring(0, 3)) //Comparo la mascara con lo que se encuentra en los primeros 3 caracteres de la variable para no permitir que se repitan
                {
                    MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                    txtCultivo.Text = "";
                    mtbNumeroCultivo.Text = "";
                    mtbNumeroCultivo.Focus();
                    Bandera = true;// habilito la bandera para que no deje que el dato se cargo

                }

            }
            srNumeroCultivos.Close();

            if (Bandera == false) // si la bandera es falsa dejamos que los datos se carguen en el archivo 
            {
                StreamWriter Cultivos = new StreamWriter("./Cultivos.txt", true);
                Cultivos.WriteLine(mtbNumeroCultivo.Text + " " + txtCultivo.Text);
                MessageBox.Show("Cargado con exito");
                Cultivos.Close();//cierro el archivo
                //limpio los controles
                txtCultivo.Text = "";
                mtbNumeroCultivo.Text = "";
                mtbNumeroCultivo.Focus();
            }



            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Cultivos.txt");
            MessageBox.Show("El archivo fue borrado con exito");
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {

        }
    }
}
