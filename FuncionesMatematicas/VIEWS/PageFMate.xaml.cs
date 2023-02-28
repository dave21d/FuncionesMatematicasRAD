using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FuncionesMatematicas.VIEWS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFMate : ContentPage
    {
        public PageFMate()
        {
            InitializeComponent();
        }

        private async void Sumatoria_Clicked(object sender, EventArgs e)
        {
            var ope = new MODELS.Operaciones
            {
                //double resul=Convert.ToDouble(nume1),
                //digito1 =  Convert.ToDouble(nume1.Text),                     //Convert.ToInt32(nume1.ToString()),
                //digito2 = Convert.ToDouble(nume2.Text),                    //Convert.ToInt32(nume2.ToString()),
                resultado= Convert.ToDouble(nume1.Text)+ Convert.ToDouble(nume2.Text),//Convert.ToInt32(nume1.Text)+Convert.ToInt32(nume2.Text) ,                              //(Convert.ToDouble(nume1.Text)+Convert.ToDouble(nume2.Text)),            
               
            };
       
            double dig1 = Convert.ToDouble(nume1.Text);
            double dig2 = Convert.ToDouble(nume2.Text);
            double sumatoria = dig1 + dig2;
            await DisplayAlert("Mensaje", "La suma Total es: " + sumatoria.ToString(), "Aceptar");

            var page = new VIEWS.PageResulOpe();
            page.BindingContext = ope;
            await Navigation.PushAsync(page);

            
        }

        private async void Resta_Clicked(object sender, EventArgs e)
        {
            var ope = new MODELS.Operaciones
            {
                //double resul=Convert.ToDouble(nume1),
                //digito1 =  Convert.ToDouble(nume1.Text),                     //Convert.ToInt32(nume1.ToString()),
                //digito2 = Convert.ToDouble(nume2.Text),                    //Convert.ToInt32(nume2.ToString()),
                resultado = Convert.ToDouble(nume1.Text) - Convert.ToDouble(nume2.Text),//Convert.ToInt32(nume1.Text)+Convert.ToInt32(nume2.Text) ,                              //(Convert.ToDouble(nume1.Text)+Convert.ToDouble(nume2.Text)),            
               
            };


            double dig1 = Convert.ToDouble(nume1.Text);
            double dig2 = Convert.ToDouble(nume2.Text);
            double resta = dig1 - dig2;
            await DisplayAlert("Mensaje", "Su resta Final es: " + resta.ToString(), "Aceptar");

            var page = new VIEWS.PageResulOpe();
            page.BindingContext = ope;
            await Navigation.PushAsync(page);

            
        }

        private  async void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            var ope = new MODELS.Operaciones
            {
                //double resul=Convert.ToDouble(nume1),
                //digito1 =  Convert.ToDouble(nume1.Text),                     //Convert.ToInt32(nume1.ToString()),
                //digito2 = Convert.ToDouble(nume2.Text),                    //Convert.ToInt32(nume2.ToString()),
                resultado = Convert.ToDouble(nume1.Text) * Convert.ToDouble(nume2.Text),//Convert.ToInt32(nume1.Text)+Convert.ToInt32(nume2.Text) ,                              //(Convert.ToDouble(nume1.Text)+Convert.ToDouble(nume2.Text)),            

            };


            double dig1 = Convert.ToDouble(nume1.Text); 
            double dig2 = Convert.ToDouble(nume2.Text);
            double Multiplicacion = dig1 * dig2;
            await DisplayAlert("Mensaje", "Su Multiplicacion Final es: " + Multiplicacion.ToString(), "Aceptar");

            var page = new VIEWS.PageResulOpe();
            page.BindingContext = ope;
            await Navigation.PushAsync(page);

            //DisplayAlert("Mensaje",sumatoria.ToString(),"total");
        }

        private async void Division_Clicked(object sender, EventArgs e)
        {
            var ope = new MODELS.Operaciones
            {
                //double resul=Convert.ToDouble(nume1),
                //digito1 =  Convert.ToDouble(nume1.Text),                     //Convert.ToInt32(nume1.ToString()),
                //digito2 = Convert.ToDouble(nume2.Text),                    //Convert.ToInt32(nume2.ToString()),
                resultado = Convert.ToDouble(nume1.Text) / Convert.ToDouble(nume2.Text),//Convert.ToInt32(nume1.Text)+Convert.ToInt32(nume2.Text) ,                              //(Convert.ToDouble(nume1.Text)+Convert.ToDouble(nume2.Text)),            

            };
            

            double dig1 = Convert.ToDouble(nume1.Text);
            double dig2 = Convert.ToDouble(nume2.Text);
            double division = dig1 / dig2;
            await DisplayAlert("Mensaje", "Su Multiplicacion Final es: " + division.ToString(), "Aceptar");

            var page = new VIEWS.PageResulOpe();
            page.BindingContext = ope;
            await Navigation.PushAsync(page);

            //DisplayAlert("Mensaje",sumatoria.ToString(),"total");
        }
    }
    }
