using System;
using System.ComponentModel;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for BackupWindow.xaml
    /// </summary>
    public partial class BackupWindow : Window
    {
        private SqlCommand _command;
        //Конфігурація з'єднання з базою даних
        string connection = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        private readonly ClearElements _clearElements;

        public BackupWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }

        //Закриття вікна
        private void CLoseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _clearElements.ClearTextBoxes(this);
        }

        

        //Вибір папки для збереження резервної копії
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathTextBox.Text = browser.SelectedPath;
            }
        }
        //Створення резервної копії
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Якщо користувач не обрав місце збереження файлу резервної копії
                if (String.Compare(PathTextBox.Text, "", StringComparison.Ordinal) == 0)
                {
                    System.Windows.MessageBox.Show("Будь-ласка, оберіть місце збереження резервної копії!", "Помилка",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                SqlConnection conn = new SqlConnection { ConnectionString = connection };
                //Відкриваємо з'єднання
                conn.Open();

                string dbname = conn.Database;

                //Створення запиту
                string sql = "BACKUP DATABASE " + dbname + " TO DISK = '" + PathTextBox.Text + "\\" +
                             dbname + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'" + dbname + "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10, CHECKSUM";
                _command = new SqlCommand(sql, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Повідомлення про успішне створення
                System.Windows.MessageBox.Show("Резервну копію успішно створено!", "Повідомлення",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                //В разі помилки - повідомлення з інформацією 
                System.Windows.MessageBox.Show(ex.Message, "Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Приховання вікна при його закритті
        private void BackupWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
            _clearElements.ClearTextBoxes(this);
        }
    }
}