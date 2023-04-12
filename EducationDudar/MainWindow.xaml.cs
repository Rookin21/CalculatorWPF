using System;
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
            throw new NotImplementedException();
        }
    }
}
