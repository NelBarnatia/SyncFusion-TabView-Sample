using Syncfusion.XForms.TabView;
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
	public partial class TapPage : ContentPage
	{
		public TapPage ()
		{
           
            InitializeComponent ();
            CreateListView();
            
        }

        private void CreateListView()
        {
            int stato = 0;
            foreach (var item in ((ContactsViewModel)BindingContext).ListaTabItem)
            {
                ListView listView = new ListView
                {
                    HasUnevenRows = true,
                    RowHeight = -1,
                    ItemTemplate = new DataTemplate(typeof(AuditView)),
                    ItemsSource = ((ContactsViewModel)BindingContext).ContactList,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    BackgroundColor = Color.Yellow,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    SeparatorVisibility = SeparatorVisibility.None,
                    SeparatorColor = Color.Transparent
                };

                listView.ItemTapped += ListView_ItemTapped;

                listView.Behaviors.Add(new EventToCommandBehavior
                {
                    Command = ((ContactsViewModel)BindingContext).OutputAgeCommand,
                    Converter = new SelectedItemEventArgsToSelectedItemConverter(),
                    EventName = "ItemTapped"
                });

                CustomTabItem customTabItem = new CustomTabItem
                {
                    //Immagine = "https://picsum.photos/200/300",
                    Title = item.ToUpper(),
                    GridId = stato
                };

                tabView.Items.Add(new SfTabItem()
                {
                    Title = customTabItem.Title,
                    Content = listView, 
                    SelectionColor = Color.White
                });
                stato++;
            }
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("ListView_ItemTapped Event", "item Tapped", "ok");
        }

        private void TabView_SelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
            var selectedIndex = e.Index;
            //DisplayAlert("TabView_SelectionChanged Event", "Selected index" + e.Index, "ok");
        }

    }
}