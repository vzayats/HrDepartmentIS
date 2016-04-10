namespace ReportLib
{
    partial class HiringDateReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiringDateReport));
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.iDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.surnameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.middleNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.hiringDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.PersonnelDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.iDDataTextBox = new Telerik.Reporting.TextBox();
            this.surnameDataTextBox = new Telerik.Reporting.TextBox();
            this.nameDataTextBox = new Telerik.Reporting.TextBox();
            this.middleNameDataTextBox = new Telerik.Reporting.TextBox();
            this.hiringDateDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(3.6039586067199707D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.iDCaptionTextBox,
            this.surnameCaptionTextBox,
            this.nameCaptionTextBox,
            this.middleNameCaptionTextBox,
            this.hiringDateCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // iDCaptionTextBox
            // 
            this.iDCaptionTextBox.CanGrow = true;
            this.iDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.iDCaptionTextBox.Name = "iDCaptionTextBox";
            this.iDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5470829010009766D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.iDCaptionTextBox.StyleName = "Caption";
            this.iDCaptionTextBox.Value = "��������� �";
            // 
            // surnameCaptionTextBox
            // 
            this.surnameCaptionTextBox.CanGrow = true;
            this.surnameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6001994609832764D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.surnameCaptionTextBox.Name = "surnameCaptionTextBox";
            this.surnameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.70430064201355D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.surnameCaptionTextBox.StyleName = "Caption";
            this.surnameCaptionTextBox.Value = "�������";
            // 
            // nameCaptionTextBox
            // 
            this.nameCaptionTextBox.CanGrow = true;
            this.nameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.35741662979126D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nameCaptionTextBox.Name = "nameCaptionTextBox";
            this.nameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0993332862854004D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.nameCaptionTextBox.StyleName = "Caption";
            this.nameCaptionTextBox.Value = "��\'�";
            // 
            // middleNameCaptionTextBox
            // 
            this.middleNameCaptionTextBox.CanGrow = true;
            this.middleNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.5096664428710938D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.middleNameCaptionTextBox.Name = "middleNameCaptionTextBox";
            this.middleNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3901345729827881D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.middleNameCaptionTextBox.StyleName = "Caption";
            this.middleNameCaptionTextBox.Value = "��-�������";
            // 
            // hiringDateCaptionTextBox
            // 
            this.hiringDateCaptionTextBox.CanGrow = true;
            this.hiringDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.899999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.hiringDateCaptionTextBox.Name = "hiringDateCaptionTextBox";
            this.hiringDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8612501621246338D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.hiringDateCaptionTextBox.StyleName = "Caption";
            this.hiringDateCaptionTextBox.Value = "���� ���������";
            // 
            // PersonnelDataSource1
            // 
            this.PersonnelDataSource1.ConnectionString = "ReportLib.Properties.Settings.Personneldepartment";
            this.PersonnelDataSource1.Name = "PersonnelDataSource1";
            this.PersonnelDataSource1.SelectCommand = resources.GetString("PersonnelDataSource1.SelectCommand");
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "���";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.76729035377502441D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox,
            this.currentTimeTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.05291646346449852D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(3D));
            this.barcode1.Stretch = true;
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3856254816055298D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D), Telerik.Reporting.Drawing.Unit.Cm(1.2856249809265137D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "���� ��������� ���������� �� ������";
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
            this.iDDataTextBox,
            this.surnameDataTextBox,
            this.nameDataTextBox,
            this.middleNameDataTextBox,
            this.hiringDateDataTextBox});
            this.detail.Name = "detail";
            // 
            // iDDataTextBox
            // 
            this.iDDataTextBox.CanGrow = true;
            this.iDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.iDDataTextBox.Name = "iDDataTextBox";
            this.iDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5470829010009766D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.iDDataTextBox.StyleName = "Data";
            this.iDDataTextBox.Value = "= Fields.ID";
            // 
            // surnameDataTextBox
            // 
            this.surnameDataTextBox.CanGrow = true;
            this.surnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6001994609832764D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.surnameDataTextBox.Name = "surnameDataTextBox";
            this.surnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.70430064201355D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.surnameDataTextBox.StyleName = "Data";
            this.surnameDataTextBox.Value = "= Fields.Surname";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = true;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.35741662979126D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0993332862854004D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.nameDataTextBox.StyleName = "Data";
            this.nameDataTextBox.Value = "= Fields.Name";
            // 
            // middleNameDataTextBox
            // 
            this.middleNameDataTextBox.CanGrow = true;
            this.middleNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.5096664428710938D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.middleNameDataTextBox.Name = "middleNameDataTextBox";
            this.middleNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3901345729827881D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.middleNameDataTextBox.StyleName = "Data";
            this.middleNameDataTextBox.Value = "= Fields.MiddleName";
            // 
            // hiringDateDataTextBox
            // 
            this.hiringDateDataTextBox.CanGrow = true;
            this.hiringDateDataTextBox.Format = "{0:d}";
            this.hiringDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.899999618530273D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.hiringDateDataTextBox.Name = "hiringDateDataTextBox";
            this.hiringDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8612501621246338D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.hiringDateDataTextBox.StyleName = "Data";
            this.hiringDateDataTextBox.Value = "= Fields.HiringDate";
            // 
            // HiringDateReport
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
            this.Name = "HiringDateReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox iDCaptionTextBox;
        private Telerik.Reporting.TextBox surnameCaptionTextBox;
        private Telerik.Reporting.TextBox nameCaptionTextBox;
        private Telerik.Reporting.TextBox middleNameCaptionTextBox;
        private Telerik.Reporting.TextBox hiringDateCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox iDDataTextBox;
        private Telerik.Reporting.TextBox surnameDataTextBox;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.TextBox middleNameDataTextBox;
        private Telerik.Reporting.TextBox hiringDateDataTextBox;

    }
}