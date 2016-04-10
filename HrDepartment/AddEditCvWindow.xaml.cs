using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for AddEditCvWindow.xaml
    /// </summary>
    public partial class AddEditCvWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string _connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        //Назва файлу з OpenDialog
        public string FileName;

        //ID кандидата (з CvWindow)
        public int CvId;

        private readonly ClearElements _clearElements;
        public AddEditCvWindow()
        {
            InitializeComponent();
            BindComboBox(VacancyComboBox);
            VacancyComboBox.SelectedIndex = 0;
            _clearElements = new ClearElements();
        }

        //Вибираємо назви посад (Binding) у ComboBox
        public void BindComboBox(ComboBox comboBoxName)
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про посади
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT PositionID, Position FROM Position ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Position");

                //заповнюємо Combobox
                comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["Position"].ToString();
                comboBoxName.Text = ds.Tables[0].Columns["Position"].ToString();
            }
        }

        //завантажити файл резюме кандидата на вакантну посаду
        private void UploadButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Файли документів(*.doc;*.docx;*.pdf;*.rtf;*.odt;*xps)|*.doc;*.docx;*.pdf;*.rtf;*.odt;*xps|Всі файли(*.*)|*.*",
                FilterIndex = 0,
                Title = "Відкрити файл",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == true)
            {
                FileName = open.FileName;
            }
        }

        //Додати нового кандидата
        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Обрати назву посади з VacancyComboBox (з таблиці Посади)
            string positionName = VacancyComboBox.Text.ToString();

            //якщо користувач не заповнив ім'я кандидата
            if (PersonTextBox.Text.Trim() == "" )
            {
                MessageBox.Show("Будь-ласка, введіть ім'я кандидата!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            //перевірити чи користувач обрав назву посади
            if ( VacancyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь-ласка, оберіть назву вакантної посади!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection { ConnectionString = _connection };
                //відкриття з'єднання
                conn.Open();
               
                //додаємо інформацію про нового кандидата
                SqlCommand command = new SqlCommand(@"INSERT INTO Candidates VALUES (@Vacancy, @CandidateName, @FileName, @Data, GetDate())", conn);
                
                //параметри додавання
                command.Parameters.AddWithValue("@Vacancy", positionName);
                command.Parameters.AddWithValue("@CandidateName", PersonTextBox.Text.Trim());
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 150);
                command.Parameters.Add("@Data", SqlDbType.VarBinary, Int32.MaxValue);

                //шлях до файлу для завантаження
                string file = FileName;

                //отримуємо ім'я файлу з шляху для запису в БД
                string shortFileName = file.Substring(file.LastIndexOf('\\') + 1);

                //масив для збереження бінарних даних файлу
                byte[] bytes;
                using (System.IO.FileStream fs = new System.IO.FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                }
                //передача даних в команду через параметри
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@Data"].Value = bytes;
                //виконання Sql-запиту
                int a = command.ExecuteNonQuery();

                //Закриття з'єднання
                conn.Close();

                //якщо файл не додано
                if (a == 0)
                {
                    MessageBox.Show("Інформацію про кандидата не було додано", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                //якщо успішно додано
                else if (a == 1)
                {
                    MessageBox.Show("Інформацію про нового кандидата успішно додано!",
                        "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    //Закриваємо форму
                    this.Hide();
                    Clear();
                }
            }
            //якщо користувач не обрав файл
            catch (Exception)
            {
                MessageBox.Show("Будь-ласка, оберіть файл резюме!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
            }
        }
        //оновити інформацію про кандидата
        private void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Обрати назву посади
            string positionName = VacancyComboBox.Text.ToString();

            //якщо користувач не заповнив всі поля
            if (PersonTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Будь-ласка, введіть ім'я кандидата!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            //перевірити чи користувач обрав назву посади
            if (VacancyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь-ласка, оберіть назву вакантної посади!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection { ConnectionString = _connection };
                //відкриття з'єднання
                conn.Open();

                //оновити інформацію про нового кандидата
                SqlCommand command = new SqlCommand(@"UPDATE Candidates SET  " +
                                                "Vacancy=@Vacancy, CandidateName=@CandidateName, FileName=@FileName,  Data=@Data " +
                                                "WHERE CvID=@CvID ", conn);
                //параметри оновлення
                command.Parameters.AddWithValue("@Vacancy", positionName);
                command.Parameters.AddWithValue("@CandidateName", PersonTextBox.Text.Trim());
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 150);
                command.Parameters.Add("@Data", SqlDbType.VarBinary, Int32.MaxValue);
                command.Parameters.AddWithValue("@CvID", CvId);

                //шлях до файлу для завантаження
                string file = FileName;

                //отримуємо ім'я файлу з шляху для запису в БД
                string shortFileName = file.Substring(file.LastIndexOf('\\') + 1);

                //масив для збереження бінарних даних файлу
                byte[] bytes;
                using (System.IO.FileStream fs = new System.IO.FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                }
                //передача даних в команду через параметри
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@Data"].Value = bytes;
                //виконання Sql-запиту
                int a = command.ExecuteNonQuery();

                //Закриття з'єднання
                conn.Close();

                //якщо інформацію оновлено
                if (a == 1)
                {
                    MessageBox.Show("Дані успішно оновлено!",
                        "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                //Закриваємо форму
                this.Hide();
                Clear();
            }
            //якщо користувач не обрав файл
            catch (Exception)
            {
                MessageBox.Show("Будь-ласка, оберіть файл резюме!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
            }
        }
        //Приховання вікна
        private void AddEditCvWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            //приховання форми
            this.Hide();
            Clear();
        }
        //очищення елементів вікна
        private void Clear()
        {
            VacancyComboBox.SelectedIndex = 0;
            _clearElements.ClearTextBoxes(this);
            AddButton.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Hidden;
        }
    }
}
