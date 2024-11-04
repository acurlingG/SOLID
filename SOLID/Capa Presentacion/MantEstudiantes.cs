using SOLID.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID.Capa_Presentacion
{
    public partial class MantEstudiantes : Form
    {
        public MantEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsEstudiantes estudiantes = new ClsEstudiantes();
            estudiantes.Agregar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsEstudiantes estudiantes = new ClsEstudiantes();
            estudiantes.Borrar();
        }
    }
}
