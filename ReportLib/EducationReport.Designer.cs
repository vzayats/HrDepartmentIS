namespace ReportLib
{
    partial class EducationReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationReport));
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
            this.fiaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.institutionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.graduationYearCaptionTextBox = new Telerik.Reporting.TextBox();
            this.professionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.educationFormCaptionTextBox = new Telerik.Reporting.TextBox();
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
            this.fiaDataTextBox = new Telerik.Reporting.TextBox();
            this.institutionDataTextBox = new Telerik.Reporting.TextBox();
            this.graduationYearDataTextBox = new Telerik.Reporting.TextBox();
            this.professionDataTextBox = new Telerik.Reporting.TextBox();
            this.educationFormDataTextBox = new Telerik.Reporting.TextBox();
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
            this.fiaCaptionTextBox,
            this.institutionCaptionTextBox,
            this.graduationYearCaptionTextBox,
            this.professionCaptionTextBox,
            this.educationFormCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // rowCaptionTextBox
            // 
            this.rowCaptionTextBox.CanGrow = true;
            this.rowCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowCaptionTextBox.Name = "rowCaptionTextBox";
            this.rowCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.84708321094512939D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowCaptionTextBox.StyleName = "Caption";
            this.rowCaptionTextBox.Value = "№";
            // 
            // fiaCaptionTextBox
            // 
            this.fiaCaptionTextBox.CanGrow = true;
            this.fiaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.9001995325088501D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaCaptionTextBox.Name = "fiaCaptionTextBox";
            this.fiaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4996004104614258D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaCaptionTextBox.StyleName = "Caption";
            this.fiaCaptionTextBox.Value = "ПІБ працівника";
            // 
            // institutionCaptionTextBox
            // 
            this.institutionCaptionTextBox.CanGrow = true;
            this.institutionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.4000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.institutionCaptionTextBox.Name = "institutionCaptionTextBox";
            this.institutionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.5998001098632812D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.institutionCaptionTextBox.StyleName = "Caption";
            this.institutionCaptionTextBox.Value = "Назва навчального закладу";
            // 
            // graduationYearCaptionTextBox
            // 
            this.graduationYearCaptionTextBox.CanGrow = true;
            this.graduationYearCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.graduationYearCaptionTextBox.Name = "graduationYearCaptionTextBox";
            this.graduationYearCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.199798583984375D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.graduationYearCaptionTextBox.StyleName = "Caption";
            this.graduationYearCaptionTextBox.Value = "Рік закінчення";
            // 
            // professionCaptionTextBox
            // 
            this.professionCaptionTextBox.CanGrow = true;
            this.professionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.19999885559082D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.professionCaptionTextBox.Name = "professionCaptionTextBox";
            this.professionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.29979944229126D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.professionCaptionTextBox.StyleName = "Caption";
            this.professionCaptionTextBox.Value = "Спеціальність";
            // 
            // educationFormCaptionTextBox
            // 
            this.educationFormCaptionTextBox.CanGrow = true;
            this.educationFormCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.499998092651367D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.educationFormCaptionTextBox.Name = "educationFormCaptionTextBox";
            this.educationFormCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9470860958099365D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.educationFormCaptionTextBox.StyleName = "Caption";
            this.educationFormCaptionTextBox.Value = "Форма навчання";
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
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(23.394166946411133D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Звіт";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.65687525272369385D);
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.513542175292969D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0D));
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(23.5D), Telerik.Reporting.Drawing.Unit.Cm(1.2856249809265137D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Освіта працівників";
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
            this.fiaDataTextBox,
            this.institutionDataTextBox,
            this.graduationYearDataTextBox,
            this.professionDataTextBox,
            this.educationFormDataTextBox});
            this.detail.Name = "detail";
            // 
            // rowDataTextBox
            // 
            this.rowDataTextBox.CanGrow = true;
            this.rowDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.rowDataTextBox.Name = "rowDataTextBox";
            this.rowDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.84708321094512939D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.rowDataTextBox.StyleName = "Data";
            this.rowDataTextBox.Value = "= Fields.Row";
            // 
            // fiaDataTextBox
            // 
            this.fiaDataTextBox.CanGrow = true;
            this.fiaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.9001995325088501D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fiaDataTextBox.Name = "fiaDataTextBox";
            this.fiaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.4996004104614258D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.fiaDataTextBox.StyleName = "Data";
            this.fiaDataTextBox.Value = "= Fields.Fia";
            // 
            // institutionDataTextBox
            // 
            this.institutionDataTextBox.CanGrow = true;
            this.institutionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.3999996185302734D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.institutionDataTextBox.Name = "institutionDataTextBox";
            this.institutionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.5998001098632812D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.institutionDataTextBox.StyleName = "Data";
            this.institutionDataTextBox.Value = "= Fields.Institution";
            // 
            // graduationYearDataTextBox
            // 
            this.graduationYearDataTextBox.CanGrow = true;
            this.graduationYearDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.graduationYearDataTextBox.Name = "graduationYearDataTextBox";
            this.graduationYearDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.199798583984375D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.graduationYearDataTextBox.StyleName = "Data";
            this.graduationYearDataTextBox.Value = "= Fields.GraduationYear";
            // 
            // professionDataTextBox
            // 
            this.professionDataTextBox.CanGrow = true;
            this.professionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.19999885559082D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.professionDataTextBox.Name = "professionDataTextBox";
            this.professionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.29979944229126D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.professionDataTextBox.StyleName = "Data";
            this.professionDataTextBox.Value = "= Fields.Profession";
            // 
            // educationFormDataTextBox
            // 
            this.educationFormDataTextBox.CanGrow = true;
            this.educationFormDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.499998092651367D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.educationFormDataTextBox.Name = "educationFormDataTextBox";
            this.educationFormDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9470860958099365D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
            this.educationFormDataTextBox.StyleName = "Data";
            this.educationFormDataTextBox.Value = "= Fields.EducationForm";
            // 
            // EducationReport
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
            this.Name = "EducationReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(23.5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PersonnelDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox rowCaptionTextBox;
        private Telerik.Reporting.TextBox fiaCaptionTextBox;
        private Telerik.Reporting.TextBox institutionCaptionTextBox;
        private Telerik.Reporting.TextBox graduationYearCaptionTextBox;
        private Telerik.Reporting.TextBox professionCaptionTextBox;
        private Telerik.Reporting.TextBox educationFormCaptionTextBox;
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
        private Telerik.Reporting.TextBox fiaDataTextBox;
        private Telerik.Reporting.TextBox institutionDataTextBox;
        private Telerik.Reporting.TextBox graduationYearDataTextBox;
        private Telerik.Reporting.TextBox professionDataTextBox;
        private Telerik.Reporting.TextBox educationFormDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}