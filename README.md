# justFeast-App
Windows Form Recipe Search App with built in Tesco Ingredient search
Objective:  To search for food Recipes and their ingredients. 
Application Name:  “Just Feast”
Service Description 
The application is a Recipe Search Application; the App is ideally targeted at cooking enthusiast who wish to search for a Recipe, get the ingredients, cooking instructions and check the price of those ingredients from Tesco.com. 
Application Overview 
The application is designed to perform a search for any valid recipe in the “Food2Fork” api directory and return those searches for the user to select.  Upon selecting that Recipe the user can then get the ingredients of that recipe and the cooking instructions.  Furthermore a user can also click any ingredient and it returns a top ten search result from Tesco of that ingredient. 
Application Design
Upon loading the application is clearly laid out for users.   There is a textbox adjacent to a “search” button therefore it is clearly identifiable to the user to enter a recipe search & click search.  The “Get Ingredients!”  & “Get Cooking Instructions!” buttons are enabled as false until the combo box of recipes is populated with returned recipe searches. 
Once a search is inputted and the search button is clicked the combo box is populated and the image automatically changes to the selected Recipe in the combo box. 
Once a user selects which recipe they want from the combo box (and of course the picture of that recipe automatically changes when selected) they click the “Get Ingredients” button to return the ingredients of said recipe.   The ingredients are displayed as well as an invitation in the form of a label to click on any ingredient to return a top 10 search result from Tesco.
The “Get Cooking Instructions!” button allows the user to click it while any recipe is selected to open a web page of the source recipe including the cooking instructions . 

Added Extra
As an addition to the application you have the ability to convert different ingredients units.  E.g. if you needed to convert “2 pints (UK) to Litres.”   However the SOAP URL seems to have been updated or removed as it’s suddenly unable to function.  The attached screen image is prior to the publisher removal/update.
(Error Message now -   System.Net.WebException: 'The request failed with HTTP status 404: Not Found.')

Application Summary
REST
The REST API Library utilised for the application is RESTSHARP.   
REST API’S	Number of calls	Response Format	API Key needed
Food2Fork	          2	              JSON	        YES
Tesco	              1	              JSON	        YES

The application calls to Food2Fork for both the Recipe Search and the return of Recipe Ingredients are as follows:

Recipe Search:    var client = new RestClient("http://food2fork.com/api/search ");
  var request = new RestRequest();
                string myKey = "31fe84d5c583468f519efe4236df6df4";
                request.AddParameter("key", myKey);
                request.AddParameter("q", searchFeast);

                var response = client.Execute(request);
The GET ingredients request is based on a unique Recipe ID returned in the search.  Therefore once a recipe has been selected from the returned search its unique ID number is utilised to GET the recipe ingredients data. 
Get Ingredients:  var client = new RestClient("http://food2fork.com/api/get");	            	 	  var request = new RestRequest();            
            	 string myKey = "31fe84d5c583468f519efe4236df6df4";
           	 request.AddParameter("key", myKey);

            	 string recipeID = myVariables.recipeIDS[comboRecipeList.SelectedIndex];

            	 request.AddParameter("rId", recipeID);
            
            	 var response = client.Execute(request);
The application calls to Tesco for a top ten search of the selected Recipe Ingredient along with its respective price:
Tesco:           var client = new RestClient("https://dev.tescolabs.com/grocery/products/");

            var request = new RestRequest();

            string myKey = "eee761bf115044b795d3eab923c9222f";
            client.AddDefaultHeader("Ocp-Apim-Subscription-Key", myKey);

            int offset = 0;
            int limit = 10;

            request.AddParameter("query", ingredientListBx.SelectedItem);
            request.AddParameter("offset", offset);
            request.AddParameter("limit", limit);

            var response = client.Execute(request);
Source URL for the Cooking Instructions:

The application accesses the source url of the cooking instructions from a List Array which is populated upon searching.  The selected index of the Recipe ComboBox is then used as the selector of the cooking instructions url List array to load the address into the opened web page.  The code once the “Get Cooking Instructions!” button is pressed is simply one line!
            System.Diagnostics.Process.Start(myVariables.cookInstructions[comboRecipeList.SelectedIndex]);

SOAP
Finally the SOAP API in the application is to convert cooking units from one to another.  The entire class added in the service reference and the application creates an instance of the class enabling it to use the convert cooking unit method. 
cookConvert.CookingUnit myConvert = new cookConvert.CookingUnit();
double result = myConvert.ChangeCookingUnit(input, fromUnit, toUnit);
SOAP API’S	Number of calls	Response Format
http://www.webservicex.net/ConvertCooking.asmx?WSDL	1	XML

Conclusion
The Just Feast application satisfies the requirements of the objective to obtain Recipes,  their ingredients and cooking instructions.  In addition to this it not only allows the user to view the results but also to price individual ingredients from a large retail grocery provider (Tesco).   The lay out is intuitive & easy to use and the required task can be completed with ease.  
However although the application meets the objective requirements it does have one highlighted flaw; it does not provide cooking instructions built into the app to run as an independent entity.  This was not an intentional omission as the API does not return any cooking instructions in the JSON.  
Recommendation 
Due to the fact that the instructions are not returned it is recommended the publisher be contacted to highlight this flaw & ask them to address.  Therefore the application can use the same API with the addition of the updated instructions returned in the JSON to be utilised.  However if the publisher was unwilling to fulfil this task the only other alternative would be to search for a new API that does include instructions in its JSON along with recipes & ingredients.  
Due to the publisher removing/updating their SOAP it is proposed they are contacted to discover the new URL or sourcing an alternative SOAP provider of converting cooking units. 

