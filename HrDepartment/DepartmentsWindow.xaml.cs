using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Model;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for DepartmentsWindow.xaml
    /// </summary>
    public partial class DepartmentsWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public DepartmentsWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        //заповнюємо GridView
        public void FillDataGrid()
        {
            //Запит для виводу всіх даних про підрозділи
            string Query = "SELECT DepartmentID, DepartmentName, Head, office, PhoneNumber FROM Department ";

            //використаємо з'єднання
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Department");
                //Заповнення DataTable
                sda.Fill(dt);
                DepartmentsGridView.ItemsSource = dt.DefaultView;
            }
        }
        //Експортування GridView
        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem comboItem = (ComboBoxItem)ComboBox.SelectedItem;

            //Експортувати в документ PDF
            if (comboItem.Name != null && comboItem.Name.ToString() == "Pdf")
            {
                string extension = "pdf";
                //
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    DefaultExt = extension,
                    RestoreDirectory = true,
                    Title = "Збереження",
                    Filter = String.Format("Файл {1} (*.{0})|*.{0}|Всі файли (*.*)|*.*", extension, "Pdf"),
                    FilterIndex = 1
                };

                if (dialog.ShowDialog() == true)
                {
                    using (Stream stream = dialog.OpenFile())
                    {
                        //параметри експорту
                        DepartmentsGridView.ExportToPdf(stream,
                            new GridViewPdfExportOptions()
                            {
                                ShowColumnHeaders = true,
                                ShowColumnFooters = true,
                                ShowGroupFooters = true,
                                ExportDefaultStyles = true,
                                PageOrientation = PageOrientation.Landscape
                            });
                        //Повідомлення про успішне експортування
                        MessageBox.Show("Експорт у файл Pdf виконано успішно!", "Повідомлення",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            //Експортувати в документ Excel
            if (comboItem.Name != null && comboItem.Name.ToString() == "Xlsx")
            {
                string extension = "xlsx";

                SaveFileDialog dialog = new SaveFileDialog()
                {
                    DefaultExt = extension,
                    Title = "Збереження",
                    RestoreDirectory = true,
                    Filter = String.Format("Файл {1} (*.{0})|*.{0}|Всі файли (*.*)|*.*", extension, "Excel"),
                    FilterIndex = 1
                };

                if (dialog.ShowDialog() == true)
                {
                    using (Stream stream = dialog.OpenFile())
                    {
                        //параметри експорту
                        DepartmentsGridView.ExportToXlsx(stream,
                            new GridViewDocumentExportOptions()
                            {
                                ShowColumnFooters = true,
                                ShowColumnHeaders = true,
                                ShowGroupFooters = true,
                                ExportDefaultStyles = true
                            });
                        //Повідомлення про успішне експортування
                        MessageBox.Show("Експорт у файл Excel виконано успішно!", "Повідомлення",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        //Виалити підрозділ
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити обраний запис про підрозділ
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер DepartmentID виділеної лінійки з GridView
                DataRowView rowview = DepartmentsGridView.SelectedItem as DataRowView;
                if (rowview != null)
                {
                    var idValue = rowview.Row.ItemArray[0].ToString();

                    //Створення Sql-з'єднання
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            //Відкриваємо з'єднання
                            conn.Open();

                            //запит видалення запису про підрозділ
                            SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE DepartmentID=@DepartmentID ", conn);
                            //параметр запису
                            cmd.Parameters.AddWithValue("@DepartmentID", idValue);

                            //виконання запиту
                            int a = cmd.ExecuteNonQuery();

                            //закриваємо з'єднання
                            conn.Close();

                            //якщо запис успішно видалено
                            if (a == 1)
                            {
                                MessageBox.Show("Запис успішно видалено!", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
                                //Оновити GridView
                                FillDataGrid();
                            }
                        }
                        //в разі помилки - вивести повідомлення
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        AddEditDepartmentWindow addEdit = new AddEditDepartmentWindow();

        //Додати новий підрозділ
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEdit.Title = "Додати дані про новий підрозділ";
            //Показати кнопку додавання
            addEdit.AddButton.Visibility = Visibility.Visible;
            addEdit.ShowDialog();
        }

        //оновлення даних про підрозділ
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = DepartmentsGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                //відкрити з вказаними значеннями (з GridView)
                addEdit.DepartmentId = Convert.ToInt16(rowview.Row.ItemArray[0]);
                addEdit.DepNameTextBox.Text = rowview.Row.ItemArray[1].ToString();
                addEdit.OfficeNumericUpDown.Value = Convert.ToInt16(rowview.Row.ItemArray[3]);
                //ім'я начальника (текстовий) з GridView у ComboBox
                addEdit.FiaComboBox.Text = rowview.Row.ItemArray[2].ToString();
                addEdit.TelephoneTextInput.Value = rowview.Row.ItemArray[4].ToString();
            }
            //Заговолок вікна
            addEdit.Title = "Внесення змін";
            //Показати кнопку зміни
            addEdit.ChangeButton.Visibility = Visibility.Visible;
             
            //показати форму зміни даних
            addEdit.Show();
        }
        //Приховати вікно при закритті
        private void DepartmentsWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }
    }
}
