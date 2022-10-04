using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_9___Menus_en_C____
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //o this.close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Rigoberto Zamora", "Acerca de..."/*Para el titulo de la ventana emergente*/, MessageBoxButtons.OK, MessageBoxIcon.Information /*simbolo dentro del cuadro emergente*/);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor(); //Borra ambas palomitas
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true; //te pone una palomita :D
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void borrarColor() //Funcion que limpiará la palomita del menu de opcionbes
        {
            rojoToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = false;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style); //comic sans y times estan en todas las computadoras con office
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans MS", 20, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
