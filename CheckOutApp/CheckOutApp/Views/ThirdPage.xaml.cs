using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	    }

	    public ThirdPage(ContentPage a)
	    {
	        InitializeComponent();
	        var lst = new ListView();
	        previouscontent = a;
	        ReviewIsValid = false;
	    }
    }
}