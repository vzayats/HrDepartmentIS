namespace ReportLib
{
    partial class AllHirringByDeptReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllHirringByDeptReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.departmentNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.numberOfWorkersCaptionTextBox = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.numberOfWorkersSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.departmentNameDataTextBox = new Telerik.Reporting.TextBox();
            this.numberOfWorkersDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.8039584755897522D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.departmentNameCaptionTextBox,
            this.numberOfWorkersCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // departmentNameCaptionTextBox
            // 
            this.departmentNameCaptionTextBox.CanGrow = true;
            this.departmentNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameCaptionTextBox.Name = "departmentNameCaptionTextBox";
            this.departmentNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.9470829963684082D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameCaptionTextBox.StyleName = "Caption";
            this.departmentNameCaptionTextBox.Value = "����� ��������";
            // 
            // numberOfWorkersCaptionTextBox
            // 
            this.numberOfWorkersCaptionTextBox.CanGrow = true;
            this.numberOfWorkersCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0001997947692871D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersCaptionTextBox.Name = "numberOfWorkersCaptionTextBox";
            this.numberOfWorkersCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1468839645385742D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersCaptionTextBox.StyleName = "Caption";
            this.numberOfWorkersCaptionTextBox.Value = "�������� �� ����� ���";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = resources.GetString("PersonnelDataSource1.SelectCommand");
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3.652916431427002D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.numberOfWorkersSumFunctionTextBox,
            this.barcode1});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.9470829963684082D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "������ ����������:";
            // 
            // numberOfWorkersSumFunctionTextBox
            // 
            this.numberOfWorkersSumFunctionTextBox.CanGrow = true;
            this.numberOfWorkersSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0001997947692871D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersSumFunctionTextBox.Name = "numberOfWorkersSumFunctionTextBox";
            this.numberOfWorkersSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1468839645385742D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersSumFunctionTextBox.StyleName = "Data";
            this.numberOfWorkersSumFunctionTextBox.Value = "= Sum(Fields.NumberOfWorkers)";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.09416675567627D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "���";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437549591064453D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.2135419845581055D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.65291637182235718D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.barcode1.Stretch = true;
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.6856253147125244D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.200000762939453D), Telerik.Reporting.Drawing.Unit.Cm(1.6856251955032349D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "�������� �� ������ ���������� �� ���������(������ �� ����� ���)";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.departmentNameDataTextBox,
            this.numberOfWorkersDataTextBox});
            this.detail.Name = "detail";
            // 
            // departmentNameDataTextBox
            // 
            this.departmentNameDataTextBox.CanGrow = true;
            this.departmentNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameDataTextBox.Name = "departmentNameDataTextBox";
            this.departmentNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.9470829963684082D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameDataTextBox.StyleName = "Data";
            this.departmentNameDataTextBox.Value = "= Fields.DepartmentName";
            // 
            // numberOfWorkersDataTextBox
            // 
            this.numberOfWorkersDataTextBox.CanGrow = true;
            this.numberOfWorkersDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0001997947692871D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersDataTextBox.Name = "numberOfWorkersDataTextBox";
            this.numberOfWorkersDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1468839645385742D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersDataTextBox.StyleName = "Data";
            this.numberOfWorkersDataTextBox.Value = "= Fields.NumberOfWorkers";
            // 
            // AllHirringByDeptReport
            // 
            this.DataSource = this.PersonnelDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.reportFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "AllHirringByDeptReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(97)))), ((int)(((byte)(74)))));
            styleRule2.Style.Font.Name = "Georgia";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            styleRule3.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(168)))), ((int)(((byte)(212)))));
            styleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted;
            styleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            styleRule3.Style.Font.Name = "Georgia";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Font.Name = "Georgia";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Font.Name = "Georgia";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.200000762939453D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox departmentNameCaptionTextBox;
        private Telerik.Reporting.TextBox numberOfWorkersCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox numberOfWorkersSumFunctionTextBox;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox departmentNameDataTextBox;
        private Telerik.Reporting.TextBox numberOfWorkersDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}