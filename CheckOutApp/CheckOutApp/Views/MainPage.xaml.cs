using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using CheckOutApp.Models;
using Xamarin.Forms;

namespace CheckOutApp.Views
{
	public partial class MainPage : ContentPage
	{
        private readonly FirstPage a = new FirstPage();
        private readonly SecondPage aa = new SecondPage();
        private readonly ThirdPage aaa = new ThirdPage();
        private string acimgsource = "active_dot.png";
        private string inimgsource = "inactive_dot.png";
        public int PayementStep;

	    private int animationTime = 2000;

        public MainPage()
        {
            InitializeComponent();

            var PayementOptions = new List<PayementOption>
            {
                new PayementOption {ImageSource1 = "credit_card.png", Name = "Credit Card", Price = 0},
                new PayementOption {ImageSource1 = "bank_transfer.png", Name = "Bank Transfer", Price = 0}
            };

            var DeliveryOptions = new List<DeliveryOption>
            {
                new DeliveryOption {ImageSource1 = "normal_shipping.png", Name = "Express", Price = 30},
                new DeliveryOption {ImageSource1 = "express_shipping.png", Name = "Normal", Price = 10}
            };

            PayementStep = 0;

            //Step3Image.Source = this.acimgsource;
            //Step2Image.Source = this.acimgsource;
            //Step3Image.Source = this.acimgsource;


            Step1Frame.HasShadow = true;
            Step1Frame.OutlineColor = Color.FromHex("#443E43");
            Step1Frame.BackgroundColor = Color.FromHex("#F9FAFC");

            Step2Frame.HasShadow = true;
            Step2Frame.OutlineColor = Color.FromHex("#443E43");
            Step2Frame.BackgroundColor = Color.FromHex("#F9FAFC");

            Step3Frame.HasShadow = true;
            Step3Frame.OutlineColor = Color.FromHex("#443E43");
            Step3Frame.BackgroundColor = Color.FromHex("#F9FAFC");

            switchsteps(PayementStep);
            a = new FirstPage(this);
            aa = new SecondPage(a);
            aaa = new ThirdPage(aa);

            CheckOutContentHolder.Content = a.Content;
        }

        private void TapGestureRecognizer_OnTappedHome(object sender, EventArgs e)
        {
            DisplayAlert("Home", "Home Button Tapped", "Ok");
        }

        private void TapGestureRecognizer_OnTappedSearch(object sender, EventArgs e)
        {
            DisplayAlert("Search", "Search Button Tapped", "Ok");
        }

        private void TapGestureRecognizer_OnTappedMenu(object sender, EventArgs e)
        {
            DisplayAlert("Menu", "Menu Button Tapped", "Ok");
        }

        private void TapGestureRecognizer_OnTappedCart(object sender, EventArgs e)
        {
            DisplayAlert("Cart", "Cart Button Tapped", "Ok");
        }

        private void TapGestureRecognizer_OnTappedAccount(object sender, EventArgs e)
        {
            DisplayAlert("Account", "Account Button Tapped", "Ok");
        }

