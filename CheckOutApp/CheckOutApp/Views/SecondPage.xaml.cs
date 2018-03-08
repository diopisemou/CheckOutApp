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
	public partial class SecondPage : ContentPage
	{
	    public bool FormIsValid;
	    public ContentPage previouscontent = new ContentPage();

	    public SecondPage()
	    {
	        InitializeComponent();
	        FormIsValid = false;
	    }

	    public SecondPage(ContentPage a)
	    {
	        InitializeComponent();
	        previouscontent = a;
	        FormIsValid = false;
	    }
    }
}