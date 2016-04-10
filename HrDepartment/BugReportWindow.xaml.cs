using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for BugReportWindow.xaml
    /// </summary>
    public partial class BugReportWindow : Window
    {
        private readonly ClearElements _clearElements;
        public BugReportWindow()
        {
            InitializeComponent();
            _clearElements = new ClearElements();
        }
        //Відкрити файл зображення 
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Зображення (*.JPG;*.BMP;*.GIF;*.PNG)|*.JPG;*.BMP;*.GIF;*.PNG|Всі файли (*.*)|*.*",
                FilterIndex = 0,
                Title = "Відкриття",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == true)
            {
                ImageFileTextBox.Text = open.FileName;
            }
        }
        //Надіслати 
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            //Текст з richTextBox
            TextRange mailText = new TextRange(ReportichTextBox.Document.ContentStart, ReportichTextBox.Document.ContentEnd);
            //Створення посилання mailto
            string mailTo = string.Format("mailto:{0}?Subject={1}&Body={2}&Attach={3}", "vzaiats@yahoo.com", "Повідомлення про помилку",
                "Ім'я користувача: " + NameTextBox.Text + ". " + " Опис помилки: " + Environment.NewLine + mailText.Text + ".", @ImageFileTextBox.Text);
            //Запуск стороннього поштового клієнта
            System.Diagnostics.Process.Start(mailTo);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Clear();
        }
        //Захопити зображення екрану
        Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private void ScreenshotButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            //Призупинити потік
            System.Threading.Thread.Sleep(500);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            Show();

            //Діалог збереження файлу
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.DefaultExt = ".Jpg";
            dialog.RestoreDirectory = true;
            dialog.Title = "Збереження";
            dialog.Filter = "Файли зображень (.jpg)|*.jpg";
            if (dialog.ShowDialog() == true)
            {
                bitmap.Save(dialog.FileName.ToString());
            }
        }
        //Приховати вікно при його закритті
        private void BugReportWindow_Closing(object sender, CancelEventArgs e)
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