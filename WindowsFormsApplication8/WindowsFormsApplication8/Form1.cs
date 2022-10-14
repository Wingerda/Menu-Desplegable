using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.PersonalizarDiseno();
        }

        private void PersonalizarDiseno()
        {
            this.panelmedio.Visible = false;
            this.panelmedio1.Visible = false;
            this.panelmedioListados.Visible = false;
            this.panelmediaListado2.Visible = false;
            this.panelGerencial.Visible = false;
        }

        private void OcultarSubmenu()
        {
           if(this.panelmedio.Visible==true)
               this.panelmedio.Visible = false;
               this.panelmediaListado2.Visible = false;
                this.panelGerencial.Visible = false;

            if (this.panelmedio1.Visible == true)
               this.panelmedio1.Visible = false;
               this.panelmediaListado2.Visible = false;
                this.panelGerencial.Visible = false;

            if (this.panelmedioListados.Visible == true)
                this.panelmedioListados.Visible = false;

        }

        private void MostrarSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                this.OcultarSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;


        }


        private void paneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmedios_Click(object sender, EventArgs e)
        {
            this.MostrarSubMenu(this.panelmedio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            AbrirFormHijo(new FrMarca());

            this.OcultarSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MostrarSubMenu(this.panelmedio1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Abrir Formulario
            //Abrie Archivos
            this.OcultarSubmenu();
        }

        private Form FormActivo = null;
        private void AbrirFormHijo(Form FormHijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = FormHijo;
            FormHijo.TopLevel = false;//el form tiene nivel control
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            this.panelhijo.Controls.Add(FormHijo);
            this.panelhijo.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.MostrarSubMenu(this.panelmedioListados);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.panelmediaListado2.Visible == false)
                this.panelmediaListado2.Visible = true;
            else if (this.panelmediaListado2.Visible == true)
                this.panelmediaListado2.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (this.panelGerencial.Visible == false)
                this.panelGerencial.Visible = true;
            else if (this.panelGerencial.Visible == true)
                this.panelGerencial.Visible = false;
        }
    }
}
