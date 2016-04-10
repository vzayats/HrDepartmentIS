using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;

namespace HrDepartment
{
    /// <summary>
    /// Interaction logic for LawWindow.xaml
    /// </summary>
    public partial class LawWindow : Window
    {
        public LawWindow()
        {
            InitializeComponent();

            //відкрити документ при завантаженні
            ComboBox.SelectedIndex = 0;

        }

        private void Item1_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Кодекс законів про працю України (КЗпП).xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item2_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про оплату праці».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item3_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про відпустки».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item4_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про військовий обов’язок і військову службу».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item5_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про державну службу».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item6_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про загальнообов’язкове державне пенсійне.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item7_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про загальнообов’язкове державне соціальне.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item8_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про зайнятість населення».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item9_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про колективні договори і угоди».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item10_OnSelected(object sender, RoutedEventArgs e)
        {
          var tempXpsFile = @"Documents\Закон України «Про пенсійне забезпечення».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item11_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про професійний розвиток працівників».xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item12_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Наказ Міністерства фінансів України «Про затвердження.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item13_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Постанова Кабінету Міністрів України «Про затвердження Порядку.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item14_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України Про основи соціальної захищеності.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item15_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Закон України «Про державну допомогу сім’ям з дітьми» .xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }

        private void Item16_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Інструкція про порядок ведення трудових книжок працівників.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }
        private void Item17_OnSelected(object sender, RoutedEventArgs e)
        {
            var tempXpsFile = @"Documents\Класифікатор професій ДК 003 2010.xps";
            XpsDocument xps_doc = new XpsDocument(tempXpsFile, System.IO.FileAccess.Read);
            FixedDocumentSequence fseq = xps_doc.GetFixedDocumentSequence();
            DocumentViewer.Document = fseq;
            xps_doc.Close();
        }
        //Приховати вікно після закриття
        private void LawWindow_Closing(object sender, CancelEventArgs e)
        {
            //відміна закриття вікна 
            e.Cancel = true;
            //приховати форму
            this.Hide();
            ComboBox.SelectedIndex = 0;
        }

        
    }
}
