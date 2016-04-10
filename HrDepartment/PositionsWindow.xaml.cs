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
    /// Interaction logic for PositionsWindow.xaml
    /// </summary>
    public partial class PositionsWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public PositionsWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        //Заповнення Gridview
        public void FillDataGrid()
        {

            //Запит
            string Query = "SELECT PositionID, PositionCode, Position, Salary, Bonus FROM Position ";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Positions");
                sda.Fill(dt);
                PositionsGridView.ItemsSource = dt.DefaultView;
            }
        }
        //Видалення запису
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер PositionID виділеної лінійки з GridView
                DataRowView rowview = PositionsGridView.SelectedItem as DataRowView;
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

                            //видалення запису
                            SqlCommand cmd = new SqlCommand("DELETE FROM Position WHERE PositionID=@PositionID ", conn);
                            cmd.Parameters.AddWithValue("@PositionID", idValue);

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
        AddEditPositionWindow addEdit = new AddEditPositionWindow();

        //оновити дані про посаду
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = PositionsGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                addEdit.positionID = Convert.ToInt16(rowview.Row.ItemArray[0]);
                addEdit.PositionNameTextBox.Text = rowview.Row.ItemArray[2].ToString();
                addEdit.PositionCodeTextBox.Text = rowview.Row.ItemArray[1].ToString();
                addEdit.SalaryTextInput.Value = rowview.Row.ItemArray[3].ToString();
                addEdit.BonusTextInput.Value = rowview.Row.ItemArray[4].ToString();
            }
            //Заговолок вікна
            addEdit.Title = "Внесення змін";
            //Показати кнопку зміни
            addEdit.EditButton.Visibility = Visibility.Visible;
            addEdit.ShowDialog();
        }
       
        //Додати інформацію про нову посаду
        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEdit.Title = "Додати новий запис про посаду";
            //Показати кнопку додавання
            addEdit.AddButton.Visibility = Visibility.Visible;
            addEdit.ShowDialog();
        }
        
        //Експортувати у файл
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
                        PositionsGridView.ExportToPdf(stream,
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
                        PositionsGridView.ExportToXlsx(stream,
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
        //Приховати вікно при закритті
        private void PositionsWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }
    }
}
