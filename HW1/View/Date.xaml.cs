using HW1.ViewModel;

using System.Windows.Controls;

//using HW1.ViewModel;

namespace HW1.View
{
    /// <summary>
    /// Логика взаимодействия для Data.xaml
    /// </summary>
    public partial class Date : UserControl
    {
        internal Date()
        {
            InitializeComponent();
            DataContext = new DateViewModel();

        }

      

        //private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    MessageBox.Show("AHAHHA");
        //}
    }
}
