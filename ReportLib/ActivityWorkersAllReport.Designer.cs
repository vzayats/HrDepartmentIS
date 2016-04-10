namespace ReportLib
{
    partial class ActivityWorkersAllReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityWorkersAllReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group3 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.fiaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.departmentNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.calendarMonthNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.calendarYearCaptionTextBox = new Telerik.Reporting.TextBox();
            this.presentCaptionTextBox = new Telerik.Reporting.TextBox();
            this.absenceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.hospitalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.vacationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fiaGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.fiaGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.departmentNameGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.presentSumFunctionTextBox1 = new Telerik.Reporting.TextBox();
            this.absenceSumFunctionTextBox1 = new Telerik.Reporting.TextBox();
            this.hospitalSumFunctionTextBox1 = new Telerik.Reporting.TextBox();
            this.vacationSumFunctionTextBox1 = new Telerik.Reporting.TextBox();
            this.departmentNameGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.calendarMonthNameDataTextBox = new Telerik.Reporting.TextBox();
            this.calendarYearDataTextBox = new Telerik.Reporting.TextBox();
            this.presentDataTextBox = new Telerik.Reporting.TextBox();
            this.absenceDataTextBox = new Telerik.Reporting.TextBox();
            this.hospitalDataTextBox = new Telerik.Reporting.TextBox();
            this.vacationDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.fiaCaptionTextBox,
            this.departmentNameCaptionTextBox,
            this.calendarMonthNameCaptionTextBox,
            this.calendarYearCaptionTextBox,
            this.presentCaptionTextBox,
            this.absenceCaptionTextBox,
            this.hospitalCaptionTextBox,
            this.vacationCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // fiaCaptionTextBox
            // 
            this.fiaCaptionTextBox.CanGrow = true;
            this.fiaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCaptionTextBox.Name = "fiaCaptionTextBox";
            this.fiaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.74688196182251D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaCaptionTextBox.StyleName = "Caption";
            this.fiaCaptionTextBox.Value = "ПІБ працівника";
            // 
            // departmentNameCaptionTextBox
            // 
            this.departmentNameCaptionTextBox.CanGrow = true;
            this.departmentNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7999997138977051D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameCaptionTextBox.Name = "departmentNameCaptionTextBox";
            this.departmentNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9998002052307129D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameCaptionTextBox.StyleName = "Caption";
            this.departmentNameCaptionTextBox.Value = "Підрозділ";
            // 
            // calendarMonthNameCaptionTextBox
            // 
            this.calendarMonthNameCaptionTextBox.CanGrow = true;
            this.calendarMonthNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.calendarMonthNameCaptionTextBox.Name = "calendarMonthNameCaptionTextBox";
            this.calendarMonthNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.39979887008667D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.calendarMonthNameCaptionTextBox.StyleName = "Caption";
            this.calendarMonthNameCaptionTextBox.Value = "Місяць";
            // 
            // calendarYearCaptionTextBox
            // 
            this.calendarYearCaptionTextBox.CanGrow = true;
            this.calendarYearCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.200000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.calendarYearCaptionTextBox.Name = "calendarYearCaptionTextBox";
            this.calendarYearCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1997987031936646D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.calendarYearCaptionTextBox.StyleName = "Caption";
            this.calendarYearCaptionTextBox.Value = "Рік";
            // 
            // presentCaptionTextBox
            // 
            this.presentCaptionTextBox.CanGrow = true;
            this.presentCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.399998664855957D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.presentCaptionTextBox.Name = "presentCaptionTextBox";
            this.presentCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2998011112213135D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.presentCaptionTextBox.StyleName = "Caption";
            this.presentCaptionTextBox.Value = "Присутність (днів)";
            // 
            // absenceCaptionTextBox
            // 
            this.absenceCaptionTextBox.CanGrow = true;
            this.absenceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.700000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.absenceCaptionTextBox.Name = "absenceCaptionTextBox";
            this.absenceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997993946075439D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.absenceCaptionTextBox.StyleName = "Caption";
            this.absenceCaptionTextBox.Value = "Відсутність (днів)";
            // 
            // hospitalCaptionTextBox
            // 
            this.hospitalCaptionTextBox.CanGrow = true;
            this.hospitalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.799999237060547D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.hospitalCaptionTextBox.Name = "hospitalCaptionTextBox";
            this.hospitalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1769287586212158D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.hospitalCaptionTextBox.StyleName = "Caption";
            this.hospitalCaptionTextBox.Value = "Лікарняний (днів)";
            // 
            // vacationCaptionTextBox
            // 
            this.vacationCaptionTextBox.CanGrow = true;
            this.vacationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.977128982543945D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.vacationCaptionTextBox.Name = "vacationCaptionTextBox";
            this.vacationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9699550867080689D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.vacationCaptionTextBox.StyleName = "Caption";
            this.vacationCaptionTextBox.Value = "Відпустки (днів)";
            // 
            // fiaGroupFooterSection
            // 
            this.fiaGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144D);
            this.fiaGroupFooterSection.Name = "fiaGroupFooterSection";
            // 
            // fiaGroupHeaderSection
            // 
            this.fiaGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.fiaGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2});
            this.fiaGroupHeaderSection.Name = "fiaGroupHeaderSection";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.0470829010009766D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.Fia";
            // 
            // departmentNameGroupFooterSection
            // 
            this.departmentNameGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.departmentNameGroupFooterSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.presentSumFunctionTextBox1,
            this.absenceSumFunctionTextBox1,
            this.hospitalSumFunctionTextBox1,
            this.vacationSumFunctionTextBox1});
            this.departmentNameGroupFooterSection.Name = "departmentNameGroupFooterSection";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5997979640960693D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.StyleName = "Caption";
            this.textBox5.Value = "Всього за рік (днів):";
            // 
            // presentSumFunctionTextBox1
            // 
            this.presentSumFunctionTextBox1.CanGrow = true;
            this.presentSumFunctionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.399998664855957D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.presentSumFunctionTextBox1.Name = "presentSumFunctionTextBox1";
            this.presentSumFunctionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2998011112213135D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.presentSumFunctionTextBox1.StyleName = "Data";
            this.presentSumFunctionTextBox1.Value = "= Sum(Fields.Present)";
            // 
            // absenceSumFunctionTextBox1
            // 
            this.absenceSumFunctionTextBox1.CanGrow = true;
            this.absenceSumFunctionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.700000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.absenceSumFunctionTextBox1.Name = "absenceSumFunctionTextBox1";
            this.absenceSumFunctionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997993946075439D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.absenceSumFunctionTextBox1.StyleName = "Data";
            this.absenceSumFunctionTextBox1.Value = "= Sum(Fields.Absence)";
            // 
            // hospitalSumFunctionTextBox1
            // 
            this.hospitalSumFunctionTextBox1.CanGrow = true;
            this.hospitalSumFunctionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.799999237060547D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.hospitalSumFunctionTextBox1.Name = "hospitalSumFunctionTextBox1";
            this.hospitalSumFunctionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1769287586212158D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.hospitalSumFunctionTextBox1.StyleName = "Data";
            this.hospitalSumFunctionTextBox1.Value = "= Sum(Fields.Hospital)";
            // 
            // vacationSumFunctionTextBox1
            // 
            this.vacationSumFunctionTextBox1.CanGrow = true;
            this.vacationSumFunctionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.977128982543945D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.vacationSumFunctionTextBox1.Name = "vacationSumFunctionTextBox1";
            this.vacationSumFunctionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9699550867080689D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.vacationSumFunctionTextBox1.StyleName = "Data";
            this.vacationSumFunctionTextBox1.Value = "= Sum(Fields.Vacation)";
            // 
            // departmentNameGroupHeaderSection
            // 
            this.departmentNameGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.departmentNameGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4});
            this.departmentNameGroupHeaderSection.Name = "departmentNameGroupHeaderSection";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.7999997138977051D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2999999523162842D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.DepartmentName";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = resources.GetString("PersonnelDataSource1.SelectCommand");
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.barcode1});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.894166946411133D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Звіт";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.66354161500930786D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.652291297912598D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.barcode1.Stretch = true;
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.085625171661377D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(21D), Telerik.Reporting.Drawing.Unit.Cm(1.085625171661377D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Діяльність працівників за всі періоди (зведений звіт)";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.calendarMonthNameDataTextBox,
            this.calendarYearDataTextBox,
            this.presentDataTextBox,
            this.absenceDataTextBox,
            this.hospitalDataTextBox,
            this.vacationDataTextBox});
            this.detail.Name = "detail";
            // 
            // calendarMonthNameDataTextBox
            // 
            this.calendarMonthNameDataTextBox.CanGrow = true;
            this.calendarMonthNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.8000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.calendarMonthNameDataTextBox.Name = "calendarMonthNameDataTextBox";
            this.calendarMonthNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.39979887008667D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.calendarMonthNameDataTextBox.StyleName = "Data";
            this.calendarMonthNameDataTextBox.Value = "= Fields.CalendarMonthName";
            // 
            // calendarYearDataTextBox
            // 
            this.calendarYearDataTextBox.CanGrow = true;
            this.calendarYearDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.200000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.calendarYearDataTextBox.Name = "calendarYearDataTextBox";
            this.calendarYearDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1997987031936646D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.calendarYearDataTextBox.StyleName = "Data";
            this.calendarYearDataTextBox.Value = "= Fields.CalendarYear";
            // 
            // presentDataTextBox
            // 
            this.presentDataTextBox.CanGrow = true;
            this.presentDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.399998664855957D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.presentDataTextBox.Name = "presentDataTextBox";
            this.presentDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2998011112213135D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.presentDataTextBox.StyleName = "Data";
            this.presentDataTextBox.Value = "= Fields.Present";
            // 
            // absenceDataTextBox
            // 
            this.absenceDataTextBox.CanGrow = true;
            this.absenceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.700000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.absenceDataTextBox.Name = "absenceDataTextBox";
            this.absenceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997993946075439D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.absenceDataTextBox.StyleName = "Data";
            this.absenceDataTextBox.Value = "= Fields.Absence";
            // 
            // hospitalDataTextBox
            // 
            this.hospitalDataTextBox.CanGrow = true;
            this.hospitalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.799999237060547D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.hospitalDataTextBox.Name = "hospitalDataTextBox";
            this.hospitalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1769287586212158D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.hospitalDataTextBox.StyleName = "Data";
            this.hospitalDataTextBox.Value = "= Fields.Hospital";
            // 
            // vacationDataTextBox
            // 
            this.vacationDataTextBox.CanGrow = true;
            this.vacationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(18.977128982543945D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.vacationDataTextBox.Name = "vacationDataTextBox";
            this.vacationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9699550867080689D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.vacationDataTextBox.StyleName = "Data";
            this.vacationDataTextBox.Value = "= Fields.Vacation";
            // 
            // ActivityWorkersAllReport
            // 
            this.DataSource = this.PersonnelDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.fiaGroupFooterSection;
            group2.GroupHeader = this.fiaGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Fia"));
            group2.Name = "fiaGroup";
            group3.GroupFooter = this.departmentNameGroupFooterSection;
            group3.GroupHeader = this.departmentNameGroupHeaderSection;
            group3.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.DepartmentName"));
            group3.Name = "departmentNameGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2,
            group3});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.fiaGroupHeaderSection,
            this.fiaGroupFooterSection,
            this.departmentNameGroupHeaderSection,
            this.departmentNameGroupFooterSection,
            this.reportFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "ActivityWorkersAllReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(21D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox fiaCaptionTextBox;
        private Telerik.Reporting.TextBox departmentNameCaptionTextBox;
        private Telerik.Reporting.TextBox calendarMonthNameCaptionTextBox;
        private Telerik.Reporting.TextBox calendarYearCaptionTextBox;
        private Telerik.Reporting.TextBox presentCaptionTextBox;
        private Telerik.Reporting.TextBox absenceCaptionTextBox;
        private Telerik.Reporting.TextBox hospitalCaptionTextBox;
        private Telerik.Reporting.TextBox vacationCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection fiaGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection fiaGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection departmentNameGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.GroupFooterSection departmentNameGroupFooterSection;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox presentSumFunctionTextBox1;
        private Telerik.Reporting.TextBox absenceSumFunctionTextBox1;
        private Telerik.Reporting.TextBox hospitalSumFunctionTextBox1;
        private Telerik.Reporting.TextBox vacationSumFunctionTextBox1;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox calendarMonthNameDataTextBox;
        private Telerik.Reporting.TextBox calendarYearDataTextBox;
        private Telerik.Reporting.TextBox presentDataTextBox;
        private Telerik.Reporting.TextBox absenceDataTextBox;
        private Telerik.Reporting.TextBox hospitalDataTextBox;
        private Telerik.Reporting.TextBox vacationDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}