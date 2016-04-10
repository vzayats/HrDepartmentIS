using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //відкриття інструкції користувача
        public DelegateCommand OpenHelpPageCommand { get; set; }

        //Конфігурація з'єднання з базою даних
        string connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();

            //Запуск форми входу
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();

            //Перевірка подій під час запуску програми
            BirthdayButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            TermButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)); 

              //при натисканні кнопки в RibbonView - відкрити інструкцію користувача
              OpenHelpPageCommand = new DelegateCommand(ExecuteCommandHandler);
              this.DataContext = OpenHelpPageCommand;

              //При натисканні F1 - викликати довідку
              this.KeyPreview = true;
              this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        //Відкрити вікно для резервного копіювання
        BackupWindow backup = new BackupWindow();

        private void BackupButton_Click(object sender, RoutedEventArgs e)
        {
            backup.ShowDialog();
        }

        //Відкрити вікно відновлення резервних копій
        RestoreWindow restore = new RestoreWindow();
        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            restore.ShowDialog();
        }

        //Відкрити вікно надсилання відгуку
        FeedbackWindow feedback = new FeedbackWindow();
        private void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            feedback.ShowDialog();
        }

        //Відкрити вікно надсилання повідомлення про помилку
        BugReportWindow bugReport = new BugReportWindow();
        private void BugReportButton_Click(object sender, RoutedEventArgs e)
        {
            bugReport.Show();
        }

        //Перевірка чи сьогодні в когось з працівників День народження
        private void BirthdayButton_Click(object sender, RoutedEventArgs e)
        {
            BirthDayCheck();
        }

        //Перевірка події - День народження працівника
        private void BirthDayCheck()
        {
            SqlConnection conn = new SqlConnection {ConnectionString = connection};
            //Відкриваємо з'єднання
            conn.Open();

            //виведення працівника, в якого День народження
            SqlCommand query =
                new SqlCommand("SELECT Surname + ' ' + Name + ' ' + MiddleName FROM Workers WHERE DATEPART" +
                               "(d, BirthDate) = DATEPART(d, GETDATE()) AND DATEPART(m, BirthDate) = DATEPART(m, GETDATE())",
                    conn);
            //Виконання запиту
            object result = query.ExecuteScalar();

            //обичслення віку працівника
            SqlCommand queryAge = new SqlCommand("SELECT DATEDIFF(YY, [BirthDate], GETDATE()) AS [AGE] FROM Workers",
                conn);
            //Виконання запиту
            object age = queryAge.ExecuteScalar();

            //якщо сьогодні немає іменин у працівників
            if (query.ExecuteScalar() == null)
            {
                //Показ повідомлення
                var nonbirthdayAlert = new RadDesktopAlert();
                nonbirthdayAlert.Header = "Повідомлення";
                nonbirthdayAlert.Content = "Днів народжень у працівників сьогодні немає.";
                nonbirthdayAlert.ShowDuration = 10000;

                RadDesktopAlertManager manager2 = new RadDesktopAlertManager();
                manager2.ShowAlert(nonbirthdayAlert);
            }
            //якщо у працівника є день народження
            else if (query.ExecuteScalar() != null && queryAge.ExecuteScalar() != null)
            {
                //Показ повідомлення
                var birthdayAlert = new RadDesktopAlert();
                birthdayAlert.Header = "День народження!";
                birthdayAlert.Content = "Працівник " + result + " сьогодні святкує свій День народження!" + " (" + age +
                                        " років)";
                birthdayAlert.ShowDuration = 10000;

                RadDesktopAlertManager manager = new RadDesktopAlertManager();
                manager.ShowAlert(birthdayAlert);
            }
        }

        //Перегляд довідника нормативних документів
        LawWindow law = new LawWindow();

        private void LawButton_Click(object sender, RoutedEventArgs e)
        {
            law.Show();
        }

        //Налаштування користувацьких записів
        EditLoginsWindow editLogins = new EditLoginsWindow();

        private void EditLoginButton_Click(object sender, RoutedEventArgs e)
        {
            editLogins.ShowDialog();
        }

        //перевірка чи цього тижня (найближчих 7 днів) в когось закінчується випробувальний термін
        private void TermButton_Click(object sender, RoutedEventArgs e)
        {
            TermCheck();
        }

        //Перевірка події - закінчення випр. терміну
        private void TermCheck()
        {
            SqlConnection conn = new SqlConnection {ConnectionString = connection};
            //Відкриваємо з'єднання
            conn.Open();
            //запит, який виводить працівників, в яких завершується випробовувальний термін
            SqlCommand queryProbationExpiry =
                new SqlCommand(
                    "SELECT ' (' + CONVERT(VARCHAR(10),con.Probation) + ') в працівника '+ wk.Surname + ' ' + wk.Name + ' ' + wk.MiddleName " +
                    "FROM  Workers wk join Contract con on con.ID=wk.ID " +
                    "WHERE DATEPART( Week, DATEADD( Year, DATEPART( Year, GETDATE()) - " +
                    "DATEPART( Year, con.Probation), con.Probation))= DATEPART( Week, GETDATE());", conn);

            //Виконання запиту
            object resultExpiry = queryProbationExpiry.ExecuteScalar();

            //якщо цього тижня в жодного з працівників не закінчується випробовувальний термін
            if (queryProbationExpiry.ExecuteScalar() == null)
            {
                //Показ повідомлення
                var nonbirthdayAlert = new RadDesktopAlert();
                nonbirthdayAlert.Header = "Повідомлення";
                nonbirthdayAlert.Content =
                    "Протягом цього тижня випробовувальний термін не закінчується в жодного з працівників";
                nonbirthdayAlert.ShowDuration = 10000;

                RadDesktopAlertManager manager2 = new RadDesktopAlertManager();
                manager2.ShowAlert(nonbirthdayAlert);
            }
            //якщо у працівника найближчим часом завершується випробовувальний термін
            else if (queryProbationExpiry.ExecuteScalar() != null)
            {
                //Показ повідомлення
                var birthdayAlert = new RadDesktopAlert();
                birthdayAlert.Header = "Завершення випробовувального терміну!";
                birthdayAlert.Content = "Протягом цього тижня " + resultExpiry +
                                        " завершується випробовувальний термін!";
                birthdayAlert.ShowDuration = 10000;

                RadDesktopAlertManager manager = new RadDesktopAlertManager();
                manager.ShowAlert(birthdayAlert);
            }
        }

        //відкриття вікна пошуку
        SearchWindow search = new SearchWindow();
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            search.ShowDialog();
        }

        //Перегляд кандидатів
        CvWindow cvWindow = new CvWindow();
        private void VacancyButton_Click(object sender, RoutedEventArgs e)
        {
            cvWindow.ShowDialog();
        }

        //Виробничий календар
        CalendarWindow calendar = new CalendarWindow();
        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
            calendar.ShowDialog();
        }

        //вивести у GridView - працівників
        private string CmdString =
            "SELECT wk.ID, wk.Surname, wk.Name, wk. MiddleName, dep.DepartmentName, " +
            "Pos.Position AS Position, wk.BirthDate as BirthDate, img.Data AS Data, Adr.WorkPhone as WorkPhone, Adr.MobileNumber as MobileNumber, " +
            "CONVERT(VARCHAR(10),Adr.ZipCode)   + ', ' + Adr.Region + ' обл., ' + Adr.Town + ', вул. ' + Adr.Street + ', ' + Adr. House as Address, " +
            "CASE WHEN con.DismissDate IS NULL THEN 'Працює' ELSE 'Звільнений'  END AS IsWork, con.HiringDate, wk.FamilyStatus, Adr.HomePhone, Adr.Email " +
            " FROM Workers wk " +
            "INNER JOIN Department dep on wk.DepartmentID=dep.DepartmentID INNER JOIN Position Pos " +
            "on wk.PositionID=Pos.PositionID INNER JOIN Addresses Adr on wk.ID=Adr.ID " +
            "INNER JOIN Contract con on wk.ID = con.ID " +
            "LEFT OUTER JOIN Images img on wk.ID=img.WorkerID ";

        private string whereConcatenator = " WHERE ";
        //заповнити GridView
        private void FillDataGrid()
        {
            string conString =
                ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Workers");
                sda.Fill(dt);
                RadGridView.ItemsSource = dt.DefaultView;
            }
        }

        //відкрити  вікно розширеного пошуку
        SearchWindow advancedSearch = new SearchWindow();
        private void AdvancedSearchButton_Click(object sender, RoutedEventArgs e)
        {
            advancedSearch.ShowDialog();
        }

        //пошук при введенні в textbox
        private void QuickTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //якщо у поле пошуку введено запит
            if (QuickTextBox.Text.Trim() != "")
            {
                this.CmdString += whereConcatenator;
                //знайти записи, які співпадають
                this.CmdString += " wk.Surname Like '" + QuickTextBox.Text.Trim() + "%' OR wk.Name Like '" +
                                  QuickTextBox.Text.Trim() + "%' ";
                // this.CmdString += " wk.Surname LIKE '" + QuickTextBox.Text.Trim() + "%' ";
                whereConcatenator = "AND ";
            }
            else
            {
                //якщо у поле запиту пусте - вивести усіх працівників
                this.CmdString = "SELECT wk.ID, wk.Surname, wk.Name, wk. MiddleName, dep.DepartmentName, " +
                                 "Pos.Position AS Position, wk.BirthDate as BirthDate, img.Data AS Data, Adr.WorkPhone as WorkPhone, Adr.MobileNumber as MobileNumber, " +
                                 "CONVERT(VARCHAR(10),Adr.ZipCode)   + ', ' + Adr.Region + ' обл., ' + Adr.Town + ', вул. ' + Adr.Street + ', ' + Adr. House as Address, " +
                                 "CASE WHEN con.DismissDate IS NULL THEN 'Працює' ELSE 'Звільнений'  END AS IsWork, con.HiringDate, wk.FamilyStatus, Adr.HomePhone, Adr.Email " +

                                 " FROM Workers wk " +
                                 "INNER JOIN Department dep on wk.DepartmentID=dep.DepartmentID INNER JOIN Position Pos " +
                                 "on wk.PositionID=Pos.PositionID INNER JOIN Addresses Adr on wk.ID=Adr.ID " +
                                 "INNER JOIN Contract con on wk.ID = con.ID " +
                                 "LEFT OUTER JOIN Images img on wk.ID=img.WorkerID  ";
            }
            FillDataGrid();
        }

        //сортування GridView за табельним номером (ID)
        private void OrderByRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //очищення критеріїв сортування
            this.RadGridView.SortDescriptors.Clear();
        }

        //сортування GridView за прізвищем працівника
        private void OrderByRadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            //очищення попередніх критеріїв сортування
            this.RadGridView.SortDescriptors.Clear();
            ColumnSortDescriptor csd = new ColumnSortDescriptor()
            {
                //сортуємо за стовпцем [Surname]
                Column = this.RadGridView.Columns["Surname"],
                //сортування за висхідним порядком
                SortDirection = ListSortDirection.Ascending
            };
            this.RadGridView.SortDescriptors.Add(csd);
        }

        //сортування GridView за підрозділом
        private void OrderByRadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            //очищення попередніх критеріїв сортування
            this.RadGridView.SortDescriptors.Clear();
            ColumnSortDescriptor csd = new ColumnSortDescriptor()
            {
                //сортуємо за стовпцем [DepartmentName]
                Column = this.RadGridView.Columns["DepartmentName"],
                //сортування за висхідним порядком
                SortDirection = ListSortDirection.Ascending
            };
            this.RadGridView.SortDescriptors.Add(csd);
        }

        //вивести всіх працюючих на даний час працівників в GridView
        private void WorkingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (WorkingCheckBox.IsChecked == true)
            {
                Telerik.Windows.Controls.GridViewColumn isworkColumn = this.RadGridView.Columns["IsWork"];
                IColumnFilterDescriptor workerFilter = isworkColumn.ColumnFilterDescriptor;

                // Призупинити фільтр GridView
                workerFilter.SuspendNotifications();

                // додати значенння фільтру в GridView 
                workerFilter.DistinctFilter.AddDistinctValue("Працює");
                workerFilter.FieldFilter.Filter1.IsCaseSensitive = true;
                //оновити фільтр GridView
                workerFilter.ResumeNotifications();
            }
        }

        //видалити значення фільтра з GridView - працюючі
        private void WorkingCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Telerik.Windows.Controls.GridViewColumn isworkColumn = this.RadGridView.Columns["IsWork"];
            IColumnFilterDescriptor workerFilter = isworkColumn.ColumnFilterDescriptor;

            // Призупинити фільтр GridView
            workerFilter.SuspendNotifications();

            // видалити з GridView фільтр
            workerFilter.DistinctFilter.RemoveDistinctValue("Працює");
            workerFilter.FieldFilter.Filter1.IsCaseSensitive = true;
            //оновити фільтр GridView
            workerFilter.ResumeNotifications();
        }

        //вивести всіх звільнених на даний час працівників в GridView
        private void NotWorkingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (NotWorkingCheckBox.IsChecked == true)
            {
                Telerik.Windows.Controls.GridViewColumn isworkColumn = this.RadGridView.Columns["IsWork"];
                IColumnFilterDescriptor workerFilter = isworkColumn.ColumnFilterDescriptor;

                // Призупинити фільтр GridView
                workerFilter.SuspendNotifications();

                // додати значенння фільтру в GridView 
                workerFilter.DistinctFilter.AddDistinctValue("Звільнений");
                workerFilter.FieldFilter.Filter1.IsCaseSensitive = true;
                //оновити фільтр GridView
                workerFilter.ResumeNotifications();
            }
        }

        //видалити значення фільтра з GridView - звільнені
        private void NotWorkingCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Telerik.Windows.Controls.GridViewColumn isworkColumn = this.RadGridView.Columns["IsWork"];
            IColumnFilterDescriptor workerFilter = isworkColumn.ColumnFilterDescriptor;

            // Призупинити фільтр GridView
            workerFilter.SuspendNotifications();

            // видалити з GridView фільтр
            workerFilter.DistinctFilter.RemoveDistinctValue("Звільнений");
            workerFilter.FieldFilter.Filter1.IsCaseSensitive = true;
            //оновити фільтр GridView
            workerFilter.ResumeNotifications();
        }

        //Відкрити вікно звітності
        ReportWindow report = new ReportWindow();

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            report.ShowDialog();
        }

        //відкрити вікно експорту в CSV
        CsvExportWindow csvExport = new CsvExportWindow();
        private void CsvExportButton_Click(object sender, RoutedEventArgs e)
        {
            csvExport.ShowDialog();
        }

        //відкрити вікно експорту в Excel
        ExcelExportWindow excelExport = new ExcelExportWindow();
        private void ExcelExportButton_Click(object sender, RoutedEventArgs e)
        {
            excelExport.ShowDialog();
        }

        //Відкрити вікно про програму
        AboutWindow about = new AboutWindow();

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            about.ShowDialog();
        }

        //відкрити вікно налаштування
        SettingsWindow settings = new SettingsWindow();
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            settings.ShowDialog();
        }

        //Відкрити вікно виводу статистики
        StatisticsWindow statistics = new StatisticsWindow();
        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            statistics.ShowDialog();
        }

        //Відкрити вікно посад
        PositionsWindow positions = new PositionsWindow();
        private void PositionsButton_OnClick(object sender, RoutedEventArgs e)
        {
            positions.ShowDialog();
        }

        //відкрити вікно графік відпусток
        VacationWindow vacation = new VacationWindow();
        private void VacationButton_Click(object sender, RoutedEventArgs e)
        {
            vacation.ShowDialog();
        }

        //відкрити вікно обліку трудових книжок
        WorkBooksWindow workBooks = new WorkBooksWindow();
        private void WorkBooksButton_OnClick(object sender, RoutedEventArgs e)
        {
            workBooks.ShowDialog();
        }

        //Відкрити вікно діяльності працівників
        ActivityWindow activityWindow = new ActivityWindow();
        private void ActivityButton_Click(object sender, RoutedEventArgs e)
        {
            activityWindow.ShowDialog();
        }

        //Штат організації (штатний розклад)
        StaffWindow staff = new StaffWindow();
        private void StuffButton_OnClick(object sender, RoutedEventArgs e)
        {
            staff.ShowDialog();
        }

        //Відкрити вікно підрозділи (відділи)
        DepartmentsWindow departments = new DepartmentsWindow();
        private void DepartmentsButton_OnClick(object sender, RoutedEventArgs e)
        {
            departments.ShowDialog();
        }

        //Завершення процесу при натисканні кнопки закриття (Window)
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        //Видалення працівника та його данних
        private void RemoveWorkerButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Вибрати ID працівника
            DataRowView rowview = RadGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                int workerId = Convert.ToInt16(rowview.Row.ItemArray[0]);

                //Підтвердження видалення запису
                MessageBoxResult result = MessageBox.Show("Ви впевнені, що бажаєте видалити всі дані працівника?",
                    "Попередження",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                //якщо користувач підтвердив - видалити дані
                if (result == MessageBoxResult.Yes)
                {

                    //Підтвердження видалення запису
                    MessageBoxResult question =
                        MessageBox.Show("Ви дійсно бажаєте остаточно видалити всі дані працівника? " +
                                        "Перед остаточним видаленням, рекомендується виконати резервне копіювання всіх даних!",
                            "Попередження",
                            MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (question == MessageBoxResult.Yes)
                    {

                        //Створення Sql-з'єднання
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            try
                            {
                                //Відкриваємо з'єднання
                                conn.Open();

                                //запит видалення всіх даних працівника
                                SqlCommand cmd = new SqlCommand("DELETE FROM PassportData WHERE ID=@WorkerID; " +
                                                                "DELETE FROM Addresses WHERE ID=@WorkerID; " +
                                                                "DELETE FROM Activity WHERE WorkerID=@WorkerID; " +
                                                                "DELETE FROM Contract WHERE ID=@WorkerID; " +
                                                                "DELETE FROM Education WHERE EducationID=@WorkerID; " +
                                                                "DELETE FROM Family WHERE WorkerID=@WorkerID; " +
                                                                "DELETE FROM Images WHERE WorkerID=@WorkerID; " +
                                                                "DELETE FROM PassportData WHERE ID=@WorkerID; " +
                                                                "DELETE FROM Vacations WHERE WorkerID=@WorkerID; " +
                                                                "DELETE FROM Military WHERE WorkerID=@WorkerID; " +
                                                                "DELETE FROM Workers WHERE ID=@WorkerID; ", conn);
                                cmd.Parameters.AddWithValue("@WorkerID", workerId);

                                //виконання запиту
                                int a = cmd.ExecuteNonQuery();

                                //закриваємо з'єднання
                                conn.Close();

                                //якщо дані успішно видалено
                                if (a > 0)
                                {
                                    MessageBox.Show(
                                        "Всі відомості про працівника успішно видалено з інформаційної системи!",
                                        "Повідомлення", MessageBoxButton.OK,
                                        MessageBoxImage.Information);
                                }
                            }
                                //в разі помилки - вивести повідомлення
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        //Відкрити вікно редагування працівника
        AddEditWorkerWindow addEditWorker = new AddEditWorkerWindow();
        private void EditWorkerButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEditWorker.Title = "Внести зміни у відомості про працівника";
            //Визначити ID працівника з вибраного запису
            DataRowView rowview = RadGridView.SelectedItem as DataRowView;
            if (rowview != null)
            {
                addEditWorker.WorkerId = Convert.ToInt16(rowview.Row.ItemArray[0]);
                //Заповнення полів даними
                addEditWorker.FillWorkerInfo();
                addEditWorker.FillPostGraduate();
                addEditWorker.FillFamily();
                addEditWorker.FillImage();
                addEditWorker.FillMilitary();
            }
            addEditWorker.EditWorkerButton.Visibility = Visibility.Visible;
             
            addEditWorker.ShowDialog();
        }

        //Додати новий запис про працівника
        private void AddWorkerButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Заговолок вікна
            addEditWorker.Title = "Додати відомості про нового працівника";
            //Очистити елементи вікна
            addEditWorker.ClearAllElements1.ClearElements();
            addEditWorker.GetNewWorkerId();
            //Показати кнопку додавання
            addEditWorker.AddWorkerButton.Visibility = Visibility.Visible;
            addEditWorker.ShowDialog();
        }

        //Відкрити інструкцію користувача
        private void HelpButton_OnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, @"Manual\UserManual.chm");
             
        }
        //Відкрити інструкцію користувача при натисканні кнопки в RibbonView
        private void ExecuteCommandHandler(object obj)
        {
            System.Windows.Forms.Help.ShowHelp(null, @"Manual\UserManual.chm");
        }

        //При натисканні F1 - викликати довідку
        public bool KeyPreview { get; set; }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "F1")
            {
                System.Windows.Forms.Help.ShowHelp(null, @"Manual\UserManual.chm");
            }
        }

        //Переглянути особову картку працівника - звітність
        PersonalCardWindow personalCard = new PersonalCardWindow();
        private void WorkerCardButton_OnClick(object sender, RoutedEventArgs e)
        {
            personalCard.ShowDialog();
        }

        //Переглянути статистику окремо по кожному працівнику
        StatisticsWorkerWindow statisticsWorker = new StatisticsWorkerWindow();
        private void StatisticsWorkerButton_OnClick(object sender, RoutedEventArgs e)
        {
            statisticsWorker.ShowDialog();
        }
    }
}

