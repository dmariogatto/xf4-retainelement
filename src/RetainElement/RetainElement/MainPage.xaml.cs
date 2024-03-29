﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RetainElement
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RetainElementListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Item i)
            {
                await DisplayAlert("Alert", $"You tapped item {i.Id}", "OK");
            }
        }
    }    
}
