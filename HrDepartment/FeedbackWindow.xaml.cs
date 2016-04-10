using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for FeedbackWindow.xaml
    /// </summary>
    public partial class FeedbackWindow : Window
    {
        private readonly ClearElements _clearElements;
        public FeedbackWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }
        //Надсилання відгуку
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            //Текст з richTextBox
            TextRange mailText = new TextRange(MailRichTextBox.Document.ContentStart, MailRichTextBox.Document.ContentEnd);
            //Створення посилання mailto
            string mailTo = string.Format("mailto:{0}?Subject={1}&Body={2}", "vzaiats@yahoo.com", "Відгук", "Ім'я користувача: " + NameTextBox.Text + ". " + " Текст відгуку: " + Environment.NewLine + mailText.Text);
            //Запуск стороннього поштового клієнта
            System.Diagnostics.Process.Start(mailTo);
        }
        //Закрити
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Clear();
        }
        //Приховати вікно при його закритті
        private void FeedbackWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна
            e.Cancel = true;
            // приховання форми
            this.Hide();
            Clear();
        }
        //Очищення елементів
        private void Clear()
        {
            _clearElements.ClearTextBoxes(this);
            _clearElements.ClearRichTextBox(this);
        }
    }
}