using System.ComponentModel;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        private readonly ClearElements _clearElements;
        public CalendarWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();

        }
        //Приховання вікна при його закритті
        private void CalendarWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            // приховання форми
            this.Hide();
            //Очищення значень елементів datePicker і textbox
            _clearElements.DefaultDatePicker(this);
            _clearElements.ClearTextBoxes(this);
        }
    }
}