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
    public partial class frmToneladas : Form
    {
        public frmToneladas()
        {
            InitializeComponent();
        }

        private void frmToneladas_Load(object sender, EventArgs e)
        {
            StreamReader srLocalidades = new StreamReader("./Localidades.txt"); //abro y leo el archivo


            while (!srLocalidades.EndOfStream) // mientra sea diferente a fin de archivo 
            {
                string Informacion = srLocalidades.ReadLine(); //creo ycargo la variable con lo que se encuentra en el archivo
                lstLocalidad.Items.Add(Informacion.Substring(3)); //cargo la lista desplegable con lo que se encuentre a partir del caracter 4 en adelante
            }
            srLocalidades.Close();

            StreamReader srCultivos = new StreamReader("./Cultivos.txt");
            while (!srCultivos.EndOfStream)
            {
                string Informacion = srCultivos.ReadLine();//creo ycargo la variable con lo que se encuentra en el archivo
                lstCultivo.Items.Add(Informacion.Substring(3)); //cargo la lista desplegable con lo que se encuentre a partir del caracter 4 en adelante
            }
            srCultivos.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            StreamWriter Toneladas = new StreamWriter("./Toneladas.txt", true); //escribo el archivo
            Toneladas.WriteLine(lstLocalidad.Text + ";" + lstCultivo.Text +";" +  txtToneladas.Text +  ";" + dtpFecha.Text); //escribo el archivo con lo que se encuentre en los diferentes controles
            MessageBox.Show("Cargado con exito");
            Toneladas.Close();//cierro el archivo

            //limpio los controles
            txtToneladas.Text = "";
            lstLocalidad.SelectedIndex = -1;
            lstCultivo.SelectedIndex = -1;
            
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Toneladas.txt");
            MessageBox.Show("Archivo borrado con exito");
        }
    }
}
