using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPage : ContentPage
	{
		public EventPage ()
		{
			InitializeComponent ();
		}

        private void ContactListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Alert", "item Tapped", "ok");
        }

        private void ContactListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Alert", "item Tapped", "ok");
        }

        private void ContactListView_ItemTapped_2(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Alert", "item Tapped", "ok");
        }
    }
}