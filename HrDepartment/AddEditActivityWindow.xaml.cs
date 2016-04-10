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
    /// Interaction logic for AddEditActivityWindow.xaml
    /// </summary>
    public partial class AddEditActivityWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string connectionString =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        //ID запису про діяльність працівника
        public int ActivityID;

        private readonly ClearElements _clearElements;
        public AddEditActivityWindow()
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
                    new SqlDataAdapter("SELECT wk.ID as WorkerID, wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName AS Fia " +
                        "FROM Workers wk " +
                        " INNER JOIN Contract con on wk.ID = con.ID " +
                        "where con.DismissDate is null ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Workers");

                //заповнюємо Combobox
                comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["Fia"].ToString();
                comboBoxName.SelectedValuePath = ds.Tables[0].Columns["WorkerID"].ToString();
            }
        }


        //Додати дані про діяльність працівника ща місяць
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не заповнив усі NumericUpDown - вивести попередження
            if (PresentNumericUpDown.Value.ToString().Trim() == ""
                && HospitalNumericUpDown.Value.ToString().Trim() == "" 
                && VacationNumericUpDown.Value.ToString().Trim() == "" 
                && AbsenceNumericUpDown.Value.ToString().Trim() == "")
            {
                MessageBox.Show("Будь-ласка, заповніть принаймні одне значення!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            //якщо користувач заповнив принаймні одне значення - додати дані про діяльність в базу даних
            else
            {
                //якщо користувач не ввів хоча б одне значення в NumericUpDown - записати у базу даних як 0
                if (PresentNumericUpDown.Value.ToString().Trim() == "")
                {
                    PresentNumericUpDown.Value = 0;
                }
                if (HospitalNumericUpDown.Value.ToString().Trim() == "")
                {
                    HospitalNumericUpDown.Value = 0;
                }
                if (VacationNumericUpDown.Value.ToString().Trim() == "")
                {
                    VacationNumericUpDown.Value = 0;
                }
                if (AbsenceNumericUpDown.Value.ToString().Trim() == "")
                {
                    AbsenceNumericUpDown.Value = 0;
                }

                //Обрати значення ID працівника з ComboBox
                var id = FiaComboBox.SelectedValue.ToString();

                //Обрати назву місяця 
                ComboBoxItem comboItem = (ComboBoxItem)MonthComboBox.SelectedItem;
                string monthName = comboItem.Content.ToString();

                //Визначаємо номер місяця із значення Tag (object) MonthComboBox 
                var selectedTag = ((ComboBoxItem)MonthComboBox.SelectedItem).Tag.ToString();
                var monthNumber = selectedTag.ToString();

                //Створення Sql-з'єднання
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Відкриваємо з'єднання
                    conn.Open();

                    //Запит для внесення даних про діяльність працівника за місяць
                    SqlCommand cmd = new SqlCommand("INSERT INTO Activity (WorkerID,  Present, Hospital, Vacation, " +
                                                    "Absence, CalendarMonth, CalendarMonthName, CalendarYear) " +
                                                    " VALUES(@WorkerID, @Present, @Hospital, @Vacation, " +
                                                    "@Absence, @CalendarMonth, @CalendarMonthName, @CalendarYear) ", conn);
                    //Параметри запиту
                    cmd.Parameters.AddWithValue("@WorkerID", id);

                    //якщо пусте значення - заповнити NULL
                    cmd.Parameters.AddWithValue("@Present", (object)PresentNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Hospital", (object)HospitalNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Vacation", (object)VacationNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Absence", (object)AbsenceNumericUpDown.Value ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@CalendarMonth", Int16.Parse(monthNumber));
                    cmd.Parameters.AddWithValue("@CalendarMonthName", monthName);
                    cmd.Parameters.AddWithValue("@CalendarYear", YearNumericUpDown.Value);

                    //виконання запиту
                    int a = cmd.ExecuteNonQuery();

                    //закриваємо з'єднання
                    conn.Close();

                    //якщо дані успішно додано
                    if (a == 1)
                    {
                        MessageBox.Show("Дані про діяльність працівника за " + monthName.ToString().ToLowerInvariant() + " успішно внесено!",
                            "Повідомлення",
                            MessageBoxButton.OK, MessageBoxImage.Information);
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
        }
        //Внести зміни у відомості про діяльність
        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            //якщо користувач не заповнив усі NumericUpDown - вивести попередження
            if (PresentNumericUpDown.Value.ToString().Trim() == "" &&
                HospitalNumericUpDown.Value.ToString().Trim() == "" &&
                VacationNumericUpDown.Value.ToString().Trim() == "" &&
                AbsenceNumericUpDown.Value.ToString().Trim() == "")
            {
                MessageBox.Show("Будь-ласка, заповніть принаймні одне значення!", "Повідомлення", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
                //якщо ввів - оновити дані
            else
            {
                //якщо користувач не ввів хоча б одне значення в NumericUpDown - записати у базу даних як 0
                if (PresentNumericUpDown.Value.ToString().Trim() == "")
                {
                    PresentNumericUpDown.Value = 0;
                }
                if (HospitalNumericUpDown.Value.ToString().Trim() == "")
                {
                    HospitalNumericUpDown.Value = 0;
                }
                if (VacationNumericUpDown.Value.ToString().Trim() == "")
                {
                    VacationNumericUpDown.Value = 0;
                }
                if (AbsenceNumericUpDown.Value.ToString().Trim() == "")
                {
                    AbsenceNumericUpDown.Value = 0;
                }

                //Обрати значення ID працівника з ComboBox
                var id = FiaComboBox.SelectedValue.ToString();

                //Обрати назву місяця 
                ComboBoxItem comboItem = (ComboBoxItem)MonthComboBox.SelectedItem;
                string monthName = comboItem.Content.ToString();

                //Визначаємо номер місяця із значення Tag (object) MonthComboBox 
                var selectedTag = ((ComboBoxItem)MonthComboBox.SelectedItem).Tag.ToString();
                var monthNumber = selectedTag.ToString();

                //Створення Sql-з'єднання
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Відкриваємо з'єднання
                    conn.Open();

                    //внесемо зміни в запис про діяльність працівника
                    SqlCommand cmd = new SqlCommand("UPDATE Activity SET WorkerID=@WorkerID, " +
                                                    "Present=@Present, Hospital=@Hospital, Vacation=@Vacation, " +
                                                    "Absence=@Absence, CalendarMonth=@CalendarMonth, CalendarMonthName=@CalendarMonthName, " +
                                                    " CalendarYear=@CalendarYear " +
                                                    "WHERE ActivityID=@ActivityID ", conn);

                    //Параметри запиту
                    cmd.Parameters.AddWithValue("@WorkerID", id);

                    //якщо пусте значення - заповнити NULL
                    cmd.Parameters.AddWithValue("@Present", (object)PresentNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Hospital", (object)HospitalNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Vacation", (object)VacationNumericUpDown.Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Absence", (object)AbsenceNumericUpDown.Value ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@CalendarMonth", Int16.Parse(monthNumber));
                    cmd.Parameters.AddWithValue("@CalendarMonthName", monthName);
                    cmd.Parameters.AddWithValue("@CalendarYear", YearNumericUpDown.Value);
                    cmd.Parameters.AddWithValue("@ActivityID", ActivityID);

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
                    this.Hide();
                    Clear();

                    //оновлюємо GridView
                    ActivityWindow activityWindow = new ActivityWindow();
                    activityWindow.FillDataGrid();
                    activityWindow.ActivityGridView.UpdateLayout();
                }
            }
            
        }
        //Приховати вікно
        private void AddEditActivityWindow_Closing(object sender, CancelEventArgs e)
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
            MonthComboBox.SelectedIndex = 0;
            _clearElements.ClearRadNumericUpDown(this);
            AddButton.Visibility = Visibility.Hidden;
            ChangeButton.Visibility = Visibility.Hidden;
            FiaComboBox.IsEnabled = true;
            YearNumericUpDown.Value = 2016;
        }
    }
}
