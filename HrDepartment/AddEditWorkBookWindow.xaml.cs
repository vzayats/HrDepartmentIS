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
    /// Interaction logic for AddEditWorkBookWindow.xaml
    /// </summary>
    public partial class AddEditWorkBookWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;
        //ID трудової книжки
        public int workerBookID;

        private readonly ClearElements _clearElements;
        public AddEditWorkBookWindow()
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
        //Додати дані про нову трудову книжку працівника
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Обрати значення ID працівника з ComboBox
            var id = FiaComboBox.SelectedValue.ToString();

            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //Вносимо дані про нову трудову книжку (якщо така вже існує - не додаємо)
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT WorkerID FROM dbo.WorkBooks WHERE WorkerID=@WorkerID ) " +
                                                "INSERT INTO WorkBooks (WorkerID, SeriesNumber, DateOfFilling, DateOfGiven, IsGiven) " +
                                                " VALUES (@WorkerID, @SeriesNumber, @DateOfFilling, @DateOfGiven, @IsGiven) ", conn);
                //Параметри запиту
                cmd.Parameters.AddWithValue("@WorkerID", id);
                cmd.Parameters.AddWithValue("@SeriesNumber", SeriesNumberTextBox.Text.Trim());
                //якщо дату не обрано
                cmd.Parameters.AddWithValue("@DateOfFilling", (object) DateOfFillingDatePicker.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfGiven", (object) DateOfGivenDatePicker.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsGiven", IsGivenCheckBox.IsChecked);

                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();

                //якщо запис додано
                if (a > 0)
                {
                    System.Windows.MessageBox.Show("Дані про нову трудову книжку працівника внесено успішно!",
                        "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    Clear();
                }
                //якщо запис не додано
                else
                {
                    System.Windows.MessageBox.Show("Запис про трудову книжку даного працівника вже існує! Внесіть зміни в існуючий запис або видаліть його.", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
                //Закриваємо форму
                this.Hide();
                Clear();

                //оновлюємо GridView
                WorkBooksWindow workBooks = new WorkBooksWindow();
                workBooks.FillDataGrid();
                workBooks.WorkBooksGridView.UpdateLayout();

            }
        }
        //Внести зміни в інформацію про трудову книжку
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            //Обрати значення ID працівника з ComboBox
            var id = FiaComboBox.SelectedValue.ToString();
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //внесемо зміни в запис про трудову книжку
                SqlCommand cmd = new SqlCommand("UPDATE WorkBooks SET WorkerID=@WorkerID, " +
                                                "SeriesNumber=@SeriesNumber, DateOfFilling=@DateOfFilling, DateOfGiven=@DateOfGiven, " +
                                                "IsGiven=@IsGiven WHERE WorkBookID=@WorkBookID ", conn);
                cmd.Parameters.AddWithValue("@WorkerID", id);
                cmd.Parameters.AddWithValue("@SeriesNumber", SeriesNumberTextBox.Text.Trim());
                //якщо дату не обрано
                cmd.Parameters.AddWithValue("@DateOfFilling", (object) DateOfFillingDatePicker.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfGiven", (object) DateOfGivenDatePicker.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsGiven", IsGivenCheckBox.IsChecked);
                cmd.Parameters.AddWithValue("@WorkBookID", workerBookID);

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
                PositionsWindow positions = new PositionsWindow();
                positions.FillDataGrid();
                positions.PositionsGridView.UpdateLayout();

            }
        }
        //Приховати вікно
        private void AddEditWorkBookWindow_Closing(object sender, CancelEventArgs e)
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
            _clearElements.DefaultDatePicker(this);
            _clearElements.UncheckCheckBox(this);
            _clearElements.ClearTextBoxes(this);
            AddButton.Visibility = Visibility.Hidden;
            ChangeButton.Visibility = Visibility.Hidden;
            FiaComboBox.IsEnabled = true;
        }
    }
}
