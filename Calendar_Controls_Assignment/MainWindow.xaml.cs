using System;
using System.Windows;
using System.Windows.Controls;

namespace Calendar_Controls_Assignment
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

        // Get First Date

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            labelResult.Content = myCalendar.SelectedDate.ToString();



        }

    }
}
