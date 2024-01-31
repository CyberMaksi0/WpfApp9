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

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetImage("https://static.wikia.nocookie.net/bindingofisaac/images/2/2c/Sacred_Heart_Icon.png/revision/latest?cb=20150318161035&path-prefix=pl");
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButton1.IsChecked == true)
            {
                SetImage("https://static.wikia.nocookie.net/bindingofisaac/images/3/3b/Godhead_Icon.png/revision/latest?cb=20150318155542&path-prefix=pl");
            }
            else
            {
                SetImage("https://static.wikia.nocookie.net/bindingofisaac/images/2/2c/Sacred_Heart_Icon.png/revision/latest?cb=20150318161035&path-prefix=pl");
            }
        }

        private void SetImage(string imageUrl)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUrl);
            bitmapImage.EndInit();

            image.Source = bitmapImage;
        }
    private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            textBlock2.Text = $"Opcja {radioButton.Content} zaznaczona";
            switch (radioButton.Content.ToString())
            {
                case "Opcja 1":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Red;
                    break;
                case "Opcja 2":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Green;
                    break;
                case "Opcja 3":
                    textBlock2.Foreground = System.Windows.Media.Brushes.Blue;
                    break;
            }
        }
    }
}