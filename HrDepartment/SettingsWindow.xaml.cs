using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string _connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public SettingsWindow()
        {
            InitializeComponent();
        }

        //Перевірка з'єднання із SqlServer
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {

                connection.Open();

                //Якщо з'єднання встановлено
                if (connection.State == ConnectionState.Open)
                {

                    MessageBox.Show("З'єднання успішно встановлено!", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                //Якщо ні
                else
                {
                    MessageBox.Show("З'єднання не встановлено!", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        //Змінити налаштування з'єднання
        private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте змінити налаштування підключення?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string varr = NameTextBox.Text.Trim();
                config.ConnectionStrings.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString = string.Format("Data Source={0};Initial Catalog=Personnel_department;Integrated Security=True", varr.ToString());
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config.Save(ConfigurationSaveMode.Minimal, true);


                Configuration config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string varr2 = NameTextBox.Text.Trim();
                config2.ConnectionStrings.ConnectionStrings["ReportLib.Properties.Settings.Personneldepartment"].ConnectionString = string.Format("Data Source={0};Initial Catalog=Personnel_department;Integrated Security=True", varr2.ToString());
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config2.Save(ConfigurationSaveMode.Minimal, true);


                Configuration config3 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string varr3 = NameTextBox.Text.Trim();
                config3.ConnectionStrings.ConnectionStrings["HrDepartment.Properties.Settings.Personnel_departmentConnectionString"].ConnectionString = string.Format("Data Source={0};Initial Catalog=Personnel_department;Integrated Security=True", varr3.ToString());
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config3.Save(ConfigurationSaveMode.Minimal, true);
                ConfigurationManager.RefreshSection("connectionStrings");
            }          
        }

        //Скинути за замовчуванням
        private void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Скинути налаштування підключення за замовчуванням?", "Повідомлення", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString = string.Format("Data Source=.;Initial Catalog=Personnel_department;Integrated Security=True");
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config.Save(ConfigurationSaveMode.Minimal, true);


                Configuration config2 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config2.ConnectionStrings.ConnectionStrings["ReportLib.Properties.Settings.Personneldepartment"].ConnectionString = string.Format("Data Source=.;Initial Catalog=Personnel_department;Integrated Security=True");
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config2.Save(ConfigurationSaveMode.Minimal, true);


                Configuration config3 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config3.ConnectionStrings.ConnectionStrings["HrDepartment.Properties.Settings.Personnel_departmentConnectionString"].ConnectionString = string.Format("Data Source=.;Initial Catalog=Personnel_department;Integrated Security=True");
                //запис у файл конфігурації тільки тих властивостей, які не є наслідуваними значеннями
                config3.Save(ConfigurationSaveMode.Minimal, true);
                ConfigurationManager.RefreshSection("connectionStrings");
            }          
        }

        //Приховати вікно
        private void SettingsWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            //приховання форми
            Hide();
            NameTextBox.Text = String.Empty;
        }

        //Закрити вікно
        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            //приховання форми
            Hide();
            NameTextBox.Text = String.Empty;
        }

        private void ThisPcCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            string name = System.Environment.MachineName;
            NameTextBox.Text = name;
        }

        private void ThisPcCheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = String.Empty;
        }
    }
}
