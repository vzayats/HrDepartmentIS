using System.ComponentModel;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for PersonalCardWindow.xaml
    /// </summary>
    public partial class PersonalCardWindow : Window
    {
        public PersonalCardWindow()
        {
            InitializeComponent();

            //Сформувати при запуску
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkerCardReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }

        //Закриття вікна
        private void PersonalCardWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
          
        }
    }
}
