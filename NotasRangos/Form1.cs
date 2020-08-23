using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasRangos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double nota5;
            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);
            nota4= double.Parse(txtnota4.Text);
            nota5= double.Parse(txtnota5.Text);
            lblnota1.Text = Convert.ToString(txtnota1);
            lblnota2.Text = Convert.ToString(txtnota2);
            lblnota3.Text = Convert.ToString(txtnota3);
            lblnota4.Text = Convert.ToString(txtnota4);
            lblnota5.Text = Convert.ToString(txtnota5);
            if (nota1>=0 &&nota1<=1) 
            {
                lblnota1.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }else if (nota1>1&&nota1<3) 
            {
                lblnota1.Text = "Reprueba la materia y puede hacer la habilitación";
            }else if (nota1>=3&&nota1<4) 
            {
                lblnota1.Text = "Aprueba la materia con plan de mejora";
            }else if (nota1>=4&&nota1<=4.5) 
            {
                lblnota1.Text = "Buen rendimiento";
            }else if (nota1>4.5&&nota1<5) 
            {
                lblnota1.Text = "Excelente";
            }else if (nota1==5) 
            {
                lblnota1.Text = "Graduado con honores";
            }
            else
            {
                MessageBox.Show("La nota ingresada no es válida");
            }
            if (nota2 >= 0 && nota2 <= 1)
            {
                lblnota2.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }
            else if (nota2 > 1 && nota2 < 3)
            {
                lblnota2.Text = "Reprueba la materia y puede hacer la habilitación";
            }
            else if (nota2 >= 3 && nota2 < 4)
            {
                lblnota2.Text = "Aprueba la materia con plan de mejora";
            }
            else if (nota2 >= 4 && nota2 <= 4.5)
            {
                lblnota2.Text = "Buen rendimiento";
            }
            else if (nota2 > 4.5 && nota2 < 5)
            {
                lblnota2.Text = "Excelente";
            }
            else if (nota2 == 5)
            {
                lblnota2.Text = "Graduado con honores";
            }
            else
            {
                MessageBox.Show("La nota ingresada no es válida");
            }
            if (nota3 >= 0 && nota3 <= 1)
            {
                lblnota3.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }
            else if (nota3 > 1 && nota3 < 3)
            {
                lblnota3.Text = "Reprueba la materia y puede hacer la habilitación";
            }
            else if (nota3 >= 3 && nota3 < 4)
            {
                lblnota3.Text = "Aprueba la materia con plan de mejora";
            }
            else if (nota3 >= 4 && nota3 <= 4.5)
            {
                lblnota3.Text = "Buen rendimiento";
            }
            else if (nota3 > 4.5 && nota3 < 5)
            {
                lblnota3.Text = "Excelente";
            }
            else if (nota3 == 5)
            {
                lblnota3.Text = "Graduado con honores";
            }
            else
            {
                MessageBox.Show("La nota ingresada no es válida");
            }
            if (nota4 >= 0 && nota4 <= 1)
            {
                lblnota4.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }
            else if (nota4 > 1 && nota4 < 3)
            {
                lblnota4.Text = "Reprueba la materia y puede hacer la habilitación";
            }
            else if (nota4 >= 3 && nota4 < 4)
            {
                lblnota4.Text = "Aprueba la materia con plan de mejora";
            }
            else if (nota4 >= 4 && nota4 <= 4.5)
            {
                lblnota4.Text = "Buen rendimiento";
            }
            else if (nota4 > 4.5 && nota4 < 5)
            {
                lblnota4.Text = "Excelente";
            }
            else if (nota4 == 5)
            {
                lblnota4.Text = "Graduado con honores";
            }
            else
            {
                MessageBox.Show("La nota ingresada no es válida");
            }
            if (nota5 >= 0 && nota5 <= 1)
            {
                lblnota5.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
            }
            else if (nota5 > 1 && nota5 < 3)
            {
                lblnota5.Text = "Reprueba la materia y puede hacer la habilitación";
            }
            else if (nota5 >= 3 && nota5 < 4)
            {
                lblnota5.Text = "Aprueba la materia con plan de mejora";
            }
            else if (nota5 >= 4 && nota5 <= 4.5)
            {
                lblnota5.Text = "Buen rendimiento";
            }
            else if (nota5 > 4.5 && nota5 < 5)
            {
                lblnota5.Text = "Excelente";
            }
            else if (nota5 == 5)
            {
                lblnota5.Text = "Graduado con honores";
            }else
            {
                MessageBox.Show("La nota ingresada no es válida");
            }
            gb1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            txtnota4.Text = String.Empty;
            txtnota5.Text = String.Empty;
            txtnota1.Focus();
            gb1.Visible = false;
        }
    }
}
