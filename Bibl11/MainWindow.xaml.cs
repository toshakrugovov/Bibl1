using System.Windows;
using SerializationLibrary;

namespace Bibl11
{
    public partial class MainWindow : Window
    {
        private readonly string filePath = "data.xml";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            string inputData = InputText.Text;
            Serializer.Serialize(inputData, filePath);
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            string deserializedData = Serializer.Deserialize<string>(filePath);
            OutputText.Text = deserializedData;
        }

        private void Click2(object sender, RoutedEventArgs e)
        { 
            
                App.Theme = "Light";
            
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            App.Theme = "Dark";
        }
    }
}
