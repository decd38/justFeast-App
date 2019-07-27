using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace justFeast
{
    public partial class convertAssistant : Form
    {
        public convertAssistant()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }

        cookConvert.CookingUnit myConvert = new cookConvert.CookingUnit();

        private void convertAssistant_Load(object sender, EventArgs e)
        {

            comboFromUnit.DataSource = Enum.GetValues(typeof(cookConvert.Cookings));
            comboFromUnit.SelectedItem = cookConvert.Cookings.tablespoonUK;

            comboToUnit.DataSource = Enum.GetValues(typeof(cookConvert.Cookings));
            comboToUnit.SelectedItem = cookConvert.Cookings.tablespoonUS;

            outputUnitRes.Text = "";

            System.Net.ServicePointManager.Expect100Continue = false;
            myConvert.Proxy = System.Net.WebRequest.GetSystemWebProxy();
            myConvert.Proxy.Credentials = CredentialCache.DefaultCredentials;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {           
            try
            {
                double input = double.Parse(inputWeight.Text);
                //System.Net.ServicePointManager.Expect100Continue = false;
                //myConvert.Proxy = System.Net.WebRequest.GetSystemWebProxy();
                //myConvert.Proxy.Credentials = CredentialCache.DefaultCredentials;

                cookConvert.Cookings fromUnit = (cookConvert.Cookings)comboFromUnit.SelectedIndex;
                cookConvert.Cookings toUnit = (cookConvert.Cookings)comboToUnit.SelectedIndex;

                double result = myConvert.ChangeCookingUnit(input, fromUnit, toUnit);

                outputUnitRes.Text = String.Format("Converted Unit = {0:F2}", result);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("You must enter a valid unit to convert", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
