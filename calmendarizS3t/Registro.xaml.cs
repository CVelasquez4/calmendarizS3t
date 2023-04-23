using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calmendarizS3t
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        
        private void btnCalcular1_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtNotaSeg1.Text) < 0))
            {
                txtNotaSeg1.Text = "";
                txtNotaEx1.Text = "";
                lblParcial1.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaSeg1.Text) > 10))
            {
                txtNotaSeg1.Text = "";
                txtNotaEx1.Text = "";
                lblParcial1.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaEx1.Text) < 0))
            {
                txtNotaSeg1.Text = "";
                txtNotaEx1.Text = "";
                lblParcial1.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaEx1.Text) > 10))
            {
                txtNotaSeg1.Text = "";
                txtNotaEx1.Text = "";
                lblParcial1.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else
            {
                double notSeg1 = Convert.ToDouble(txtNotaSeg1.Text) * 0.3;
                double notEx1 = Convert.ToDouble(txtNotaEx1.Text) * 0.2;
                double parcial1 = notSeg1 + notEx1;
                lblParcial1.Text = parcial1.ToString();

            }

        }

        private void btnCalcular2_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtNotaSeg2.Text) < 0))
            {
                txtNotaSeg2.Text = "";
                txtNotaEx2.Text = "";
                lblParcial2.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaSeg2.Text) > 10))
            {
                txtNotaSeg2.Text = "";
                txtNotaEx2.Text = "";
                lblParcial2.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaEx2.Text) > 10))
            {
                txtNotaSeg2.Text = "";
                txtNotaEx2.Text = "";
                lblParcial2.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else if ((Convert.ToDouble(txtNotaEx2.Text) < 0))
            {
                txtNotaSeg2.Text = "";
                txtNotaEx2.Text = "";
                lblParcial2.Text = "";
                DisplayAlert("Error en el ingreso de notas", "Las notas deben comprender entre 0.1 y 10", "Cerrar");
            }
            else
            {
                double notSeg2 = Convert.ToDouble(txtNotaSeg2.Text) * 0.3;
                double notEx2 = Convert.ToDouble(txtNotaEx2.Text) * 0.2;
                double parcial2 = notSeg2 + notEx2;
                lblParcial2.Text = parcial2.ToString();

            }

        }

        private void btnEstado_Clicked(object sender, EventArgs e)
        {
            double notfinal = Convert.ToDouble(lblParcial1.Text) + Convert.ToDouble(lblParcial2.Text);
            if (notfinal >= 7)
            {
                lblEstado.Text = "APROBADO";
            }
            if (notfinal < 7)
            {
                lblEstado.Text = "COMPLEMENTARIO";
            }
            if (notfinal < 3)
            {
                lblEstado.Text = "REPROBADO";
            }

        }
    }
}