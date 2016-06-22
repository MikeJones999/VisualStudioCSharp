using System.Windows;
using System.IO;

namespace SimpWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //get files
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //filesPath is the name of the textbox in the form
            string[] files = Directory.GetFiles(filePath.Text);
            foreach(string s in files)
            {
                displayBox.AppendText(s.ToString() + "\n");
            }
        }
    }
}
