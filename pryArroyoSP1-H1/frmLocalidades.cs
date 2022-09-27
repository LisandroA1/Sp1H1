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

namespace pryArroyoSP1_H1
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            //File.Create("./Localidades.txt");
            
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            bool Bandera = false;

            StreamReader srNumeroLocalidades = new StreamReader("./Localidades.txt"); //abro y leo el archivo

            while (!srNumeroLocalidades.EndOfStream) // mientra sea diferente a fin de archivo 
            {
                string auxCodigo = srNumeroLocalidades.ReadLine(); //cargo la variable con lo que se encuentra en el archivo

                if (mtbNumeroLocalidad.Text == auxCodigo.Substring(0,3)) //Comparo la mascara con lo que se encuentra en los primeros 3 caracteres de la variable para no permitir que se repitan
                {
                    MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                    txtLocalidad.Text = "";
                    mtbNumeroLocalidad.Text = "";
                    mtbNumeroLocalidad.Focus();
                    Bandera = true; // habilito la bandera para que no deje que el dato se cargo
                }
                
            }
            srNumeroLocalidades.Close();

            if (Bandera == false) // si la bandera es falsa dejamos que los datos se carguen en el archivo 
            {
                StreamWriter Localidades = new StreamWriter("./Localidades.txt", true);
                Localidades.WriteLine(mtbNumeroLocalidad.Text + " " + txtLocalidad.Text);
                MessageBox.Show("Cargado con exito");
                Localidades.Close();//cierro el archivo

                //limpio los controles
                txtLocalidad.Text = "";
                mtbNumeroLocalidad.Text = "";
                mtbNumeroLocalidad.Focus();
            }
            
            
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Localidades.txt");
            MessageBox.Show("El archivo fue borrado con exito");
        }

        private void mtbNumeroLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
