using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }
        //Список працівників (жінки)
        private void ListBoxItem1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkerListF, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список працівників (чоловіки)
        private void ListBoxItem2_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkerListM, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Загальний список працівників (із зазначенням посад)
        private void ListBoxItem3_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.CommonListOfWorkersReport1, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про вікові групи
        private void ListBoxItem4_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkersAgeCommonReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //громадянство працівників
        private void ListBoxItem5_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.Citizenship, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Адресні дані працівників
        private void ListBoxItem6_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.AddressesReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
            
        }
        //Контакти працівників
        private void ListBoxItem7_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
             var typeReportSource = new Telerik.Reporting.TypeReportSource();
             typeReportSource.TypeName = "ReportLib.ContactReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Дата прийняття працівників
        private void ListBoxItem8_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.HiringDateReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Працівники та їх статуси
        private void ListBoxItem9_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.StatusWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Кількість працівників у відділах (з підсумками)
        private void ListBoxItem10_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.CountOfWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Кількість працівників у відділах (без підсумків)
        private void ListBoxItem11_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.CountOfWorkers2Report, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        // Кількість жінок та чоловіків
        private void ListBoxItem12_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.CountFMReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Працівники та оклади / надбавки
        private void ListBoxItem13_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.SalaryBonusReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Прийнято на роботу працівників по підрозділах(всього за увесь час)
        private void ListBoxItem14_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.AllHirringByDeptReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Звільнені працівники
        private void ListBoxItem15_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.DismissedWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про дітей працівників
        private void ListBoxItem16_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ChildrensAllReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про неповнолітніх дітей працівників
        private void ListBoxItem17_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.UnderageChildrensReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про кількість дітей
        private void ListBoxItem18_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.CountOfChildrensReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про членів сім'ї працівників
        private void ListBoxItem19_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.FamilyMembersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Сімейний стан працівників
        private void ListBoxItem20_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.MaritalStatusReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Стать працівників
        private void ListBoxItem21_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkerGenderReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Місце народження працівників
        private void ListBoxItem22_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.BirthPlaceReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Паспортні дані (державний)
        private void ListBoxItem23_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.PassportDataReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Паспортні дані (закордонний паспорт)
        private void ListBoxItem24_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.PassportDataForeignReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про державне соціалье страхування
        private void ListBoxItem25_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.InsuranceReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про освіту працівників
        private void ListBoxItem26_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.EducationReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про післядипломну освіту
        private void ListBoxItem27_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.PostGraduateReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Загальний список посад
        private void ListBoxItem28_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           var typeReportSource = new Telerik.Reporting.TypeReportSource();
           typeReportSource.TypeName = "ReportLib.ListOfPositionsReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список посад (з окладами)
        private void ListBoxItem29_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ListOfPositionsSalaryReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список відділів
        private void ListBoxItem30_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ListOfDepartmentsReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про підрозділи
        private void ListBoxItem31_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.DepartmentInfoReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список працівників та їх посад
        private void ListBoxItem32_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ListOfWorkesPositionsReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список працюючих працівників
        private void ListBoxItem33_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           var typeReportSource = new Telerik.Reporting.TypeReportSource();
           typeReportSource.TypeName = "ReportLib.ListOfEmployedReportReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Працівники, які проходять випробувальний термін
        private void ListBoxItem34_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ProbationaryPeriodReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Працівники, яких було звільнено
        private void ListBoxItem35_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ListOfDismissedWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Працівники та їхні оклади
        private void ListBoxItem37_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkersAndSalaryReport1, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список особових карток працюючих працівників
        private void ListBoxItem38_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ListOfPersonalCardsReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Присутність на роботі працівників (за рік)
        private void ListBoxItem39_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.PresentWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Лікарняні працівників (за рік)
        private void ListBoxItem40_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.HospitalWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Відпустки працівників (за рік)
        private void ListBoxItem41_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.VacationWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Відсутність працівників (за рік)

        private void ListBoxItem42_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.AbsenceWorkersReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Діяльність працівників за рік (зведений звіт)
        private void ListBoxItem43_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ActivityWorkersYearReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Діяльність працівників за всі періоди (зведений звіт)
        private void ListBoxItem44_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.ActivityWorkersAllReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Список трудових книжок
        private void ListBoxItem45_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.WorkBooksReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Інформація про відпустки працівників
        private void ListBoxItem46_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.VacationsReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //штатний розпис
        private void ListBoxItem47_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.StaffListReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Штатна книга
        private void ListBoxItem48_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var typeReportSource = new Telerik.Reporting.TypeReportSource();
            typeReportSource.TypeName = "ReportLib.HeadUnitBookReport, ReportLib";
            this.ReportViewer.ReportSource = typeReportSource;
        }
        //Приховати вікно після закриття
        private void ReportWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховати форму
            this.Hide();
        }
    }
}
