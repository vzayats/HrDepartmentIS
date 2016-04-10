namespace ReportLib
{
    partial class WorkBooksReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkBooksReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.workBookIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fiaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.seriesNumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateOfFillingCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateOfGivenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.isGivenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.fiaCountFunctionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.workBookIDDataTextBox = new Telerik.Reporting.TextBox();
            this.fiaDataTextBox = new Telerik.Reporting.TextBox();
            this.seriesNumberDataTextBox = new Telerik.Reporting.TextBox();
            this.dateOfFillingDataTextBox = new Telerik.Reporting.TextBox();
            this.dateOfGivenDataTextBox = new Telerik.Reporting.TextBox();
            this.isGivenDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.workBookIDCaptionTextBox,
            this.fiaCaptionTextBox,
            this.seriesNumberCaptionTextBox,
            this.dateOfFillingCaptionTextBox,
            this.dateOfGivenCaptionTextBox,
            this.isGivenCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // workBookIDCaptionTextBox
            // 
            this.workBookIDCaptionTextBox.CanGrow = true;
            this.workBookIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.workBookIDCaptionTextBox.Name = "workBookIDCaptionTextBox";
            this.workBookIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1470832824707031D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.workBookIDCaptionTextBox.StyleName = "Caption";
            this.workBookIDCaptionTextBox.Value = "№";
            // 
            // fiaCaptionTextBox
            // 
            this.fiaCaptionTextBox.CanGrow = true;
            this.fiaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2001993656158447D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCaptionTextBox.Name = "fiaCaptionTextBox";
            this.fiaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.1995997428894043D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaCaptionTextBox.StyleName = "Caption";
            this.fiaCaptionTextBox.Value = "ПІБ працівника";
            // 
            // seriesNumberCaptionTextBox
            // 
            this.seriesNumberCaptionTextBox.CanGrow = true;
            this.seriesNumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.seriesNumberCaptionTextBox.Name = "seriesNumberCaptionTextBox";
            this.seriesNumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9997990131378174D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.seriesNumberCaptionTextBox.StyleName = "Caption";
            this.seriesNumberCaptionTextBox.Value = "Серія та номер";
            // 
            // dateOfFillingCaptionTextBox
            // 
            this.dateOfFillingCaptionTextBox.CanGrow = true;
            this.dateOfFillingCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.399999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfFillingCaptionTextBox.Name = "dateOfFillingCaptionTextBox";
            this.dateOfFillingCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.999798059463501D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfFillingCaptionTextBox.StyleName = "Caption";
            this.dateOfFillingCaptionTextBox.Value = "Дата заповнення";
            // 
            // dateOfGivenCaptionTextBox
            // 
            this.dateOfGivenCaptionTextBox.CanGrow = true;
            this.dateOfGivenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.399998664855957D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfGivenCaptionTextBox.Name = "dateOfGivenCaptionTextBox";
            this.dateOfGivenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1998016834259033D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfGivenCaptionTextBox.StyleName = "Caption";
            this.dateOfGivenCaptionTextBox.Value = "Дата видачі";
            // 
            // isGivenCaptionTextBox
            // 
            this.isGivenCaptionTextBox.CanGrow = true;
            this.isGivenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.600000381469727D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.isGivenCaptionTextBox.Name = "isGivenCaptionTextBox";
            this.isGivenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1470835208892822D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.isGivenCaptionTextBox.StyleName = "Caption";
            this.isGivenCaptionTextBox.Value = "Чи видана";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = resources.GetString("PersonnelDataSource1.SelectCommand");
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3.6531171798706055D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.fiaCountFunctionTextBox,
            this.barcode1});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4470832347869873D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Всього:";
            // 
            // fiaCountFunctionTextBox
            // 
            this.fiaCountFunctionTextBox.CanGrow = true;
            this.fiaCountFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5002002716064453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCountFunctionTextBox.Name = "fiaCountFunctionTextBox";
            this.fiaCountFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8995985984802246D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaCountFunctionTextBox.StyleName = "Data";
            this.fiaCountFunctionTextBox.Value = "= Count(Fields.Fia)";
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.69416618347168D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Звіт";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.73646581172943115D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.813541412353516D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.65311700105667114D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.barcode1.Stretch = true;
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3910582065582275D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799999237060547D), Telerik.Reporting.Drawing.Unit.Cm(1.3909581899642944D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Список трудових книжок";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.workBookIDDataTextBox,
            this.fiaDataTextBox,
            this.seriesNumberDataTextBox,
            this.dateOfFillingDataTextBox,
            this.dateOfGivenDataTextBox,
            this.isGivenDataTextBox});
            this.detail.Name = "detail";
            // 
            // workBookIDDataTextBox
            // 
            this.workBookIDDataTextBox.CanGrow = true;
            this.workBookIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.workBookIDDataTextBox.Name = "workBookIDDataTextBox";
            this.workBookIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1470832824707031D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.workBookIDDataTextBox.StyleName = "Data";
            this.workBookIDDataTextBox.Value = "= Fields.WorkBookID";
            // 
            // fiaDataTextBox
            // 
            this.fiaDataTextBox.CanGrow = true;
            this.fiaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2001993656158447D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaDataTextBox.Name = "fiaDataTextBox";
            this.fiaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.1995997428894043D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaDataTextBox.StyleName = "Data";
            this.fiaDataTextBox.Value = "= Fields.Fia";
            // 
            // seriesNumberDataTextBox
            // 
            this.seriesNumberDataTextBox.CanGrow = true;
            this.seriesNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.seriesNumberDataTextBox.Name = "seriesNumberDataTextBox";
            this.seriesNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9997990131378174D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.seriesNumberDataTextBox.StyleName = "Data";
            this.seriesNumberDataTextBox.Value = "= Fields.SeriesNumber";
            // 
            // dateOfFillingDataTextBox
            // 
            this.dateOfFillingDataTextBox.CanGrow = true;
            this.dateOfFillingDataTextBox.Format = "{0:d}";
            this.dateOfFillingDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.399999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfFillingDataTextBox.Name = "dateOfFillingDataTextBox";
            this.dateOfFillingDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.999798059463501D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfFillingDataTextBox.StyleName = "Data";
            this.dateOfFillingDataTextBox.Value = "= Fields.DateOfFilling";
            // 
            // dateOfGivenDataTextBox
            // 
            this.dateOfGivenDataTextBox.CanGrow = true;
            this.dateOfGivenDataTextBox.Format = "{0:d}";
            this.dateOfGivenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.399998664855957D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfGivenDataTextBox.Name = "dateOfGivenDataTextBox";
            this.dateOfGivenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1998016834259033D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfGivenDataTextBox.StyleName = "Data";
            this.dateOfGivenDataTextBox.Value = "= Fields.DateOfGiven";
            // 
            // isGivenDataTextBox
            // 
            this.isGivenDataTextBox.CanGrow = true;
            this.isGivenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.600000381469727D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.isGivenDataTextBox.Name = "isGivenDataTextBox";
            this.isGivenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1470835208892822D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.isGivenDataTextBox.StyleName = "Data";
            this.isGivenDataTextBox.Value = "= Fields.IsGiven";
            // 
            // WorkBooksReport
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
            this.Name = "WorkBooksReport";
            this.PageSettings.Landscape = true;
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(18.80000114440918D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox workBookIDCaptionTextBox;
        private Telerik.Reporting.TextBox fiaCaptionTextBox;
        private Telerik.Reporting.TextBox seriesNumberCaptionTextBox;
        private Telerik.Reporting.TextBox dateOfFillingCaptionTextBox;
        private Telerik.Reporting.TextBox dateOfGivenCaptionTextBox;
        private Telerik.Reporting.TextBox isGivenCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox fiaCountFunctionTextBox;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox workBookIDDataTextBox;
        private Telerik.Reporting.TextBox fiaDataTextBox;
        private Telerik.Reporting.TextBox seriesNumberDataTextBox;
        private Telerik.Reporting.TextBox dateOfFillingDataTextBox;
        private Telerik.Reporting.TextBox dateOfGivenDataTextBox;
        private Telerik.Reporting.TextBox isGivenDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}