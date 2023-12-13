using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageDetection;
using Xamarin.Forms;

namespace Ice_Translate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Traduzir(object sender, EventArgs args)
        {
            var detector = new LanguageDetector();

            detector.AddLanguages(new[] { "eng", "por", "ita", "fra", "spa" });
            var lingua = detector.Detect(txtidioma.Text);
            if(lingua == "eng")
            {
                lingua = "Inglês";
            }
            else if(lingua == "spa")
            {
                lingua = "Espanhol";
            }
            else if(lingua == "por")
            {
                lingua = "Português";
            }
            else if (lingua == "ita")
            {
                lingua = "Italiano";
            }
            else if (lingua == "fra")
            {
                lingua = "Francês";
            }
            txtverificado.Text = lingua;
        }
    }
}
