using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for CsvExportWindow.xaml
    /// </summary>
    public partial class CsvExportWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        public CsvExportWindow()
        {
            InitializeComponent();
        }

        private void CsvExportButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Обрати таблицю з ComboBox
                ComboBoxItem ComboItem = (ComboBoxItem)ComboBox.SelectedItem;
                string name = ComboItem.Name;

                //запит для виводу всіх даних з таблиці
                string cmdText = String.Format("SELECT * FROM {0}", name);
                SqlCommand cmd = new SqlCommand(cmdText, con);
             
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Створити файл CSV, який, розділений комами
                            string csv = string.Empty;

                            foreach (DataColumn column in dt.Columns)
                            {
                                //Додати заголовок рядка для CSV файлу
                                csv += column.ColumnName + ", ";
                            }

                            //Додати новий рядок
                            csv += "\r\n";

                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (DataColumn column in dt.Columns)
                                {
                                    //Додати рядок даних
                                    csv += row[column.ColumnName].ToString().Replace(", ", "; ") + ", ";
                                }

                                //Додати новий рядок
                                csv += "\r\n";
                            }

                            //Діалог збереження файлу
                            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
                            dialog.DefaultExt = ".csv";
                            dialog.Title = "Збереження";
                            //Ім'я файлу за замовчуванням
                            dialog.FileName = ComboItem.Name + " " + DateTime.Now.ToString("d-M-yyyy");
                            dialog.Filter = "Файл Csv|*.csv|Текстовий файл (*.txt)|*.txt";

                            if (dialog.ShowDialog() == true)
                            {
                                //збереження CSV файлу
                                StreamWriter file = new StreamWriter(dialog.FileName.ToString(), false, Encoding.UTF8);
                                file.WriteLine(csv.ToString());
                                file.Close();
                                //Повідомлення про успішне створення
                                System.Windows.MessageBox.Show("Експорт виконано успішно!", "Повідомлення",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                    }
                }
            }
        //Приховання вікна при його закритті
        private void CsvExportWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
            ComboBox.SelectedIndex = 0; //скинути значення ComboBox за замовчуванням
        }
    }
    }

