﻿using System;
using Xamarin.Forms;

namespace Hello
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {

        }

        public void SendAppearing()
        {
            OnAppearing();
        }

        public void SendDisappearing()
        {
            OnDisappearing();

        }
    }
}
