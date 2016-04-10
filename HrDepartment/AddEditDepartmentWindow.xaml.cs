using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for AddEditDepartmentWindow.xaml
    /// </summary>
    public partial class AddEditDepartmentWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        
        //ID запису про підрозділ
        public int DepartmentId;

        private readonly ClearElements _clearElements;
        public AddEditDepartmentWindow()
        {
            InitializeComponent();
            BindComboBox(FiaComboBox);
            _clearElements = new ClearElements();
        }

        //Вибираємо інформацію (Binding) у ComboBox
        public void BindComboBox(ComboBox comboBoxName)
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про працівників (ПІБ та ID)
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT wk.Surname +  ' ' + wk.Name + ' ' + wk.MiddleName AS Fia " +
                        "FROM Workers wk " +
                        " INNER JOIN Contract con on wk.ID = con.ID " +
                        "where con.DismissDate is null ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Workers");

                //заповнюємо Combobox
                FiaComboBox.ItemsSource = ds.Tables[0].DefaultView;
                FiaComboBox.DisplayMemberPath = ds.Tables[0].Columns["Fia"].ToString();
                FiaComboBox.Text = ds.Tables[0].Columns["Fia"].ToString();
            }
        }

        //Додати інформацію про підрозділ
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //перевірити чи користувач обрав голову підрозділу
            if (FiaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Будь-ласка, оберіть начальника підрозділу!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
            }

            //якщо користувач не заповнив назву підрозділу
            if (DepNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Будь-ласка, введіть назву нового підрозділу!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
            }
            
            //Взяти ім'я керуючого підрозділу з FiaComboBox
            string headFia = FiaComboBox.Text.ToString();

                //Створення Sql-з'єднання
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Відкриваємо з'єднання
                    conn.Open();

                    //Запит для внесення даних про підрозділ
                    SqlCommand query = new SqlCommand("INSERT INTO Department (DepartmentName,  office, Head, PhoneNumber) " +
                                                    " VALUES(@DepartmentName, @office, @Head, @PhoneNumber) ", conn);
                    //Параметри запиту
                    query.Parameters.AddWithValue("@DepartmentName", DepNameTextBox.Text.Trim().ToString());
                    //якщо пусте значення - заповнити NULL
                    query.Parameters.AddWithValue("@office", (object)OfficeNumericUpDown.Value ?? DBNull.Value);
                    query.Parameters.AddWithValue("@Head", headFia);
                    query.Parameters.AddWithValue("@PhoneNumber", (object) TelephoneTextInput.Text.ToString() ?? DBNull.Value);

                    //виконання запиту
                    int a = query.ExecuteNonQuery();

                    //закриваємо з'єднання
                    conn.Close();

                    //якщо дані успішно додано
                    if (a == 1)
                    {
                        MessageBox.Show("Дані про новий підрозділ успішно внесено!",
                            "Повідомлення",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    //Закриваємо форму
                    this.Hide();
                    Clear();

                    //оновлюємо GridView
                    DepartmentsWindow departments = new DepartmentsWindow();
                    departments.FillDataGrid();
                    departments.DepartmentsGridView.UpdateLayout();
                }
            }

        //Внесення змін 
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
                //Створення Sql-з'єднання
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Відкриваємо з'єднання
                    conn.Open();

                    //внесемо зміни в запис про підрозділ
                    SqlCommand query = new SqlCommand("UPDATE Department SET DepartmentName=@DepartmentName, " +
                                                    "office=@office, Head=@Head, PhoneNumber=@PhoneNumber " +
                                                    "WHERE DepartmentID=@DepartmentID ", conn);

                    //Параметри запиту
                    query.Parameters.AddWithValue("@DepartmentName", DepNameTextBox.Text.Trim().ToString());
                    //якщо пусте значення - заповнити NULL
                    query.Parameters.AddWithValue("@office", (object)OfficeNumericUpDown.Value ?? DBNull.Value);
                    query.Parameters.AddWithValue("@Head", FiaComboBox.Text.ToString());
                    query.Parameters.AddWithValue("@PhoneNumber", (object) TelephoneTextInput.Text.ToString() ?? DBNull.Value);
                    query.Parameters.AddWithValue("@DepartmentID", DepartmentId);


                    //виконання запиту
                    int a = query.ExecuteNonQuery();

                    //закриваємо з'єднання
                    conn.Close();

                    //якщо дані успішно змінено
                    if (a == 1)
                    {
                        MessageBox.Show("Зміни успішно внесено!", "Повідомлення",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                    }
                    //Закриваємо форму
                    this.Hide();
                    Clear();

                    //оновлюємо GridView
                    ActivityWindow activityWindow = new ActivityWindow();
                    activityWindow.FillDataGrid();
                    activityWindow.ActivityGridView.UpdateLayout();
                }
            }
        //Приховати вікно
        private void AddEditDepartmentWindow_Closing(object sender, CancelEventArgs e)
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
            FiaComboBox.SelectedIndex = -1;
            _clearElements.ClearTextBoxes(this);
            _clearElements.ClearRadNumericUpDown(this);
            TelephoneTextInput.Value = null;
            AddButton.Visibility = Visibility.Hidden;
            ChangeButton.Visibility = Visibility.Hidden;
            FiaComboBox.IsEnabled = true;
           
        }
    }
}
    

