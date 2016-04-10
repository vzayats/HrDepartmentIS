using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for ExcelExportWindow.xaml
    /// </summary>
    public partial class ExcelExportWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public ExcelExportWindow()
        {
            InitializeComponent();
        }

        private void CsvExportButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //Обрати таблицю з ComboBox
                ComboBoxItem comboItem = (ComboBoxItem)ComboBox.SelectedItem;
                string name = comboItem.Name;

                //запит для виводу всіх даних з таблиці
                string cmdText = String.Format("SELECT * FROM {0}", name);
                SqlCommand cmd = new SqlCommand(cmdText, con);

                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);

                        DataColumnCollection dcCollection = dt.Columns;

                        //ЕКспорт даних в лист EXCEL

                        Microsoft.Office.Interop.Excel.ApplicationClass excelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();

                        excelApp.Application.Workbooks.Add(Type.Missing);

                        // ExcelApp.Cells.CopyFromRecordset(objRS);

                        for (int i = 1; i < dt.Rows.Count + 1; i++)
                        {

                            for (int j = 1; j < dt.Columns.Count + 1; j++)
                            {
                                if (i == 1)
                                    excelApp.Cells[i, j] = dcCollection[j - 1].ToString();
                                else
                                    excelApp.Cells[i, j] = dt.Rows[i - 1][j - 1].ToString();
                            }
                        }
                        //Діалог збереження файлу
                        Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
                        //Ім'я файлу за замовчуванням
                        dialog.Title = "Збереження";
                        dialog.FileName = comboItem.Name + " " + DateTime.Now.ToString("d-M-yyyy");
                        dialog.Filter = "Таблиця Excel|*.xlsx";

                        if (dialog.ShowDialog() == true)
                        {
                            //збереження xlsx файлу
                            excelApp.ActiveWorkbook.SaveCopyAs(dialog.FileName);
                            excelApp.ActiveWorkbook.Saved = true;
                            excelApp.Quit();
                            //Повідомлення про успішне експортування
                            MessageBox.Show("Експорт виконано успішно!", "Повідомлення",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                       
                    }
                }
            }
        }
        //Приховання вікна при його закритті
        private void ExcelExportWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
            ComboBox.SelectedIndex = 0; //скинути значення ComboBox за замовчуванням
        }
    }
}
