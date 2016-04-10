using System;
using System.Windows;
using System.Windows.Controls;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Example : UserControl
    {
        public Example()
        {
            InitializeComponent();
        }
        //Перейти до дати
        private void GoToDayButton_Click(object sender, RoutedEventArgs e)
        {
            Calendar.DisplayDate = GoToDayDatePicker.DisplayDate;
            Calendar.SelectedDate = GoToDayDatePicker.DisplayDate;
        }
        //Розрахувати дату закінчення відпустки
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DaysTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Будь-ласка, введіть кількість днів відпустки!", "Помилка",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //Додати кількість днів до обраної дати
            DateTime today = StartDatePicker.DisplayDate.AddDays(Convert.ToInt16(DaysTextBox.Text));
            //показати позначку у календарі
            Calendar.SelectedDate = today;
            EndDatePicker.SelectedValue = today;
            //вивести позначку
            Calendar.ToolTip = "Дата закінчення відпустки";
        }

         
    }
}
