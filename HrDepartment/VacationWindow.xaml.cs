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
    /// Interaction logic for VacationWindow.xaml
    /// </summary>
    public partial class VacationWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public VacationWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        //заповнюємо GridView
        public void FillDataGrid()
        {
            string conString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
            //Запит
            string Query =
           "SELECT vac.VacationID, wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia, " +
           " vac.TypeOfVacation, vac.DateOfStart, vac.DateOfEnd, " +
           " DATEDIFF(DAY, vac.DateOfStart, vac.DateOfEnd) as CountOfDays, wk.ID " +
           " FROM dbo.Vacations vac " +
           " INNER JOIN Workers wk on vac.WorkerID = wk.ID INNER JOIN Contract con on vac.WorkerID = con.ID " +
           "where con.DismissDate is null ";

            //використаємо з'єднання
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Vacations");
                sda.Fill(dt);
                VacationGridView.ItemsSource = dt.DefaultView;
            }
        }

        //Експорт у файл
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
                        VacationGridView.ExportToPdf(stream,
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
                        VacationGridView.ExportToXlsx(stream,
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
        AddEditVacationWindow addEditVacation = new AddEditVacationWindow();
        //додати відомості про нову відпустку
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEditVacation.Title = "Додати відомості про відпустку працівника";
            //Показати кнопку додавання
            addEditVacation.AddButton.Visibility = Visibility.Visible;
            addEditVacation.ShowDialog();
        }
        //оновити дані про відпустку
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = VacationGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                //відкрити з вказаними значеннями
                addEditVacation.VacationId = Convert.ToInt16(rowview.Row.ItemArray[0]);
                addEditVacation.DateOfStart.SelectedValue = rowview.Row.ItemArray[3] as DateTime?;
                addEditVacation.DateOfEnd.SelectedValue = rowview.Row.ItemArray[4] as DateTime?;
                //тип відпустки з GridView у ComboBox
                addEditVacation.TypeVacationComboBox.Text = rowview.Row.ItemArray[2].ToString();

                //визначимо ID працівника для comboBox
                string workerId = rowview.Row.ItemArray[6].ToString();
                addEditVacation.FiaComboBox.SelectedValue = workerId;

            }
            //Заговолок вікна
            addEditVacation.Title = "Внесення змін";
            //Показати кнопку зміни
            addEditVacation.ChangeButton.Visibility = Visibility.Visible;
            //Заборонити змінювати прізвище в ComoBox
            addEditVacation.FiaComboBox.IsEnabled = false;
            //показати форму зміни даних
            addEditVacation.ShowDialog();
        }

        //видалення інформації про відпустку працівника
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис про відпустку?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити запис відпустки працівника
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер VacationID виділеної лінійки з GridView
                DataRowView rowview = VacationGridView.SelectedItem as DataRowView;
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

                            //запит видалення запису про відпустку
                            SqlCommand cmd = new SqlCommand("DELETE FROM Vacations WHERE VacationID=@VacationID ", conn);
                            cmd.Parameters.AddWithValue("@VacationID", idValue);

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
        //Приховати вікно при його закритті
        private void VacationWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }
    }
}
