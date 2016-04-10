using System;

namespace HrDepartment
{
    public class ClearAllElements
    {
        private AddEditWorkerWindow _addEditWorkerWindow;

        public ClearAllElements(AddEditWorkerWindow addEditWorkerWindow)
        {
            _addEditWorkerWindow = addEditWorkerWindow;
        }

        public void ClearElements()
        {
            //Загальні дані
            _addEditWorkerWindow.IdTextBlock.Text = String.Empty;
            _addEditWorkerWindow.SurnameTextBox.Text = String.Empty;
            _addEditWorkerWindow.NameTextBox.Text = String.Empty;
            _addEditWorkerWindow.MiddleNameTextBox.Text = String.Empty;
            _addEditWorkerWindow.GenderComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.DateOfBirth.SelectedValue = null;
            _addEditWorkerWindow.FamilyStatusComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.DepartmentComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.PositonComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.DepartmentId = null;
            _addEditWorkerWindow.PositionId = null;

            //Паспортні дані
            _addEditWorkerWindow.PassportTextInput.Value = String.Empty;
            _addEditWorkerWindow.PassportIssueDate.SelectedValue = null;
            _addEditWorkerWindow.CitizenshipTextBox.Text = String.Empty;
            _addEditWorkerWindow.TaxIdTextInput.Value = null;
            _addEditWorkerWindow.InsuranceTextInput.Value = null;
            _addEditWorkerWindow.ForeignPassportTextInput.Value = String.Empty;
            _addEditWorkerWindow.ForeignExpiry.SelectedValue = null;

            //Дані про контракт працівника
            _addEditWorkerWindow.HiringDate.SelectedValue = null;
            _addEditWorkerWindow.DismissDate.SelectedValue = null;
            _addEditWorkerWindow.Probation.SelectedValue = null;

            //Адресні дані
            _addEditWorkerWindow.ZipCodeTextInput.Value = null;
            _addEditWorkerWindow.RegionTextBox.Text = String.Empty;
            _addEditWorkerWindow.TownTextBox.Text = String.Empty;
            _addEditWorkerWindow.StreetTextBox.Text = String.Empty;
            _addEditWorkerWindow.HouseTextBox.Text = String.Empty;
            _addEditWorkerWindow.BirthplaceTextBox.Text = String.Empty;
            _addEditWorkerWindow.HomePhoneTextInput.Value = null;
            _addEditWorkerWindow.MobileNumberTextInput.Value = null;
            _addEditWorkerWindow.WorkPhoneTextInput.Value = null;
            _addEditWorkerWindow.EmailTextBox.Text = String.Empty;

            //Інформація про освіту працівника
            _addEditWorkerWindow.InstitutionTextBox.Text = String.Empty;
            _addEditWorkerWindow.ProfessionTextBox.Text = String.Empty;
            _addEditWorkerWindow.EducationFormComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.GraduationYearTextInput.Value = null;

            //Інформація про 2 вищу освіту працівника
            _addEditWorkerWindow.PostGraduateInstitutionTextBox.Text = String.Empty;
            _addEditWorkerWindow.ProfessionPostTextBox.Text = String.Empty;
            _addEditWorkerWindow.EducationFormPostComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.GraduationYearPostTextInput.Value = null;
            _addEditWorkerWindow.PostGraduateId = null;

            //Інформація про членів сім'ї працівника
            _addEditWorkerWindow.FamSurnameTextBox.Text = String.Empty;
            _addEditWorkerWindow.FamNameTextBox.Text = String.Empty;
            _addEditWorkerWindow.FamMiddleNameTextBox.Text = String.Empty;
            _addEditWorkerWindow.FamBirthDate.SelectedValue = null;
            _addEditWorkerWindow.FamGenderComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.RelationTextBox.Text = String.Empty;

            _addEditWorkerWindow.FamSurnameTextBox2.Text = String.Empty;
            _addEditWorkerWindow.FamNameTextBox2.Text = String.Empty;
            _addEditWorkerWindow.FamMiddleNameTextBox2.Text = String.Empty;
            _addEditWorkerWindow.FamBirthDate2.SelectedValue = null;
            _addEditWorkerWindow.FamGenderComboBox2.SelectedIndex = 0;
            _addEditWorkerWindow.RelationTextBox2.Text = String.Empty;

            _addEditWorkerWindow.FamSurnameTextBox3.Text = String.Empty;
            _addEditWorkerWindow.FamNameTextBox3.Text = String.Empty;
            _addEditWorkerWindow.FamMiddleNameTextBox3.Text = String.Empty;
            _addEditWorkerWindow.FamBirthDate3.SelectedValue = null;
            _addEditWorkerWindow.FamGenderComboBox3.SelectedIndex = 0;
            _addEditWorkerWindow.RelationTextBox3.Text = String.Empty;

            _addEditWorkerWindow.FamSurnameTextBox4.Text = String.Empty;
            _addEditWorkerWindow.FamNameTextBox4.Text = String.Empty;
            _addEditWorkerWindow.FamMiddleNameTextBox4.Text = String.Empty;
            _addEditWorkerWindow.FamBirthDate4.SelectedValue = null;
            _addEditWorkerWindow.FamGenderComboBox4.SelectedIndex = 0;
            _addEditWorkerWindow.RelationTextBox4.Text = String.Empty;

            _addEditWorkerWindow.AccountingGroupComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.MilitaryStructureComboBox.SelectedIndex = 0;
            _addEditWorkerWindow.NumberSpecialtiesTextInput.Value = null;
            _addEditWorkerWindow.MilitaryRankTextBox.Text = String.Empty;
            _addEditWorkerWindow.SuitabilityTextBox.Text = String.Empty;
            _addEditWorkerWindow.Ismobilized.IsChecked = false;
            _addEditWorkerWindow.DateOfMobilization.SelectedValue = null;
            _addEditWorkerWindow.NameOfMilitaryTextBox.Text = String.Empty;
            _addEditWorkerWindow.ReservationsTextBox.Text = String.Empty;

            _addEditWorkerWindow.FamilyMemberId1 = null;
            _addEditWorkerWindow.FamilyMemberId2 = null;
            _addEditWorkerWindow.FamilyMemberId3 = null;
            _addEditWorkerWindow.FamilyMemberId4 = null;
        }
    }
}