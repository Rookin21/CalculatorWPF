using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace EducationDudar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainRoot.Children) // Обработка событий
            {
                if(el is Button)
                {
                    ((Button) el).Click += ButtonClick;
                }
            }
        }
    
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content; // Обращение к строке. (Button) и (string) - присвоение типа 

            if (str == "AC")
            {
                TextLabel.Text = "";
            }               
            else if (str == "=")
            {
                string value = new DataTable().Compute(TextLabel.Text, null).ToString();
                TextLabel.Text = value;
            }
            else
            {
                TextLabel.Text += str;
            }
        }
    }
}
