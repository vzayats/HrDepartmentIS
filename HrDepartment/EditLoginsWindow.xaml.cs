using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using MessageBox = System.Windows.MessageBox;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for EditLoginsWindow.xaml
    /// </summary>
    public partial class EditLoginsWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string _connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        private readonly ClearElements _clearElements;
        public EditLoginsWindow()
        {
            InitializeComponent();
            LoginTypeComboBox.SelectedIndex = 1;
            _clearElements = new ClearElements();
        }
        //Зміна паролю корситувача
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не ввів логін
            if (LoginTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Будь-ласка, введіть логін!", "Попередження", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            //перевірка довжини пароля
            if (PasswordBox.Password.Trim().Length < 6)
            {
                MessageBox.Show("Пароль повинен бути довжиною більше 6 символів!", "Попередження", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                PasswordBox.Focus();
                return;
            }
            try
            {
                //Створення Sql-з'єднання
                SqlConnection conn = new SqlConnection {ConnectionString = _connection};
                //Відкриваємо з'єднання
                conn.Open();

                //змінюємо запис паролю для обраного користувача
                SqlCommand cmd = new SqlCommand("UPDATE Login SET Password=@Password WHERE UserName=@userName AND ROLE <> 'Administrator'", conn);
                cmd.Parameters.AddWithValue("@userName", LoginTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", PasswordBox.Password.Trim());
                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();
                //якщо дані не змінено
                if (a == 0)
                {
                    System.Windows.MessageBox.Show("Пароль користувача не було змінено!", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                //якщо дані було оновлено
                else if (a == 1)
                {
                    System.Windows.MessageBox.Show("Пароль користувача " + LoginTextBox.Text + " успішно змінено!",
                        "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    Clear();
                }
            }
            //в разі помилки - вивести повідомлення
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //видалення користувача
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не ввів логін
            if (LoginTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Будь-ласка, введіть логін!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            try
            {
                //Створення Sql-з'єднання
                SqlConnection conn = new SqlConnection { ConnectionString = _connection };
                //Відкриваємо з'єднання
                conn.Open();

                //видалення користувача (крім користувачів з роллю "Адміністратор")
                SqlCommand cmd = new SqlCommand("DELETE FROM LOGIN WHERE UserName=@userName AND " +
                                                "Password=@Password AND ROLE <> 'Administrator'", conn);
                cmd.Parameters.AddWithValue("@userName", LoginTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", PasswordBox.Password.Trim());
                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();
                //якщо користувача не видалено
                if (a == 0)
                {
                    System.Windows.MessageBox.Show("Користувача не було видалено!", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                //якщо користувача видалено
                else if (a == 1)
                {
                    System.Windows.MessageBox.Show("Користувача " + LoginTextBox.Text + " успішно видалено!",
                        "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    Clear();
                }
            }
            //в разі помилки - вивести повідомлення
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Додати нового користувача
        private void UserAddButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не ввів логін чи пароль
            if (LoginCreateTextBox.Text.Trim() == "" || PasswordCreateBox.Password.Trim() == "")
            {
                MessageBox.Show("Будь-ласка, введіть логін / пароль!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }
            //перевірка довжини пароля
            if (PasswordCreateBox.Password.Trim().Length < 6)
            {
                MessageBox.Show("Пароль повинен бути довжиною більше 6 символів!", "Попередження", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                PasswordCreateBox.Focus();
                return;
            }
            try
            {
                //Створення Sql-з'єднання
                SqlConnection conn = new SqlConnection { ConnectionString = _connection };
                //Відкриваємо з'єднання
                conn.Open();

                //отрмаємо значення name з ComboBox
                ComboBoxItem comboItem = (ComboBoxItem)LoginTypeComboBox.SelectedItem;
                string role = comboItem.Name;
                
                //додавання нового користувача (якщо такий вже існує, з тим же ім'ям не буде додано)
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT UserName FROM dbo.Login WHERE UserName=@userName )" +
                                                "INSERT INTO dbo.Login ([UserName],[Password],[Role],[CreatedDate])" +
                                                "VALUES (@userName, @Password, @Role, GETDATE())", conn);
                cmd.Parameters.AddWithValue("@userName", LoginCreateTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", PasswordCreateBox.Password.Trim());
                cmd.Parameters.AddWithValue("@Role", role);
                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();

                //якщо користувача успішно додано
                if (a > 0)
                {
                    System.Windows.MessageBox.Show("Нового користувача (" + LoginCreateTextBox.Text + ") успішно додано!",
                       "Повідомлення", MessageBoxButton.OK,
                       MessageBoxImage.Information);
                    Clear();
                    
                }
                //якщо користувач вже існує
                else  
                {
                    System.Windows.MessageBox.Show("Такий користувач вже існує", "Повідомлення",
                         MessageBoxButton.OK,
                         MessageBoxImage.Warning);
                }
            }
            //в разі помилки - вивести повідомлення
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Закрити вікно
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Clear();
        }

        //Приховати вікно при його закритті
        private void EditLoginsWindow_Closing(object sender, CancelEventArgs e)
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
            _clearElements.ClearTextBoxes(this);
            _clearElements.ClearPasswordBox(this);
            LoginTypeComboBox.SelectedIndex = 1;
        }
    }
}
