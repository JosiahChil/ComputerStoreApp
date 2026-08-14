using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CompSoftwareMastery
{

    /// <summary>
    /// This form is for the customer to shop in. It makes the panels containing the items and information for customers to pick and choose to add to cart,
    /// as well as letting the customer search specific terms, categories, or both
    /// </summary>
    public partial class frmCustomer : Form
    {
        public static List<int> itemIDCart = new List<int>();
        public static List<int> itemQuantityCart = new List<int>();
        public static int currentID = 0;
        public static bool hasAccount = false;
        public static bool pointOfSale = false;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadPanel();
            cbCategory.Items.Add("Reset Search");
            clsSQL.AddItems(cbCategory);
            lbAddToCart.Text = "";
            lbManagerPOS.Text = "";
            if (pointOfSale == true)
            {
                lbManagerPOS.Text = "Point of Sale \n Shopping as: " + frmPointOfSale.firstName + " " + frmPointOfSale.lastName;
            }

        }

        /// <summary>
        /// This task simply creates the panel for the application, sets its size, and applies an event  handler, for other objects to be applied to it
        /// </summary>
        /// <param name="Panels"></param>
        /// <param name="panel"></param>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <param name="panelLocationX"></param>
        /// <param name="panelLocationY"></param>
        /// <param name="panelSizeX"></param>
        /// <param name="panelSizeY"></param>
        /// <returns></returns>
        private async Task PanelTask(List<Panel> Panels, Panel panel, List<int> items, int index, int panelLocationX, int panelLocationY, int panelSizeX, int panelSizeY)
        {

            Panels.Add(panel);
            panel.Name = items[index].ToString();
            panel.BackColor = Color.DodgerBlue;

            panel.Location = new System.Drawing.Point(panelLocationX, panelLocationY);
            panel.Size = new System.Drawing.Size(panelSizeX, panelSizeY);

            panel.Click += new EventHandler(panelAndObjects_click);

        }

        /// <summary>
        /// This task simply creates the images for the application, sets its size, sets the image, and applies an event handler
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <param name="pictureLocationX"></param>
        /// <param name="pictureLocationY"></param>
        /// <returns></returns>
        private async Task PicBoxTask(PictureBox pic, List<int> items, int index, int pictureLocationX, int pictureLocationY)
        {
            pic.Name = items[index].ToString();
            pic.Location = new System.Drawing.Point(pictureLocationX, pictureLocationY);
            pic.Size = new System.Drawing.Size(174, 133);
            pic.BackColor = Color.Red;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = clsSQL.GetImage(items[index]);
            pic.Click += new EventHandler(panelAndObjects_click);
        }

        /// <summary>
        /// This task simply creates the name labels for the application, sets its size, and applies an event handler
        /// </summary>
        /// <param name="name"></param>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <param name="textNameLocationX"></param>
        /// <param name="textNameLocationY"></param>
        /// <returns></returns>
        private async Task LabelTask(Label name, List<int> items, int index, int textNameLocationX, int textNameLocationY)
        {
            name.Name = items[index].ToString();
            name.Location = new System.Drawing.Point(textNameLocationX, textNameLocationY);
            name.Text = clsSQL.GetTextName(items[index]);
            name.Size = new System.Drawing.Size(160, 25);
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.BackColor = Color.DodgerBlue;
            name.Click += new EventHandler(panelAndObjects_click);
        }

        /// <summary>
        /// This task simply creates the price labels for the application, sets its size, and applies an event handler
        /// </summary>
        /// <param name="price"></param>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <param name="textPriceLocationX"></param>
        /// <param name="textPriceLocationY"></param>
        /// <returns></returns>
        private async Task PriceTask(Label price, List<int> items, int index, int textPriceLocationX, int textPriceLocationY)
        {

            price.Name = items[index].ToString();
            price.Location = new System.Drawing.Point(textPriceLocationX, textPriceLocationY);
            price.Text = clsSQL.GetTextPrice(items[index]);
            price.Size = new System.Drawing.Size(70, 25);
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.BackColor = Color.DodgerBlue;
            price.Click += new EventHandler(panelAndObjects_click);

        }


        /// <summary>
        /// This function loads all the information and panels into application to be viewed
        /// </summary>
        /// <returns></returns>
        private async Task loadPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            int panelLocationX = 10;
            int panelLocationY = 10;
            int panelSizeX = 200;
            int panelSizeY = 206;
            int textNameLocationX = 25;
            int textNameLocationY = 7;
            int textPriceLocationX = 65;
            int textPriceLocationY = 174;
            int pictureLocationX = 9;
            int pictureLocationY = 35;
            int itemID = 100;
            string path;
            int numItems;
            List<int> items = new List<int>();
            int index = 0;
            clsSQL.GetNumberItems(items);
            System.Drawing.Image picture;

            List<Panel> Panels = new List<Panel>();
            for (int i = 0; i <= items.Count - 1; i++)
            {
                Panel panel = new Panel();
                Task Panel = PanelTask(Panels, panel, items, index, panelLocationX, panelLocationY, panelSizeX, panelSizeY);


                PictureBox pic = new PictureBox();
                PicBoxTask(pic, items, index, pictureLocationX, pictureLocationY);


                Label name = new Label();
                LabelTask(name, items, index, textNameLocationX, textNameLocationY);


                Label price = new Label();
                PriceTask(price, items, index, textPriceLocationX, textPriceLocationY);

                panel.Controls.Add(pic);
                panel.Controls.Add(price);
                panel.Controls.Add(name);
                this.Controls.Add(panel);
                index++;
                if (panelSizeX % 3 == 0)
                {
                    panelLocationX = 10;
                    panelLocationY += 206;

                }
                else
                {
                    panelLocationX += 200;
                }

            }


            foreach (Panel p in Panels)
            {
                flowLayoutPanel1.Controls.Add(p);
            }
        }




        /// <summary>
        /// This function sends objects to other functions to get data from the database to show on the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAndObjects_click(object sender, EventArgs e)
        {
            rtbProductInfo.Text = "";
            lbAddToCart.Text = "";
            if (sender is Label)
            {
                Label p = sender as Label;

                clsSQL.GetDetails(int.Parse(p.Name), pbSelectedItem, rtbProductInfo, cbQuantity, lbQuantity);

                currentID = int.Parse(p.Name);
            }
            else if (sender is PictureBox)
            {

                PictureBox p = sender as PictureBox;
                clsSQL.GetDetails(int.Parse(p.Name), pbSelectedItem, rtbProductInfo, cbQuantity, lbQuantity);
                currentID = int.Parse(p.Name);
            }
            else if (sender is Panel)
            {
                Panel p = sender as Panel;
                clsSQL.GetDetails(int.Parse(p.Name), pbSelectedItem, rtbProductInfo, cbQuantity, lbQuantity);
                currentID = int.Parse(p.Name);
            }

        }


        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbxSearch.Text)))
            {
                searchCategoryCombined();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            loadPanel();
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                loadPanel();
                tbxSearch.Clear();
            }
            else
            {
                searchCategoryCombined();
            }
        }

        /// <summary>
        /// This function loads in a specific set of panels based on the information in them
        /// You can either search for a specific phrase that returns all items with that phrase or a specific category.
        /// Theres also an option to search both at once returning items only in both options at once
        /// </summary>
        private void searchCategoryCombined()
        {
            flowLayoutPanel1.Controls.Clear();



            int panelLocationX = 10;
            int panelLocationY = 10;
            int panelSizeX = 200;
            int panelSizeY = 206;
            int textNameLocationX = 25;
            int textNameLocationY = 7;
            int textPriceLocationX = 65;
            int textPriceLocationY = 174;
            int pictureLocationX = 9;
            int pictureLocationY = 35;
            string path;
            int numItems = 100;
            string nameIDs = "";
            int index = 0;
            int[] searchedId = null;
            int[] categoryId = null;
            List<int> combinedSearch = new List<int>();


            if (tbxSearch.Text != null || tbxSearch.Text != " ")
            {
                searchedId = new int[clsSQL.GetAmountNumberItems(tbxSearch.Text)];
                clsSQL.GetSomeNumberItems(searchedId, tbxSearch.Text);

            }




            if (cbCategory.SelectedItem != null && cbCategory.SelectedItem.ToString() != " ")
            {
                categoryId = new int[clsSQL.GetAmountNumberItemsCategory(cbCategory.SelectedItem.ToString())];
                clsSQL.GetCategoryItems(categoryId, cbCategory.SelectedItem.ToString());

            }

            if (cbCategory.SelectedIndex == 0)
            {
                categoryId = null;
            }


            if (searchedId != null && categoryId != null)
            {
                int i = 0;
                int amount = 0;
                var intersect = searchedId.Intersect(categoryId);


                foreach (int res in intersect)
                {
                    combinedSearch.Add(res);

                    i++;

                }
            }

            if (searchedId == null)
            {
                for (int i = 0; i < categoryId.Length; i++)
                    combinedSearch.Add(categoryId[i]);
            }
            if (categoryId == null)
            {
                for (int i = 0; i < searchedId.Length; i++)
                    combinedSearch.Add(searchedId[i]);
            }




            List<Panel> Panels = new List<Panel>();
            for (int i = 0; i < combinedSearch.Count; i++)
            {

                Panel panel = new Panel();
                Task Panel = PanelTask(Panels, panel, combinedSearch, index, panelLocationX, panelLocationY, panelSizeX, panelSizeY);


                PictureBox pic = new PictureBox();

                Task PicBox = PicBoxTask(pic, combinedSearch, index, pictureLocationX, pictureLocationY);







                Label name = new Label();

                Task labels = LabelTask(name, combinedSearch, index, textNameLocationX, textNameLocationY);




                Label price = new Label();

                Task prices = PriceTask(price, combinedSearch, index, textPriceLocationX, textPriceLocationY);


                panel.Controls.Add(pic);
                panel.Controls.Add(price);
                panel.Controls.Add(name);
                this.Controls.Add(panel);
                index++;
                if (panelSizeX % 3 == 0)
                {
                    panelLocationX = 10;
                    panelLocationY += 206;

                }
                else
                {
                    panelLocationX += 200;
                }

            }
            foreach (Panel p in Panels)
            {
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        /// <summary>
        /// This function simply adds to cart the item and quantity of the selected item as well as removes that same amount temporaraly from the total amount
        /// , which will be updated later if the order goes through
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            bool flag = string.IsNullOrEmpty(this.cbQuantity.Text);
            if (!flag)
            {
                bool flag2 = this.cbQuantity.Text == "0";
                if (flag2)
                {
                    this.lbAddToCart.Text = "Quantity can not be 0";
                }
                else
                {
                    frmCustomer.itemIDCart.Add(frmCustomer.currentID);
                    frmCustomer.itemQuantityCart.Add(int.Parse(this.cbQuantity.Text));
                    for (int i = 0; i < frmCustomer.itemIDCart.Count<int>(); i++)
                    {
                        int num = 0;
                        while (i < frmCustomer.itemIDCart.Count<int>())
                        {
                            bool flag3 = frmCustomer.itemIDCart[i] == frmCustomer.itemIDCart[num] && i != num;
                            if (flag3)
                            {
                                List<int> list = frmCustomer.itemQuantityCart;
                                int index = num;
                                list[index] += frmCustomer.itemQuantityCart[i];
                                frmCustomer.itemQuantityCart.RemoveAt(i);
                                frmCustomer.itemIDCart.RemoveAt(i);
                            }
                            i++;
                        }
                    }
                    this.lbAddToCart.Text = "Item Added to cart.";
                    frmCustomer.itemIDCart.ForEach(new Action<int>(Console.WriteLine));
                    frmCustomer.itemQuantityCart.ForEach(new Action<int>(Console.WriteLine));
                }
            }
        }


        /// <summary>
        /// This function simply hides the current form and reveals the next form, and passes multiple variables to the new form 
        /// as long as the cart isnt currently empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckout_Click(object sender, EventArgs e)
        {



            bool flag = !frmCustomer.itemIDCart.Any<int>();
            if (!flag)
            {
                frmShoppingCart frmShoppingCart = new frmShoppingCart();
                frmShoppingCart.itemIDCart = frmCustomer.itemIDCart;
                frmShoppingCart.itemQuantityCart = frmCustomer.itemQuantityCart;
                frmShoppingCart.currentID = frmCustomer.currentID;
                
                frmShoppingCart.Show();
                base.Hide();
            }




        }

        /// <summary>
        /// This function simply brings up the help files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHlp_Click(object sender, EventArgs e)
        {


            if (pointOfSale == false)
            {
                Help.ShowHelp(this, hlpCustomer.HelpNamespace);
            }
            else if (pointOfSale == true)
            {
                Help.ShowHelp(this, hlpManager.HelpNamespace);
            }



        }

        private void cbQuantity_Click(object sender, EventArgs e)
        {
            lbAddToCart.Text = string.Empty;
        }
    }
}
