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
using Newtonsoft.Json.Linq;

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

        }


        private void listBoxCurrArrivee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            

            if (listBoxCurrDepart.SelectedItem != null && listBoxCurrArrivee.SelectedItem != null)
            {
                if (!listBoxCurrDepart.SelectedItem.ToString().Equals(listBoxCurrArrivee.SelectedItem.ToString()))
                {


                    var response = await ApiHelper.GetChangeRate(listBoxCurrDepart.SelectedItem.ToString(), listBoxCurrArrivee.SelectedItem.ToString());

                    var test = JsonConvert.DeserializeObject<TauxChange>(response);

                    textBox1.Text = test.rates[listBoxCurrArrivee.SelectedItem.ToString()].ToString();
                }
                else
                {
                    //message erreur meme devise
                }
                
            }
            
        }

    }
}
