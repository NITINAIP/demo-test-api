namespace demo_test_api.Services;

using IronBarCode;
using System;
using System.Drawing;
using System.Linq;

public class GeneratedQR
{
    public GeneratedQR() { }

    public void GeneratedBarcodesS(string text, string fileName)
    {
        IronBarCode.License.LicenseKey = "IRONBARCODE.NITINAIP.22235-E7E01024B8-AUJNPM-23TT5GKYLHOX-TQNKOIMVX5H3-DP7P3EJ5SDQX-JNPFMRK7I4EH-IIGVLAHM5FIO-F6WW7P-TO2IPHHFSOCJEA-DEPLOYMENT.TRIAL-57OVMD.TRIAL.EXPIRES.26.MAR.2023";
        QRCodeWriter.CreateQrCode(text, 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng($"{fileName}.png");
    }
}