using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetAllRates();

            listBoxCurrDepart.Sorted = true;
            listBoxCurrArrivee.Sorted = true;


            initCurrList(response);
        }

        private void initCurrList(string response)
        {

            var jsonRates = JsonConvert.DeserializeObject<Class1>(response);


        }

        private void listBoxCurrArrivee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            double tauxChange;

            if (listBoxCurrDepart.SelectedItem != null && listBoxCurrArrivee.SelectedItem != null)
            {
                if (!listBoxCurrDepart.SelectedItem.ToString().Equals(listBoxCurrArrivee.SelectedItem.ToString()))
                {
                    textBoxCurrDepart.Text = listBoxCurrDepart.SelectedItem.ToString();
                    textBoxCurrArrivee.Text = listBoxCurrArrivee.SelectedItem.ToString();

                    var response = await ApiHelper.GetChangeRate(listBoxCurrDepart.SelectedItem.ToString(), listBoxCurrArrivee.SelectedItem.ToString());

                    //string test = JsonConvert.DeserializeObject<Class1>(response).rates; ==> modifier Class1 pour récupérer directement le taux de change unique
                }
                else
                {
                    //message erreur meme devise
                }
                
            }
            
        }
    }
}
