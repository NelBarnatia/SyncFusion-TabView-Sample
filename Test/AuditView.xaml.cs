using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuditView : ViewCell
    {
        public AuditView()
        {
            InitializeComponent();
        }
    }

    public class CustomFrame : Frame
    {

    }
}