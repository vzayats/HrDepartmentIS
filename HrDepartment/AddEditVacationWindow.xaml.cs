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
    /// Interaction logic for AddEditVacationWindow.xaml
    /// </summary>
    public partial class AddEditVacationWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        
        //ID відпустки
        public int VacationId;

        private readonly ClearElements _clearElements;
        public AddEditVacationWindow()
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT wk.ID as WorkerID, wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia " +
                                                "FROM Workers wk " +
                                                " INNER JOIN Contract con on wk.ID = con.ID " +
                                                "INNER JOIN Addresses adr on wk.ID = adr.ID " +
                                                "where con.DismissDate is null ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Workers");

                //заповнюємо Combobox
                comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["Fia"].ToString();
                comboBoxName.SelectedValuePath = ds.Tables[0].Columns["WorkerID"].ToString();
            }
        }
        //Додати дані про нову відпустку працівника
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Обрати значення ID працівника з ComboBox
            var id = FiaComboBox.SelectedValue.ToString();

            //Обрати тип відпустку з ComboBox
            ComboBoxItem comboItem = (ComboBoxItem)TypeVacationComboBox.SelectedItem;
            string typeName = comboItem.Content.ToString();

            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //Запит для вносення даних про нову відпустку 
                SqlCommand cmd = new SqlCommand("INSERT INTO Vacations (WorkerID, TypeOfVacation, DateOfStart, DateOfEnd) " +
                                                " VALUES (@WorkerID, @TypeOfVacation, @DateOfStart, @DateOfEnd) ", conn);
                //Параметри запиту
                cmd.Parameters.AddWithValue("@WorkerID", id);
                cmd.Parameters.AddWithValue("@TypeOfVacation", typeName);
                //якщо дату не обрано
                cmd.Parameters.AddWithValue("@DateOfStart", (object)DateOfStart.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfEnd", (object)DateOfEnd.SelectedValue ?? DBNull.Value);

                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();

                //якщо дані успішно додано
                if (a == 1)
                {
                    MessageBox.Show("Дані про відпустку працівника успішно внесено!", "Повідомлення",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                //Закриваємо форму
                this.Hide();
                Clear();

                //оновлюємо GridView
                VacationWindow vacationWindow = new VacationWindow();
                vacationWindow.FillDataGrid();
                vacationWindow.VacationGridView.UpdateLayout();

            }
        }
        //Внести зміни у дані про відпустку працівника
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            //Обрати значення ID працівника з ComboBox
            var id = FiaComboBox.SelectedValue.ToString();

            //Обрати тип відпустку з ComboBox
            ComboBoxItem comboItem = (ComboBoxItem)TypeVacationComboBox.SelectedItem;
            string typeName = comboItem.Content.ToString();

            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //внесемо зміни в запис про відпустку працівника
                SqlCommand cmd = new SqlCommand("UPDATE Vacations SET WorkerID=@WorkerID, " +
                                                "TypeOfVacation=@TypeOfVacation, DateOfStart=@DateOfStart, DateOfEnd=@DateOfEnd " +
                                                "WHERE VacationID=@VacationID ", conn);
                cmd.Parameters.AddWithValue("@WorkerID", id);
                cmd.Parameters.AddWithValue("@TypeOfVacation", typeName);
                //якщо дату не обрано
                cmd.Parameters.AddWithValue("@DateOfStart", (object)DateOfStart.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfEnd", (object)DateOfEnd.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@VacationID", VacationId);

                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();

                //якщо дані успішно змінено
                if (a == 1)
                {
                    MessageBox.Show("Зміни внесено успішно!", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                //Закриваємо форму
                this.Hide();
                Clear();

                //оновлюємо GridView
                VacationWindow vacationWindow = new VacationWindow();
                vacationWindow.FillDataGrid();
                vacationWindow.VacationGridView.UpdateLayout();

            }
        }
        //Приховати вікно
        private void AddEditVacationWindow_Closing(object sender, CancelEventArgs e)
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
            TypeVacationComboBox.SelectedIndex = 0;
            _clearElements.DefaultDatePicker(this);
            AddButton.Visibility = Visibility.Hidden;
            ChangeButton.Visibility = Visibility.Hidden;
            FiaComboBox.IsEnabled = true;
        }

    }
}
