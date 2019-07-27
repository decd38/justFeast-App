using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
using System.Net;

namespace justFeast
{
    public partial class justFeast : Form
    {
        public justFeast()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                recipePictureBx.SizeMode = PictureBoxSizeMode.StretchImage;

                ingredientListBx.Items.Clear();
                comboRecipeList.Items.Clear();
                myVariables.imagesURL.Clear();
                myVariables.recipeIDS.Clear();
                myVariables.cookInstructions.Clear();

                tescoSearchLab1.Hide();
                tescoSearchLab2.Hide();
                tescoPicBox.Hide();

                tescoProdDisplayLab.Hide();
                tescoPriceDisplayLab.Hide();

                string searchFeast = searchTxt.Text;

                /*////////////////////////////////////////////
              //////// SEARCH RECIPE CALL/////// ///////////
              ///////////////////////////////////////////*/

                var client = new RestClient("http://food2fork.com/api/search ");

                var request = new RestRequest();

                System.Net.ServicePointManager.Expect100Continue = false;
                client.Proxy = System.Net.WebRequest.GetSystemWebProxy();
                client.Proxy.Credentials = CredentialCache.DefaultCredentials;

                string myKey = "31fe84d5c583468f519efe4236df6df4";
                request.AddParameter("key", myKey);
                request.AddParameter("q", searchFeast);

                var response = client.Execute(request);

                
                /*////////////////////////////////////////////
                //////// DESERIALISING SEARCH RECIPE CALL/////
                //////// RETURNED JSON INTO C# OBJECTS //////
                ///////////////////////////////////////////*/
                ///
                

                JsonDeserializer deserializer = new JsonDeserializer();

                MySearchRecipeRoot myReturnedRecipes = deserializer.Deserialize<MySearchRecipeRoot>(response);

                List<RecipeSearches> returnedRecipes = myReturnedRecipes.recipes;

                /*////////////////////////////////////////////////
                //////// POPULATE RECIPE COMBOBOX name ///////////
                 //////// POPULATE LIST ARRAY OF RECIPE ID'S//////
                  //////// POPULATE INSTRUCTIONS URL ////////////
                  //////// POPULATE LIST ARRAY OF IMAGE URL'S////
                ////////////////////////////////////////////////*/

                foreach (RecipeSearches r in returnedRecipes)
                {
                    comboRecipeList.Items.Add(r.title);
                    myVariables.recipeIDS.Add(r.recipe_id);
                    myVariables.cookInstructions.Add(r.source_url);
                    myVariables.imagesURL.Add(r.image_url);
                }

                comboRecipeList.SelectedIndex = 0;

                recipePictureBx.Load(myVariables.imagesURL[comboRecipeList.SelectedIndex]);

                btnGetIngedients.Enabled = true;
                btnGetCookInstruct.Enabled = true;
        }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid Search Criteria\n\nEnsure you enter a valid search item(s)",
                   "SEARCH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

