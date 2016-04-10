using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using MessageBox = System.Windows.MessageBox;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string _connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        public LoginWindow()
        {
            InitializeComponent();
        }
        
        //Завершення процесу при натисканні кнопки закриття (Window)
        void LoginWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    
        //Вхід користувача
        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не ввів логін чи пароль
            if (LoginTextBox.Text == "" || PasswordBox.Password == "")
            {
                MessageBox.Show("Будь-ласка, введіть логін / пароль!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            try
            {
                //Створення Sql-з'єднання
                SqlConnection conn = new SqlConnection { ConnectionString = _connection };
                //Відкриваємо з'єднання
                conn.Open();
                //звіряємо логін/пароль з записами у базі даних
                SqlCommand cmd = new SqlCommand("Select * from Login WHERE UserName=@userName and Password=@Password",
                    conn);
                cmd.Parameters.AddWithValue("@userName", LoginTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordBox.Password);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                //закриття з'єднання
                conn.Close();
                //Якщо кількість дорівнює 1, увійти у систему
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    this.Hide();
                }
                //якщо помилка, показати повідомлення
                else
                {
                    MessageBox.Show("Логін / пароль не коректні!", "Помилка", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    LoginTextBox.Text = String.Empty;
                    PasswordBox.Password = String.Empty;
                }
            }
            //в разі помилки - вивести повідомлення
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Завершення роботи програми
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Увійти при натисканні Enter
        private void PasswordBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //Натиснути кнопку "Вхід"
                EntryButton_Click((object) sender, (RoutedEventArgs) e);
            }
        }
    }
}
