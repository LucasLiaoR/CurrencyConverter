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

        static string previouslyDeletedItemArrivee;
        static string previouslyDeletedItemDepart;


        private void listBoxCheckChanged(object sender, EventArgs e)
        {
            ListBox listBoxChanged = (ListBox)sender;
            

            if (listBoxChanged.Name == "listBoxCurrDepart")
            {
                if (previouslyDeletedItemArrivee != null)
                {
                    listBoxCurrArrivee.Items.Add(previouslyDeletedItemArrivee);
                }

                previouslyDeletedItemArrivee = listBoxChanged.SelectedItem.ToString();
                
                listBoxCurrArrivee.Items.Remove(listBoxChanged.SelectedItem.ToString());

                listBoxCurrArrivee.Sorted = true; 
            }
            else
            {
                if (previouslyDeletedItemDepart != null)
                {
                    listBoxCurrDepart.Items.Add(previouslyDeletedItemDepart);
                }

                previouslyDeletedItemDepart = listBoxChanged.SelectedItem.ToString();

                listBoxCurrDepart.Items.Remove(listBoxChanged.SelectedItem.ToString());

                listBoxCurrArrivee.Sorted = true;
            }

            if (listBoxCurrArrivee.SelectedItem != null && listBoxCurrDepart.SelectedItem != null)
            {
                btnConvertir_Click(sender, e);
            }
        }

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            string deviseDepart = listBoxCurrDepart.SelectedItem.ToString();
            string deviseArrivee = listBoxCurrArrivee.SelectedItem.ToString();

            if (listBoxCurrDepart.SelectedItem != null && listBoxCurrArrivee.SelectedItem != null)
            {
                if (!deviseDepart.Equals(deviseArrivee))
                {

                    var response = await ApiHelper.GetChangeRate(deviseDepart, deviseArrivee);

                    var test = JsonConvert.DeserializeObject<TauxChange>(response);

                    tauxChange.Text = test.rates[deviseArrivee].ToString();

                    calculerDevises();
                }
                else
                {
                    //message erreur meme devise
                }
                
            }
            
        }

        private void calculerDevises()
        {


            textBoxCurrArrivee.Text = (Convert.ToDouble(textBoxCurrDepart.Text) * Convert.ToDouble(tauxChange.Text)).ToString();
        }

    }
}
