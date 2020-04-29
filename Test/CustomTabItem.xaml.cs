using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomTabItem : ContentView, INotifyPropertyChanged
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            propertyName: nameof(Title),
            returnType: typeof(string),
            declaringType: typeof(CustomTabItem),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TitlePropertyChanged);

        public string Title { get { return GetValue(TitleProperty).ToString(); } set { SetValue(TitleProperty, value); } }

        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTabItem)bindable;
            control.title.Text = newValue.ToString();
        }

        //public static readonly BindableProperty ImmagineProperty = BindableProperty.Create(
        //    propertyName: nameof(Immagine),
        //    returnType: typeof(string),
        //    declaringType: typeof(CustomTabItem),
        //    defaultValue: string.Empty,
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: ImageSourcePropertyChanged);

        //public string Immagine { get { return GetValue(ImmagineProperty).ToString(); } set { SetValue(ImmagineProperty, value); } }

        //private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (CustomTabItem)bindable;
        //    control.image.Source = newValue.ToString();
        //}

        public static readonly BindableProperty GridIdProperty = BindableProperty.Create(
            propertyName: nameof(GridId),
            returnType: typeof(int),
            declaringType: typeof(CustomTabItem),
            defaultValue: 0,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: GridIdPropertyChanged);

        public int GridId { get { return (int)GetValue(GridIdProperty); } set { SetValue(GridIdProperty, value); } }

        private static void GridIdPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomTabItem)bindable;
            control.TabItem.StyleId = newValue.ToString();
        }

        public CustomTabItem()
        {
            try
            {
                InitializeComponent();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}