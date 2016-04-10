using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Telerik.Windows.Controls;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        private readonly ClearElements _clearElements;
        public SearchWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }
        //закриття вікна
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Пошук даних
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //запит для виконання пошуку
            string sql = "SELECT wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia, dep.DepartmentName AS DepartmentName," +
                         "Pos.Position AS Position, wk.BirthDate as BirthDate, Adr.WorkPhone as WorkPhone, Adr.MobileNumber as MobileNumber FROM Workers wk " +
                         "INNER JOIN Department dep on wk.DepartmentID=dep.DepartmentID INNER JOIN Position Pos " +
                         "on wk.PositionID=Pos.PositionID INNER JOIN Addresses Adr on wk.ID=Adr.ID " +
                         "INNER JOIN Contract con on wk.ID = con.ID" ;
            string whereConcatenator = " WHERE ";
            
            //параметри пошуку - ім'я
            if (SurnameTextBox.Text.Length != 0)
            {
                sql += whereConcatenator;
                sql += " wk.Surname LIKE '" + SurnameTextBox.Text.Trim() + "%' ";
                whereConcatenator = "AND ";
            }
            //параметри пошуку - прізвище
            if (NameTextBox.Text.Length != 0)
            {
                sql += whereConcatenator;
                sql += " wk.Name LIKE '" + NameTextBox.Text.Trim() + "%' ";
                whereConcatenator = "AND ";
            }
            //параметри пошуку - по-батькові
            if (MiddleNameTextBox.Text.Length != 0)
            {
                sql += whereConcatenator;
                sql += " wk.Name LIKE '" + MiddleNameTextBox.Text.Trim() + "%' ";
                whereConcatenator = "AND ";
            }
            //пошук серед звільнених
            if (ContractCheckBox.IsChecked == true)
            {
                sql += whereConcatenator;
                sql += " con.DismissDate IS NOT NULL ";
                whereConcatenator = "AND ";
            }
            //пошук серед еа даний момент працюючих
            if (ContractCheckBox.IsChecked == false)
            {
                sql += whereConcatenator;
                sql += " con.DismissDate IS NULL ";
                whereConcatenator = "AND ";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //відкриття з'єднання
                connection.Open();
                //створюємо об'єкт DataAdapter
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Workers");
                sda.Fill(dt);
                SearchGridView.ItemsSource = dt.DefaultView;
            }
        }
        //експорт в Excel
        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            string extension = "xlsx";
            //діалог збереження файлу
            SaveFileDialog dialog = new SaveFileDialog()
            {
                FilterIndex = 0,
                DefaultExt = extension,
                Title = "Збереження",
                Filter = String.Format("Файл {1} (*.{0})|*.{0}|Всі файли (*.*)|*.*", extension, "Excel"),
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    //параметри експорту
                    SearchGridView.ExportToXlsx(stream,
                        new GridViewDocumentExportOptions()
                        {
                            ExportDefaultStyles = true,
                            ShowColumnFooters = true,
                            ShowColumnHeaders = true,
                            ShowGroupFooters = true
                        });
                }
                //Повідомлення про успішне експортування
                MessageBox.Show("Інформацію успішно експортовано!", "Повідомлення",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
        }
        //Приховати вікно при його закритті
        private void SearchWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            // приховання форми
            this.Hide();
            //Очищення значень елементів
            _clearElements.ClearTextBoxes(this);
            _clearElements.UncheckCheckBox(this);
        }
    }
}
