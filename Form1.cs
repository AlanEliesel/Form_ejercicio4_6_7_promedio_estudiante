using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ejercicio4_promedio_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txt_Resultado.Visible = false;
            lbl_Resultado.Visible=false;
            txt_Pruba_Completiva.Visible = false;
            lbl_Pruba_Completiva.Visible=false;
            txt_Nota_Completiva.Visible = false;
            lbl_Nota_Completiva.Visible = false;
            txt_Total.Visible = false;
            lbl_Total.Visible=false;
            
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            int Nota1, Nota2, Nota3, Nota4;



            Nota1 = Convert.ToInt32(txt_nota1.Text);
            Nota2 = Convert.ToInt32(txt_nota2.Text);
            Nota3 = Convert.ToInt32(txt_nota3.Text);
            Nota4 = Convert.ToInt32(txt_nota4.Text);

            double Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;            

            txt_promedio.Text = Promedio.ToString();




            if (Promedio >= 70)
            {
                txt_situacion.Text = "Aprobado";
                txt_situacion.ForeColor = Color.Green;
                txt_promedio.ForeColor = Color.Green;


            }

            else if (Promedio <= 69)
            {
                txt_situacion.Text = "Reprobado";
                txt_situacion.ForeColor = Color.Red;
                txt_promedio.ForeColor = Color.Red;
            }







            if (Promedio <= 69)
            {

                txt_Resultado.Visible = true;
                lbl_Resultado.Visible = true;
                txt_Pruba_Completiva.Visible = true;
                lbl_Pruba_Completiva.Visible = true;
                txt_Nota_Completiva.Visible = true;
                lbl_Nota_Completiva.Visible = true;
                txt_Total.Visible = true;
                lbl_Total.Visible = true;




                txt_Resultado.Enabled = false;
                txt_Nota_Completiva.Enabled = false;
                txt_Total.Enabled = false;

                double NotaCompletiva = Promedio * 50 / 100;
                txt_Nota_Completiva.Text = NotaCompletiva.ToString();

                int PruebaCompletiva = 0;
                 PruebaCompletiva = int.Parse(txt_Pruba_Completiva.Text);


                double Porciento_Prueba_Completiva = PruebaCompletiva * 50 / 100;


                double total = NotaCompletiva + Porciento_Prueba_Completiva;

                txt_Total.Text = total.ToString();

                string resultado;

                if(total >= 70)
                {

                    resultado = "Aprobado";
                    txt_Resultado.Text = resultado;
                    txt_Resultado.ForeColor = Color.Green;

                }
                else if (total <= 69)
                {

                    resultado = "Reprobado";
                    txt_Resultado.Text = resultado;
                    txt_Resultado.ForeColor = Color.Red;

                }
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Clear();
            txt_promedio.Clear();
            txt_situacion.Clear();

            txt_Nota_Completiva.Clear();
            txt_Pruba_Completiva.Clear();
            txt_Resultado.Clear();
            txt_Total.Clear();
        }
    }
}
