using System.ComponentModel;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        public StaffWindow()
        {
            InitializeComponent();

            //Запустимо з відкритим штатним розписом за замовчуванням
            TypeComboBox.SelectedIndex = 0;
        }

        //штатний розпис
        private void StaffListReport_OnSelected(object sender, RoutedEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.StaffListReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Штатна книга
        private void HeadUnitBookReport_OnSelected(object sender, RoutedEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.HeadUnitBookReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //приховати вікно після закриття
        private void StaffWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            TypeComboBox.SelectedIndex = 0;
        }
    }
}
