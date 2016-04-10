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
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Documents.Model;
using Path = System.IO.Path;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for CvWindow.xaml
    /// </summary>
    public partial class CvWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        public CvWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        //заповнюємо GridView
        public void FillDataGrid()
        {
            //Запит
            string Query = "SELECT CvId, Vacancy, CandidateName, FileName, Data, AddDate FROM Candidates";

            //використаємо конфігурацію з'єднання
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Candidates");
                sda.Fill(dt);
                CandidatesGridView.ItemsSource = dt.DefaultView;
            }
        }

        //видалити кандидата
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Попередження",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити запис відпустки працівника
            if (result == MessageBoxResult.Yes)
            {
                //Обрати номер CvId (запису кандидата) виділеної лінійки з GridView
                DataRowView rowview = CandidatesGridView.SelectedItem as DataRowView;
                if (rowview != null)
                {
                    var idValue = rowview.Row.ItemArray[0].ToString();

                    //Створення Sql-з'єднання
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        try
                        {
                            //Відкриваємо з'єднання
                            conn.Open();

                            //запит видалення запису про кандидата на роботу
                            SqlCommand cmd = new SqlCommand("DELETE FROM Candidates WHERE CvId=@CvId ", conn);
                            cmd.Parameters.AddWithValue("@CvId", idValue);

                            //виконання запиту
                            int a = cmd.ExecuteNonQuery();

                            //закриваємо з'єднання
                            conn.Close();

                            //якщо запис успішно видалено
                            if (a == 1)
                            {
                                MessageBox.Show("Запис успішно видалено!", "Повідомлення", MessageBoxButton.OK,
                                    MessageBoxImage.Information);
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

        //відкрити файл резюме кандидата
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            //при натисканні кнопки OpenButton - змінити фокус на рядок, в якому знаходиться кнопка
            var senderElement = e.OriginalSource as FrameworkElement;
            var row = senderElement.ParentOfType<GridViewRow>();
            if (row != null)
                row.IsSelected = true;

            //Обрати номер CvId (запису кандидата) виділеної лінійки з GridView
            DataRowView rowview = CandidatesGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                var idValue = rowview.Row.ItemArray[0].ToString();

                //використаємо з'єднання
                using (SqlConnection con = new SqlConnection(connection))
                {
                    //Витягнемо ім'я файлу та сам файл
                    SqlCommand cmd = new SqlCommand("SELECT FileName, Data FROM Candidates where CvId=@CvId", con);
                    cmd.Parameters.AddWithValue("@CvId", idValue);
                    //відкриваємо з'єднання
                    con.Open();

                    //прочитаємо потік 
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //визначимо назву файлу
                            string path = reader.GetString(0);

                            //витягнемо файл
                            byte[] transactionContext = reader.GetSqlBytes(1).Buffer;

                            //діалог збереження файлу
                            SaveFileDialog dlg = new SaveFileDialog();
                            dlg.RestoreDirectory = true;
                            dlg.Title = "Збереження";

                            //Ім'я файлу з бази даних
                            dlg.FileName = path;

                            //Показати діалог збереження файлу
                            bool? result = dlg.ShowDialog();

                            //Якщо підтверджено - зберегти у файл
                            if (result == true)
                            {
                                FileStream fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.ReadWrite);
                                fs.Write(transactionContext, 0, transactionContext.Length);
                                fs.Close();

                                //Повідомлення про успішне експортування
                                MessageBox.Show(
                                    "Документ '" + Path.GetFileName(dlg.FileName.Trim()) + "' успішно збережено!",
                                    "Повідомлення",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                    }
                }
            }
        }

        //Експортувати у файл
        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem comboItem = (ComboBoxItem) ComboBox.SelectedItem;

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
                        CandidatesGridView.ExportToPdf(stream,
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
                        CandidatesGridView.ExportToXlsx(stream,
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

        AddEditCvWindow addEditCv = new AddEditCvWindow();

        //Додати нового кандидата
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEditCv.Title = "Додати нового кандидата";
            //Показати кнопку додавання
            addEditCv.AddButton.Visibility = Visibility.Visible;
            addEditCv.ShowDialog();
        }

        //оновити дані про кандидата
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //Перенести дані вибраної стрічки GridView у форму редагування
            DataRowView rowview = CandidatesGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                //відкрити з вказаними значеннями (з GridView)
                addEditCv.PersonTextBox.Text = rowview.Row.ItemArray[2].ToString();
                //Номер вакансыъ
                addEditCv.CvId = Convert.ToInt16(rowview.Row.ItemArray[0]);

                //назва посади (текстовий) з GridView у ComboBox
                addEditCv.VacancyComboBox.Text = rowview.Row.ItemArray[1].ToString();
                
                //Параметри вікна
                addEditCv.Title = "Змінити дані кандидата";
                addEditCv.EditButton.Visibility = Visibility.Visible;
                //відкрити
                addEditCv.ShowDialog();
            }
        }
        //Приховати вікно при закритті
        private void CvWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховання форми
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }
    }
}

