namespace ReportLib
{
    partial class VacationsReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationsReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.vacationIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fiaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.typeOfVacationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateOfStartCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateOfEndCaptionTextBox = new Telerik.Reporting.TextBox();
            this.countOfDaysCaptionTextBox = new Telerik.Reporting.TextBox();
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
            this.vacationIDDataTextBox = new Telerik.Reporting.TextBox();
            this.fiaDataTextBox = new Telerik.Reporting.TextBox();
            this.typeOfVacationDataTextBox = new Telerik.Reporting.TextBox();
            this.dateOfStartDataTextBox = new Telerik.Reporting.TextBox();
            this.dateOfEndDataTextBox = new Telerik.Reporting.TextBox();
            this.countOfDaysDataTextBox = new Telerik.Reporting.TextBox();
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
            this.vacationIDCaptionTextBox,
            this.fiaCaptionTextBox,
            this.typeOfVacationCaptionTextBox,
            this.dateOfStartCaptionTextBox,
            this.dateOfEndCaptionTextBox,
            this.countOfDaysCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // vacationIDCaptionTextBox
            // 
            this.vacationIDCaptionTextBox.CanGrow = true;
            this.vacationIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.vacationIDCaptionTextBox.Name = "vacationIDCaptionTextBox";
            this.vacationIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.84708338975906372D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.vacationIDCaptionTextBox.StyleName = "Caption";
            this.vacationIDCaptionTextBox.Value = "№";
            // 
            // fiaCaptionTextBox
            // 
            this.fiaCaptionTextBox.CanGrow = true;
            this.fiaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.90019994974136353D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCaptionTextBox.Name = "fiaCaptionTextBox";
            this.fiaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9995999336242676D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaCaptionTextBox.StyleName = "Caption";
            this.fiaCaptionTextBox.Value = "ПІБ працівника";
            // 
            // typeOfVacationCaptionTextBox
            // 
            this.typeOfVacationCaptionTextBox.CanGrow = true;
            this.typeOfVacationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.typeOfVacationCaptionTextBox.Name = "typeOfVacationCaptionTextBox";
            this.typeOfVacationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.199798583984375D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.typeOfVacationCaptionTextBox.StyleName = "Caption";
            this.typeOfVacationCaptionTextBox.Value = "Тип відпустки";
            // 
            // dateOfStartCaptionTextBox
            // 
            this.dateOfStartCaptionTextBox.CanGrow = true;
            this.dateOfStartCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.09999942779541D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfStartCaptionTextBox.Name = "dateOfStartCaptionTextBox";
            this.dateOfStartCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3998000621795654D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfStartCaptionTextBox.StyleName = "Caption";
            this.dateOfStartCaptionTextBox.Value = "Дата початку";
            // 
            // dateOfEndCaptionTextBox
            // 
            this.dateOfEndCaptionTextBox.CanGrow = true;
            this.dateOfEndCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfEndCaptionTextBox.Name = "dateOfEndCaptionTextBox";
            this.dateOfEndCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9997996091842651D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfEndCaptionTextBox.StyleName = "Caption";
            this.dateOfEndCaptionTextBox.Value = "Дата закінчення";
            // 
            // countOfDaysCaptionTextBox
            // 
            this.countOfDaysCaptionTextBox.CanGrow = true;
            this.countOfDaysCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.countOfDaysCaptionTextBox.Name = "countOfDaysCaptionTextBox";
            this.countOfDaysCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8470824956893921D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.countOfDaysCaptionTextBox.StyleName = "Caption";
            this.countOfDaysCaptionTextBox.Value = "К-сть днів відпустки";
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
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6468832492828369D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Всього записів:";
            // 
            // fiaCountFunctionTextBox
            // 
            this.fiaCountFunctionTextBox.CanGrow = true;
            this.fiaCountFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCountFunctionTextBox.Name = "fiaCountFunctionTextBox";
            this.fiaCountFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1997995376586914D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.294166564941406D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Звіт";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.83646613359451294D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.413540840148926D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.2856251001358032D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.399999618530273D), Telerik.Reporting.Drawing.Unit.Cm(1.1856250762939453D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Інформація про відпустки працівників";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.vacationIDDataTextBox,
            this.fiaDataTextBox,
            this.typeOfVacationDataTextBox,
            this.dateOfStartDataTextBox,
            this.dateOfEndDataTextBox,
            this.countOfDaysDataTextBox});
            this.detail.Name = "detail";
            // 
            // vacationIDDataTextBox
            // 
            this.vacationIDDataTextBox.CanGrow = true;
            this.vacationIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.vacationIDDataTextBox.Name = "vacationIDDataTextBox";
            this.vacationIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.84708338975906372D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.vacationIDDataTextBox.StyleName = "Data";
            this.vacationIDDataTextBox.Value = "= Fields.VacationID";
            // 
            // fiaDataTextBox
            // 
            this.fiaDataTextBox.CanGrow = true;
            this.fiaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.90019994974136353D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaDataTextBox.Name = "fiaDataTextBox";
            this.fiaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9995999336242676D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaDataTextBox.StyleName = "Data";
            this.fiaDataTextBox.Value = "= Fields.Fia";
            // 
            // typeOfVacationDataTextBox
            // 
            this.typeOfVacationDataTextBox.CanGrow = true;
            this.typeOfVacationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.typeOfVacationDataTextBox.Name = "typeOfVacationDataTextBox";
            this.typeOfVacationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.199798583984375D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.typeOfVacationDataTextBox.StyleName = "Data";
            this.typeOfVacationDataTextBox.Value = "= Fields.TypeOfVacation";
            // 
            // dateOfStartDataTextBox
            // 
            this.dateOfStartDataTextBox.CanGrow = true;
            this.dateOfStartDataTextBox.Format = "{0:d}";
            this.dateOfStartDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.09999942779541D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfStartDataTextBox.Name = "dateOfStartDataTextBox";
            this.dateOfStartDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3998000621795654D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfStartDataTextBox.StyleName = "Data";
            this.dateOfStartDataTextBox.Value = "= Fields.DateOfStart";
            // 
            // dateOfEndDataTextBox
            // 
            this.dateOfEndDataTextBox.CanGrow = true;
            this.dateOfEndDataTextBox.Format = "{0:d}";
            this.dateOfEndDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.dateOfEndDataTextBox.Name = "dateOfEndDataTextBox";
            this.dateOfEndDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9997996091842651D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.dateOfEndDataTextBox.StyleName = "Data";
            this.dateOfEndDataTextBox.Value = "= Fields.DateOfEnd";
            // 
            // countOfDaysDataTextBox
            // 
            this.countOfDaysDataTextBox.CanGrow = true;
            this.countOfDaysDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.countOfDaysDataTextBox.Name = "countOfDaysDataTextBox";
            this.countOfDaysDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8470824956893921D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.countOfDaysDataTextBox.StyleName = "Data";
            this.countOfDaysDataTextBox.Value = "= Fields.CountOfDays";
            // 
            // VacationsReport
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
            this.Name = "VacationsReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(20.399999618530273D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox vacationIDCaptionTextBox;
        private Telerik.Reporting.TextBox fiaCaptionTextBox;
        private Telerik.Reporting.TextBox typeOfVacationCaptionTextBox;
        private Telerik.Reporting.TextBox dateOfStartCaptionTextBox;
        private Telerik.Reporting.TextBox dateOfEndCaptionTextBox;
        private Telerik.Reporting.TextBox countOfDaysCaptionTextBox;
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
        private Telerik.Reporting.TextBox vacationIDDataTextBox;
        private Telerik.Reporting.TextBox fiaDataTextBox;
        private Telerik.Reporting.TextBox typeOfVacationDataTextBox;
        private Telerik.Reporting.TextBox dateOfStartDataTextBox;
        private Telerik.Reporting.TextBox dateOfEndDataTextBox;
        private Telerik.Reporting.TextBox countOfDaysDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}