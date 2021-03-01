using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        //useless- acidentally clicked on it lol 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        IList<itemCateogry> ICategory = new List<itemCateogry>();
        IList<item> Item = new List<item>();
        IList<string> Output = new List<String>();


        private void addCategoryButton_Click(object sender, EventArgs e)
        {
           //Parsing / trimming of entered fields
            var numTemp = Int32.Parse(stroreItemCategoryTextBox.Text); 
            var nameTemp = categoryNameTextBox.Text;
            nameTemp.Trim();
            var desTemp = categoryDescriptionTextBox.Text;
            desTemp.Trim();


           //creating temp category object to add to ICategory list
            itemCateogry temp = new itemCateogry { num = numTemp, name = nameTemp, description = desTemp };
            ICategory.Add(temp);
            itemCategoryComboBox.Items.Add(nameTemp);
            Output.Add("\nSAVED; Added New Category: " + nameTemp + "\n");


            updateDisplay();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
           if(itemCategoryComboBox.Text != "")
            {
                //Parsing / trimming of entered fields
                var priceTemp = Double.Parse(itemPriceTextBox.Text); 
                var nameTemp = itemNameTextBox.Text;
                nameTemp.Trim();

                //creating temp category object to add to Item list
                item temp = new item { price = priceTemp, name = nameTemp, category = (string)itemCategoryComboBox.SelectedItem};// assigning a new cat name to item.
                Item.Add(temp);
                Output.Add("\nSAVED; Added New Item: " + nameTemp + " in category: " + (string)itemCategoryComboBox.SelectedItem + "\n");
            }
            else
            {
                MessageBox.Show("Please select a category for the item.");
            }
           
            updateDisplay();
        }

        //function to display to output labl
        public void updateDisplay()
        {
            outputTextBox.Text = "";
            foreach(var s in Output)
            {
                
                outputTextBox.Text +=  (s + "\r\r" );
                
            }
            
           
            stroreItemCategoryTextBox.Text = "";
            categoryNameTextBox.Text = "";
            categoryDescriptionTextBox.Text = "";
            itemPriceTextBox.Text = "";
            itemNameTextBox.Text = "";
            searchForTextBox.Text = "";
            startsWithTextBox.Text = "";
            endsWithTextBox.Text = "";

        }

        //button to display length of every element of output
        private void lengthButton_Click(object sender, EventArgs e)
        {
            lengthTextBox.Text = "";
            foreach(var num in Output)
            {
                lengthTextBox.Text += num.Length;
            }
        }


        //search button to search for input within the scope of the seleceted item category
        private void searchForButton_Click(object sender, EventArgs e) 
        {
            int num = 1;
            var search = searchForTextBox.Text;
            search.Trim();

            var innnerJoin = Item.Join(
                ICategory,
                itemCatName => itemCatName.category,
                catName => catName.name,
                (itemCatName, catName) => new { name = itemCatName.name, price = itemCatName.price, category = catName.name });



            var query = from x in innnerJoin
                        where x.name.Contains(search) && x.category == (string)itemCategoryComboBox.SelectedItem
                        select x;

            if (search == "")
            {
                Output.Add("\nShowing all items in category: " + (string)itemCategoryComboBox.SelectedItem + "\n");
                updateDisplay();
            }

            


            if (query.Count() > 0)
            {
                Output.Add("\nSearch Results (" + (query.Count()) + ") for '" + search + "'\r\n");
                foreach (var res in query)
                {

                    Output.Add("(" + num + ") " + res + "\r\n");
                    num++;


                }
                updateDisplay();
            }


            //output config
            else
            {
                if (search == "")
                {

                }
                else
                {
                    Output.Add("\nNo Results found, please try again.\n");
                    updateDisplay();
                }
                  
            }


        }

        //starts with search to search input through items within selected category 
        private void startsWithButton_Click(object sender, EventArgs e)
        {
            int num = 1;
            var search = startsWithTextBox.Text;
            search.Trim();

            var innnerJoin = Item.Join(
                ICategory,
                itemCatName => itemCatName.category,
                catName => catName.name,
                (itemCatName, catName) => new { name = itemCatName.name, price = itemCatName.price, category = catName.name });

            var query = from x in innnerJoin
                        where x.name.StartsWith(search) && x.category == (string)itemCategoryComboBox.SelectedItem
                        select x;


            if (query.Count() > 0)
            {
                Output.Add("\nSearch Results (" + (query.Count()) + ") for '" + search + "'\r\n");
                foreach (var res in query)
                {
                    
                        Output.Add("(" + num + ") " + res + "\r\n");
                        num++;
                    

                }
                updateDisplay();
            }


         


            else
            {
                Output.Add("\nNo Results found, please try again. \n");
                updateDisplay();
            }
        }

        //ends with search to search input through items within selected category
        private void endsWithButton_Click(object sender, EventArgs e) //copied main logic except for endswith from above query function
        {
            int num = 1;
            var search = endsWithTextBox.Text;
            search.Trim();

            var innnerJoin = Item.Join(
                ICategory,
                itemCatName => itemCatName.category,
                catName => catName.name,
                (itemCatName, catName) => new { name = itemCatName.name, price = itemCatName.price, category = catName.name });



            var query = from x in innnerJoin
                        where x.name.EndsWith(search) && x.category == (string)itemCategoryComboBox.SelectedItem
                        select x;


            if (query.Count() > 0)
            {
                Output.Add("\nSearch Results (" + (query.Count()) + ") for '" + search + "'\r\n");
                foreach (var res in query)
                {

                    Output.Add("(" + num + ") " + res + "\r\n");
                    num++;


                }
                updateDisplay();
            }


            else
            {
                Output.Add("\nNo Results found, please try again. \n");
                updateDisplay();
            }
        }

        //info button mouse hover to inform user how to show all items in a certain category
        private void infobutton_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Enter nothing into first search text box to show all items in selected dropdown category.");
        }
    }

    //class iCategory to be framework for ICategory list
    public class itemCateogry
    {
        public int num { get; set; }
        public string name { get; set; }
        public string description { get; set; }

    }

    //class item to be framework for Item list
    public class item
    {
        public string name { get; set; }
        public double price { get; set; }
        public string category { get; set; }
       
    }
}
