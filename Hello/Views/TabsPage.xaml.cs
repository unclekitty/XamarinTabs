using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Hello
{
    public partial class TabsPage : TabbedPage
    {
        public TabsPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            Title = CurrentPage?.Title;
        }
    }
}
