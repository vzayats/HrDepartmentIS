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
    /// Interaction logic for ActivityWindow.xaml
    /// </summary>
    public partial class ActivityWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public ActivityWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        //заповнюємо GridView
        public void FillDataGrid()
        {
            //Запит для виводу всіх даних про діяльність працівників
            string Query =
           "SELECT act.ActivityID, wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia, " +
           "act.CalendarMonth, act.CalendarMonthName,  act.CalendarYear, ACT.Present, act.Absence, " +
           "act.Hospital, act.Vacation, wk.ID " +
           "FROM Workers wk " +
           "INNER JOIN Contract con on wk.ID = con.ID " +
           "INNER JOIN Activity act on wk.ID = act.WorkerID " +
           " INNER JOIN Department dep on wk.DepartmentID = dep.DepartmentID " +
           " order by act.CalendarYear asc, act.CalendarMonth asc ";

            //використаємо з'єднання
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Activity");
                sda.Fill(dt);
                ActivityGridView.ItemsSource = dt.DefaultView;
            }
        }
        

        //Експорт у файл
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
                        ActivityGridView.ExportToPdf(stream,
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
                        ActivityGridView.ExportToXlsx(stream,
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
        //Видалити запис про діяльність працівника
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити обраний запис про діяльність працівника за місяць 
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер ActivityID виділеної лінійки з GridView
                DataRowView rowview = ActivityGridView.SelectedItem as DataRowView;
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

                            //запит видалення запису про діяльність
                            SqlCommand cmd = new SqlCommand("DELETE FROM Activity WHERE ActivityID=@ActivityID ", conn);
                            //параметр запису
                            cmd.Parameters.AddWithValue("@ActivityID", idValue);

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

        //Додати дані про діяльність працівника
        AddEditActivityWindow addEditActivity = new AddEditActivityWindow();
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEditActivity.Title = "Додати дані про діяльність";
            //Показати кнопку додавання
            addEditActivity.AddButton.Visibility = Visibility.Visible;
            addEditActivity.ShowDialog();
        }
        //Внести зміни про діяльність працівника
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = ActivityGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                //відкрити з вказаними значеннями (з GridView)
                addEditActivity.ActivityID = Convert.ToInt16(rowview.Row.ItemArray[0]);
                addEditActivity.YearNumericUpDown.Value = Convert.ToInt32(rowview.Row.ItemArray[4]);

                addEditActivity.PresentNumericUpDown.Value = Convert.ToInt16(rowview.Row.ItemArray[5]);
                addEditActivity.AbsenceNumericUpDown.Value = Convert.ToInt16(rowview.Row.ItemArray[6]);
                addEditActivity.HospitalNumericUpDown.Value = Convert.ToInt16(rowview.Row.ItemArray[7] );
                addEditActivity.VacationNumericUpDown.Value = Convert.ToInt16(rowview.Row.ItemArray[8]);
                
                //назва місяця (текстовий) з GridView у ComboBox
                addEditActivity.MonthComboBox.Text = rowview.Row.ItemArray[3].ToString();

                //визначимо ID працівника для comboBox
                string workerId = rowview.Row.ItemArray[9].ToString();
                addEditActivity.FiaComboBox.SelectedValue = workerId;

            }
            //Заговолок вікна
            addEditActivity.Title = "Внесення змін";
            //Показати кнопку зміни
            addEditActivity.ChangeButton.Visibility = Visibility.Visible;
            //Заборонити змінювати прізвище в ComoBox
            addEditActivity.FiaComboBox.IsEnabled = false;
            //показати форму зміни даних
            addEditActivity.ShowDialog();
        }
        //Приховати вікно після його закриття
        private void ActivityWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide(); 
            ComboBox.SelectedIndex = 0;
        }
    }
}
