namespace ReportLib
{
    partial class DepartmentInfoReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.headCaptionTextBox = new Telerik.Reporting.TextBox();
            this.officeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.phoneNumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.rowDataTextBox = new Telerik.Reporting.TextBox();
            this.departmentNameDataTextBox = new Telerik.Reporting.TextBox();
            this.headDataTextBox = new Telerik.Reporting.TextBox();
            this.officeDataTextBox = new Telerik.Reporting.TextBox();
            this.phoneNumberDataTextBox = new Telerik.Reporting.TextBox();
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
            this.headCaptionTextBox,
            this.officeCaptionTextBox,
            this.phoneNumberCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // rowCaptionTextBox
            // 
            this.rowCaptionTextBox.CanGrow = true;
            this.rowCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowCaptionTextBox.Name = "rowCaptionTextBox";
            this.rowCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1470834016799927D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowCaptionTextBox.StyleName = "Caption";
            this.rowCaptionTextBox.Value = "�";
            // 
            // departmentNameCaptionTextBox
            // 
            this.departmentNameCaptionTextBox.CanGrow = true;
            this.departmentNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2001998424530029D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameCaptionTextBox.Name = "departmentNameCaptionTextBox";
            this.departmentNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.299799919128418D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameCaptionTextBox.StyleName = "Caption";
            this.departmentNameCaptionTextBox.Value = "����� ��������";
            // 
            // headCaptionTextBox
            // 
            this.headCaptionTextBox.CanGrow = true;
            this.headCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.5002007484436035D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.headCaptionTextBox.Name = "headCaptionTextBox";
            this.headCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.6995987892150879D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.headCaptionTextBox.StyleName = "Caption";
            this.headCaptionTextBox.Value = "���������";
            // 
            // officeCaptionTextBox
            // 
            this.officeCaptionTextBox.CanGrow = true;
            this.officeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.200000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.officeCaptionTextBox.Name = "officeCaptionTextBox";
            this.officeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3997986316680908D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.officeCaptionTextBox.StyleName = "Caption";
            this.officeCaptionTextBox.Value = "� �������";
            // 
            // phoneNumberCaptionTextBox
            // 
            this.phoneNumberCaptionTextBox.CanGrow = true;
            this.phoneNumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599998474121094D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.phoneNumberCaptionTextBox.Name = "phoneNumberCaptionTextBox";
            this.phoneNumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.747084379196167D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.phoneNumberCaptionTextBox.StyleName = "Caption";
            this.phoneNumberCaptionTextBox.Value = "�������";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = "SELECT        ROW_NUMBER() OVER (ORDER BY departmentname) AS Row, DepartmentName," +
    " Head, office, PhoneNumber\r\nFROM            Department";
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.294166564941406D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "���";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.6895831823348999D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.4135417938232422D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.399999618530273D), Telerik.Reporting.Drawing.Unit.Cm(1.1856250762939453D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "���������� ��� ��������";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.barcode1});
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.rowDataTextBox,
            this.departmentNameDataTextBox,
            this.headDataTextBox,
            this.officeDataTextBox,
            this.phoneNumberDataTextBox});
            this.detail.Name = "detail";
            // 
            // rowDataTextBox
            // 
            this.rowDataTextBox.CanGrow = true;
            this.rowDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowDataTextBox.Name = "rowDataTextBox";
            this.rowDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1470834016799927D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowDataTextBox.StyleName = "Data";
            this.rowDataTextBox.Value = "= Fields.Row";
            // 
            // departmentNameDataTextBox
            // 
            this.departmentNameDataTextBox.CanGrow = true;
            this.departmentNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2001998424530029D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.departmentNameDataTextBox.Name = "departmentNameDataTextBox";
            this.departmentNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.299799919128418D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.departmentNameDataTextBox.StyleName = "Data";
            this.departmentNameDataTextBox.Value = "= Fields.DepartmentName";
            // 
            // headDataTextBox
            // 
            this.headDataTextBox.CanGrow = true;
            this.headDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.5002007484436035D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.headDataTextBox.Name = "headDataTextBox";
            this.headDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.6995987892150879D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.headDataTextBox.StyleName = "Data";
            this.headDataTextBox.Value = "= Fields.Head";
            // 
            // officeDataTextBox
            // 
            this.officeDataTextBox.CanGrow = true;
            this.officeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.200000762939453D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.officeDataTextBox.Name = "officeDataTextBox";
            this.officeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3997986316680908D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.officeDataTextBox.StyleName = "Data";
            this.officeDataTextBox.Value = "= Fields.office";
            // 
            // phoneNumberDataTextBox
            // 
            this.phoneNumberDataTextBox.CanGrow = true;
            this.phoneNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599998474121094D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.phoneNumberDataTextBox.Name = "phoneNumberDataTextBox";
            this.phoneNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.747084379196167D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.phoneNumberDataTextBox.StyleName = "Data";
            this.phoneNumberDataTextBox.Value = "= Fields.PhoneNumber";
            // 
            // DepartmentInfoReport
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
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "DepartmentInfoReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17.399999618530273D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox rowCaptionTextBox;
        private Telerik.Reporting.TextBox departmentNameCaptionTextBox;
        private Telerik.Reporting.TextBox headCaptionTextBox;
        private Telerik.Reporting.TextBox officeCaptionTextBox;
        private Telerik.Reporting.TextBox phoneNumberCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox rowDataTextBox;
        private Telerik.Reporting.TextBox departmentNameDataTextBox;
        private Telerik.Reporting.TextBox headDataTextBox;
        private Telerik.Reporting.TextBox officeDataTextBox;
        private Telerik.Reporting.TextBox phoneNumberDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}