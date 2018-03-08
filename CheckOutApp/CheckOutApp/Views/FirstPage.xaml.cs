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
	public partial class FirstPage : ContentPage
	{
        public bool DeliveryIsSelected;
        public bool PayementIsSelected;
        public ContentPage previouscontent = new ContentPage();

        public FirstPage()
        {
            InitializeComponent();
            PayementIsSelected = false;
            DeliveryIsSelected = false;
            var lst = new ListView();
        }

        public FirstPage(ContentPage a)
        {
            InitializeComponent();
            var lst = new ListView();
            PayementIsSelected = false;
            DeliveryIsSelected = false;
            previouscontent = a;
        }

        private void PayementBankTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var senderFrame = (Frame)sender;
            var shopi = new PayementOption("Bank Transfert", 10, "bank_transfer.png");
            senderFrame.HasShadow = true;
            CreditCardFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
            PayementIsSelected = true;
            DisplayAlert("Frame Tapped ", "Payement Name : " + shopi.Name + " Payement Price : " + shopi.Price, "Ok");
        }

        private void PayementCreditTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var senderFrame = (Frame)sender;
            var shopi = new PayementOption("Bank Transfert", 20, "credit_card.png");
            senderFrame.HasShadow = true;
            BankTransfertFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
            PayementIsSelected = true;
            DisplayAlert("Frame Tapped ", "Payement Name : " + shopi.Name + " Payement Price : " + shopi.Price, "Ok");
        }

        private void DeliveryExpressTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var senderFrame = (Frame)sender;
            var shopi = new DeliveryOption("Express Shipping", 70, "express_shipping.png");
            senderFrame.HasShadow = true;
            NormalShippingFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
            DeliveryIsSelected = true;
            DisplayAlert("Frame Tapped ", "Delivery Name : " + shopi.Name + " Delivery Price : " + shopi.Price, "Ok");
        }

        private void DeliveryNormalTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var senderFrame = (Frame)sender;
            var shopi = new DeliveryOption("Normal Shipping", 35, "normal_shipping.png");
            senderFrame.HasShadow = true;
            ExpressShippingFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
            DeliveryIsSelected = true;
            DisplayAlert("Frame Tapped ", "Delivery Name : " + shopi.Name + " Delivery Price : " + shopi.Price, "Ok");
        }
    }
}