        private void switchsteps(int pstep, int backbtn = 0)
        {
            switch (pstep)
            {
                case 0:
                    //Step1Image.Source = this.acimgsource;
                    //Step2Image.Source = this.acimgsource;
                    //Step3Image.Source = this.acimgsource;
                    NextButton.Text = "NEXT";
                    BackButton.IsVisible = true;
                    pstep++;
                    PayementStep = pstep;

                    Step1Frame.HasShadow = true;
                    Step1Frame.OutlineColor = Color.FromHex("#443E43");
                    Step1FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");

                    Step2Frame.HasShadow = true;
                    Step2Frame.OutlineColor = Color.FromHex("#443E43");
                    Step2FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");

                    Step3Frame.HasShadow = true;
                    Step3Frame.OutlineColor = Color.FromHex("#443E43");
                    Step3FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");

                    CheckOutContent.FadeTo(0.3, (uint)animationTime, Easing.SpringOut);
                    CheckOutContent.TranslateTo(10000, 0, (uint)animationTime);
                    
                    CheckOutContentHolder.Content = a.Content;

                    CheckOutContent.TranslateTo(0, 0, (uint)animationTime);
                    CheckOutContent.FadeTo(1, (uint)animationTime,Easing.SpringIn);

                    if (backbtn == -1)
                    {
                        Step1Frame.HasShadow = true;
                        Step1FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step1Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step1Frame.OutlineColor = Color.FromHex("#443E43");
                        Step2Frame.HasShadow = true;
                        Step2FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.OutlineColor = Color.FromHex("#443E43");
                        Step3Frame.HasShadow = true;
                        Step3FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.OutlineColor = Color.FromHex("#443E43");
                    }
                    //DisplayAlert("Etape =>"+pstep, "Etape 1 Effectue step = " + this.PayementStep, "Ok");
                    //this.payementStep = this.payementStep + backbtn;
                    if (PayementStep > 3 || PayementStep < 0)
                        PayementStep = 0;
                    break;
                case 1:
                    BackButton.IsVisible = true;
                    if (backbtn == -1)
                    {
                        Step1Frame.HasShadow = true;
                        Step1FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step1Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step1Frame.OutlineColor = Color.FromHex("#443E43");
                        Step2Frame.HasShadow = true;
                        Step2FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.OutlineColor = Color.FromHex("#443E43");
                        Step3Frame.HasShadow = true;
                        Step3FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.OutlineColor = Color.FromHex("#443E43");
                    }

                    if (a.PayementIsSelected)
                    {
                        if (a.DeliveryIsSelected)
                        {
                            //Step1Image.Source = this.inimgsource;
                            NextButton.Text = "NEXT";
                            pstep++;
                            PayementStep = pstep;
                            Step1Frame.HasShadow = true;
                            Step1FrameStack.BackgroundColor = Color.FromHex("#443E43");
                            //Step1Frame.BackgroundColor = Color.FromHex("#443E43");
                            Step1Frame.OutlineColor = Color.FromHex("#443E43");

                            CheckOutContent.FadeTo(0.3, (uint)animationTime, Easing.SpringOut);
                            CheckOutContent.TranslateTo(10000,0, (uint)animationTime);
                            CheckOutContentHolder.Content = aa.Content;
                            CheckOutContent.TranslateTo(0,0, (uint)animationTime);
                            CheckOutContent.FadeTo(1, (uint)animationTime, Easing.SpringIn);

                            //DisplayAlert("Etape 1", "Etape 1 Effectue step = "+this.PayementStep, "Ok");
                            if (PayementStep > 3 || PayementStep < 0)
                                PayementStep = 0;
                        }
                        else
                        {
                            CheckOutContentHolder.Content = a.Content;
                            DisplayAlert("Erreur ", "Delivery Method Is Not Selected !", "Ok");
                        }
                    }
                    else
                    {
                        CheckOutContentHolder.Content = a.Content;
                        DisplayAlert("Erreur ", "Payement Method Is Not Selected !", "Ok");
                    }

                    break;
                case 2:
                    BackButton.IsVisible = true;
                    if (backbtn == -1)
                    {
                       
                        Step2Frame.HasShadow = true;
                        Step2FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step2Frame.OutlineColor = Color.FromHex("#443E43");
                        Step3Frame.HasShadow = true;
                        Step3FrameStack.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.BackgroundColor = Color.FromHex("#F9FAFC");
                        Step3Frame.OutlineColor = Color.FromHex("#443E43");
                    }

                    //Step2Image.Source = this.inimgsource;
                    NextButton.Text = "PAY";
                    pstep++;
                    PayementStep = pstep;

                    Step2Frame.HasShadow = true;
                    Step2FrameStack.BackgroundColor = Color.FromHex("#443E43");
                    //Step2Frame.BackgroundColor = Color.FromHex("#443E43");
                    Step2Frame.OutlineColor = Color.FromHex("#443E43");

                    CheckOutContent.FadeTo(0.3, (uint)animationTime, Easing.SpringOut);
                    CheckOutContent.TranslateTo(10000, 0, (uint)animationTime);
                    CheckOutContentHolder.Content = aaa.Content;
                    CheckOutContent.TranslateTo(0, 0, (uint)animationTime);
                    CheckOutContent.FadeTo(1, (uint)animationTime, Easing.SpringIn);

                    //DisplayAlert("Etape 2", "Etape 2 Effectue step = " + this.PayementStep, "Ok");
                    if (PayementStep > 3 || PayementStep < 0)
                        PayementStep = 0;
                    break;
                case 3:
                    BackButton.IsVisible = true;
                    //Step3Image.Source = this.inimgsource;
                    NextButton.Text = "FINISH";
                    pstep++;
                    PayementStep = pstep;
                    BackButton.IsVisible = false;

                    Step3Frame.HasShadow = true;
                    Step3FrameStack.BackgroundColor = Color.FromHex("#443E43");
                    //Step2Frame.BackgroundColor = Color.FromHex("#443E43");
                    Step3Frame.OutlineColor = Color.FromHex("#443E43");

                    //DisplayAlert("Etape 3", "Etape 3 Effectue step = " + this.PayementStep, "Ok");
                    if (PayementStep > 3 || PayementStep < 0)
                        PayementStep = 0;
                    break;
                default:
                    DisplayAlert("Erreur", "Erreur dans le processus de paiment", "Ok");
                    break;
            }
        }

