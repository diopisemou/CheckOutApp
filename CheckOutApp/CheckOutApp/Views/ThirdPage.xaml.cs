using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckOutApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPage : ContentPage
	{
	    public ContentPage previouscontent = new ContentPage();
	    public bool ReviewIsValid;

	    public ThirdPage()
	    {
	        InitializeComponent();
	        ReviewIsValid = false;

            List<ShopItem> CartList = new List<ShopItem>
	        {
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","1"),
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","2"),
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","3"),
            };
	        CartListView.ItemsSource = CartList;
	    }

	    public ThirdPage(ContentPage a)
	    {
	        InitializeComponent();
	        var lst = new ListView();
	        previouscontent = a;
	        ReviewIsValid = false;
	        List<ShopItem> CartList = new List<ShopItem>
	        {
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","1"),
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","2"),
	            new ShopItem("Gucci Hand Bag Light Brown",3000,"icon.png","New Prada","3"),
            };
	        CartListView.ItemsSource = CartList;
        }

	  

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        DisplayAlert("Trying", "In Function", "OK");

	        List<ShopItem> CartList = CartListView.ItemsSource as List<ShopItem>;
	        Image senderImage = sender as Image;


	        foreach (ShopItem VARIABLE in CartList)
	        {
	            DisplayAlert("Trying", "In Foreach", "OK");
	            StackLayout res = null;
	            res = this.FindByName<StackLayout>(VARIABLE.ProductUid);
	            if (res == null)
	            {
	                DisplayAlert("Erreur", "Not Found", "OK");
	            }
	            else
	            {
	                DisplayAlert("Success", "Found", "OK");
	                //CartList.Remove(VARIABLE);
	                res.FadeTo(0, 2000);
	                //res.IsVisible = false;
	            }
	        }

	        //CartListView.ItemsSource = CartList;
        }
    }
}