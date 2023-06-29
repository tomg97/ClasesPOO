using clase2806POO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase2806POO
{
    public partial class Form1 : Form
    {
        Jugador jugador = new Jugador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatada_Click(object sender, EventArgs e)
        {
            jugador.festejo += festejar;
            jugador.insulto += insultar;
            jugador.patear();
        }

        private void insultar(string mensaje, int volumen)
        {
            lblAccion.Text = mensaje + " " + volumen.ToString();
        }

        private void festejar(string mensaje)
        {
            lblAccion.Text = mensaje;
        }
    }
}