        private void BackButton_OnPressed(object sender, EventArgs e)
        {
            //DisplayAlert("BackButton", "BackButton Pressed", "Ok");
            var pstep = PayementStep - 2;
            switchsteps(pstep,-1);
        }

        private void NextButton_OnPressed(object sender, EventArgs e)
        {
            //DisplayAlert("NextButton", "NextButton Pressed", "Ok");
            var pstep = PayementStep;
            switchsteps(pstep);
        }

        private void FrameStep1TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            //DisplayAlert("Test ", "Frame Tapped !", "Ok");
            var pstep = PayementStep;
            if (pstep == 1)
            {
                switchsteps(0);
            }
            else if (pstep == 2)
            {
                switchsteps(0,-1);
            }
            else if (pstep == 3)
            {
                switchsteps(0,-1);
            }
            else if (pstep == 0)
            {
                switchsteps(0);
            }
        }

        private void FrameStep2TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            //DisplayAlert("Test ", "Frame Tapped !", "Ok");
            var pstep = PayementStep;
            if (pstep == 1)
            {
                if (a.PayementIsSelected)
                {
                    if (a.DeliveryIsSelected)
                    {
                        //Step1Image.Source = this.inimgsource;
                        NextButton.Text = "NEXT";
                        pstep++;
                        PayementStep = pstep;
                        Step1Frame.HasShadow = true;
                        Step1FrameStack.BackgroundColor = Color.FromHex("#443E43");

                        CheckOutContent.FadeTo(0.3, (uint)animationTime, Easing.SpringOut);
                        CheckOutContent.TranslateTo(1000, 0, (uint)animationTime);
                        CheckOutContentHolder.Content = aa.Content;
                        CheckOutContent.TranslateTo(0, 0, (uint) animationTime);
                        CheckOutContent.FadeTo(1, (uint)animationTime, Easing.SpringIn);

                        //DisplayAlert("Etape 1", "Etape 1 Effectue step = "+this.PayementStep, "Ok");
                        if (PayementStep > 3 || PayementStep < 0)
                            PayementStep = 0;
                    }
                    else
                    {
                        CheckOutContentHolder.Content = a.Content;
                        DisplayAlert("Erreur ", "Delivery Method Is Not Selected !", "Ok");
                    }
                }
                else
                {
                    CheckOutContentHolder.Content = a.Content;
                    DisplayAlert("Erreur ", "Payement Method Is Not Selected !", "Ok");
                }
            }
            else if (pstep == 2)
            {
                switchsteps(1,-1);
            }
            else if (pstep == 3)
            {
                switchsteps(1,-1);
            }
            else if (pstep == 0)
            {
                switchsteps(0);
            }
        }

        private void FrameStep3TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            //DisplayAlert("Test ", "Frame Tapped !", "Ok");
            var pstep = PayementStep;
            if (pstep == 1)
            {
                switchsteps(1);
            }
            else if (pstep == 2)
            {
                switchsteps(2);
            }
            else if (pstep == 3)
            {
                switchsteps(3);
            }
            else if (pstep == 0)
            {
                switchsteps(0);
            }
        }
    }
}