    private void comboRecipeList_SelectedIndexChanged(object sender, EventArgs e)
    {
            ingredientListBx.Items.Clear();

            tescoSearchLab1.Hide();
            tescoSearchLab2.Hide();
            tescoPicBox.Hide();

            tescoProdDisplayLab.Hide();
            tescoPriceDisplayLab.Hide();

            try
            {
                recipePictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
                if (comboRecipeList.SelectedIndex == 0)
                {
                    recipePictureBx.Load(myVariables.imagesURL[comboRecipeList.SelectedIndex]);
                }
                else
                {
                    recipePictureBx.Load(myVariables.imagesURL[comboRecipeList.SelectedIndex]);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }      
    }

    private void btnGetIngedients_Click(object sender, EventArgs e)
        {
            recipePictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            
            ingredientListBx.Items.Clear();

            /*////////////////////////////////////////////
            /////////// GET INGREDIENTS CALL//////////////
            ///////////////////////////////////////////*/

            var client = new RestClient("http://food2fork.com/api/get");

            var request = new RestRequest();

            System.Net.ServicePointManager.Expect100Continue = false;
            client.Proxy = System.Net.WebRequest.GetSystemWebProxy();
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;
            
            string myKey = "31fe84d5c583468f519efe4236df6df4";
            request.AddParameter("key", myKey);

            string recipeID = myVariables.recipeIDS[comboRecipeList.SelectedIndex];

            request.AddParameter("rId", recipeID);
            
            var response = client.Execute(request);

            /*////////////////////////////////////////////
            //////// DESERIALISING  GET INGREDIENTS CALL//
            //////// RETURNED JSON INTO C# OBJECTS //////
            ///////////////////////////////////////////*/

            JsonDeserializer deserializer = new JsonDeserializer();

            MyIngredientRoot myIng = deserializer.Deserialize<MyIngredientRoot>(response);

            IngredientProperty myIngredients = myIng.recipe;

            List<string> ingredientList = myIngredients.ingredients;

            /*////////////////////////////////////////////
            //////// POPULATE LIST BOX OF INGREDIENTS/////
            ///////////////////////////////////////////*/

            foreach (string inG in ingredientList)
            {
                ingredientListBx.Items.Add(inG);
            }

            tescoSearchLab1.Show();
            tescoSearchLab2.Show();
            tescoPicBox.Show();
        }        
     
        private void justFeast_Load(object sender, EventArgs e)
        {
            tescoSearchLab1.Hide();
            tescoSearchLab2.Hide();
            tescoPicBox.Hide();

            tescoProdDisplayLab.Hide();
            tescoPriceDisplayLab.Hide();


            recipePictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            recipePictureBx.Image = Properties.Resources.justFeastPic;

            btnGetIngedients.Enabled = false;
            btnGetCookInstruct.Enabled = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {            
            convertAssistant convertAs = new convertAssistant();
            convertAs.Show();
        }

        private void ingredientListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            tescoSearchLab1.Hide();
            tescoSearchLab2.Hide();
            tescoPicBox.Hide();

            /*////////////////////////////////////////////
            //////// SEARCH TESCO CALL/////// ///////////
            ///////////////////////////////////////////*/

            var client = new RestClient("https://dev.tescolabs.com/grocery/products/");

                    var request = new RestRequest();

                    string myKey = "eee761bf115044b795d3eab923c9222f";
                    client.AddDefaultHeader("Ocp-Apim-Subscription-Key", myKey);

                    System.Net.ServicePointManager.Expect100Continue = false;
                    client.Proxy = System.Net.WebRequest.GetSystemWebProxy();
                    client.Proxy.Credentials = CredentialCache.DefaultCredentials;

                    int offset = 0;
                    int limit = 10;

                    request.AddParameter("query", ingredientListBx.SelectedItem);
                    request.AddParameter("offset", offset);
                    request.AddParameter("limit", limit);

                    var response = client.Execute(request);

            /*////////////////////////////////////////////
              //////// DESERIALISING TESCO CALL///////////
              //////// RETURNED JSON INTO C# OBJECTS //////
              ///////////////////////////////////////////*/

            JsonDeserializer deserializer = new JsonDeserializer();
            
                    TescoRootObject myReturnedProduct = deserializer.Deserialize<TescoRootObject>(response);

                    Uk productCountry = myReturnedProduct.uk;

                    Ghs myGhs = productCountry.ghs;

                    Products myProducts = myGhs.products;

                    List<TescoResult> myResult = myProducts.results;

                    string tescoProdOutput = "";
                    string tescoPriceOutput = "";
                    string spaceFiller = "                                                                                  ";
                    int outputLength = 50;

            /*////////////////////////////////////////////
            /////POPULATE TESCO PRODUCT & PRICE LIST///////
            ///////////////////////////////////////////*/


            foreach (TescoResult r in myResult)
                    {
                    int difference = 0;
                    if (r.name.Length < outputLength)
                        {
                        difference = outputLength - r.name.Length;

                        tescoProdOutput += (r.name + spaceFiller.Substring(1, difference)+ "\n");
                        tescoPriceOutput += ("€" + r.price.ToString("0.00") + "\n");                        
                        }
                        else
                        {
                        tescoProdOutput += r.name.Substring(0, outputLength) + "\n";
                        tescoPriceOutput += ("€" + r.price.ToString("0.00") + "\n");
                        }
                    
                }
                
                tescoProdDisplayLab.Text ="Product Description:\n\n" + tescoProdOutput;
                tescoPriceDisplayLab.Text = "Price:\n\n" + tescoPriceOutput;

                tescoProdDisplayLab.Show();
                tescoPriceDisplayLab.Show();
        }

        private void btnGetCookInstruct_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(myVariables.cookInstructions[comboRecipeList.SelectedIndex]);
        }
    }

    /*////////////////////////////////////////////
    //////// THE CLASSES  //////////////////////
    ///////////////////////////////////////////*/


    /*////////////////////////////////////////////
   //////// RECIPE SEARCH //////////////////////
  ///////////////////////////////////////////*/

    public class RecipeSearches
    {
        public string publisher { get; set; }
        public string f2f_url { get; set; }
        public string title { get; set; }
        public string source_url { get; set; }
        public string recipe_id { get; set; }
        public string image_url { get; set; }
        public double social_rank { get; set; }
        public string publisher_url { get; set; }
    }

    public class MySearchRecipeRoot
    {
        public int count { get; set; }
        public List<RecipeSearches> recipes { get; set; }
    }
    

    /*////////////////////////////////////////////
   //////// INGREDIENTS //////////////////////
  ///////////////////////////////////////////*/

    public class IngredientProperty
    {
        public string publisher { get; set; }
        public string f2f_url { get; set; }
        public List<string> ingredients { get; set; }
        public string source_url { get; set; }
        public string recipe_id { get; set; }
        public string image_url { get; set; }
        public double social_rank { get; set; }
        public string publisher_url { get; set; }
        public string title { get; set; }
    }

    public class MyIngredientRoot
    {
        public IngredientProperty recipe { get; set; }
    }

    /*////////////////////////////////////////////
    //////// TESCO /////// //////////////////////
   ///////////////////////////////////////////*/
   

    public class Filters
    {
    }

    public class Totals
    {
        public int all { get; set; }
        public int @new { get; set; }
        public int offer { get; set; }
    }

    public class TescoResult
    {
        public string image { get; set; }
        public string superDepartment { get; set; }
        public int tpnb { get; set; }
        public string ContentsMeasureType { get; set; }
        public string name { get; set; }
        public int UnitOfSale { get; set; }
        public double AverageSellingUnitWeight { get; set; }
        public List<string> description { get; set; }
        public string UnitQuantity { get; set; }
        public string id { get; set; }
        public double ContentsQuantity { get; set; }
        public string department { get; set; }
        public double price { get; set; }
        public double unitprice { get; set; }
    }
      
    public class Products
    {
        public string input_query { get; set; }
        public string output_query { get; set; }
        public Filters filters { get; set; }
        public Totals totals { get; set; }
        public string queryPhase { get; set; }
        public string config { get; set; }
        public List<TescoResult> results { get; set; }
        public List<object> suggestions { get; set; }
    }

    public class Ghs
    {
        public Products products { get; set; }
    }

    public class Uk
    {
        public Ghs ghs { get; set; }
    }

    public class TescoRootObject
    {
        public Uk uk { get; set; }
    }

    /*//////////////////////////////////////////////////////////
    //////// MY VARIABLE CLASS - ACCESS THROUGHOUT PROGRAM   ///
    ////////////////////////////////////////////////////////////*/


    class myVariables
    {
        public static List<string> imagesURL = new List<string>();
        public static List<string> recipeIDS = new List<string>();
        public static List<string> cookInstructions = new List<string>();
    }

    /*/////////////////////////////////////////*/



}
