namespace ReportLib
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ListOfWorkesPositionsReport.
    /// </summary>
    public partial class ListOfWorkesPositionsReport : Telerik.Reporting.Report
    {
        public ListOfWorkesPositionsReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //згенерувати інформацію в Qr-код
            var encoder = new Telerik.Reporting.Barcodes.QRCodeEncoder();

            encoder.Version = 3;

            encoder.ECI = Telerik.Reporting.Barcodes.QRCode.ECIMode.ISO8859_5;
            encoder.ErrorCorrectionLevel = Telerik.Reporting.Barcodes.QRCode.ErrorCorrectionLevel.M;
            encoder.Mode = Telerik.Reporting.Barcodes.QRCode.CodeMode.Alphanumeric;
            encoder.FNC1 = Telerik.Reporting.Barcodes.QRCode.FNC1Mode.FirstPosition;

            this.barcode1.Value = "HrDepartment Report. Date of creation: " + DateTime.Now;
            this.barcode1.Encoder = encoder;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}