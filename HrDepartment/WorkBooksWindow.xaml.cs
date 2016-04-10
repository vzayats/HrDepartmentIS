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
    /// Interaction logic for WorkBooksWindow.xaml
    /// </summary>
    public partial class WorkBooksWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public WorkBooksWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        //заповнюємо GridView
        public void FillDataGrid()
        {            
            //Запит
            string Query = "SELECT book.WorkBookID, wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia, " +
          "book.SeriesNumber, book.DateOfFilling, book.DateOfGiven, book.IsGiven, " +
           "CASE WHEN book.IsGiven = 1 THEN 'Видана' " +
           "WHEN book.IsGiven = 0 THEN 'Не видана' end IsGiven, wk.ID " +
           "FROM dbo.WorkBooks book " +
           "INNER JOIN Workers wk on wk.ID = book.WorkerID " +
           "INNER JOIN Contract con on wk.ID = con.ID where con.DismissDate is null ";
           
            //використаємо з'єднання
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("WorkBooks");
                sda.Fill(dt);
                WorkBooksGridView.ItemsSource = dt.DefaultView;
            }
        }

        //Експорт у файл PDF та Excel
        private void ExportButton_OnClick(object sender, RoutedEventArgs e)
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
                        WorkBooksGridView.ExportToPdf(stream,
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
                        WorkBooksGridView.ExportToXlsx(stream,
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
        //видалення інформації про трудову книгу працівника
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити запис трудової книги
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер WorkBookID виділеної лінійки з GridView
                DataRowView rowview = WorkBooksGridView.SelectedItem as DataRowView;
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

                            //запит видалення запису
                            SqlCommand cmd = new SqlCommand("DELETE FROM WorkBooks WHERE WorkBookID=@WorkBookID ", conn);
                            cmd.Parameters.AddWithValue("@WorkBookID", idValue);

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
       
        AddEditWorkBookWindow workBookEditWindow = new AddEditWorkBookWindow();

        //внести зміни в інформацію про вибрану трудову книжку в нове вікно
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = WorkBooksGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                //відкрити з вказаними значеннями
                workBookEditWindow.workerBookID = Convert.ToInt16(rowview.Row.ItemArray[0]);
                workBookEditWindow.SeriesNumberTextBox.Text = rowview.Row.ItemArray[2].ToString();
                workBookEditWindow.DateOfFillingDatePicker.SelectedValue = rowview.Row.ItemArray[3] as DateTime?;
                workBookEditWindow.DateOfGivenDatePicker.SelectedValue = rowview.Row.ItemArray[4] as DateTime?;
                workBookEditWindow.IsGivenCheckBox.IsChecked = (bool?) rowview.Row.ItemArray[5];
                
                //визначимо ID працівника для comboBox
                string workerId = rowview.Row.ItemArray[7].ToString();
                workBookEditWindow.FiaComboBox.SelectedValue = workerId;
                 
            }
            //Заговолок вікна
            workBookEditWindow.Title = "Внесення змін";
            //Показати кнопку зміни
            workBookEditWindow.ChangeButton.Visibility = Visibility.Visible;
            //Заборонити змінювати прізвище в ComoBox
            workBookEditWindow.FiaComboBox.IsEnabled = false;
            //показати форму зміни даних
            workBookEditWindow.ShowDialog();
        }

        //Додати відомості про нову трудову книгу працівника
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            workBookEditWindow.Title = "Додати новий запис про трудову книжку";
            //Показати кнопку додавання
            workBookEditWindow.AddButton.Visibility = Visibility.Visible;
            workBookEditWindow.ShowDialog();
        }
        //Приховати вікно при закритті
        private void WorkBooksWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }
    }
}
