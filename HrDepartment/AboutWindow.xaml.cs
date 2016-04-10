using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();

            //Вивести номер збірки в TextBlock з AssemblyInfo 
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            VesionTextBlock.Text += String.Format("{0}", appVersion);

            //Дата збірки програми з AssemblyInfo 
            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            string s = buildDate.ToShortDateString();
            DateTextBlock.Text += String.Format(" {0}", s);

            //Авторське право з AssemblyInfo 
            var copyright = Assembly.GetEntryAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
            string copyRights = ((AssemblyCopyrightAttribute)copyright[0]).Copyright;
            CopyrightTextBlock.Text += String.Format("{0}", copyRights.ToString());


        }
        //Закрити вікно
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        //Написати у Facebook
        private void FacebookButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/vasilzayats");
        }
        //відкрити поштовий клієнт та написати лист
        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            string mailTo = string.Format("mailto:{0}?Subject={1}", "vzaiats@yahoo.com", "Відгук");
            //Запуск стороннього поштового клієнта
            System.Diagnostics.Process.Start(mailTo);
        }
        //відкрити вікно інформації про систему
        private void SystemInfoButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
        }
        //Приховання вікна при його закритті
        private void AboutWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
        }
    }
}
