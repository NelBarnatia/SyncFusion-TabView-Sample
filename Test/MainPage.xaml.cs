#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XForms.TabView;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CreateListView();
        }

        private void CreateListView()
        {
            int stato = 0;

            foreach (var item in ((ContactsViewModel)BindingContext).ListaTabItem)
            {
                StackLayout stackLayout = new StackLayout();

                Label label = new Label
                {
                    Text = "MAMA MO " + stato,
                    TextColor = Color.Black,
                    FontSize = 30,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.Center
                };

                stackLayout.Children.Add(label);

                //ListView listView = new ListView
                //{
                //    HasUnevenRows = true,
                //    RowHeight = -1,
                //    ItemTemplate = new DataTemplate(typeof(AuditView)),
                //    ItemsSource = ((ContactsViewModel)BindingContext).ContactList,
                //    HorizontalOptions = LayoutOptions.FillAndExpand,
                //    BackgroundColor = Color.Yellow,
                //    VerticalOptions = LayoutOptions.FillAndExpand,
                //    SeparatorVisibility = SeparatorVisibility.None,
                //    SeparatorColor = Color.Transparent
                //};

                //listView.ItemTapped += ListView_ItemTapped;

                //listView.Behaviors.Add(new EventToCommandBehavior
                //{
                //    Command = ((ContactsViewModel)BindingContext).OutputAgeCommand,
                //    Converter = new SelectedItemEventArgsToSelectedItemConverter(),
                //    EventName = "ItemTapped"
                //});

                CustomTabItem customTabItem = new CustomTabItem
                {
                    //Immagine = "https://picsum.photos/200/300",
                    Title = item.ToUpper(),
                    GridId = stato,
                    BackgroundColor = Color.ForestGreen
                };
                tabView.Items.Add(new SfTabItem()
                {
                    Title = customTabItem.Title,
                    Content = stackLayout,
                    HeaderContent = customTabItem,
                    SelectionColor = Color.White,
                });

                stato++;
            }
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("ListView_ItemTapped Even", "item Tapped", "ok");
        }

        private void TabView_SelectionChanged(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
            var selectedIndex = e.Index;
            //DisplayAlert("TabView_SelectionChanged Event", "Selected index" + e.Index, "ok");
        }
    }
}