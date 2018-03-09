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
	        
	        List<ShopItem> CartList = CartListView.ItemsSource as List<ShopItem>;

	        StackLayout senderView = sender as StackLayout;
	        IEnumerable<Label> results = senderView.Children.SkipWhile(delegate(View view) { return view.GetType() != typeof(Label); }).Cast<Label>();

	        foreach (var VARIABLE in results)
	        {
	            CartList = CartList.SkipWhile(delegate(ShopItem item) { return item.ProductUid.Contains(VARIABLE.Text); }).ToList();
	        }

            

	        CartListView.ItemsSource = CartList;

	       

            //senderView.Parent.SetValue(IsVisibleProperty,false);
            
            
        }
    }
}