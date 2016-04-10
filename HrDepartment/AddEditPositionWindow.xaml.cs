using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for AddEditPositionWindow.xaml
    /// </summary>
    public partial class AddEditPositionWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString = ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        //ID посади
        public int positionID;

        private readonly ClearElements _clearElements;
        public AddEditPositionWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }
        //Внесення змін про посаду
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //змінюємо дані про посаду
                SqlCommand cmd = new SqlCommand("UPDATE Position SET PositionCode=@PositionCode, " +
                                                "Position=@Position, Salary=@Salary, Bonus=@Bonus WHERE PositionID=@PositionID", conn);
                cmd.Parameters.AddWithValue("@PositionCode", PositionCodeTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Position", PositionNameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Salary", int.Parse(SalaryTextInput.Value.Trim()));
                cmd.Parameters.AddWithValue("@Bonus", int.Parse(BonusTextInput.Value.Trim()));
                cmd.Parameters.AddWithValue("@PositionID", positionID);

                //виконання запиту
                int a = cmd.ExecuteNonQuery();

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
                this.Close();
                //оновлюємо GridView
                PositionsWindow positions = new PositionsWindow();
                positions.FillDataGrid();
                positions.PositionsGridView.UpdateLayout();

            }
        }
        //Додати дані про посаду
        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //Створення Sql-з'єднання

                //Відкриваємо з'єднання
                conn.Open();

                //Вносимо дані про нову посаду
                SqlCommand cmd = new SqlCommand("INSERT INTO Position (PositionCode, Position, Salary, Bonus) " +
                                                " VALUES (@PositionCode, @Position, @Salary, @Bonus ) ", conn);
                //Параметри запиту
                cmd.Parameters.AddWithValue("@PositionCode", PositionCodeTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Position", PositionNameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Salary", int.Parse(SalaryTextInput.Value.Trim()));
                cmd.Parameters.AddWithValue("@Bonus", int.Parse(BonusTextInput.Value.Trim()));

                //виконання запиту
                int a = cmd.ExecuteNonQuery();

                //закриваємо з'єднання
                conn.Close();

                //якщо дані успішно додано
                if (a == 1)
                {
                    MessageBox.Show("Дані про нову посаду успішно внесено!", "Повідомлення",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                //Закриваємо форму
                this.Close();
                //оновлюємо GridView
                PositionsWindow positions = new PositionsWindow();
                positions.FillDataGrid();
                positions.PositionsGridView.UpdateLayout();


            }
        }
        //Приховати вікно
        private void AddEditPositionWindow_Closing(object sender, CancelEventArgs e)
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
            _clearElements.ClearRadMaskedTextInput(this);
            AddButton.Visibility = Visibility.Hidden;
            EditButton.Visibility = Visibility.Hidden;
        }
    }
}
