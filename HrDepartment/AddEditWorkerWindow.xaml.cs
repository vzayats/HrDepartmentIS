using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for AddEditWorkerWindow.xaml
    /// </summary>
    public partial class AddEditWorkerWindow : Window
    {
        //Конфігурація з'єднання з базою даних
        string _connection =
            ConfigurationManager.ConnectionStrings["Personnel_departmentConnectionString"].ConnectionString;

        //ID табельного номера працівника
        public int WorkerId;

        //Табельний номер нового працівника (для додавання)
        public int NewWorkerId;

        //ID працівника нового (для label та educationID)
        public int NewWorkerIDcreated;

        //Назва файлу з OpenDialog
        public string FileName;

        //ID Підрозділу та посади (для редагування)
        public int? DepartmentId;
        public int? PositionId;

        //ID запису про післядипломну освіту
        public int? PostGraduateId = null;

        //ID члена сім'ї працівника
        public int? FamilyMemberId1 = null;
        public int? FamilyMemberId2 = null;
        public int? FamilyMemberId3 = null;
        public int? FamilyMemberId4 = null;
        private readonly ClearAllElements _clearAllElements;

        public AddEditWorkerWindow()
        {
            InitializeComponent();
            BindComboBox(PositonComboBox);
            DepartmentsBindComboBox(DepartmentComboBox);
            _clearAllElements = new ClearAllElements(this);
        }

        //Очищення полів вводу
        public ClearAllElements ClearAllElements1
        {
            get { return _clearAllElements; }
        }

        //Вибираємо назви посад (Binding) у ComboBox
        public void BindComboBox(ComboBox comboBoxName)
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про посади
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT PositionID, Position FROM Position ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Position");

                //заповнюємо Combobox
                comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["Position"].ToString();
                comboBoxName.Text = ds.Tables[0].Columns["Position"].ToString();
                comboBoxName.SelectedValuePath = ds.Tables[0].Columns["PositionID"].ToString();
            }
        }

        //Вибираємо назви підрозділів (Binding) у ComboBox
        public void DepartmentsBindComboBox(ComboBox comboBoxName)
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про підрозділи
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT DepartmentID, DepartmentName FROM Department ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DepartmentName");

                //заповнюємо Combobox
                comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["DepartmentName"].ToString();
                comboBoxName.Text = ds.Tables[0].Columns["DepartmentName"].ToString();
                comboBoxName.SelectedValuePath = ds.Tables[0].Columns["DepartmentID"].ToString();
            }
        }

        //Заповнення даних про працівника
        public void FillWorkerInfo()
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про працівників (ПІБ та ID)
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT wk.ID as ID, wk.Surname AS Surname, wk.Name AS Name, " +
                                       " wk.MiddleName AS MiddleName, " +
                                       "wk.BirthDate AS BirthDate, wk.Gender AS Gender, wk.FamilyStatus AS FamilyStatus, " +
                                       "wk.PositionID AS PositionID, wk.DepartmentID AS DepartmentID, " +
                                       "pas.TaxID as TaxID, pas.Passport as Passport, pas.PassportIssueDate as PassportIssueDate, " +
                                       "pas.Citizenship as Citizenship, pas.Insurance AS Insurance, pas.ForeignPassport AS ForeignPassport, " +
                                       "pas.ForeignExpiry AS ForeignExpiry, " +
                                       "adr.ZipCode AS ZipCode, adr.Region AS Region, adr.Town AS Town, adr.Street AS Street, " +
                                       "adr.House AS House, adr.Birthplace AS Birthplace, adr.HomePhone AS HomePhone, " +
                                       "adr.MobileNumber AS MobileNumber, adr.WorkPhone AS WorkPhone, adr.Email AS Email, " +
                                       "edu.Institution AS Institution, edu.GraduationYear AS GraduationYear, edu.Profession AS Profession, " +
                                       "edu.EducationForm AS EducationForm, " +
                                       "con.HiringDate AS HiringDate, con.DismissDate AS DismissDate , con.Probation AS Probation " +
                                       "FROM Workers wk " +
                                       "INNER JOIN PassportData pas on wk.ID = pas.ID " +
                                       "INNER JOIN Addresses adr on wk.ID = adr.ID " +
                                       "INNER JOIN Education edu on wk.EducationID = edu.EducationID " +
                                       "INNER JOIN Contract con on wk.ID=con.ID  " +
                                       "WHERE wk.ID = @WorkerID ", conn);
                da.SelectCommand.Parameters.AddWithValue("@WorkerID", WorkerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Загальні дані
                    IdTextBlock.Text = dt.Rows[0]["ID"].ToString();
                    SurnameTextBox.Text = dt.Rows[0]["Surname"].ToString();
                    NameTextBox.Text = dt.Rows[0]["Name"].ToString();
                    MiddleNameTextBox.Text = dt.Rows[0]["MiddleName"].ToString();
                    GenderComboBox.Text = (string) dt.Rows[0]["Gender"];
                    DateOfBirth.SelectedValue = dt.Rows[0]["BirthDate"] as DateTime?;
                    FamilyStatusComboBox.Text = dt.Rows[0]["FamilyStatus"].ToString();
                    PositonComboBox.SelectedValue = dt.Rows[0]["PositionID"].ToString();
                    DepartmentComboBox.SelectedValue = dt.Rows[0]["DepartmentID"].ToString();
                    DepartmentId = (int) dt.Rows[0]["DepartmentID"];
                    PositionId = (int) dt.Rows[0]["PositionID"];
                }
                if (dt.Rows.Count > 0)
                {
                    //Дані про контракт працівника
                    HiringDate.SelectedValue = dt.Rows[0]["HiringDate"] as DateTime?;
                    DismissDate.SelectedValue = dt.Rows[0]["DismissDate"] as DateTime?;
                    Probation.SelectedValue = dt.Rows[0]["Probation"] as DateTime?;
                }
                if (dt.Rows.Count > 0)
                {
                    //Паспортні дані
                    PassportTextInput.Value = dt.Rows[0]["Passport"].ToString();
                    PassportIssueDate.SelectedValue = dt.Rows[0]["PassportIssueDate"] as DateTime?;
                    CitizenshipTextBox.Text = dt.Rows[0]["Citizenship"].ToString();
                    TaxIdTextInput.Value = dt.Rows[0]["TaxID"].ToString();
                    InsuranceTextInput.Value = dt.Rows[0]["Insurance"].ToString();
                    ForeignPassportTextInput.Value = dt.Rows[0]["ForeignPassport"].ToString();
                    ForeignExpiry.SelectedValue = dt.Rows[0]["ForeignExpiry"] as DateTime?;
                }
                if (dt.Rows.Count > 0)
                {
                    //Адресні дані
                    ZipCodeTextInput.Value = dt.Rows[0]["ZipCode"].ToString();
                    RegionTextBox.Text = dt.Rows[0]["Region"].ToString();
                    TownTextBox.Text = dt.Rows[0]["Town"].ToString();
                    StreetTextBox.Text = dt.Rows[0]["Street"].ToString();
                    HouseTextBox.Text = dt.Rows[0]["House"].ToString();
                    BirthplaceTextBox.Text = dt.Rows[0]["Birthplace"].ToString();
                    HomePhoneTextInput.Value = dt.Rows[0]["HomePhone"].ToString();
                    MobileNumberTextInput.Value = dt.Rows[0]["MobileNumber"].ToString();
                    WorkPhoneTextInput.Value = dt.Rows[0]["WorkPhone"].ToString();
                    EmailTextBox.Text = dt.Rows[0]["Email"].ToString();
                }
                if (dt.Rows.Count > 0)
                {
                    //Інформація про освіту працівника
                    InstitutionTextBox.Text = dt.Rows[0]["Institution"].ToString();
                    ProfessionTextBox.Text = dt.Rows[0]["Profession"].ToString();
                    EducationFormComboBox.Text = dt.Rows[0]["EducationForm"].ToString();
                    GraduationYearTextInput.Value = dt.Rows[0]["GraduationYear"].ToString();
                }
            }
        }

        //Післядипломна освіта
        public void FillPostGraduate()
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про працівників (ПІБ та ID)
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT   pg.PostGraduateID AS PostGraduateID, pg.EducationForm as EducationForm, pg.PostGraduateInstitution as Institution, pg.GraduationYear as GraduationYear , " +
                        "pg.Profession as Profession  " +
                        "FROM Workers wk join Education Ed on wk.EducationID=Ed.EducationID " +
                        "join PostGraduate pg on Ed.PostGraduateID=pg.PostGraduateID " +
                        "WHERE wk.ID = @WorkerID ", conn);
                da.SelectCommand.Parameters.AddWithValue("@WorkerID", WorkerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Інформація про 2 вищу освіту працівника
                    PostGraduateId = (int)dt.Rows[0]["PostGraduateID"];
                    if (PostGraduateInstitutionTextBox != null)
                        PostGraduateInstitutionTextBox.Text = dt.Rows[0]["Institution"].ToString();
                    if (ProfessionPostTextBox != null) ProfessionPostTextBox.Text = dt.Rows[0]["Profession"].ToString();
                    if (EducationFormPostComboBox != null)
                        EducationFormPostComboBox.Text = dt.Rows[0]["EducationForm"].ToString();
                        GraduationYearPostTextInput.Value = dt.Rows[0]["GraduationYear"].ToString();
                }
            }
        }

        //Військовий облік працівників
        public void FillMilitary()
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про військовий облік працівників
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT  WorkerID AS WorkerID, AccountingGroup AS AccountingGroup, MilitaryStructure AS MilitaryStructure, " +
                        "NumberSpecialties AS NumberSpecialties, MilitaryRank AS MilitaryRank, Suitability AS Suitability, " +
                        "Ismobilized AS Ismobilized, DateOfMobilization AS DateOfMobilization, NameOfMilitary AS NameOfMilitary, " +
                        "reservations AS reservations FROM [dbo].[Military] WHERE WorkerID = @WorkerID ", conn);
                da.SelectCommand.Parameters.AddWithValue("@WorkerID", WorkerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AccountingGroupComboBox.Text = dt.Rows[0]["AccountingGroup"].ToString();
                    MilitaryStructureComboBox.Text = dt.Rows[0]["MilitaryStructure"].ToString();
                    NumberSpecialtiesTextInput.Value = dt.Rows[0]["NumberSpecialties"].ToString();
                    MilitaryRankTextBox.Text = dt.Rows[0]["MilitaryRank"].ToString();
                    SuitabilityTextBox.Text = dt.Rows[0]["Suitability"].ToString();
                    Ismobilized.IsChecked = (bool?) dt.Rows[0]["Ismobilized"];
                    DateOfMobilization.SelectedValue = dt.Rows[0]["DateOfMobilization"] as DateTime?;
                    NameOfMilitaryTextBox.Text = dt.Rows[0]["NameOfMilitary"].ToString();
                    ReservationsTextBox.Text = dt.Rows[0]["reservations"].ToString();
                }
            }
        }

        //Заповнення полів про членів сім'ї
        public void FillFamily()
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //вибираємо дані про членів сім'ї
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT fam.MemberID AS MemberID, fam.Relation AS Relation, fam.Surname AS famSurname, " +
                                       "fam.Name AS famName, fam.MiddleName AS famMiddleName, " +
                                       "fam.BirthDate AS famBirthDate, fam.Gender AS famGender " +
                                       "FROM Workers wk INNER JOIN Family fam on wk.ID = fam.WorkerID " +
                                       "WHERE wk.ID = @WorkerID", conn);
                da.SelectCommand.Parameters.AddWithValue("@WorkerID", value: WorkerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Члени сім'ї працівника
                if (dt.Rows.Count > 0 && 1 < dt.Rows.Count)
                {
                    FamilyMemberId1 = (int)dt.Rows[0]["MemberID"];
                    FamSurnameTextBox.Text = dt.Rows[0]["famSurname"].ToString();
                    FamNameTextBox.Text = dt.Rows[0]["famName"].ToString();
                    FamMiddleNameTextBox.Text = dt.Rows[0]["famMiddleName"].ToString();
                    FamBirthDate.SelectedValue = dt.Rows[0]["famBirthDate"] as DateTime?;
                    FamGenderComboBox.Text = dt.Rows[0]["famGender"].ToString();
                    RelationTextBox.Text = dt.Rows[0]["Relation"].ToString();
                }
                if (dt.Rows.Count > 1)
                {
                    FamilyMemberId2 = (int)dt.Rows[0]["MemberID"];
                    FamSurnameTextBox2.Text = dt.Rows[1]["famSurname"].ToString();
                    FamNameTextBox2.Text = dt.Rows[1]["famName"].ToString();
                    FamMiddleNameTextBox2.Text = dt.Rows[1]["famMiddleName"].ToString();
                    FamBirthDate2.SelectedValue = dt.Rows[1]["famBirthDate"] as DateTime?;
                    FamGenderComboBox2.Text = dt.Rows[1]["famGender"].ToString();
                    RelationTextBox2.Text = dt.Rows[1]["Relation"].ToString();
                }
                if (dt.Rows.Count > 2)
                {
                    FamilyMemberId3 = (int)dt.Rows[0]["MemberID"];
                    FamSurnameTextBox3.Text = dt.Rows[2]["famSurname"].ToString();
                    FamNameTextBox3.Text = dt.Rows[2]["famName"].ToString();
                    FamMiddleNameTextBox3.Text = dt.Rows[2]["famMiddleName"].ToString();
                    FamBirthDate3.SelectedValue = dt.Rows[2]["famBirthDate"] as DateTime?;
                    FamGenderComboBox3.Text = dt.Rows[2]["famGender"].ToString();
                    RelationTextBox3.Text = dt.Rows[2]["Relation"].ToString();
                }
                if (dt.Rows.Count > 3)
                {
                    FamilyMemberId4 = (int)dt.Rows[0]["MemberID"];
                    FamSurnameTextBox4.Text = dt.Rows[3]["famSurname"].ToString();
                    FamNameTextBox4.Text = dt.Rows[3]["famName"].ToString();
                    FamMiddleNameTextBox4.Text = dt.Rows[3]["famMiddleName"].ToString();
                    FamBirthDate4.SelectedValue = dt.Rows[3]["famBirthDate"] as DateTime?;
                    FamGenderComboBox4.Text = dt.Rows[3]["famGender"].ToString();
                    RelationTextBox4.Text = dt.Rows[3]["Relation"].ToString();
                }
            }
        }

        //Приховати вікно
        private void AddEditWorkerWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            //приховання форми
            Hide();
            AddWorkerButton.Visibility = Visibility.Hidden;
            EditWorkerButton.Visibility = Visibility.Hidden;
            //Очищення форми при закритті
            ClearAllElements1.ClearElements();
            FileName = null;
            Image.Source = null;
        }

        //Додати зображення працівника
        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter =
                    "Файли зображень (*.jpg;*.jpeg;*.png;*.bmp;*.tiff)|*.jpg;*.jpeg;*.png;*.bmp;*.tiff|Всі файли(*.*)|*.*",
                FilterIndex = 0,
                Title = "Обрати файл",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == true)
            {
                FileName = open.FileName;
            }
            if (!String.IsNullOrWhiteSpace(FileName))
            {
                using (SqlConnection conn = new SqlConnection {ConnectionString = _connection})
                {
                    //відкриття з'єднання
                    conn.Open();

                    //додаємо файл зображення
                    SqlCommand command =
                        new SqlCommand(@"IF NOT EXISTS (SELECT WorkerID FROM dbo.Images WHERE WorkerID=@WorkerID) " +
                                       "INSERT INTO Images VALUES (@WorkerID, @ImageName, @Data) ", conn);

                    //параметри додавання
                    command.Parameters.AddWithValue("@WorkerID", WorkerId);
                    command.Parameters.Add("@ImageName", SqlDbType.NVarChar, 150);
                    command.Parameters.Add("@Data", SqlDbType.VarBinary, Int32.MaxValue);

                    //шлях до файлу для завантаження
                    string file = FileName;

                    //отримуємо ім'я файлу з шляху для запису в БД
                    string shortFileName = file.Substring(file.LastIndexOf('\\') + 1);

                    //масив для збереження бінарних даних файлу
                    byte[] bytes;
                    using (System.IO.FileStream fs = new System.IO.FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        bytes = new byte[fs.Length];
                        fs.Read(bytes, 0, bytes.Length);
                    }
                    //передача даних в команду через параметри
                    command.Parameters["@ImageName"].Value = shortFileName;
                    command.Parameters["@Data"].Value = bytes;
                    //виконання Sql-запиту
                    int a = command.ExecuteNonQuery();

                    //Закриття з'єднання
                    conn.Close();

                    //якщо успішно додано
                    if (a > 0)
                    {
                        MessageBox.Show("Зображення працівника успішно додано", "Повідомлення",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                    }
                    //якщо файл не додано
                    else
                    {
                        MessageBox.Show(
                            "Зображення даного даного працівника вже існує! Щоб змінити, видаліть існуюче зображення.",
                            "Повідомлення", MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
                    //Заповнити новим зображенням
                    FillImage();
                }
            }
        }

        //Видалити зображення працівника
        private void DeleteImageButton_Click(object sender, RoutedEventArgs e)
        {
            //Підтвердження видалення запису
            MessageBoxResult result = MessageBox.Show("Ви дійсно бажаєте видалити зображення?", "Попередження",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            //якщо користувач підтвердив - видалити фото
            if (result == MessageBoxResult.Yes)
            {
                //Створення Sql-з'єднання
                using (SqlConnection conn = new SqlConnection(_connection))
                {
                    try
                    {
                        //Відкриваємо з'єднання
                        conn.Open();

                        //запит видалення фото
                        SqlCommand cmd = new SqlCommand("DELETE FROM Images WHERE WorkerID=@WorkerID ", conn);
                        cmd.Parameters.AddWithValue("@WorkerID", WorkerId);

                        //виконання запиту
                        int a = cmd.ExecuteNonQuery();

                        //закриваємо з'єднання
                        conn.Close();

                        //якщо зображення успішно видалено
                        if (a == 1)
                        {
                            MessageBox.Show("Зображення успішно видалено!", "Повідомлення", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                        //Очистити зображення
                        Image.Source = null;
                    }
                        //в разі помилки - вивести повідомлення
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //Відобразити зображення працівника
        public void FillImage()
        {
            //Створення Sql-з'єднання
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                //Відкриваємо з'єднання
                conn.Open();

                //Виірка зображень працівника
                SqlDataAdapter da =
                    new SqlDataAdapter("SELECT WorkerID, ImageName, Data FROM Images " +
                                       "where WorkerID = @WorkerID ", conn);
                da.SelectCommand.Parameters.AddWithValue("@WorkerID", WorkerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Взяти зображення з потоку
                    byte[] img = (byte[]) dt.Rows[0][2];
                    MemoryStream ms = new MemoryStream(img);
                    var imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.StreamSource = ms;
                    imageSource.EndInit();

                    //Зображення у вікні
                    Image.Source = imageSource;
                }
            }
        }

        //Табельний номер нового працівника (для додавання)
        public void GetNewWorkerId()
        {
            SqlConnection conn = new SqlConnection {ConnectionString = _connection};
            //Відкриваємо з'єднання
            conn.Open();

            //Виведемо ID працівника (максимальний)
            SqlCommand query =
                new SqlCommand("SELECT MAX ( ID ) FROM Workers",
                    conn);
            //Виконання запиту
            NewWorkerId = (int) query.ExecuteScalar();

            //Новий ID для форми створення
            NewWorkerIDcreated = NewWorkerId + 1;
            IdTextBlock.Text = NewWorkerIDcreated.ToString();
        }

        //Додати працівника
        private void AddWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            GetNewWorkerId();
            //Обрати стать працівника з ComboBox
            var selectedTag = ((ComboBoxItem) GenderComboBox.SelectedItem).Tag.ToString();
            char genderWorker = Convert.ToChar(selectedTag);

            //Додати відомості про працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Worker workerTable = new Worker();
                workerTable.Surname = SurnameTextBox.Text.Trim();
                workerTable.Name = NameTextBox.Text.Trim();
                workerTable.MiddleName = MiddleNameTextBox.Text;
                if (DateOfBirth.SelectedValue != null) workerTable.BirthDate = (DateTime) DateOfBirth.SelectedValue;
                workerTable.Gender = genderWorker;
                workerTable.EducationID = NewWorkerId + 1;
                workerTable.FamilyStatus = FamilyStatusComboBox.Text;
                workerTable.DepartmentID = DepartmentComboBox.SelectedValue as int?;
                workerTable.PositionID = PositonComboBox.SelectedValue as int?;
                db.Workers.InsertOnSubmit(workerTable);
                db.SubmitChanges();
            }

            //Дізнатися новий ID працівника (тільки створеного)
            GetNewWorkerId();

            //Додати дані про контракт
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Contract contractTable = new Contract();
                contractTable.ID = NewWorkerId;
                contractTable.HiringDate = HiringDate.SelectedValue;
                contractTable.DismissDate = DismissDate.SelectedValue;
                contractTable.Probation = Probation.SelectedValue;
                db.Contracts.InsertOnSubmit(contractTable);
                db.SubmitChanges();
            }

            //Додати адресні дані працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Address addressTable = new Address();
                addressTable.ID = NewWorkerId;
                if (ZipCodeTextInput.Value != null)
                {
                    addressTable.ZipCode = int.Parse(ZipCodeTextInput.Value.Trim());
                }
                addressTable.Region = RegionTextBox.Text.Trim();
                addressTable.Town = TownTextBox.Text.Trim();
                addressTable.Street = StreetTextBox.Text.Trim();
                addressTable.House = HouseTextBox.Text.Trim();
                addressTable.Birthplace = BirthplaceTextBox.Text.Trim();
                if (HomePhoneTextInput.Value != null)
                {
                    addressTable.HomePhone = HomePhoneTextInput.Value.Trim();
                }
                if (MobileNumberTextInput.Value != null)
                {
                    addressTable.MobileNumber = MobileNumberTextInput.Value.Trim();
                }
                if (WorkPhoneTextInput.Value != null)
                {
                    addressTable.WorkPhone = WorkPhoneTextInput.Value.Trim();
                }
                addressTable.Email = EmailTextBox.Text.Trim();
                db.Addresses.InsertOnSubmit(addressTable);
                db.SubmitChanges();
            }

            //Додати паспортні дані працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                PassportData passportTable = new PassportData();
                passportTable.ID = NewWorkerId;
                if (TaxIdTextInput.Value != null)
                {
                    passportTable.TaxID = TaxIdTextInput.Value.Trim();
                }
                passportTable.Passport = PassportTextInput.Value.Trim();
                if (PassportIssueDate.SelectedValue != null)
                {
                    passportTable.PassportIssueDate = (DateTime) PassportIssueDate.SelectedValue;
                }
                passportTable.Citizenship = CitizenshipTextBox.Text.Trim();
                if (InsuranceTextInput.Value != null)
                {
                    passportTable.Insurance = InsuranceTextInput.Value.Trim();
                }
                if (ForeignPassportTextInput.Value != null)
                {
                    passportTable.ForeignPassport = ForeignPassportTextInput.Value.Trim();
                }
                passportTable.ForeignExpiry = ForeignExpiry.SelectedValue;
                db.PassportDatas.InsertOnSubmit(passportTable);
                db.SubmitChanges();
            }

            //Додати дані про освіту працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Education educationTable = new Education();
                educationTable.EducationID = NewWorkerId;
                educationTable.Institution = InstitutionTextBox.Text.Trim();
                if (GraduationYearTextInput.Value != null)
                {
                    educationTable.GraduationYear = int.Parse(GraduationYearTextInput.Value.Trim());
                }
                educationTable.Profession = ProfessionTextBox.Text.Trim();
                educationTable.EducationForm = EducationFormComboBox.Text.Trim();
                db.Educations.InsertOnSubmit(educationTable);
                db.SubmitChanges();
            }

            //Додати відомості про військовий облік працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Military militaryTable = new Military();
                militaryTable.WorkerID = NewWorkerId;
                militaryTable.AccountingGroup = AccountingGroupComboBox.Text.Trim();
                militaryTable.MilitaryStructure = MilitaryStructureComboBox.Text.Trim();
                if (NumberSpecialtiesTextInput.Value != null)
                {
                    militaryTable.NumberSpecialties = int.Parse(NumberSpecialtiesTextInput.Value.Trim());
                }
                militaryTable.MilitaryRank = MilitaryRankTextBox.Text.Trim();
                militaryTable.Suitability = SuitabilityTextBox.Text.Trim();
                militaryTable.Ismobilized = Ismobilized.IsChecked;
                if (DateOfMobilization.SelectedValue != null)
                {
                    militaryTable.DateOfMobilization = (DateTime) DateOfMobilization.SelectedValue;
                }
                militaryTable.NameOfMilitary = NameOfMilitaryTextBox.Text.Trim();
                militaryTable.reservations = ReservationsTextBox.Text.Trim();
                db.Militaries.InsertOnSubmit(militaryTable);
                db.SubmitChanges();
            }

            //Додати дані про післядипломну освіту працівника
            if (PostGraduateInstitutionTextBox.Text.Trim() != "" && ProfessionPostTextBox.Text.Trim() != "")
            {
                //Внести зміни в дані про освіту працівника
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Education objEducation = db.Educations.Single(education => education.EducationID == NewWorkerId);
                    objEducation.PostGraduateID = NewWorkerId;
                    db.SubmitChanges();
                }
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    PostGraduate postGraduateTable = new PostGraduate();
                    postGraduateTable.PostGraduateID = NewWorkerId;
                    postGraduateTable.PostGraduateInstitution = PostGraduateInstitutionTextBox.Text.Trim();
                    if (GraduationYearPostTextInput.Value != null)
                    {
                        postGraduateTable.GraduationYear = int.Parse(GraduationYearPostTextInput.Value.Trim());
                    }
                    postGraduateTable.Profession = ProfessionPostTextBox.Text.Trim();
                    postGraduateTable.EducationForm = EducationFormPostComboBox.Text.Trim();
                    db.PostGraduates.InsertOnSubmit(postGraduateTable);
                    db.SubmitChanges();
                }
            }

            //Додати новий запис даних про сім'ю працівника
            //інформація про першого члена сім'ї
            if (FamSurnameTextBox.Text.Trim() != "" && FamNameTextBox.Text.Trim() != "")
            {
                //Обрати стать члена сім'ї з ComboBox
                string selectedTag2 = ((ComboBoxItem) FamGenderComboBox.SelectedItem).Tag.ToString();
                char? genderFamily = Char.Parse(selectedTag2);

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family familyTable = new Family();
                    familyTable.WorkerID = NewWorkerId;
                    familyTable.Relation = RelationTextBox.Text.Trim();
                    familyTable.Surname = FamSurnameTextBox.Text.Trim();
                    familyTable.Name = FamNameTextBox.Text.Trim();
                    familyTable.MiddleName = FamMiddleNameTextBox.Text.Trim();
                    if (FamBirthDate.SelectedValue != null)
                        familyTable.BirthDate = (DateTime) FamBirthDate.SelectedValue;
                    familyTable.Gender = genderFamily;
                    db.Families.InsertOnSubmit(familyTable);
                    db.SubmitChanges();
                }
            }

            //інформація про другого члена сім'ї
            if (FamSurnameTextBox2.Text.Trim() != "" && FamNameTextBox2.Text.Trim() != "")
            {
                //Обрати стать члена сім'ї з ComboBox
                string selectedTag3 = ((ComboBoxItem) FamGenderComboBox2.SelectedItem).Tag.ToString();
                char? genderFamily2 = Char.Parse(selectedTag3);

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family familyTable = new Family();
                    familyTable.WorkerID = NewWorkerId;
                    familyTable.Relation = RelationTextBox2.Text.Trim();
                    familyTable.Surname = FamSurnameTextBox2.Text.Trim();
                    familyTable.Name = FamNameTextBox2.Text.Trim();
                    familyTable.MiddleName = FamMiddleNameTextBox2.Text.Trim();
                    if (FamBirthDate2.SelectedValue != null)
                        familyTable.BirthDate = (DateTime) FamBirthDate2.SelectedValue;

                    familyTable.Gender = genderFamily2;
                    db.Families.InsertOnSubmit(familyTable);
                    db.SubmitChanges();
                }
            }

            //інформація про третього члена сім'ї
            if (FamSurnameTextBox3.Text.Trim() != "" && FamNameTextBox3.Text.Trim() != "")
            {
                //Обрати стать члена сім'ї з ComboBox
                string selectedTag4 = ((ComboBoxItem) FamGenderComboBox3.SelectedItem).Tag.ToString();
                char? genderFamily3 = Char.Parse(selectedTag4);

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family familyTable = new Family();
                    familyTable.WorkerID = NewWorkerId;
                    familyTable.Relation = RelationTextBox3.Text.Trim();
                    familyTable.Surname = FamSurnameTextBox3.Text.Trim();
                    familyTable.Name = FamNameTextBox3.Text.Trim();
                    familyTable.MiddleName = FamMiddleNameTextBox3.Text.Trim();
                    if (FamBirthDate3.SelectedValue != null)
                        familyTable.BirthDate = (DateTime) FamBirthDate3.SelectedValue;
                    familyTable.Gender = genderFamily3;
                    db.Families.InsertOnSubmit(familyTable);
                    db.SubmitChanges();
                }
            }

            //інформація про четвертого члена сім'ї
            if (FamSurnameTextBox4.Text.Trim() != "" && FamNameTextBox4.Text.Trim() != "")
            {
                //Обрати стать члена сім'ї з ComboBox
                string selectedTag5 = ((ComboBoxItem) FamGenderComboBox4.SelectedItem).Tag.ToString();
                char? genderFamily4 = Char.Parse(selectedTag5);

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family familyTable = new Family();
                    familyTable.WorkerID = NewWorkerId;
                    familyTable.Relation = RelationTextBox4.Text.Trim();
                    familyTable.Surname = FamSurnameTextBox4.Text.Trim();
                    familyTable.Name = FamNameTextBox4.Text.Trim();
                    familyTable.MiddleName = FamMiddleNameTextBox4.Text.Trim();
                    familyTable.BirthDate = (DateTime) FamBirthDate4.SelectedValue;
                    familyTable.Gender = genderFamily4;
                    db.Families.InsertOnSubmit(familyTable);
                    db.SubmitChanges();
                }
            }
            //Якщо дані успішно додано
            MessageBox.Show("Відомості про нового працівника успішно внесено!", "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
            //Закриваємо форму
            Close();
        }

        //Внести зміни у відомості про працівника
        private void EditWorkerButton_OnClick(object sender, RoutedEventArgs e)
        {
            //Обрати стать працівника з ComboBox
            var selectedTag = ((ComboBoxItem) GenderComboBox.SelectedItem).Tag.ToString();
            char genderWorker = Convert.ToChar(selectedTag);

            //Внести зміни у відомості про працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Worker objWorker = db.Workers.Single(worker => worker.ID == WorkerId);
                objWorker.Surname = SurnameTextBox.Text.Trim();
                objWorker.Name = NameTextBox.Text.Trim();
                objWorker.MiddleName = MiddleNameTextBox.Text;
                if (DateOfBirth.SelectedValue != null) objWorker.BirthDate = (DateTime) DateOfBirth.SelectedValue;
                if (DateOfBirth.SelectedValue == null)
                {
                    objWorker.BirthDate = null;
                }
                objWorker.Gender = genderWorker;
                objWorker.FamilyStatus = FamilyStatusComboBox.Text;
                db.SubmitChanges();
                }

              //Внести зміни у відомості про контракт працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                Contract objContract = db.Contracts.Single(contract => contract.ID == WorkerId);
                objContract.HiringDate = HiringDate.SelectedValue;
                objContract.DismissDate = DismissDate.SelectedValue;
                objContract.Probation = Probation.SelectedValue;
                db.SubmitChanges();
                }

            //Внести зміни в адресні дані працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Address objAddress = db.Addresses.Single(address => address.ID == WorkerId);
                if (ZipCodeTextInput.Value != "")
                {
                    objAddress.ZipCode = int.Parse(ZipCodeTextInput.Text.Trim());
                }
                if (ZipCodeTextInput.Value == "")
                {
                    objAddress.ZipCode = null;
                }
                objAddress.Region = RegionTextBox.Text.Trim();
                objAddress.Town = TownTextBox.Text.Trim();
                objAddress.Street = StreetTextBox.Text.Trim();
                objAddress.House = HouseTextBox.Text.Trim();
                objAddress.Birthplace = BirthplaceTextBox.Text.Trim();
                if (HomePhoneTextInput.Value != null)
                {
                    objAddress.HomePhone = HomePhoneTextInput.Value.Trim();
                }
                if (MobileNumberTextInput.Value != null)
                {
                    objAddress.MobileNumber = MobileNumberTextInput.Value.Trim();
                }
                if (WorkPhoneTextInput.Value != null)
                {
                    objAddress.WorkPhone = WorkPhoneTextInput.Value.Trim();
                }
                objAddress.Email = EmailTextBox.Text.Trim();
                db.SubmitChanges();
            }

            //Внести зміни в паспортні дані працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                PassportData objPassport = db.PassportDatas.Single(passport => passport.ID == WorkerId);
                if (TaxIdTextInput.Value != null)
                {
                    objPassport.TaxID = TaxIdTextInput.Value.Trim();
                }
                objPassport.Passport = PassportTextInput.Value.Trim();
                if (PassportIssueDate.SelectedValue != null)
                {
                    objPassport.PassportIssueDate = (DateTime) PassportIssueDate.SelectedValue;
                }
                objPassport.Citizenship = CitizenshipTextBox.Text.Trim();
                if (InsuranceTextInput.Value != null)
                {
                    objPassport.Insurance = InsuranceTextInput.Value.Trim();
                }
                if (ForeignPassportTextInput.Value != null)
                {
                    objPassport.ForeignPassport = ForeignPassportTextInput.Value.Trim();
                }
                objPassport.ForeignExpiry = ForeignExpiry.SelectedValue;
                db.SubmitChanges();
            }

            //Внести зміни в дані про освіту працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Education objEducation = db.Educations.Single(education => education.EducationID == WorkerId);
                objEducation.Institution = InstitutionTextBox.Text.Trim();
                if (GraduationYearTextInput.Value != "")
                {
                    objEducation.GraduationYear = int.Parse(GraduationYearTextInput.Value.Trim());
                }
                if (GraduationYearTextInput.Value == "")
                {
                    objEducation.GraduationYear = null;
                }
                objEducation.Profession = ProfessionTextBox.Text.Trim();
                objEducation.EducationForm = EducationFormComboBox.Text.Trim();
                db.SubmitChanges();
            }

            //Внести зміни в дані про післядипломну освіту працівника 
            if (PostGraduateId != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    PostGraduate objPostGraduate = db.PostGraduates.Single(postGraduate => postGraduate.PostGraduateID == PostGraduateId);
                    objPostGraduate.PostGraduateInstitution = PostGraduateInstitutionTextBox.Text.Trim();
                    if (GraduationYearPostTextInput.Value != "")
                    {
                        objPostGraduate.GraduationYear = int.Parse(GraduationYearPostTextInput.Value.Trim());
                    }
                    if (GraduationYearPostTextInput.Value == "")
                    {
                        objPostGraduate.GraduationYear = null;
                    }
                    objPostGraduate.Profession = ProfessionPostTextBox.Text.Trim();
                    objPostGraduate.EducationForm = EducationFormPostComboBox.Text.Trim();
                    db.SubmitChanges();
                }
            }
            //Якщо запису немає - додати новий
            if (PostGraduateId == null & PostGraduateInstitutionTextBox.Text.Trim() != "" && ProfessionPostTextBox.Text.Trim() != "")
            {
                //Внести зміни в дані про освіту працівника
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Education objEducation = db.Educations.Single(education => education.EducationID == WorkerId);
                    objEducation.PostGraduateID = NewWorkerId;
                    db.SubmitChanges();
                }
                //Додати новий запис про післядипломну освіту працівника 
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    PostGraduate postGraduateTable = new PostGraduate();
                    postGraduateTable.PostGraduateID = WorkerId;
                    postGraduateTable.PostGraduateInstitution = PostGraduateInstitutionTextBox.Text.Trim();
                    if (GraduationYearPostTextInput.Value != null)
                    {
                        postGraduateTable.GraduationYear = int.Parse(GraduationYearPostTextInput.Value.Trim());
                    }
                    postGraduateTable.Profession = ProfessionPostTextBox.Text.Trim();
                    postGraduateTable.EducationForm = EducationFormPostComboBox.Text.Trim();
                    db.PostGraduates.InsertOnSubmit(postGraduateTable);
                    db.SubmitChanges();
                }
            }

            //Внести зміни у відомості про військовий облік працівника
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Military objMilitary = db.Militaries.Single(military => military.WorkerID == WorkerId);
                objMilitary.AccountingGroup = AccountingGroupComboBox.Text.Trim();
                objMilitary.MilitaryStructure = MilitaryStructureComboBox.Text.Trim();
                if (NumberSpecialtiesTextInput.Value != "")
                {
                    objMilitary.NumberSpecialties = int.Parse(NumberSpecialtiesTextInput.Text.Trim());
                }
                if (NumberSpecialtiesTextInput.Value == "")
                {
                    objMilitary.NumberSpecialties = null;
                }
                objMilitary.MilitaryRank = MilitaryRankTextBox.Text.Trim();
                objMilitary.Suitability = SuitabilityTextBox.Text.Trim();
                objMilitary.Ismobilized = Ismobilized.IsChecked;
                if (DateOfMobilization.SelectedValue != null)
                {
                    objMilitary.DateOfMobilization = (DateTime)DateOfMobilization.SelectedValue;
                }
                if (DateOfMobilization.SelectedValue == null)
                {
                    objMilitary.DateOfMobilization = null;
                }
                objMilitary.NameOfMilitary = NameOfMilitaryTextBox.Text.Trim();
                objMilitary.reservations = ReservationsTextBox.Text.Trim();
                db.SubmitChanges();
            }

            //Внести зміни в інформацію про членів сім'ї працівника
            //Внести зміни в інформацію про першого члена сім'ї
            if (FamilyMemberId1 != null)
            {
                //Обрати стать члена сім'ї з ComboBox
                var selectedTag2 = ((ComboBoxItem)FamGenderComboBox.SelectedItem).Tag.ToString();
                char genderFamily = Convert.ToChar(selectedTag2.ToString());
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {

                    Family objFamily =
                        db.Families.Single(
                            family => family.WorkerID == WorkerId && family.MemberID == FamilyMemberId1);

                    objFamily.Relation = RelationTextBox.Text.Trim();
                    objFamily.Surname = FamSurnameTextBox.Text.Trim();
                    objFamily.Name = FamNameTextBox.Text.Trim();
                    objFamily.MiddleName = FamMiddleNameTextBox.Text.Trim();
                    if (FamBirthDate.SelectedValue != null)
                    {
                        objFamily.BirthDate = (DateTime) FamBirthDate.SelectedValue;
                    }
                    if (FamBirthDate.SelectedValue == null)
                    {
                        objFamily.BirthDate = null;
                    }
                    objFamily.Gender = genderFamily;
                    db.SubmitChanges();
                }
            }

            //Внести зміни в інформацію про другого члена сім'ї
            if (FamilyMemberId2 != null)
            {
                //Обрати стать члена сім'ї з ComboBox
                var selectedTag3 = ((ComboBoxItem)FamGenderComboBox2.SelectedItem).Tag.ToString();
                char genderFamily2 = Convert.ToChar(selectedTag3.ToString());

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family objFamily =
                        db.Families.Single(
                            family => family.WorkerID == WorkerId && family.MemberID == FamilyMemberId2);

                    objFamily.Relation = RelationTextBox2.Text.Trim();
                    objFamily.Surname = FamSurnameTextBox2.Text.Trim();
                    objFamily.Name = FamNameTextBox2.Text.Trim();
                    objFamily.MiddleName = FamMiddleNameTextBox2.Text.Trim();
                    if (FamBirthDate2.SelectedValue != null)
                    {
                        objFamily.BirthDate = (DateTime) FamBirthDate2.SelectedValue;
                    }
                    if (FamBirthDate2.SelectedValue == null)
                    {
                        objFamily.BirthDate = null;
                    }
                    objFamily.Gender = genderFamily2;
                    db.SubmitChanges();
                }
            }

            //Внести зміни в інформацію про третього члена сім'ї
            if (FamilyMemberId3 != null)
            {
                //Обрати стать члена сім'ї з ComboBox
                var selectedTag4 = ((ComboBoxItem)FamGenderComboBox3.SelectedItem).Tag.ToString();
                char genderFamily3 = Convert.ToChar(selectedTag4.ToString());

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family objFamily =
                        db.Families.Single(
                            family => family.WorkerID == WorkerId && family.MemberID == FamilyMemberId3);

                    objFamily.Relation = RelationTextBox3.Text.Trim();
                    objFamily.Surname = FamSurnameTextBox3.Text.Trim();
                    objFamily.Name = FamNameTextBox3.Text.Trim();
                    objFamily.MiddleName = FamMiddleNameTextBox3.Text.Trim();
                    if (FamBirthDate3.SelectedValue != null)
                    {
                        objFamily.BirthDate = (DateTime) FamBirthDate3.SelectedValue;
                    }
                    if (FamBirthDate3.SelectedValue == null)
                    {
                        objFamily.BirthDate = null;
                    }
                    objFamily.Gender = genderFamily3;
                    db.SubmitChanges();
                }
            }

            //Внести зміни в інформацію про четвертого члена сім'ї
            if (FamilyMemberId4 != null)
            {
                //Обрати стать члена сім'ї з ComboBox
                var selectedTag5 = ((ComboBoxItem)FamGenderComboBox4.SelectedItem).Tag.ToString();
                char genderFamily4 = Convert.ToChar(selectedTag5.ToString());

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    Family objFamily =
                        db.Families.Single(
                            family => family.WorkerID == WorkerId && family.MemberID == FamilyMemberId4);

                    objFamily.Relation = RelationTextBox4.Text.Trim();
                    objFamily.Surname = FamSurnameTextBox4.Text.Trim();
                    objFamily.Name = FamNameTextBox4.Text.Trim();
                    objFamily.MiddleName = FamMiddleNameTextBox4.Text.Trim();
                    if (FamBirthDate4.SelectedValue != null)
                    {
                        objFamily.BirthDate = (DateTime) FamBirthDate4.SelectedValue;
                    }
                    if (FamBirthDate4.SelectedValue == null)
                    {
                        objFamily.BirthDate = null;
                    }
                    objFamily.Gender = genderFamily4;
                    db.SubmitChanges();
                }
            }
            //Якщо відомості успішно змінено
            MessageBox.Show("Відомості про працівника успішно змінено!", "Повідомлення", MessageBoxButton.OK,
                        MessageBoxImage.Information);
            //Закриваємо форму
            Close();
        }
    }
}



