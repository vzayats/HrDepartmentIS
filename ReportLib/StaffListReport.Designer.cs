namespace ReportLib
{
    partial class StaffListReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.rowCaptionTextBox = new Telerik.Reporting.TextBox();
            this.departmentNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.departmentIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.positionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.positionCodeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.numberOfWorkersCaptionTextBox = new Telerik.Reporting.TextBox();
            this.salaryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.bonusCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sumTotalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.numberOfWorkersSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.salarySumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.bonusSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.sumTotalSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.rowDataTextBox = new Telerik.Reporting.TextBox();
            this.departmentNameDataTextBox = new Telerik.Reporting.TextBox();
            this.departmentIDDataTextBox = new Telerik.Reporting.TextBox();
            this.positionDataTextBox = new Telerik.Reporting.TextBox();
            this.positionCodeDataTextBox = new Telerik.Reporting.TextBox();
            this.numberOfWorkersDataTextBox = new Telerik.Reporting.TextBox();
            this.salaryDataTextBox = new Telerik.Reporting.TextBox();
            this.bonusDataTextBox = new Telerik.Reporting.TextBox();
            this.sumTotalDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
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
            this.rowCaptionTextBox,
            this.departmentNameCaptionTextBox,
            this.departmentIDCaptionTextBox,
            this.positionCaptionTextBox,
            this.positionCodeCaptionTextBox,
            this.numberOfWorkersCaptionTextBox,
            this.salaryCaptionTextBox,
            this.bonusCaptionTextBox,
            this.sumTotalCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // rowCaptionTextBox
            // 
            this.rowCaptionTextBox.CanGrow = true;
            this.rowCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowCaptionTextBox.Name = "rowCaptionTextBox";
            this.rowCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.94708347320556641D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowCaptionTextBox.StyleName = "Caption";
            this.rowCaptionTextBox.Value = "№";
            // 
            // departmentNameCaptionTextBox
            // 
            this.departmentNameCaptionTextBox.CanGrow = true;
            this.departmentNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0002002716064453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameCaptionTextBox.Name = "departmentNameCaptionTextBox";
            this.departmentNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.19980001449585D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameCaptionTextBox.StyleName = "Caption";
            this.departmentNameCaptionTextBox.Value = "Назва підрозділу";
            // 
            // departmentIDCaptionTextBox
            // 
            this.departmentIDCaptionTextBox.CanGrow = true;
            this.departmentIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.20020055770874D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentIDCaptionTextBox.Name = "departmentIDCaptionTextBox";
            this.departmentIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.999798595905304D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentIDCaptionTextBox.StyleName = "Caption";
            this.departmentIDCaptionTextBox.Value = "Код";
            // 
            // positionCaptionTextBox
            // 
            this.positionCaptionTextBox.CanGrow = true;
            this.positionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2001991271972656D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.positionCaptionTextBox.Name = "positionCaptionTextBox";
            this.positionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.499600887298584D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.positionCaptionTextBox.StyleName = "Caption";
            this.positionCaptionTextBox.Value = "Назва посади (професії)";
            // 
            // positionCodeCaptionTextBox
            // 
            this.positionCodeCaptionTextBox.CanGrow = true;
            this.positionCodeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.699999809265137D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.positionCodeCaptionTextBox.Name = "positionCodeCaptionTextBox";
            this.positionCodeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997986793518066D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.positionCodeCaptionTextBox.StyleName = "Caption";
            this.positionCodeCaptionTextBox.Value = "Код посади";
            // 
            // numberOfWorkersCaptionTextBox
            // 
            this.numberOfWorkersCaptionTextBox.CanGrow = true;
            this.numberOfWorkersCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.799998283386231D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersCaptionTextBox.Name = "numberOfWorkersCaptionTextBox";
            this.numberOfWorkersCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997998714447021D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersCaptionTextBox.StyleName = "Caption";
            this.numberOfWorkersCaptionTextBox.Value = "Кількість штатних одиниць ";
            // 
            // salaryCaptionTextBox
            // 
            this.salaryCaptionTextBox.CanGrow = true;
            this.salaryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.899997711181641D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.salaryCaptionTextBox.Name = "salaryCaptionTextBox";
            this.salaryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5998015403747559D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.salaryCaptionTextBox.StyleName = "Caption";
            this.salaryCaptionTextBox.Value = "Посадовий оклад, грн";
            // 
            // bonusCaptionTextBox
            // 
            this.bonusCaptionTextBox.CanGrow = true;
            this.bonusCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.bonusCaptionTextBox.Name = "bonusCaptionTextBox";
            this.bonusCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2960517406463623D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.bonusCaptionTextBox.StyleName = "Caption";
            this.bonusCaptionTextBox.Value = "Надбавка, грн";
            // 
            // sumTotalCaptionTextBox
            // 
            this.sumTotalCaptionTextBox.CanGrow = true;
            this.sumTotalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.796249389648438D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.sumTotalCaptionTextBox.Name = "sumTotalCaptionTextBox";
            this.sumTotalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6649999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.sumTotalCaptionTextBox.StyleName = "Caption";
            this.sumTotalCaptionTextBox.Value = "Місячний фонд заробітної плати, грн";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = resources.GetString("PersonnelDataSource1.SelectCommand");
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(8.1753082275390625D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.numberOfWorkersSumFunctionTextBox,
            this.salarySumFunctionTextBox,
            this.bonusSumFunctionTextBox,
            this.sumTotalSumFunctionTextBox,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.barcode1,
            this.textBox8});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(14.746880531311035D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.textBox1.Style.Font.Bold = false;
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Разом:";
            // 
            // numberOfWorkersSumFunctionTextBox
            // 
            this.numberOfWorkersSumFunctionTextBox.CanGrow = true;
            this.numberOfWorkersSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.799998283386231D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersSumFunctionTextBox.Name = "numberOfWorkersSumFunctionTextBox";
            this.numberOfWorkersSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997998714447021D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersSumFunctionTextBox.StyleName = "Data";
            this.numberOfWorkersSumFunctionTextBox.Value = "= Sum(Fields.NumberOfWorkers)";
            // 
            // salarySumFunctionTextBox
            // 
            this.salarySumFunctionTextBox.CanGrow = true;
            this.salarySumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.899997711181641D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.salarySumFunctionTextBox.Name = "salarySumFunctionTextBox";
            this.salarySumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5998036861419678D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.salarySumFunctionTextBox.StyleName = "Data";
            this.salarySumFunctionTextBox.Value = "= Sum(Fields.Salary)";
            // 
            // bonusSumFunctionTextBox
            // 
            this.bonusSumFunctionTextBox.CanGrow = true;
            this.bonusSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.bonusSumFunctionTextBox.Name = "bonusSumFunctionTextBox";
            this.bonusSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.243333101272583D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.bonusSumFunctionTextBox.StyleName = "Data";
            this.bonusSumFunctionTextBox.Value = "= Sum(Fields.Bonus)";
            // 
            // sumTotalSumFunctionTextBox
            // 
            this.sumTotalSumFunctionTextBox.CanGrow = true;
            this.sumTotalSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.796249389648438D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.sumTotalSumFunctionTextBox.Name = "sumTotalSumFunctionTextBox";
            this.sumTotalSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6649999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.sumTotalSumFunctionTextBox.StyleName = "Data";
            this.sumTotalSumFunctionTextBox.Value = "= Sum(Fields.SumTotal)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D), Telerik.Reporting.Drawing.Unit.Cm(0.8895835280418396D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611D));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox3.Value = "Розроблено:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448D), Telerik.Reporting.Drawing.Unit.Cm(1.6895830631256104D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.899999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611D));
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox4.Value = "Начальник відділу кадрів _________________________\t";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.75291633605957D), Telerik.Reporting.Drawing.Unit.Cm(2.2897839546203613D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D));
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox5.Value = "(Підпис)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.552915573120117D), Telerik.Reporting.Drawing.Unit.Cm(1.6895830631256104D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.7470850944519043D), Telerik.Reporting.Drawing.Unit.Cm(0.59999954700469971D));
            this.textBox6.Value = "____________________________________";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.799998283386231D), Telerik.Reporting.Drawing.Unit.Cm(2.2897839546203613D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.800001859664917D), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D));
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Value = "(Прізвище, ініціали)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.544373512268066D), Telerik.Reporting.Drawing.Unit.Cm(3.7833333015441895D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.7470850944519043D), Telerik.Reporting.Drawing.Unit.Cm(0.59999954700469971D));
            this.textBox9.Value = "___________________________________";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.7554168701171875D), Telerik.Reporting.Drawing.Unit.Cm(4.3918757438659668D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D));
            this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox10.Value = "(Підпис)";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000033378601074D), Telerik.Reporting.Drawing.Unit.Cm(3.7833333015441895D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.899999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611D));
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox11.Value = "Головний бухгалтер          _________________________\t";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40000033378601074D), Telerik.Reporting.Drawing.Unit.Cm(2.9895832538604736D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.60000050067901611D));
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox12.Value = "Погоджено:";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.3999997079372406D), Telerik.Reporting.Drawing.Unit.Cm(5.0753087997436523D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(3.0000007152557373D));
            this.barcode1.Stretch = true;
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.50000011920928955D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.KeepTogether = true;
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(9.9921220680698752E-05D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(24.408332824707031D), Telerik.Reporting.Drawing.Unit.Cm(0.49990010261535645D));
            this.reportNameTextBox.Style.Color = System.Drawing.Color.White;
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Розпис";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.70529437065124512D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox,
            this.textBox2});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3000001907348633D), Telerik.Reporting.Drawing.Unit.Cm(0.10529449582099915D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.9306249618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.283541679382324D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.177708625793457D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.1999993622303009D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2468831539154053D), Telerik.Reporting.Drawing.Unit.Cm(0.50529509782791138D));
            this.textBox2.Style.Font.Name = "Georgia";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox2.Value = "Сформовано:";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.4999997615814209D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox14,
            this.textBox15,
            this.textBox13});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(24.5141658782959D), Telerik.Reporting.Drawing.Unit.Cm(2.1999995708465576D));
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Штатний розпис";
            // 
            // textBox14
            // 
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.999997138977051D), Telerik.Reporting.Drawing.Unit.Cm(0.70019978284835815D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.90000057220459D), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269D));
            this.textBox14.Value = "Наказом директора від  \"____\" _______________  ______ р. №______";
            // 
            // textBox15
            // 
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(0.70019990205764771D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.142299652099609D), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269D));
            this.textBox15.Value = "На період ________  з  \"_____\"  _______________  ______ р. ";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12D), Telerik.Reporting.Drawing.Unit.Cm(9.9988508736714721E-05D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000009536743164D), Telerik.Reporting.Drawing.Unit.Cm(0.59999990463256836D));
            this.textBox13.Style.Font.Bold = true;
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox13.Value = "Затверджено";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.rowDataTextBox,
            this.departmentNameDataTextBox,
            this.departmentIDDataTextBox,
            this.positionDataTextBox,
            this.positionCodeDataTextBox,
            this.numberOfWorkersDataTextBox,
            this.salaryDataTextBox,
            this.bonusDataTextBox,
            this.sumTotalDataTextBox});
            this.detail.Name = "detail";
            // 
            // rowDataTextBox
            // 
            this.rowDataTextBox.CanGrow = true;
            this.rowDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowDataTextBox.Name = "rowDataTextBox";
            this.rowDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.94708347320556641D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowDataTextBox.StyleName = "Data";
            this.rowDataTextBox.Value = "= Fields.Row";
            // 
            // departmentNameDataTextBox
            // 
            this.departmentNameDataTextBox.CanGrow = true;
            this.departmentNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0002002716064453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameDataTextBox.Name = "departmentNameDataTextBox";
            this.departmentNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.19980001449585D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameDataTextBox.StyleName = "Data";
            this.departmentNameDataTextBox.Value = "= Fields.DepartmentName";
            // 
            // departmentIDDataTextBox
            // 
            this.departmentIDDataTextBox.CanGrow = true;
            this.departmentIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.20020055770874D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentIDDataTextBox.Name = "departmentIDDataTextBox";
            this.departmentIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.999798595905304D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentIDDataTextBox.StyleName = "Data";
            this.departmentIDDataTextBox.Value = "= Fields.DepartmentID";
            // 
            // positionDataTextBox
            // 
            this.positionDataTextBox.CanGrow = true;
            this.positionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.2001991271972656D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.positionDataTextBox.Name = "positionDataTextBox";
            this.positionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.499600887298584D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.positionDataTextBox.StyleName = "Data";
            this.positionDataTextBox.Value = "= Fields.Position";
            // 
            // positionCodeDataTextBox
            // 
            this.positionCodeDataTextBox.CanGrow = true;
            this.positionCodeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.69999885559082D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.positionCodeDataTextBox.Name = "positionCodeDataTextBox";
            this.positionCodeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997986793518066D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.positionCodeDataTextBox.StyleName = "Data";
            this.positionCodeDataTextBox.Value = "= Fields.PositionCode";
            // 
            // numberOfWorkersDataTextBox
            // 
            this.numberOfWorkersDataTextBox.CanGrow = true;
            this.numberOfWorkersDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.799998283386231D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.numberOfWorkersDataTextBox.Name = "numberOfWorkersDataTextBox";
            this.numberOfWorkersDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0997998714447021D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.numberOfWorkersDataTextBox.StyleName = "Data";
            this.numberOfWorkersDataTextBox.Value = "= Fields.NumberOfWorkers";
            // 
            // salaryDataTextBox
            // 
            this.salaryDataTextBox.CanGrow = true;
            this.salaryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.899997711181641D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.salaryDataTextBox.Name = "salaryDataTextBox";
            this.salaryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5998015403747559D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.salaryDataTextBox.StyleName = "Data";
            this.salaryDataTextBox.Value = "= Fields.Salary";
            // 
            // bonusDataTextBox
            // 
            this.bonusDataTextBox.CanGrow = true;
            this.bonusDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.5D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.bonusDataTextBox.Name = "bonusDataTextBox";
            this.bonusDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2960517406463623D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.bonusDataTextBox.StyleName = "Data";
            this.bonusDataTextBox.Value = "= Fields.Bonus";
            // 
            // sumTotalDataTextBox
            // 
            this.sumTotalDataTextBox.CanGrow = true;
            this.sumTotalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.796249389648438D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.sumTotalDataTextBox.Name = "sumTotalDataTextBox";
            this.sumTotalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6649999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.sumTotalDataTextBox.StyleName = "Data";
            this.sumTotalDataTextBox.Value = "= Fields.SumTotal";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.799998283386231D), Telerik.Reporting.Drawing.Unit.Cm(4.3918752670288086D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.800001859664917D), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634D));
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox8.Value = "(Прізвище, ініціали)";
            // 
            // StaffListReport
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
            this.Name = "StaffListReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(24.599998474121094D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox rowCaptionTextBox;
        private Telerik.Reporting.TextBox departmentNameCaptionTextBox;
        private Telerik.Reporting.TextBox departmentIDCaptionTextBox;
        private Telerik.Reporting.TextBox positionCaptionTextBox;
        private Telerik.Reporting.TextBox positionCodeCaptionTextBox;
        private Telerik.Reporting.TextBox numberOfWorkersCaptionTextBox;
        private Telerik.Reporting.TextBox salaryCaptionTextBox;
        private Telerik.Reporting.TextBox bonusCaptionTextBox;
        private Telerik.Reporting.TextBox sumTotalCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox numberOfWorkersSumFunctionTextBox;
        private Telerik.Reporting.TextBox salarySumFunctionTextBox;
        private Telerik.Reporting.TextBox bonusSumFunctionTextBox;
        private Telerik.Reporting.TextBox sumTotalSumFunctionTextBox;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox rowDataTextBox;
        private Telerik.Reporting.TextBox departmentNameDataTextBox;
        private Telerik.Reporting.TextBox departmentIDDataTextBox;
        private Telerik.Reporting.TextBox positionDataTextBox;
        private Telerik.Reporting.TextBox positionCodeDataTextBox;
        private Telerik.Reporting.TextBox numberOfWorkersDataTextBox;
        private Telerik.Reporting.TextBox salaryDataTextBox;
        private Telerik.Reporting.TextBox bonusDataTextBox;
        private Telerik.Reporting.TextBox sumTotalDataTextBox;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox8;

    }
}