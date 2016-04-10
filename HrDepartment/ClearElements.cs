using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Telerik.Windows.Controls;

namespace HrDepartment
{
    public class ClearElements
    {
        //����� ���� ������� �� �������� �������� 
        //�� ������ ���� �� ��������
        public ClearElements()
        {
        }

        //�������� ��� TextBoxes �� ����
        public void ClearTextBoxes(DependencyObject obj)
        {
            TextBox tb = obj as TextBox;
            if (tb != null)
                tb.Text = String.Empty;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearTextBoxes(VisualTreeHelper.GetChild(obj, i));
        }
        //�������� ���������� ������ �� �������������
        public void DefaultValueComboBoxes(DependencyObject obj)
        {
            ComboBox comboBox = obj as ComboBox;
            if (comboBox != null)
                comboBox.SelectedIndex = 0;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                DefaultValueComboBoxes(VisualTreeHelper.GetChild(obj, i));
        }

        //�������� ������� �������� datePicker
        public void DefaultDatePicker(DependencyObject obj)
        {
            RadDatePicker datePicker = obj as RadDatePicker;
            if (datePicker != null)
                datePicker.SelectedValue = null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                DefaultDatePicker(VisualTreeHelper.GetChild(obj, i));
        }
        //CheckBox� �� �������������
        public void UncheckCheckBox(DependencyObject obj)
        {
            CheckBox checkBox = obj as CheckBox;
            if (checkBox != null)
                checkBox.IsChecked = false;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                UncheckCheckBox(VisualTreeHelper.GetChild(obj, i));
        }
        //�������� ���� ����� ������
        public void ClearPasswordBox(DependencyObject obj)
        {
            PasswordBox password = obj as PasswordBox;
            if (password != null)
                password.Password = String.Empty;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearPasswordBox(VisualTreeHelper.GetChild(obj, i));
        }
        //�������� RichTextBox
        public void ClearRichTextBox(DependencyObject obj)
        {
            RichTextBox richText = obj as RichTextBox;
            if (richText != null)
                richText.Document.Blocks.Clear(); 

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearRichTextBox(VisualTreeHelper.GetChild(obj, i));
        }
        //�������� RadNumericUpDown
        public void ClearRadNumericUpDown(DependencyObject obj)
        {
            RadNumericUpDown numericUpDown = obj as RadNumericUpDown;
            if (numericUpDown != null)
                numericUpDown.Value = null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearRadNumericUpDown(VisualTreeHelper.GetChild(obj, i));
        }

        //�������� ������������� ���� �����
        public void ClearRadMaskedTextInput(DependencyObject obj)
        {
            RadMaskedTextInput maskedTextInput = obj as RadMaskedTextInput;
            if (maskedTextInput != null)
                maskedTextInput.Value = null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
                ClearRadMaskedTextInput(VisualTreeHelper.GetChild(obj, i));
        }
    }
}