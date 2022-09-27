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
    public partial class frmSecretariaDeAgricultura : Form
    {
        public frmSecretariaDeAgricultura()
        {
            InitializeComponent();
        }
        //Creo estructura para meter diferentes tipos de datos
        public struct Agricultura
        {
            public string vLocalidad;
            public string vCultivo;
            public int vLocalidadNumero;
            public int vCultivoNumero;
        }
        //Declaro Matriz
        float[,] MAgricultura = new float[10, 10];
        private void tsmLocalidades_Click(object sender, EventArgs e)
        {
            frmLocalidades NewObject = new frmLocalidades();
            NewObject.ShowDialog();
            
        }

        private void tsmCultivos_Click(object sender, EventArgs e)
        {
            frmCultivos NewObject = new frmCultivos();
            NewObject.ShowDialog();
        }

        private void tsmProduccion_Click(object sender, EventArgs e)
        {
            frmToneladas NewObject = new frmToneladas();
            NewObject.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSecretariaDeAgricultura_Load(object sender, EventArgs e)
        {

        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProduccion newObject = new frmConsultaProduccion();
            newObject.ShowDialog();
        }
    }
}
