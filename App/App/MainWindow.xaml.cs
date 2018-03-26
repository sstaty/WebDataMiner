using System.Windows;

namespace WebDataMiner.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Reader reader;

        public MainWindow()
        {
            InitializeComponent();
            reader = new Reader(new Source_File(@"D:\[13] - Documents\Test Files\Text.txt"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            results.Items.Add(reader.Read_Text.Letter());
            results.Items.Add(reader.Read_Text.Line());
        }
    }
}
