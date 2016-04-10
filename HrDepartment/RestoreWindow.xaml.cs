using System;
using System.ComponentModel;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for RestoreWindow.xaml
    /// </summary>
    public partial class RestoreWindow : Window
    {
        private SqlCommand _command;
       
        //Конфігурація з'єднання з базою даних
        string connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        
        private readonly ClearElements _clearElements;
        public RestoreWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }
        //Пошук файлу резервної копії
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Файли резервних копій (*.bak)|*.bak|Всі файли (*.*)|*.*",
                FilterIndex = 0,
                Title = "Відновлення",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == true)
            {
                RestoreFileTextBox.Text = open.FileName;
            }
        }
        //Закриття вікна
        private void CLoseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _clearElements.ClearTextBoxes(this);
        }
        //Відновлення резервної копії
        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Якщо користувач не обрав файл резервної копії
                if (String.Compare(RestoreFileTextBox.Text, "", StringComparison.Ordinal) == 0)
                {
                    MessageBox.Show("Будь-ласка, оберіть файл резервної копії!", "Помилка",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                SqlConnection conn = new SqlConnection { ConnectionString = connection };
                //Відкриваємо з'єднання
                conn.Open();

                string dbname = conn.Database;

                //Переключення на master
                string UseMaster = "USE MASTER";
                _command = new SqlCommand(UseMaster, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Переключення на однокористувацький режим
                string alter = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                _command = new SqlCommand(alter, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Відновлення резервної копії
                string restore = "RESTORE DATABASE " + dbname + " FROM DISK = '" + RestoreFileTextBox.Text + "' WITH REPLACE";
                _command = new SqlCommand(restore, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Переключення на master
                string UseMaster2 = "USE MASTER";
                _command = new SqlCommand(UseMaster2, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Переключення на багатокористувацький режим
                string alter2 = "ALTER DATABASE " + dbname + " SET MULTI_USER";
                _command = new SqlCommand(alter2, conn);
                //Виконання запиту
                _command.ExecuteNonQuery();

                //Закриття з'єднання
                conn.Close();
                conn.Dispose();

                //Повідомлення про успішне відновлення
                MessageBox.Show("Базу даних успішно відновлено!", "Повідомлення",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                //В разі помилки - повідомлення з інформацією
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Приховання вікна при його закритті
        private void RestoreWindow_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;  //відміна закриття вікна    
            this.Hide(); // приховання форми
            _clearElements.ClearTextBoxes(this);
        }
    }
}
