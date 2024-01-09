using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RestoranMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowMenu_Click(object sender, RoutedEventArgs e)
        {
            menuPopup.IsOpen = true;
        }
        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            imgFullScale.Source = img.Source;

            popFullScale.PlacementTarget = img;
            popFullScale.IsOpen = true;
        }

        // The mouse has left an image. Hide the popup.
        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            popFullScale.IsOpen = false;
        }

        private void CloseMenu_click(object ender, RoutedEventArgs e)

            { menuPopup.IsOpen = false; }
    }
}