using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArroyoSP1_H1
{
    public partial class frmConsultaProduccion : Form
    {
        public frmConsultaProduccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader srConsultaProduccion = new StreamReader("./Toneladas.txt");

            while (!srConsultaProduccion.EndOfStream)
            {
                

                

                string line = srConsultaProduccion.ReadLine();
                string[] vecDatosProduccion = line.Split(';');
                dgvConsultaProduccion.Rows.Add(vecDatosProduccion[0], vecDatosProduccion[1], vecDatosProduccion[2]);

                

            }
            srConsultaProduccion.Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultaProduccion.Rows.Clear();
        }
    }
}
